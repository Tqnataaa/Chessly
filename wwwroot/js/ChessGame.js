var board = null;
var game = new Chess();
var $status = $('#status');
var $pgnContainer = $('#pgnContainer');
var whiteSquareGrey = '#a9a9a9';
var blackSquareGrey = '#696969';

let isGameActive = false;
let isGameLocked = true;
let selectedBot = null;

// --- Bot Selection Functions ---
function selectBot($elem) {
    if (isGameActive) return; // Locked once a game starts

    $('.bot-item').removeClass('active');
    $elem.addClass('active');

    selectedBot = {
        id: parseInt($elem.data('id')),
        name: $elem.data('name'),
        elo: $elem.data('elo'),
        difficulty: $elem.data('difficulty'),
        img: $elem.data('img')
    };

    $('#selectedBotImg').attr('src', selectedBot.img);
    $('#selectedBotName').text(selectedBot.name);
    $('#selectedBotElo').text('Elo: ' + selectedBot.elo);
    $('#selectedBotDifficulty').text(selectedBot.difficulty);
}

function initSelectedBot() {
    let $firstThumb = $('.bot-item').first();
    if ($firstThumb.length > 0) {
        selectBot($firstThumb);
    }
}

// --- Square Highlighting ---
function removeGreySquares() {
    $('#myBoard .square-55d63').css('background', '');
}

function greySquare(square) {
    var $square = $('#myBoard .square-' + square);
    var background = whiteSquareGrey;
    if ($square.hasClass('black-3c85d')) {
        background = blackSquareGrey;
    }
    $square.css('background', background);
}

function onMouseoverSquare(square, piece) {
    if (isGameLocked || !isGameActive) return;

    var moves = game.moves({
        square: square,
        verbose: true
    });

    if (moves.length === 0) return;

    greySquare(square);
    for (var i = 0; i < moves.length; i++) {
        greySquare(moves[i].to);
    }
}

function onMouseoutSquare(square, piece) {
    removeGreySquares();
}

// --- PGN Row Display ---
function renderPgnRows() {
    let history = game.history();
    if (history.length === 0) {
        $pgnContainer.html('<em>Moves will appear here...</em>');
        return;
    }

    let rowsHtml = '';
    for (let i = 0; i < history.length; i += 2) {
        let moveNum = (i / 2) + 1;
        let whiteMove = history[i];
        let blackMove = history[i + 1] ? history[i + 1] : '';
        rowsHtml += `<div><strong>${moveNum}.</strong> ${whiteMove} ${blackMove}</div>`;
    }

    $pgnContainer.html(rowsHtml);
    $pgnContainer.scrollTop($pgnContainer[0].scrollHeight);
}

// --- Board Drag and Drop ---
function onDragStart(source, piece) {
    if (isGameLocked || !isGameActive || game.game_over()) {
        return false;
    }

    // Player is strictly White
    if (piece.search(/^b/) !== -1) {
        return false;
    }
}

function onDrop(source, target) {
    removeGreySquares();

    var move = game.move({
        from: source,
        to: target,
        promotion: 'q'
    });

    if (move === null) return 'snapback';

    renderPgnRows();
    updateStatus();

    if (!game.game_over()) {
        window.setTimeout(makeBotMove, 250);
    }
}

function onSnapEnd() {
    board.position(game.fen());
}

// --- Bot Move & Server Sync ---
function makeBotMove() {
    if (isGameLocked || !isGameActive || game.game_over()) return;

    let moves = game.moves();
    let botId = selectedBot ? selectedBot.id : 1;
    let difficulty = selectedBot ? selectedBot.difficulty : 'Easy';

    $.ajax({
        url: '/Game/MakeBotMove',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify({
            botId: botId,
            legalMoves: moves,
            difficulty: difficulty
        }),
        success: function (res) {
            if (isGameLocked) return;
            if (res && res.move) {
                game.move(res.move);
                board.position(game.fen());
                renderPgnRows();
                updateStatus();
            }
        }
    });
}

function saveGameResult(resultString) {
    if (!selectedBot) return;

    $.ajax({
        url: '/Game/SaveGame',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify({
            botId: selectedBot.id,
            result: resultString,
            notation: game.pgn() || "N/A"
        }),
        success: function (res) {
            console.log("Game saved successfully");
        }
    });
}

function showGameOverModal(title, subtitle, result) {
    isGameActive = false;
    isGameLocked = true;

    saveGameResult(result);

    $('#modalResultTitle').text(title);
    $('#modalResultSubtitle').text(subtitle);
    $('#gameOverModal').removeClass('hidden-section');
}

function updateStatus() {
    var status = '';

    if (game.in_checkmate()) {
        if (game.turn() === 'w') {
            status = 'Game over: Black (Bot) won by checkmate!';
            showGameOverModal('You Lost!', 'Checkmate by ' + (selectedBot ? selectedBot.name : 'Bot'), 'Loss');
        } else {
            status = 'Game over: White (You) won by checkmate!';
            showGameOverModal('Victory!', 'You defeated ' + (selectedBot ? selectedBot.name : 'Bot') + ' by checkmate!', 'Win');
        }
    } else if (game.in_draw()) {
        status = 'Game over: Drawn position';
        showGameOverModal('Draw!', 'The match ended in a draw.', 'Draw');
    } else {
        status = game.turn() === 'w' ? 'Your turn (White)' : 'Bot is thinking...';
        if (game.in_check()) {
            status += ' (Check!)';
        }
    }

    $status.text(status);
}

function resetBoardAndGame() {
    game.reset();
    board.start();
    $pgnContainer.html('<em>Moves will appear here...</em>');
    $status.text('White to move');
}

// --- Initialization & Event Listeners ---
$(document).ready(function () {
    var config = {
        draggable: true,
        position: 'start',
        pieceTheme: '/img/chesspieces/wikipedia/{piece}.png',
        onDragStart: onDragStart,
        onDrop: onDrop,
        onMouseoutSquare: onMouseoutSquare,
        onMouseoverSquare: onMouseoverSquare,
        onSnapEnd: onSnapEnd
    };

    board = Chessboard('myBoard', config);
    initSelectedBot();

    // Select Bot
    $(document).on('click', '.bot-item', function () {
        selectBot($(this));
    });

    // Start Game: Reveal Resign, Hide Start
    $('#startGameBtn').on('click', function () {
        isGameActive = true;
        isGameLocked = false;
        resetBoardAndGame();

        $('#preGameSection').addClass('hidden-section');
        $('#activeGameSection').removeClass('hidden-section');

        $('#startGameBtn').addClass('hidden-section');
        $('#resignBtn').removeClass('hidden-section');
    });

    // Resign Button
    $('#resignBtn').on('click', function () {
        showGameOverModal('Resigned', 'You conceded the match.', 'Loss');
        $status.text('Game Over: Resigned');
    });

    // Rematch inside Modal
    $('#modalRematchBtn').on('click', function () {
        $('#gameOverModal').addClass('hidden-section');
        isGameActive = true;
        isGameLocked = false;
        resetBoardAndGame();

        $('#startGameBtn').addClass('hidden-section');
        $('#resignBtn').removeClass('hidden-section');
    });
});