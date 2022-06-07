using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmacare.Api.Migrations
{
    public partial class InsertData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ActiveSubstances",
                columns: new[] { "SubstanceId", "Description", "InternationalName", "Name" },
                values: new object[,]
                {
                    { 2, "Opis", "Beclometasone", "Dipropionian beklometazonu" },
                    { 3, "Opis", "Clarithromycin", "Klarytromycyna" },
                    { 4, "Opis", "Amoxicillin", "Amoksycylina" },
                    { 5, "Opis", "Salbutamol", "Salbutamol" },
                    { 6, "Opis", "Cefixime", "Cefiksym" },
                    { 7, "Opis", "Azithromycin", "Azytromycyna" },
                    { 8, "Opis", "Betametasone", "Betametazon" },
                    { 9, "Opis", "Cefaclor", "Cefaklor" },
                    { 10, "Opis", "Cetirizine", "Cetyryzyna" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserGuid" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Dla diabetyków" },
                    { 3, "Dermatologia" },
                    { 4, "Homeopatia" },
                    { 5, "Układ krążenia" },
                    { 6, "Odporność" },
                    { 7, "Przeziębienie i grypa" },
                    { 8, "Zdrowie mężczyny" },
                    { 9, "Seks i antykoncepcja" },
                    { 10, "Alergia" },
                    { 11, "Układ pokarmowy" },
                    { 12, "Układ mięśniowo-szkieletowy" },
                    { 13, "Oczy" },
                    { 14, "Układ moczowo-płciowy" },
                    { 15, "Układ nerwowy" }
                });

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 1,
                columns: new[] { "ActiveSubstanceId", "CategoryId" },
                values: new object[] { 5, 0 });

            migrationBuilder.InsertData(
                table: "Drugs",
                columns: new[] { "DrugId", "ActiveSubstanceId", "CategoryId", "Dosage", "ImageURL", "PackSize", "Price", "Quantity", "TradeName" },
                values: new object[,]
                {
                    { 2, 4, 0, "3 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "75 tabletek", 70.99m, 165, "Nazwa leku" },
                    { 3, 9, 0, "2 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "100 tabletek", 39.99m, 857, "Nazwa leku" },
                    { 4, 7, 0, "3 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "20 tabletek", 62.99m, 225, "Nazwa leku" },
                    { 5, 3, 0, "1 tabletka", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "20 tabletek", 117.99m, 853, "Nazwa leku" },
                    { 6, 2, 1, "2 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "75 tabletek", 49.99m, 671, "Nazwa leku" },
                    { 7, 9, 1, "3 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "10 tabletek", 63.99m, 724, "Nazwa leku" },
                    { 8, 0, 1, "2 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "10 tabletek", 32.99m, 90, "Nazwa leku" },
                    { 9, 2, 1, "1 tabletka", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "150 tabletek", 149.99m, 808, "Nazwa leku" },
                    { 10, 6, 1, "2 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "10 tabletek", 74.99m, 871, "Nazwa leku" },
                    { 11, 5, 2, "1 tabletka", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "50 tabletek", 79.99m, 616, "Nazwa leku" },
                    { 12, 7, 2, "5 tabletek", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "75 tabletek", 60.99m, 341, "Nazwa leku" },
                    { 13, 6, 2, "3 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "150 tabletek", 62.99m, 96, "Nazwa leku" },
                    { 14, 7, 2, "2 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "50 tabletek", 137.99m, 92, "Nazwa leku" },
                    { 15, 8, 2, "5 tabletek", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "100 tabletek", 57.99m, 855, "Nazwa leku" },
                    { 16, 1, 3, "3 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "20 tabletek", 27.99m, 543, "Nazwa leku" },
                    { 17, 1, 3, "3 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "50 tabletek", 32.99m, 861, "Nazwa leku" }
                });

            migrationBuilder.InsertData(
                table: "Drugs",
                columns: new[] { "DrugId", "ActiveSubstanceId", "CategoryId", "Dosage", "ImageURL", "PackSize", "Price", "Quantity", "TradeName" },
                values: new object[,]
                {
                    { 18, 2, 3, "1 tabletka", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "20 tabletek", 76.99m, 942, "Nazwa leku" },
                    { 19, 4, 3, "5 tabletek", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "150 tabletek", 120.99m, 390, "Nazwa leku" },
                    { 20, 7, 3, "2 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "200 tabletek", 115.99m, 688, "Nazwa leku" },
                    { 21, 5, 4, "3 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "100 tabletek", 149.99m, 569, "Nazwa leku" },
                    { 22, 3, 4, "1 tabletka", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "75 tabletek", 106.99m, 130, "Nazwa leku" },
                    { 23, 9, 4, "1 tabletka", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "50 tabletek", 138.99m, 625, "Nazwa leku" },
                    { 24, 0, 4, "1 tabletka", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "200 tabletek", 122.99m, 123, "Nazwa leku" },
                    { 25, 3, 4, "1 tabletka", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "10 tabletek", 98.99m, 388, "Nazwa leku" },
                    { 26, 7, 5, "2 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "30 tabletek", 105.99m, 145, "Nazwa leku" },
                    { 27, 6, 5, "2 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "200 tabletek", 24.99m, 552, "Nazwa leku" },
                    { 28, 1, 5, "3 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "75 tabletek", 97.99m, 502, "Nazwa leku" },
                    { 29, 9, 5, "5 tabletek", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "50 tabletek", 59.99m, 907, "Nazwa leku" },
                    { 30, 2, 5, "2 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "75 tabletek", 57.99m, 794, "Nazwa leku" },
                    { 31, 3, 6, "3 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "200 tabletek", 59.99m, 83, "Nazwa leku" },
                    { 32, 1, 6, "3 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "150 tabletek", 22.99m, 534, "Nazwa leku" },
                    { 33, 5, 6, "1 tabletka", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "10 tabletek", 121.99m, 134, "Nazwa leku" },
                    { 34, 0, 6, "5 tabletek", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "150 tabletek", 96.99m, 395, "Nazwa leku" },
                    { 35, 6, 6, "2 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "75 tabletek", 97.99m, 525, "Nazwa leku" },
                    { 36, 6, 7, "1 tabletka", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "200 tabletek", 72.99m, 899, "Nazwa leku" },
                    { 37, 2, 7, "2 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "150 tabletek", 30.99m, 23, "Nazwa leku" },
                    { 38, 8, 7, "1 tabletka", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "30 tabletek", 24.99m, 194, "Nazwa leku" },
                    { 39, 6, 7, "3 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "150 tabletek", 85.99m, 909, "Nazwa leku" },
                    { 40, 2, 7, "5 tabletek", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "200 tabletek", 106.99m, 912, "Nazwa leku" },
                    { 41, 7, 8, "2 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "10 tabletek", 24.99m, 675, "Nazwa leku" },
                    { 42, 0, 8, "2 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "150 tabletek", 98.99m, 913, "Nazwa leku" },
                    { 43, 5, 8, "3 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "150 tabletek", 91.99m, 263, "Nazwa leku" },
                    { 44, 7, 8, "3 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "75 tabletek", 20.99m, 861, "Nazwa leku" },
                    { 45, 0, 8, "2 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "200 tabletek", 95.99m, 289, "Nazwa leku" },
                    { 46, 7, 9, "5 tabletek", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "200 tabletek", 53.99m, 331, "Nazwa leku" },
                    { 47, 2, 9, "2 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "50 tabletek", 63.99m, 268, "Nazwa leku" },
                    { 48, 5, 9, "3 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "30 tabletek", 58.99m, 933, "Nazwa leku" },
                    { 49, 2, 9, "5 tabletek", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "150 tabletek", 73.99m, 274, "Nazwa leku" },
                    { 50, 5, 9, "5 tabletek", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "30 tabletek", 112.99m, 553, "Nazwa leku" },
                    { 51, 7, 10, "5 tabletek", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "75 tabletek", 145.99m, 341, "Nazwa leku" },
                    { 52, 7, 10, "3 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "30 tabletek", 123.99m, 71, "Nazwa leku" },
                    { 53, 2, 10, "5 tabletek", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "20 tabletek", 126.99m, 293, "Nazwa leku" },
                    { 54, 9, 10, "1 tabletka", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "200 tabletek", 19.99m, 849, "Nazwa leku" },
                    { 55, 9, 10, "3 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "50 tabletek", 43.99m, 286, "Nazwa leku" },
                    { 56, 7, 11, "2 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "200 tabletek", 19.99m, 654, "Nazwa leku" },
                    { 57, 0, 11, "1 tabletka", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "50 tabletek", 55.99m, 375, "Nazwa leku" },
                    { 58, 9, 11, "2 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "50 tabletek", 144.99m, 767, "Nazwa leku" },
                    { 59, 7, 11, "1 tabletka", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "30 tabletek", 133.99m, 869, "Nazwa leku" }
                });

            migrationBuilder.InsertData(
                table: "Drugs",
                columns: new[] { "DrugId", "ActiveSubstanceId", "CategoryId", "Dosage", "ImageURL", "PackSize", "Price", "Quantity", "TradeName" },
                values: new object[,]
                {
                    { 60, 6, 11, "1 tabletka", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "30 tabletek", 51.99m, 253, "Nazwa leku" },
                    { 61, 2, 12, "5 tabletek", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "50 tabletek", 136.99m, 475, "Nazwa leku" },
                    { 62, 4, 12, "3 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "30 tabletek", 119.99m, 116, "Nazwa leku" },
                    { 63, 7, 12, "2 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "150 tabletek", 21.99m, 329, "Nazwa leku" },
                    { 64, 1, 12, "5 tabletek", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "10 tabletek", 48.99m, 749, "Nazwa leku" },
                    { 65, 1, 12, "5 tabletek", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "75 tabletek", 98.99m, 458, "Nazwa leku" },
                    { 66, 4, 13, "2 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "10 tabletek", 102.99m, 912, "Nazwa leku" },
                    { 67, 7, 13, "1 tabletka", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "100 tabletek", 98.99m, 51, "Nazwa leku" },
                    { 68, 9, 13, "2 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "30 tabletek", 71.99m, 87, "Nazwa leku" },
                    { 69, 5, 13, "1 tabletka", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "100 tabletek", 146.99m, 197, "Nazwa leku" },
                    { 70, 8, 13, "3 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "150 tabletek", 129.99m, 499, "Nazwa leku" },
                    { 71, 7, 14, "3 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "50 tabletek", 41.99m, 565, "Nazwa leku" },
                    { 72, 5, 14, "5 tabletek", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "100 tabletek", 64.99m, 212, "Nazwa leku" },
                    { 73, 6, 14, "3 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "100 tabletek", 78.99m, 735, "Nazwa leku" },
                    { 74, 4, 14, "2 tabletki", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "30 tabletek", 110.99m, 158, "Nazwa leku" },
                    { 75, 8, 14, "5 tabletek", "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg", "10 tabletek", 96.99m, 872, "Nazwa leku" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActiveSubstances",
                keyColumn: "SubstanceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ActiveSubstances",
                keyColumn: "SubstanceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ActiveSubstances",
                keyColumn: "SubstanceId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ActiveSubstances",
                keyColumn: "SubstanceId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ActiveSubstances",
                keyColumn: "SubstanceId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ActiveSubstances",
                keyColumn: "SubstanceId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ActiveSubstances",
                keyColumn: "SubstanceId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ActiveSubstances",
                keyColumn: "SubstanceId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ActiveSubstances",
                keyColumn: "SubstanceId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 75);

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "DrugId",
                keyValue: 1,
                columns: new[] { "ActiveSubstanceId", "CategoryId" },
                values: new object[] { 1, 1 });
        }
    }
}
