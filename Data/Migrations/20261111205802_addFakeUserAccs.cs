using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Chessly.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class addFakeUserAccs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Country", "Draws", "Elo", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Losses", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wins" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", 0, "concurrency-stamp-001", "Unknown", 10, 2538, "test001@test.com", true, false, null, 10, "TEST001@TEST.COM", "TEST001", "AQAAAAIAAYagAAAAEB4o+FcfOksU4vVbCqcutz0o1jiDpwBHqyBZiXv0RVxcF6XOLNnX/mQx7aI8lSj7JQ==", null, false, "", "security-stamp-001", false, "test001", 14 },
                    { "00000000-0000-0000-0000-000000000002", 0, "concurrency-stamp-002", "Unknown", 10, 1088, "test002@test.com", true, false, null, 57, "TEST002@TEST.COM", "TEST002", "AQAAAAIAAYagAAAAEBDhcnKotTCawehPc68O99lXon3d1rDqp8N9QhWIVomiDAa1iKPF0eodfN1xnA4pkw==", null, false, "", "security-stamp-002", false, "test002", 26 },
                    { "00000000-0000-0000-0000-000000000003", 0, "concurrency-stamp-003", "Unknown", 5, 1103, "test003@test.com", true, false, null, 18, "TEST003@TEST.COM", "TEST003", "AQAAAAIAAYagAAAAEKmx5b6qXb3kD24dWiQYPaOPdvNfHSefYlEdMT3yoeQyFkcqrHMurUDyPfVNxxv4cA==", null, false, "", "security-stamp-003", false, "test003", 76 },
                    { "00000000-0000-0000-0000-000000000004", 0, "concurrency-stamp-004", "Unknown", 5, 2066, "test004@test.com", true, false, null, 30, "TEST004@TEST.COM", "TEST004", "AQAAAAIAAYagAAAAEKhDHXIeyGtvYvJtoxt+V6mWJUqagrRRSyOC1iNOYqvz6plEp75EjdKeywRbXkpvmA==", null, false, "", "security-stamp-004", false, "test004", 32 },
                    { "00000000-0000-0000-0000-000000000005", 0, "concurrency-stamp-005", "Unknown", 11, 2101, "test005@test.com", true, false, null, 65, "TEST005@TEST.COM", "TEST005", "AQAAAAIAAYagAAAAEIooqj96ZR45PYL8oOkuJqIwCPgwU87iIO1mh2mGE5jUiXWdDjI96yN24M++f+M0AQ==", null, false, "", "security-stamp-005", false, "test005", 3 },
                    { "00000000-0000-0000-0000-000000000006", 0, "concurrency-stamp-006", "Unknown", 14, 1753, "test006@test.com", true, false, null, 7, "TEST006@TEST.COM", "TEST006", "AQAAAAIAAYagAAAAEBoVl3IywCYOReLIc1NOM4lNjoXhkaPiBpvzKvktwtTLLDI3v7NRYhxCUZnDq3NvSA==", null, false, "", "security-stamp-006", false, "test006", 15 },
                    { "00000000-0000-0000-0000-000000000007", 0, "concurrency-stamp-007", "Unknown", 14, 2967, "test007@test.com", true, false, null, 3, "TEST007@TEST.COM", "TEST007", "AQAAAAIAAYagAAAAEPqEfqYGUJGRtbVECPpAetGmFh77hHL4RN+3Cmt7iLGcw8CuDNx8A8be4DKJy3GUpA==", null, false, "", "security-stamp-007", false, "test007", 53 },
                    { "00000000-0000-0000-0000-000000000008", 0, "concurrency-stamp-008", "Unknown", 10, 1028, "test008@test.com", true, false, null, 55, "TEST008@TEST.COM", "TEST008", "AQAAAAIAAYagAAAAEH+kgXNn/f0ALmtaGLbogWR8KZ9MlTwmTlu9AUeFwa1R8HhIB+yG9c1q2JkDv++AzA==", null, false, "", "security-stamp-008", false, "test008", 90 },
                    { "00000000-0000-0000-0000-000000000009", 0, "concurrency-stamp-009", "Unknown", 11, 1140, "test009@test.com", true, false, null, 24, "TEST009@TEST.COM", "TEST009", "AQAAAAIAAYagAAAAEGlEsQanq2J0VYwuKEthzXJqDnkwm1nBZj/jhPENlKMrGrFXJIHeP15g+GevtC5mUA==", null, false, "", "security-stamp-009", false, "test009", 4 },
                    { "00000000-0000-0000-0000-000000000010", 0, "concurrency-stamp-010", "Unknown", 16, 2981, "test010@test.com", true, false, null, 42, "TEST010@TEST.COM", "TEST010", "AQAAAAIAAYagAAAAEGc9Hnx6yqqsBgiISB8KQcXfz6gTp7Q9knSnLQz5dY6bH3OWZVNGL++MUzLoJS3eBA==", null, false, "", "security-stamp-010", false, "test010", 0 },
                    { "00000000-0000-0000-0000-000000000011", 0, "concurrency-stamp-011", "Unknown", 0, 2770, "test011@test.com", true, false, null, 11, "TEST011@TEST.COM", "TEST011", "AQAAAAIAAYagAAAAEEOw63Z6gMR7SYImvpq7o8HjeNHJme1sD9mQGYVjZSDHA5ILW4kk/1b3vTKkciNERQ==", null, false, "", "security-stamp-011", false, "test011", 38 },
                    { "00000000-0000-0000-0000-000000000012", 0, "concurrency-stamp-012", "Unknown", 2, 747, "test012@test.com", true, false, null, 50, "TEST012@TEST.COM", "TEST012", "AQAAAAIAAYagAAAAEDGXW/exbUSO0SmBP9kL+IyXDGYXqO3r0v6vOW/1D53YtZtrCtzoVHHpBV61useb8g==", null, false, "", "security-stamp-012", false, "test012", 78 },
                    { "00000000-0000-0000-0000-000000000013", 0, "concurrency-stamp-013", "Unknown", 12, 1325, "test013@test.com", true, false, null, 23, "TEST013@TEST.COM", "TEST013", "AQAAAAIAAYagAAAAEBUHr1T/17bs/wku1F74XasTHt97rcbQLKtUf5DHOZgLKs7/Od1Jsf/LIae2D1CkLA==", null, false, "", "security-stamp-013", false, "test013", 77 },
                    { "00000000-0000-0000-0000-000000000014", 0, "concurrency-stamp-014", "Unknown", 10, 1016, "test014@test.com", true, false, null, 48, "TEST014@TEST.COM", "TEST014", "AQAAAAIAAYagAAAAEHYykyAh2GvFPcQF+8G3DVUBTOuU2N11fyx9tkNuoZjni8janRwBZz30V6MTlnrmDw==", null, false, "", "security-stamp-014", false, "test014", 4 },
                    { "00000000-0000-0000-0000-000000000015", 0, "concurrency-stamp-015", "Unknown", 12, 747, "test015@test.com", true, false, null, 56, "TEST015@TEST.COM", "TEST015", "AQAAAAIAAYagAAAAEAGTcpAEQKeek/cFSSd9KcRlLmf+30QzYr5HDHEeQFfsUH60RBrxMCPFV/TO0Wixgw==", null, false, "", "security-stamp-015", false, "test015", 42 },
                    { "00000000-0000-0000-0000-000000000016", 0, "concurrency-stamp-016", "Unknown", 5, 1233, "test016@test.com", true, false, null, 29, "TEST016@TEST.COM", "TEST016", "AQAAAAIAAYagAAAAENDq7jwfeou7QypeHYOpaHxsAKbL/qiEY/vDpYTVkYPRnbJGvc2AJXZNrmWRJ8dnpQ==", null, false, "", "security-stamp-016", false, "test016", 1 },
                    { "00000000-0000-0000-0000-000000000017", 0, "concurrency-stamp-017", "Unknown", 9, 799, "test017@test.com", true, false, null, 5, "TEST017@TEST.COM", "TEST017", "AQAAAAIAAYagAAAAEEEg5s1Fp+Z6rcwibOc3A5E6nB2HvHYCSCD6YfI9+IBZUi7uXTBXobumxGXpYQcpkQ==", null, false, "", "security-stamp-017", false, "test017", 71 },
                    { "00000000-0000-0000-0000-000000000018", 0, "concurrency-stamp-018", "Unknown", 10, 634, "test018@test.com", true, false, null, 35, "TEST018@TEST.COM", "TEST018", "AQAAAAIAAYagAAAAEDeaNgD1N6xuvhsdzEWcBRqamAlypDGikoTxnrd0u726fQnu5Z4CqHOs82kEpQHBBg==", null, false, "", "security-stamp-018", false, "test018", 79 },
                    { "00000000-0000-0000-0000-000000000019", 0, "concurrency-stamp-019", "Unknown", 0, 2049, "test019@test.com", true, false, null, 66, "TEST019@TEST.COM", "TEST019", "AQAAAAIAAYagAAAAEFpyMWSZ05NwfumIwZecidGz7Mb9R+Nb62Gyox+Liwax0eJPTNfUuKAnSuicRU+pAg==", null, false, "", "security-stamp-019", false, "test019", 0 },
                    { "00000000-0000-0000-0000-000000000020", 0, "concurrency-stamp-020", "Unknown", 0, 608, "test020@test.com", true, false, null, 52, "TEST020@TEST.COM", "TEST020", "AQAAAAIAAYagAAAAEBfF5Iqz+f8UsxuWtSFn2zCvZCOPviDA2Ca2f9x4uBbcNEdqVwIBFS+mjfH96RUImg==", null, false, "", "security-stamp-020", false, "test020", 6 },
                    { "00000000-0000-0000-0000-000000000021", 0, "concurrency-stamp-021", "Unknown", 7, 3250, "test021@test.com", true, false, null, 36, "TEST021@TEST.COM", "TEST021", "AQAAAAIAAYagAAAAEHbYH+Da109JDWiEQrxL9nfFXR+6NoFxmw4SRsAUkcXy+cbS6X5J6d/nKVVxiejkbQ==", null, false, "", "security-stamp-021", false, "test021", 92 },
                    { "00000000-0000-0000-0000-000000000022", 0, "concurrency-stamp-022", "Unknown", 2, 2388, "test022@test.com", true, false, null, 29, "TEST022@TEST.COM", "TEST022", "AQAAAAIAAYagAAAAENZLmC7X7Yz7QCigazUGR0u3e+muxRksVn8xcwlgeNCrN7eDkzm3kfYW2m66xRlxuA==", null, false, "", "security-stamp-022", false, "test022", 4 },
                    { "00000000-0000-0000-0000-000000000023", 0, "concurrency-stamp-023", "Unknown", 8, 1867, "test023@test.com", true, false, null, 42, "TEST023@TEST.COM", "TEST023", "AQAAAAIAAYagAAAAEOrt2tPu9c63EG8BDblO3PmrWuC+MmE6WHqofgg0595k7KjFf6hD7z+Voofb9lAV3w==", null, false, "", "security-stamp-023", false, "test023", 79 },
                    { "00000000-0000-0000-0000-000000000024", 0, "concurrency-stamp-024", "Unknown", 14, 1462, "test024@test.com", true, false, null, 46, "TEST024@TEST.COM", "TEST024", "AQAAAAIAAYagAAAAELPX36at1KK/eik153vMAQKjcBgOptWYBbt/s+rJZL8Pf6kbSpKMLT+FDppKgqHKFg==", null, false, "", "security-stamp-024", false, "test024", 90 },
                    { "00000000-0000-0000-0000-000000000025", 0, "concurrency-stamp-025", "Unknown", 6, 656, "test025@test.com", true, false, null, 76, "TEST025@TEST.COM", "TEST025", "AQAAAAIAAYagAAAAEIF8mdgt100b79hjb53F5iMEVilKwolXHNO/mBAkhAKYTGT/KU5wOnaWSBfsaNr9Kw==", null, false, "", "security-stamp-025", false, "test025", 88 },
                    { "00000000-0000-0000-0000-000000000026", 0, "concurrency-stamp-026", "Unknown", 9, 2661, "test026@test.com", true, false, null, 8, "TEST026@TEST.COM", "TEST026", "AQAAAAIAAYagAAAAEONcjntDYYoWARuVmluxw5QUVSFL8NPMl5i6QwUa0tmt1jeF26wC8qf2d39FfL3veg==", null, false, "", "security-stamp-026", false, "test026", 16 },
                    { "00000000-0000-0000-0000-000000000027", 0, "concurrency-stamp-027", "Unknown", 2, 1566, "test027@test.com", true, false, null, 11, "TEST027@TEST.COM", "TEST027", "AQAAAAIAAYagAAAAEIfwVgMxdQeEy4UYtiY/Mg5VuOuucQKAb5qNUc9zAtywPzthPNI9mbaUZxRsBr13Kw==", null, false, "", "security-stamp-027", false, "test027", 77 },
                    { "00000000-0000-0000-0000-000000000028", 0, "concurrency-stamp-028", "Unknown", 19, 1225, "test028@test.com", true, false, null, 41, "TEST028@TEST.COM", "TEST028", "AQAAAAIAAYagAAAAEOAcZ2zwi1q5V4Nkj6nNYXWs0ANc7n1NrtvFNC8GxCYefSC89OGpnZZ+gAJyr53pJw==", null, false, "", "security-stamp-028", false, "test028", 59 },
                    { "00000000-0000-0000-0000-000000000029", 0, "concurrency-stamp-029", "Unknown", 5, 2822, "test029@test.com", true, false, null, 57, "TEST029@TEST.COM", "TEST029", "AQAAAAIAAYagAAAAEHIobEqu8qrRolluYiNL8GKzACDSDJcu/wR3f6I4dThB8LDxDH52+InzBX2rfyWjYA==", null, false, "", "security-stamp-029", false, "test029", 67 },
                    { "00000000-0000-0000-0000-000000000030", 0, "concurrency-stamp-030", "Unknown", 0, 2201, "test030@test.com", true, false, null, 52, "TEST030@TEST.COM", "TEST030", "AQAAAAIAAYagAAAAEGLZCLbKTSOaabiJh3VY63F/3JgHo9Y3vOI9s0m1Jr6kPrIyupngnwNC6M0uKFV+nA==", null, false, "", "security-stamp-030", false, "test030", 98 },
                    { "00000000-0000-0000-0000-000000000031", 0, "concurrency-stamp-031", "Unknown", 4, 1602, "test031@test.com", true, false, null, 2, "TEST031@TEST.COM", "TEST031", "AQAAAAIAAYagAAAAEIGeMkClumhUQALv+x/CvkKO5AXqpda/TqFKHCknC+nwwwdxkW0CGG0Q8uWNzZst+Q==", null, false, "", "security-stamp-031", false, "test031", 92 },
                    { "00000000-0000-0000-0000-000000000032", 0, "concurrency-stamp-032", "Unknown", 11, 1370, "test032@test.com", true, false, null, 17, "TEST032@TEST.COM", "TEST032", "AQAAAAIAAYagAAAAEOU18dEL2I+762FFChMunOpVxPT4ZUdmPHHGM2AB8h0EgDpt/N5WCtliw/yE8/67Wg==", null, false, "", "security-stamp-032", false, "test032", 3 },
                    { "00000000-0000-0000-0000-000000000033", 0, "concurrency-stamp-033", "Unknown", 2, 1824, "test033@test.com", true, false, null, 79, "TEST033@TEST.COM", "TEST033", "AQAAAAIAAYagAAAAEIskmAy7kc7mv1PMlkWzmlU/xUZUn32Fm1oQx0hjZaFATonzHBnkOnQiBX8lmbFjXA==", null, false, "", "security-stamp-033", false, "test033", 9 },
                    { "00000000-0000-0000-0000-000000000034", 0, "concurrency-stamp-034", "Unknown", 15, 907, "test034@test.com", true, false, null, 25, "TEST034@TEST.COM", "TEST034", "AQAAAAIAAYagAAAAEO5vEsIk/XiQjZsvu0TT4rhQJyDNxgH2hnfRveb1t7WHJzJZ5XsQiPh39DmAp6myEg==", null, false, "", "security-stamp-034", false, "test034", 32 },
                    { "00000000-0000-0000-0000-000000000035", 0, "concurrency-stamp-035", "Unknown", 16, 2995, "test035@test.com", true, false, null, 3, "TEST035@TEST.COM", "TEST035", "AQAAAAIAAYagAAAAEExZtR98YGJ55WqfqmcP4HHz7Kq5DwXUwL7G0WGP9nlE4LIyLsYXmp82v6sEbkeogA==", null, false, "", "security-stamp-035", false, "test035", 0 },
                    { "00000000-0000-0000-0000-000000000036", 0, "concurrency-stamp-036", "Unknown", 16, 3198, "test036@test.com", true, false, null, 74, "TEST036@TEST.COM", "TEST036", "AQAAAAIAAYagAAAAEACWtEYp9Kbx2gyVupPCoDds6oAFptY428/VdK44ZlvhLyubcA97mPNBAwI8tqNlJw==", null, false, "", "security-stamp-036", false, "test036", 23 },
                    { "00000000-0000-0000-0000-000000000037", 0, "concurrency-stamp-037", "Unknown", 12, 1410, "test037@test.com", true, false, null, 50, "TEST037@TEST.COM", "TEST037", "AQAAAAIAAYagAAAAEEO/B+wcYHsTna8xzFMl9p9C/4nM5f2Icwaepq+sLtrRQSLNQUCZ9761nZ2uXtVkug==", null, false, "", "security-stamp-037", false, "test037", 54 },
                    { "00000000-0000-0000-0000-000000000038", 0, "concurrency-stamp-038", "Unknown", 0, 1157, "test038@test.com", true, false, null, 14, "TEST038@TEST.COM", "TEST038", "AQAAAAIAAYagAAAAEByLmkzYnBD6Vb15/Umk40VY/c7RJfDUieseUSu3JsSWGja4bMIgPLh9uesXmqjjFQ==", null, false, "", "security-stamp-038", false, "test038", 29 },
                    { "00000000-0000-0000-0000-000000000039", 0, "concurrency-stamp-039", "Unknown", 15, 1269, "test039@test.com", true, false, null, 78, "TEST039@TEST.COM", "TEST039", "AQAAAAIAAYagAAAAEBPWNNPQV31NzF24emETh9PYZ2hwcsvKuoheg2/NN8l+X23m46y+TlnLVUUDfxNZYw==", null, false, "", "security-stamp-039", false, "test039", 93 },
                    { "00000000-0000-0000-0000-000000000040", 0, "concurrency-stamp-040", "Unknown", 5, 992, "test040@test.com", true, false, null, 14, "TEST040@TEST.COM", "TEST040", "AQAAAAIAAYagAAAAEAzsJleF3MAv9vk9SvMX9q/JwEl7ApzmFFsRVbONdRu/vf4fuZRwH0KsUfeqy3DZSg==", null, false, "", "security-stamp-040", false, "test040", 88 },
                    { "00000000-0000-0000-0000-000000000041", 0, "concurrency-stamp-041", "Unknown", 2, 2224, "test041@test.com", true, false, null, 56, "TEST041@TEST.COM", "TEST041", "AQAAAAIAAYagAAAAEA6wrJJ2X325gST9TRumC3RkkzvQvo62uds9GeFjUQ15SIeUiCO6QnYxucc6GKOYAw==", null, false, "", "security-stamp-041", false, "test041", 55 },
                    { "00000000-0000-0000-0000-000000000042", 0, "concurrency-stamp-042", "Unknown", 8, 2335, "test042@test.com", true, false, null, 70, "TEST042@TEST.COM", "TEST042", "AQAAAAIAAYagAAAAEBTFHkrwWJJleSTCNHzTPTa8pxPDmZ/2zY4u43QfOrCFcqZc9f03u6BBzJeWOhuJ+Q==", null, false, "", "security-stamp-042", false, "test042", 39 },
                    { "00000000-0000-0000-0000-000000000043", 0, "concurrency-stamp-043", "Unknown", 10, 1610, "test043@test.com", true, false, null, 37, "TEST043@TEST.COM", "TEST043", "AQAAAAIAAYagAAAAENnvM7AKzqLTvkqCkgfGJTMRLPWA5F7muBob0jC1HuW9ul7g98K+QWU2NQNRbTtCxg==", null, false, "", "security-stamp-043", false, "test043", 96 },
                    { "00000000-0000-0000-0000-000000000044", 0, "concurrency-stamp-044", "Unknown", 2, 3349, "test044@test.com", true, false, null, 10, "TEST044@TEST.COM", "TEST044", "AQAAAAIAAYagAAAAED/ccqUFQj95XBP1bLYF4tKHQOkac5B8Az2PPAxCSnqczY5OLW3fmRcfg5Y49rj7Wg==", null, false, "", "security-stamp-044", false, "test044", 81 },
                    { "00000000-0000-0000-0000-000000000045", 0, "concurrency-stamp-045", "Unknown", 14, 608, "test045@test.com", true, false, null, 75, "TEST045@TEST.COM", "TEST045", "AQAAAAIAAYagAAAAECzMcoicPIKm8bfVzzBEAPpbf7tapJORhH+9N4o/2F8cTKlpiYorNGTuaHUunqwE3g==", null, false, "", "security-stamp-045", false, "test045", 18 },
                    { "00000000-0000-0000-0000-000000000046", 0, "concurrency-stamp-046", "Unknown", 2, 1772, "test046@test.com", true, false, null, 32, "TEST046@TEST.COM", "TEST046", "AQAAAAIAAYagAAAAEG+iiJlTb00HWS4usRGp9EYdtIO1xCmDayorrwznzattGKV+4FC+UGygJq/L/W4fWQ==", null, false, "", "security-stamp-046", false, "test046", 59 },
                    { "00000000-0000-0000-0000-000000000047", 0, "concurrency-stamp-047", "Unknown", 3, 3241, "test047@test.com", true, false, null, 71, "TEST047@TEST.COM", "TEST047", "AQAAAAIAAYagAAAAEBUUUkr6k9vmvdHgbj0G2V1fJdv4yXvKnnZ5OpMyVReToCvj422FlSEGgCbW7t9RIg==", null, false, "", "security-stamp-047", false, "test047", 96 },
                    { "00000000-0000-0000-0000-000000000048", 0, "concurrency-stamp-048", "Unknown", 18, 1568, "test048@test.com", true, false, null, 49, "TEST048@TEST.COM", "TEST048", "AQAAAAIAAYagAAAAEMbVS9pzTYCxbP6cU9k37R0tbRXymz67S3Ur6jE2ZFoPXcUqjHkRvvkvzjGdKbHW0A==", null, false, "", "security-stamp-048", false, "test048", 54 },
                    { "00000000-0000-0000-0000-000000000049", 0, "concurrency-stamp-049", "Unknown", 6, 2985, "test049@test.com", true, false, null, 22, "TEST049@TEST.COM", "TEST049", "AQAAAAIAAYagAAAAEO7RRut4YP7zKm4uRqxONXXoyzbnZr79/Pfk8SgTgeSx4KkkvzSm239HrRYEnkNfrA==", null, false, "", "security-stamp-049", false, "test049", 74 },
                    { "00000000-0000-0000-0000-000000000050", 0, "concurrency-stamp-050", "Unknown", 17, 2124, "test050@test.com", true, false, null, 19, "TEST050@TEST.COM", "TEST050", "AQAAAAIAAYagAAAAELFA1tJEcK2/v7jU3L8L+ftn2KHPS8GlSEVvoQIm+P0kACPvvJFubaZR0QDCba0OXg==", null, false, "", "security-stamp-050", false, "test050", 80 }
                });

            migrationBuilder.UpdateData(
                table: "Bots",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "/img/chesspieces/wikipedia/wP.png", "PawnBot" });

            migrationBuilder.UpdateData(
                table: "Bots",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "/img/chesspieces/wikipedia/wN.png", "KnightBot" });

            migrationBuilder.UpdateData(
                table: "Bots",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "/img/chesspieces/wikipedia/wQ.png", "QueenBot" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000006");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000007");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000008");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000009");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000010");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000011");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000012");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000013");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000014");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000015");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000016");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000017");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000018");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000019");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000020");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000021");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000022");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000023");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000024");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000025");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000026");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000027");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000028");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000029");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000030");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000031");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000032");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000033");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000034");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000035");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000036");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000037");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000038");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000039");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000040");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000041");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000042");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000043");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000044");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000045");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000046");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000047");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000048");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000049");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000050");

            migrationBuilder.UpdateData(
                table: "Bots",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "/images/bots/easybot.png", "EasyBot" });

            migrationBuilder.UpdateData(
                table: "Bots",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "/images/bots/mediumbot.png", "MediumBot" });

            migrationBuilder.UpdateData(
                table: "Bots",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "/images/bots/hardbot.png", "HardBot" });
        }
    }
}
