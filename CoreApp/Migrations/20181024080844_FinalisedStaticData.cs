using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreApp.Migrations
{
    public partial class FinalisedStaticData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F130");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F164");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F168");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F504");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F505");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F506");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F509");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F525");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F529");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F538");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F543");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F544");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F548");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F550");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F573");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F576");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F578");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F579");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F584");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F592");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F599");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0024");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F160",
                columns: new[] { "Name", "VinPrefix" },
                values: new object[] { "South Africa", "BA-BE" });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0024",
                column: "VinPrefix",
                value: null);

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name", "VinPrefix" },
                values: new object[,]
                {
                    { "8b6e9487-db5b-4985-9852-ecca594d0100", "Porsche", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0099", "Alpina", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0098", "Neoplan", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0097", "Talbot", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0096", "DS Automobiles", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0095", "Opel", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0094", "Scania", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0093", "Google", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0092", "DeLorean", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0091", "Aston Martin", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0090", "Lotus", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0089", "Mclaren", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0088", "Triumph", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0087", "Rover", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0086", "Land Rover", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0085", "Jaguar", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0084", "Volvo", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0083", "Subaru", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0081", "BMW", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0080", "SsangYong", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0079", "Daewoo", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0078", "Yamaha", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0101", "Quattro", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0102", "RUF", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0103", "MAN", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0104", "Karl Kässbohrer Fahrzeugwerke", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0127", "SAIC General Motors", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0126", "SAIC MG", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0125", "SAIC GM Wuling", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0124", "SAIC Maxus", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0123", "GAC Trumpchi", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0122", "JAC", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0121", "FAW Haima", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0120", "Great Wall", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0119", "Dongfeng Fengshen", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0118", "Yutong", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0117", "BYD", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0116", "FAW Car", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0115", "King Long", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0114", "Jaguar", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0113", "Tesla", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0112", "Continental", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0111", "Lincon", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0110", "Oldsmobile", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0109", "Chrysler", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0108", "Mini", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0107", "Irmscher", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0106", "EvoBus", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0105", "Jeep", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0077", "Fuji Heavy Industries", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0076", "Wallyscar", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0082", "Hyundai", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0074", "Lancia", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0047", "Pontiac", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0046", "Ontario Drive & Gear", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0045", "DAF Trucks", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0044", "Volkswagen", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0075", "Dodge", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0042", "Saab", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0041", "General Motors", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0040", "Mitsubishi", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0039", "Chevrolet", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0038", "Tauro Sport Auto", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0037", "SEAT", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0036", "Škoda", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0035", "Nissan", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0034", "Honda", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0033", "ÖAF", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0032", "Dacia", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0031", "Suzuki", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0030", "Audi", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0029", "Smart", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0028", "Proton", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0027", "Hyundai", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0026", "Ford", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0025", "KIA", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0048", "Gnome Homes", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0049", "Les Contenants Durabac", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0043", "Acura", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0051", "Holden", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0073", "Lamborghini", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0072", "Ferrari", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0071", "Alfa Romeo", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0070", "Maserati", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0050", "Mercury", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0069", "Bugatti", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0068", "Alexander Dennis", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0067", "DaimlerChrysler AG/Daimler AG", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0066", "Geely", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0064", "Isuzu", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0063", "Volkswagen Commercial Vehicles", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0065", "IvecoBus", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0061", "Lifan", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0052", "Japanese Import", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0053", "NZ Transport Agency", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0062", "Mazda", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0055", "Renault", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0056", "Mercedes Benz", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0054", "Fiat", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0058", "Peugeot", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0059", "Iveco", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0060", "Chery", null },
                    { "8b6e9487-db5b-4985-9852-ecca594d0057", "Citroën", null }
                });

            migrationBuilder.InsertData(
                table: "VinWMIs",
                columns: new[] { "Id", "CountryId", "ManufacturerId", "Matcher" },
                values: new object[,]
                {
                    { "61", "4E8349F3-BE69-4A7E-9AC7-0188C7F3F160", "8b6e9487-db5b-4985-9852-ecca594d0024", "AHT" },
                    { "82", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0024", "4T" },
                    { "74", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F552", "8b6e9487-db5b-4985-9852-ecca594d0024", "VNK" },
                    { "70", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F534", "8b6e9487-db5b-4985-9852-ecca594d0024", "SB1" },
                    { "67", "4E8349F3-BE69-4A7E-9AC7-0188C7F3F503", "8b6e9487-db5b-4985-9852-ecca594d0024", "JT" },
                    { "58", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F587", "8b6e9487-db5b-4985-9852-ecca594d0024", "8AJ" },
                    { "88", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0024", "5T" },
                    { "47", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F585", "8b6e9487-db5b-4985-9852-ecca594d0024", "6T1" },
                    { "43", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F580", "8b6e9487-db5b-4985-9852-ecca594d0024", "2T" },
                    { "31", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F524", "8b6e9487-db5b-4985-9852-ecca594d0024", "NMT" },
                    { "24", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0024", "LFM" },
                    { "4", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0024", "LVG" },
                    { "3", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0024", "LTV" },
                    { "55", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F586", "8b6e9487-db5b-4985-9852-ecca594d0024", "7A4" },
                    { "91", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0024", "9BR" }
                });

            migrationBuilder.InsertData(
                table: "VinWMIs",
                columns: new[] { "Id", "CountryId", "ManufacturerId", "Matcher" },
                values: new object[,]
                {
                    { "17", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0025", "LJD" },
                    { "169", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0067", "WDC" },
                    { "170", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0067", "WDD" },
                    { "171", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0067", "WMX" },
                    { "166", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F534", "8b6e9487-db5b-4985-9852-ecca594d0068", "SFD" },
                    { "167", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F534", "8b6e9487-db5b-4985-9852-ecca594d0068", "SFE" },
                    { "174", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F572", "8b6e9487-db5b-4985-9852-ecca594d0069", "ZA9" },
                    { "202", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F552", "8b6e9487-db5b-4985-9852-ecca594d0069", "VF9" },
                    { "175", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F572", "8b6e9487-db5b-4985-9852-ecca594d0070", "ZAM" },
                    { "176", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F572", "8b6e9487-db5b-4985-9852-ecca594d0071", "ZAR" },
                    { "178", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F572", "8b6e9487-db5b-4985-9852-ecca594d0072", "ZFF" },
                    { "179", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F572", "8b6e9487-db5b-4985-9852-ecca594d0073", "ZHW" },
                    { "180", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F572", "8b6e9487-db5b-4985-9852-ecca594d0074", "ZLA" },
                    { "165", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0066", "LB3" },
                    { "181", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0075", "1B" },
                    { "184", "4E8349F3-BE69-4A7E-9AC7-0188C7F3F503", "8b6e9487-db5b-4985-9852-ecca594d0077", "JF" },
                    { "185", "4E8349F3-BE69-4A7E-9AC7-0188C7F3F503", "8b6e9487-db5b-4985-9852-ecca594d0078", "JY" },
                    { "197", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0078", "9C6" },
                    { "186", "4E8349F3-BE69-4A7E-9AC7-0188C7F3F565", "8b6e9487-db5b-4985-9852-ecca594d0079", "KL" },
                    { "187", "4E8349F3-BE69-4A7E-9AC7-0188C7F3F565", "8b6e9487-db5b-4985-9852-ecca594d0080", "KPT" },
                    { "189", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0081", "4US" },
                    { "190", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0081", "5U" },
                    { "196", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0081", "98M" },
                    { "198", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0081", "WBA" },
                    { "199", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0081", "WBS" },
                    { "201", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0081", "WBX" },
                    { "206", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0081", "LBV" },
                    { "182", "4E8349F3-BE69-4A7E-9AC7-0188C7F3F167", "8b6e9487-db5b-4985-9852-ecca594d0076", "CL9" },
                    { "191", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0082", "5X" },
                    { "164", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0066", "L6T" },
                    { "162", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F572", "8b6e9487-db5b-4985-9852-ecca594d0065", "ZGA" },
                    { "152", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F552", "8b6e9487-db5b-4985-9852-ecca594d0057", "VF7" },
                    { "157", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0057", "935" },
                    { "22", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0058", "LDC" },
                    { "140", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F587", "8b6e9487-db5b-4985-9852-ecca594d0058", "8AD" },
                    { "151", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F552", "8b6e9487-db5b-4985-9852-ecca594d0058", "VF3" },
                    { "156", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0058", "936" },
                    { "141", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F587", "8b6e9487-db5b-4985-9852-ecca594d0059", "8AT" },
                    { "145", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F572", "8b6e9487-db5b-4985-9852-ecca594d0059", "ZCF" },
                    { "153", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0059", "WJM" },
                    { "161", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0059", "93Z" },
                    { "236", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F552", "8b6e9487-db5b-4985-9852-ecca594d0059", "VF5" },
                    { "142", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F596", "8b6e9487-db5b-4985-9852-ecca594d0060", "9UJ" },
                    { "168", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F552", "8b6e9487-db5b-4985-9852-ecca594d0065", "VFE" },
                    { "148", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0060", "LVV" },
                    { "203", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0060", "L2C" },
                    { "143", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F596", "8b6e9487-db5b-4985-9852-ecca594d0061", "9UK" },
                    { "147", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0061", "LLV" },
                    { "5", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0062", "LVR" },
                    { "144", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F520", "8b6e9487-db5b-4985-9852-ecca594d0062", "MM0" },
                    { "146", "4E8349F3-BE69-4A7E-9AC7-0188C7F3F503", "8b6e9487-db5b-4985-9852-ecca594d0062", "JM6" },
                    { "154", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0062", "1YV" },
                    { "155", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0062", "4F" },
                    { "183", "4E8349F3-BE69-4A7E-9AC7-0188C7F3F503", "8b6e9487-db5b-4985-9852-ecca594d0062", "JC1" },
                    { "172", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0063", "WV1" },
                    { "173", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0063", "WV2" },
                    { "163", "4E8349F3-BE69-4A7E-9AC7-0188C7F3F503", "8b6e9487-db5b-4985-9852-ecca594d0064", "JA" },
                    { "159", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0060", "98R" },
                    { "194", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0082", "9BH" },
                    { "195", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0082", "95P" },
                    { "205", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0082", "LBE" },
                    { "225", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0103", "953" },
                    { "221", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0104", "WKK" },
                    { "219", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0105", "1J" },
                    { "220", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0105", "988" },
                    { "207", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0106", "WEB" },
                    { "208", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0107", "WJR" },
                    { "209", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0108", "WMW" },
                    { "210", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0109", "1C" },
                    { "211", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0110", "1G3" },
                    { "212", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0111", "1L" },
                    { "216", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0111", "5L" },
                    { "214", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0112", "1MR" },
                    { "222", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0103", "WMA" },
                    { "217", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0113", "5YJ" },
                    { "204", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0115", "LA6" },
                    { "25", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0116", "LFP" },
                    { "21", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0117", "LC0" },
                    { "26", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0117", "LGX" },
                    { "29", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0118", "LZY" },
                    { "15", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0119", "LGJ" },
                    { "16", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0120", "LGW" },
                    { "9", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0121", "LH1" },
                    { "10", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0122", "LJ1" },
                    { "11", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0123", "LMG" },
                    { "12", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0124", "LSFA" },
                    { "8", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0125", "LZW" },
                    { "218", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0114", "99J" },
                    { "235", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0102", "W09" },
                    { "234", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0101", "WUA" },
                    { "233", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0100", "WP1" },
                    { "257", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0083", "4S3" },
                    { "258", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0083", "4S4" },
                    { "254", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F568", "8b6e9487-db5b-4985-9852-ecca594d0084", "YV1" },
                    { "255", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F568", "8b6e9487-db5b-4985-9852-ecca594d0084", "YV2" },
                    { "256", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F568", "8b6e9487-db5b-4985-9852-ecca594d0084", "YV3" },
                    { "259", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0084", "9BV" },
                    { "245", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F534", "8b6e9487-db5b-4985-9852-ecca594d0085", "SAJ" },
                    { "246", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F534", "8b6e9487-db5b-4985-9852-ecca594d0086", "SAL" },
                    { "247", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F534", "8b6e9487-db5b-4985-9852-ecca594d0087", "SAR" },
                    { "248", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F534", "8b6e9487-db5b-4985-9852-ecca594d0088", "SAT" },
                    { "249", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F534", "8b6e9487-db5b-4985-9852-ecca594d0089", "SBM" },
                    { "250", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F534", "8b6e9487-db5b-4985-9852-ecca594d0090", "SCC" },
                    { "251", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F534", "8b6e9487-db5b-4985-9852-ecca594d0091", "SCF" },
                    { "252", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F534", "8b6e9487-db5b-4985-9852-ecca594d0092", "SCE" },
                    { "243", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0093", "1G9" },
                    { "241", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F568", "8b6e9487-db5b-4985-9852-ecca594d0094", "YS2" },
                    { "242", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F568", "8b6e9487-db5b-4985-9852-ecca594d0094", "YS4" },
                    { "244", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0094", "9BS" },
                    { "239", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0095", "W0L" },
                    { "240", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0095", "W0SV" },
                    { "18", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0096", "LPA" },
                    { "238", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F552", "8b6e9487-db5b-4985-9852-ecca594d0096", "VR1" },
                    { "226", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F552", "8b6e9487-db5b-4985-9852-ecca594d0097", "VF4" },
                    { "227", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F552", "8b6e9487-db5b-4985-9852-ecca594d0097", "VF8" },
                    { "228", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0098", "WAG" },
                    { "229", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0099", "WAP" },
                    { "232", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0100", "WP0" },
                    { "139", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F587", "8b6e9487-db5b-4985-9852-ecca594d0057", "8BC" },
                    { "230", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0056", "WDB" },
                    { "192", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0056", "55" },
                    { "188", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0056", "4J" },
                    { "95", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0031", "9CD" },
                    { "38", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F547", "8b6e9487-db5b-4985-9852-ecca594d0032", "UU" },
                    { "39", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F551", "8b6e9487-db5b-4985-9852-ecca594d0033", "VA0" },
                    { "27", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0034", "LHG" },
                    { "28", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0034", "LVH" },
                    { "48", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F580", "8b6e9487-db5b-4985-9852-ecca594d0034", "2HG" },
                    { "49", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F580", "8b6e9487-db5b-4985-9852-ecca594d0034", "2HJ" },
                    { "50", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F580", "8b6e9487-db5b-4985-9852-ecca594d0034", "2HK" },
                    { "51", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F581", "8b6e9487-db5b-4985-9852-ecca594d0034", "3HG" },
                    { "52", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F581", "8b6e9487-db5b-4985-9852-ecca594d0034", "3HM" },
                    { "54", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F586", "8b6e9487-db5b-4985-9852-ecca594d0034", "7A3" },
                    { "59", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F587", "8b6e9487-db5b-4985-9852-ecca594d0034", "8C3" },
                    { "66", "4E8349F3-BE69-4A7E-9AC7-0188C7F3F503", "8b6e9487-db5b-4985-9852-ecca594d0031", "JS" },
                    { "63", "4E8349F3-BE69-4A7E-9AC7-0188C7F3F503", "8b6e9487-db5b-4985-9852-ecca594d0034", "JHL" },
                    { "71", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F534", "8b6e9487-db5b-4985-9852-ecca594d0034", "SHH" },
                    { "72", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F534", "8b6e9487-db5b-4985-9852-ecca594d0034", "SHS" },
                    { "78", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0034", "1HG" },
                    { "81", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0034", "4S6" },
                    { "83", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0034", "5FN" },
                    { "84", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0034", "5J6" },
                    { "90", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0034", "93H" },
                    { "94", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0034", "9C2" },
                    { "14", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0035", "LGB" },
                    { "53", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F581", "8b6e9487-db5b-4985-9852-ecca594d0035", "3N" },
                    { "65", "4E8349F3-BE69-4A7E-9AC7-0188C7F3F503", "8b6e9487-db5b-4985-9852-ecca594d0035", "JN" },
                    { "73", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F534", "8b6e9487-db5b-4985-9852-ecca594d0035", "SJN" },
                    { "64", "4E8349F3-BE69-4A7E-9AC7-0188C7F3F503", "8b6e9487-db5b-4985-9852-ecca594d0034", "JHM" },
                    { "36", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F541", "8b6e9487-db5b-4985-9852-ecca594d0031", "TSM" },
                    { "19", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0031", "LS5" },
                    { "93", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0030", "99A" },
                    { "30", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F521", "8b6e9487-db5b-4985-9852-ecca594d0025", "MS0" },
                    { "37", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F549", "8b6e9487-db5b-4985-9852-ecca594d0025", "U5Y" },
                    { "45", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F581", "8b6e9487-db5b-4985-9852-ecca594d0025", "3KP" },
                    { "60", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F596", "8b6e9487-db5b-4985-9852-ecca594d0025", "9UW" },
                    { "69", "4E8349F3-BE69-4A7E-9AC7-0188C7F3F565", "8b6e9487-db5b-4985-9852-ecca594d0025", "KN" },
                    { "6", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0026", "LVS" },
                    { "32", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F524", "8b6e9487-db5b-4985-9852-ecca594d0026", "NM0" },
                    { "40", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F540", "8b6e9487-db5b-4985-9852-ecca594d0026", "TMA" },
                    { "41", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F580", "8b6e9487-db5b-4985-9852-ecca594d0026", "2F" },
                    { "42", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F580", "8b6e9487-db5b-4985-9852-ecca594d0026", "2HM" },
                    { "44", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F581", "8b6e9487-db5b-4985-9852-ecca594d0026", "3F" },
                    { "46", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F585", "8b6e9487-db5b-4985-9852-ecca594d0026", "6F" },
                    { "56", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F586", "8b6e9487-db5b-4985-9852-ecca594d0026", "7A5" },
                    { "57", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F587", "8b6e9487-db5b-4985-9852-ecca594d0026", "8AF" },
                    { "62", "4E8349F3-BE69-4A7E-9AC7-0188C7F3F160", "8b6e9487-db5b-4985-9852-ecca594d0026", "AFA" },
                    { "68", "4E8349F3-BE69-4A7E-9AC7-0188C7F3F565", "8b6e9487-db5b-4985-9852-ecca594d0026", "KMH" },
                    { "76", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0026", "WF0" },
                    { "77", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0026", "1F" },
                    { "80", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0026", "1ZV" },
                    { "86", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0026", "5NM" },
                    { "87", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0026", "5NP" },
                    { "89", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0026", "9BF" },
                    { "33", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F528", "8b6e9487-db5b-4985-9852-ecca594d0028", "PL1" },
                    { "34", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F539", "8b6e9487-db5b-4985-9852-ecca594d0029", "TCC" },
                    { "231", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0029", "WME" },
                    { "35", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F541", "8b6e9487-db5b-4985-9852-ecca594d0030", "TRU" },
                    { "75", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0030", "WAU" },
                    { "79", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0035", "1N" },
                    { "2", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0126", "LSJ" },
                    { "85", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0035", "5N1" },
                    { "96", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F540", "8b6e9487-db5b-4985-9852-ecca594d0036", "TMB" },
                    { "102", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F580", "8b6e9487-db5b-4985-9852-ecca594d0046", "2DG" },
                    { "105", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F580", "8b6e9487-db5b-4985-9852-ecca594d0047", "2G2" },
                    { "114", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F585", "8b6e9487-db5b-4985-9852-ecca594d0047", "6G2" },
                    { "121", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0047", "1GM" },
                    { "106", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F580", "8b6e9487-db5b-4985-9852-ecca594d0048", "2G9" },
                    { "108", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F580", "8b6e9487-db5b-4985-9852-ecca594d0049", "2L9" },
                    { "109", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F580", "8b6e9487-db5b-4985-9852-ecca594d0050", "2M" },
                    { "213", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0050", "1M" },
                    { "215", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0050", "4M" },
                    { "132", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F585", "8b6e9487-db5b-4985-9852-ecca594d0051", "6H" },
                    { "133", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F585", "8b6e9487-db5b-4985-9852-ecca594d0052", "6U9" },
                    { "134", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F586", "8b6e9487-db5b-4985-9852-ecca594d0053", "7A8" },
                    { "99", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F561", "8b6e9487-db5b-4985-9852-ecca594d0045", "XLR" },
                    { "135", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F586", "8b6e9487-db5b-4985-9852-ecca594d0053", "7AT" },
                    { "136", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F587", "8b6e9487-db5b-4985-9852-ecca594d0054", "8AP" },
                    { "177", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F572", "8b6e9487-db5b-4985-9852-ecca594d0054", "ZFA" },
                    { "223", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0054", "9BD" },
                    { "224", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0054", "93W" },
                    { "137", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F587", "8b6e9487-db5b-4985-9852-ecca594d0055", "8A1" },
                    { "149", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F552", "8b6e9487-db5b-4985-9852-ecca594d0055", "VF1" },
                    { "150", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F552", "8b6e9487-db5b-4985-9852-ecca594d0055", "VF2" },
                    { "158", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0055", "93Y" },
                    { "237", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F552", "8b6e9487-db5b-4985-9852-ecca594d0055", "VF6" },
                    { "23", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0056", "LE4" },
                    { "138", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F587", "8b6e9487-db5b-4985-9852-ecca594d0056", "8AC" },
                    { "160", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0056", "9BM" },
                    { "7", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0054", "LWV" },
                    { "129", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F587", "8b6e9487-db5b-4985-9852-ecca594d0044", "8AW" },
                    { "126", "4E8349F3-BE69-4A7E-9AC7-0188C7F3F160", "8b6e9487-db5b-4985-9852-ecca594d0044", "AAV" },
                    { "124", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0044", "9BW" },
                    { "97", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F553", "8b6e9487-db5b-4985-9852-ecca594d0037", "VSS" },
                    { "98", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F553", "8b6e9487-db5b-4985-9852-ecca594d0038", "VV9" },
                    { "104", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F580", "8b6e9487-db5b-4985-9852-ecca594d0039", "2G1" },
                    { "113", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F585", "8b6e9487-db5b-4985-9852-ecca594d0039", "6G1" },
                    { "119", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0039", "1G1" },
                    { "120", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0039", "1GC" },
                    { "125", "4E8349F3-BE69-4A7E-9AC7-0188C7F3F503", "8b6e9487-db5b-4985-9852-ecca594d0040", "JMB" },
                    { "127", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F520", "8b6e9487-db5b-4985-9852-ecca594d0040", "MMB" },
                    { "130", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F586", "8b6e9487-db5b-4985-9852-ecca594d0040", "7A1" },
                    { "131", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F585", "8b6e9487-db5b-4985-9852-ecca594d0040", "6MM" },
                    { "193", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0040", "93X" },
                    { "103", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F580", "8b6e9487-db5b-4985-9852-ecca594d0041", "2Gx" },
                    { "110", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F581", "8b6e9487-db5b-4985-9852-ecca594d0041", "3G" },
                    { "112", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F585", "8b6e9487-db5b-4985-9852-ecca594d0041", "6G" },
                    { "118", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0041", "1G" },
                    { "123", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0041", "9BG" },
                    { "128", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F587", "8b6e9487-db5b-4985-9852-ecca594d0041", "8AG" },
                    { "101", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F566", "8b6e9487-db5b-4985-9852-ecca594d0042", "YK1" },
                    { "117", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F568", "8b6e9487-db5b-4985-9852-ecca594d0042", "YS3" },
                    { "253", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F568", "8b6e9487-db5b-4985-9852-ecca594d0042", "YTN" },
                    { "107", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F580", "8b6e9487-db5b-4985-9852-ecca594d0043", "2HH" },
                    { "13", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0044", "LFV" },
                    { "20", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0044", "LSV" },
                    { "111", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F581", "8b6e9487-db5b-4985-9852-ecca594d0044", "3VW" },
                    { "115", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0044", "WVG" },
                    { "116", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "8b6e9487-db5b-4985-9852-ecca594d0044", "WVW" },
                    { "122", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "8b6e9487-db5b-4985-9852-ecca594d0044", "1VW" },
                    { "92", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "8b6e9487-db5b-4985-9852-ecca594d0035", "94D" },
                    { "1", "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "8b6e9487-db5b-4985-9852-ecca594d0127", "LSG" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0027");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "101");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "102");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "103");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "104");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "105");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "106");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "107");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "108");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "109");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "110");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "111");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "112");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "113");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "114");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "115");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "116");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "117");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "118");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "119");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "120");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "121");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "122");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "123");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "124");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "125");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "126");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "127");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "128");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "129");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "130");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "131");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "132");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "133");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "134");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "135");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "136");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "137");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "138");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "139");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "140");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "141");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "142");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "143");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "144");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "145");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "146");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "147");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "148");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "149");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "150");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "151");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "152");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "153");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "154");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "155");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "156");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "157");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "158");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "159");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "160");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "161");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "162");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "163");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "164");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "165");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "166");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "167");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "168");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "169");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "170");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "171");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "172");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "173");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "174");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "175");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "176");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "177");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "178");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "179");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "180");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "181");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "182");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "183");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "184");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "185");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "186");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "187");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "188");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "189");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "19");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "190");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "191");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "192");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "193");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "194");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "195");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "196");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "197");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "198");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "199");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "20");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "201");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "202");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "203");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "204");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "205");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "206");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "207");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "208");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "209");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "21");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "210");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "211");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "212");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "213");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "214");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "215");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "216");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "217");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "218");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "219");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "22");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "220");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "221");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "222");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "223");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "224");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "225");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "226");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "227");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "228");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "229");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "23");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "230");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "231");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "232");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "233");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "234");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "235");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "236");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "237");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "238");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "239");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "24");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "240");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "241");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "242");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "243");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "244");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "245");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "246");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "247");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "248");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "249");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "25");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "250");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "251");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "252");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "253");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "254");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "255");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "256");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "257");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "258");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "259");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "26");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "27");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "28");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "29");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "30");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "31");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "32");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "33");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "34");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "35");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "36");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "37");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "38");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "39");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "40");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "41");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "42");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "43");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "44");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "45");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "46");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "47");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "48");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "49");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "50");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "51");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "52");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "53");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "54");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "55");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "56");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "57");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "58");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "59");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "60");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "61");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "62");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "63");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "64");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "65");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "66");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "67");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "68");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "69");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "70");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "71");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "72");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "73");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "74");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "75");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "76");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "77");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "78");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "79");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "80");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "81");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "82");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "83");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "84");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "85");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "86");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "87");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "88");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "89");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "90");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "91");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "92");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "93");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "94");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "95");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "96");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "97");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "98");

            migrationBuilder.DeleteData(
                table: "VinWMIs",
                keyColumn: "Id",
                keyValue: "99");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0025");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0026");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0028");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0029");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0030");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0031");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0032");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0033");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0034");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0035");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0036");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0037");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0038");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0039");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0040");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0041");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0042");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0043");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0044");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0045");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0046");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0047");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0048");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0049");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0050");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0051");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0052");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0053");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0054");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0055");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0056");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0057");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0058");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0059");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0060");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0061");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0062");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0063");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0064");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0065");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0066");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0067");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0068");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0069");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0070");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0071");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0072");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0073");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0074");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0075");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0076");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0077");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0078");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0079");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0080");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0081");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0082");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0083");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0084");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0085");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0086");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0087");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0088");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0089");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0090");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0091");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0092");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0093");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0094");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0095");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0096");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0097");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0098");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0099");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0100");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0101");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0102");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0103");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0104");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0105");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0106");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0107");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0108");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0109");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0110");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0111");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0112");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0113");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0114");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0115");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0116");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0117");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0118");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0119");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0120");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0121");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0122");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0123");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0124");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0125");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0126");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0127");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F160",
                columns: new[] { "Name", "VinPrefix" },
                values: new object[] { "unassigned", "AP-A0" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "VinPrefix" },
                values: new object[,]
                {
                    { "4E8349F3-BE69-4A7E-9AC7-0588C7F3F599", "unassigned", "90" },
                    { "4E8349F3-BE69-4A7E-9AC7-0588C7F3F592", "unassigned", "83-80" },
                    { "4E8349F3-BE69-4A7E-9AC7-0588C7F3F584", "unassigned", "30" },
                    { "4E8349F3-BE69-4A7E-9AC7-0588C7F3F579", "United States", "1" },
                    { "4E8349F3-BE69-4A7E-9AC7-0588C7F3F578", "United States", "4" },
                    { "4E8349F3-BE69-4A7E-9AC7-0588C7F3F576", "unassigned", "Z6-Z0" },
                    { "4E8349F3-BE69-4A7E-9AC7-0588C7F3F573", "unassigned", "ZS-ZW" },
                    { "4E8349F3-BE69-4A7E-9AC7-0588C7F3F550", "unassigned", "U8-U0" },
                    { "4E8349F3-BE69-4A7E-9AC7-0588C7F3F548", "unassigned", "U1-U4" },
                    { "4E8349F3-BE69-4A7E-9AC7-0588C7F3F544", "unassigned", "UA-UG" },
                    { "4E8349F3-BE69-4A7E-9AC7-0588C7F3F543", "unassigned", "T2-T0" },
                    { "4E8349F3-BE69-4A7E-9AC7-0588C7F3F538", "unassigned", "S5-S0" },
                    { "4E8349F3-BE69-4A7E-9AC7-0588C7F3F529", "unassigned", "PS-P0" },
                    { "4E8349F3-BE69-4A7E-9AC7-0588C7F3F525", "unassigned", "NS-N0" },
                    { "4E8349F3-BE69-4A7E-9AC7-0188C7F3F504", "unassigned", "HA-H0" },
                    { "4E8349F3-BE69-4A7E-9AC7-0188C7F3F505", "unassigned", "GA-G0" },
                    { "4E8349F3-BE69-4A7E-9AC7-0188C7F3F506", "unassigned", "FL-F0" },
                    { "4E8349F3-BE69-4A7E-9AC7-0188C7F3F509", "unassigned", "EL-E0" },
                    { "4E8349F3-BE69-4A7E-9AC7-0188C7F3F130", "unassigned", "DS-D0" },
                    { "4E8349F3-BE69-4A7E-9AC7-0188C7F3F168", "unassigned", "CS-C0" },
                    { "4E8349F3-BE69-4A7E-9AC7-0188C7F3F164", "unassigned", "BS-B0" }
                });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: "8b6e9487-db5b-4985-9852-ecca594d0024",
                column: "VinPrefix",
                value: "");

            migrationBuilder.InsertData(
                table: "VinWMIs",
                columns: new[] { "Id", "CountryId", "ManufacturerId", "Matcher" },
                values: new object[] { "8b6e9487-db5b-4985-9852-ecca594d0024", "8b6e9487-db5b-4985-9852-ecca594d0024", "8b6e9487-db5b-4985-9852-ecca594d0024", "6T1" });
        }
    }
}
