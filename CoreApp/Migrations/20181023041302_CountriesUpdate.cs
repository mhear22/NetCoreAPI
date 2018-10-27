using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreApp.Migrations
{
	public partial class CountriesUpdate : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			
			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "8b6e9487-db5b-4985-9852-ecca594d0024");
			
			migrationBuilder.InsertData(
				table: "Countries",
				columns: new[] { "Id", "Name", "VinPrefix" },
				values: new object[,]
				{
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F160", "unassigned", "AP-A0" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F570", "Belarus", "Y3-Y5" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F569", "Norway", "YX-Y2" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F568", "Sweden", "YS-YW" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F567", "Malta", "YL-YR" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F566", "Finland", "YF-YK" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F565", "Belgium", "YA-YE" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F564", "Russia", "X3-X0" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F563", "Luxembourg", "XX-X2" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F562", "Russia (former USSR)", "XS-XW" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F561", "Netherlands", "XL-XR" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F559", "Greece", "XF-XK" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F558", "Bulgaria", "XA-XE" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", "Germany (formerly West Germany)", "W" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F556", "Estonia", "V6-V0" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F555", "Croatia", "V3-V5" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F554", "Serbia", "VX-V2" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F553", "Spain", "VS-VW" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F552", "France", "VF-VR" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F551", "Austria", "VA-VE" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F550", "unassigned", "U8-U0" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F549", "Slovakia", "U5-U7" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F548", "unassigned", "U1-U4" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F547", "Romania", "UU-UZ" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F571", "Ukraine", "Y6-Y0" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F546", "Ireland", "UN-UT" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F572", "Italy", "ZA-ZR" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F574", "Slovenia", "ZX-Z2" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F597", "Trinidad & Tobago", "9X-92" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F596", "Uruguay", "9S-9W" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F595", "Paraguay", "9L-9R" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F594", "Colombia", "9F-9K" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F593", "Brazil", "9A-9E" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F592", "unassigned", "83-80" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F591", "Venezuela", "8X-82" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F590", "Peru", "8S-8W" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F589", "Ecuador", "8L-8R" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F588", "Chile", "8F-8K" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F587", "Argentina", "8A-8E" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F586", "New Zealand", "7" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F585", "Australia", "6" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F584", "unassigned", "30" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F583", "Cayman Islands", "38-39" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F582", "Costa Rica", "3X-37" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F581", "Mexico", "3A-3W" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F580", "Canada", "2" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F579", "United States", "1" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F578", "United States", "4" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", "United States", "5" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F576", "unassigned", "Z6-Z0" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F575", "Lithuania", "Z3-Z5" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F573", "unassigned", "ZS-ZW" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F545", "Denmark", "UH-UM" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F544", "unassigned", "UA-UG" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F543", "unassigned", "T2-T0" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F501", "Israel", "KF-KK" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F502", "Sri Lanka", "KA-KE" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F503", "Japan", "J" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F504", "unassigned", "HA-H0" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F505", "unassigned", "GA-G0" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F506", "unassigned", "FL-F0" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F507", "Nigeria", "FF-FK" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F508", "Ghana", "FA-FE" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F509", "unassigned", "EL-E0" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F550", "Mozambique", "EF-EK" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F540", "Ethiopia", "EA-EE" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F130", "unassigned", "DS-D0" },
					{ "4E8349F3-BE69-4A7E-9AC7-1188C7F3F520", "Zambia", "DL-DR" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F110", "Morocco", "DF-DK" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F169", "Egypt", "DA-DE" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F168", "unassigned", "CS-C0" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F167", "Tunisia", "CL-CR" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F166", "Madagascar", "CF-CK" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F165", "Benin", "CA-CE" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F164", "unassigned", "BS-B0" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F163", "Tanzania", "BL-BR" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F162", "Kenya", "BF-BK" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F161", "Angola", "BA-BE" },
					{ "4E8349F3-BE69-4A7E-9AC7-0188C7F3F565", "Korea (South)", "KL-KR" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F516", "Kazakhstan", "KS-K0" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", "China (Mainland)", "L" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F518", "India", "MA-ME" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F542", "Portugal", "TW-T1" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F541", "Hungary", "TR-TV" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F540", "Czech Republic", "TJ-TP" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F539", "Switzerland", "TA-TH" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F538", "unassigned", "S5-S0" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F537", "Latvia", "S1-S4" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F536", "Poland", "SU-SZ" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F535", "Germany (formerly East Germany)", "SN-ST" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F534", "United Kingdom", "SA-SM" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F533", "Saudi Arabia", "RS-R0" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F532", "Vietnam", "RL-RR" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", "Brazil", "93–99" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F531", "Taiwan", "RF-RK" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F529", "unassigned", "PS-P0" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F528", "Malaysia", "PL-PR" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F527", "Singapore", "PF-PK" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F526", "Philippines", "PA-PE" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F525", "unassigned", "NS-N0" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F524", "Turkey", "NL-NR" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F523", "Pakistan", "NF-NK" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F522", "Iran", "NA-NE" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F521", "Myanmar", "MS-M0" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F520", "Thailand", "ML-MR" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F519", "Indonesia", "MF-MK" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F530", "United Arab Emirates", "RA-RE" },
					{ "4E8349F3-BE69-4A7E-9AC7-0588C7F3F599", "unassigned", "90" }
				});
			
			migrationBuilder.AddForeignKey(
				name: "FK_VinWMIs_Countries_CountryId",
				table: "VinWMIs",
				column: "CountryId",
				principalTable: "Countries",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F110");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F130");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F160");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F161");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F162");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F163");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F164");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F165");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F166");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F167");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F168");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F169");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F501");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F502");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F503");

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
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F507");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F508");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F509");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F540");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F550");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0188C7F3F565");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F516");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F517");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F518");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F519");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F520");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F521");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F522");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F523");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F524");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F525");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F526");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F527");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F528");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F529");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F530");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F531");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F532");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F533");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F534");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F535");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F536");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F537");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F538");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F539");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F540");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F541");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F542");

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
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F545");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F546");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F547");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F548");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F549");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F550");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F551");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F552");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F553");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F554");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F555");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F556");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F557");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F558");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F559");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F561");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F562");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F563");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F564");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F565");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F566");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F567");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F568");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F569");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F570");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F571");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F572");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F573");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F574");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F575");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F576");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F577");

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
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F580");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F581");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F582");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F583");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F584");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F585");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F586");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F587");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F588");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F589");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F590");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F591");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F592");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F593");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F594");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F595");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F596");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F597");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F598");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-0588C7F3F599");

			migrationBuilder.DeleteData(
				table: "Countries",
				keyColumn: "Id",
				keyValue: "4E8349F3-BE69-4A7E-9AC7-1188C7F3F520");

			migrationBuilder.InsertData(
				table: "CountryDto",
				columns: new[] { "Id", "Name", "VinPrefix" },
				values: new object[] { "8b6e9487-db5b-4985-9852-ecca594d0024", "Australia", "6" });

			migrationBuilder.AddForeignKey(
				name: "FK_VinWMIs_CountryDto_CountryId",
				table: "VinWMIs",
				column: "CountryId",
				principalTable: "CountryDto",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);
		}
	}
}
