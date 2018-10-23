using CoreApp.Models.Repositories;
using CoreApp.Models.Repositories.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Repositories
{
	public class StaticData
	{
		public static List<CountryDto> Countries = new List<CountryDto>()
		{
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F160", Name="unassigned", VinPrefix="AP-A0"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F161", Name="Angola", VinPrefix="BA-BE"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F162", Name="Kenya", VinPrefix="BF-BK"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F163", Name="Tanzania", VinPrefix="BL-BR"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F164", Name="unassigned", VinPrefix="BS-B0"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F165", Name="Benin", VinPrefix="CA-CE"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F166", Name="Madagascar", VinPrefix="CF-CK"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F167", Name="Tunisia", VinPrefix="CL-CR"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F168", Name="unassigned", VinPrefix="CS-C0"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F169", Name="Egypt", VinPrefix="DA-DE"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F110", Name="Morocco", VinPrefix="DF-DK"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-1188C7F3F520", Name="Zambia", VinPrefix="DL-DR"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F130", Name="unassigned", VinPrefix="DS-D0"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F540", Name="Ethiopia", VinPrefix="EA-EE"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F550", Name="Mozambique", VinPrefix="EF-EK"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F509", Name="unassigned", VinPrefix="EL-E0"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F508", Name="Ghana", VinPrefix="FA-FE"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F507", Name="Nigeria", VinPrefix="FF-FK"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F506", Name="unassigned", VinPrefix="FL-F0"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F505", Name="unassigned", VinPrefix="GA-G0"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F504", Name="unassigned", VinPrefix="HA-H0"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F503", Name="Japan", VinPrefix="J"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F502", Name="Sri Lanka", VinPrefix="KA-KE"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F501", Name="Israel", VinPrefix="KF-KK"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0188C7F3F565", Name="Korea (South)", VinPrefix="KL-KR"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F516", Name="Kazakhstan", VinPrefix="KS-K0"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F517", Name="China (Mainland)", VinPrefix="L"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F518", Name="India", VinPrefix="MA-ME"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F519", Name="Indonesia", VinPrefix="MF-MK"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F520", Name="Thailand", VinPrefix="ML-MR"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F521", Name="Myanmar", VinPrefix="MS-M0"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F522", Name="Iran", VinPrefix="NA-NE"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F523", Name="Pakistan", VinPrefix="NF-NK"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F524", Name="Turkey", VinPrefix="NL-NR"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F525", Name="unassigned", VinPrefix="NS-N0"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F526", Name="Philippines", VinPrefix="PA-PE"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F527", Name="Singapore", VinPrefix="PF-PK"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F528", Name="Malaysia", VinPrefix="PL-PR"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F529", Name="unassigned", VinPrefix="PS-P0"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F530", Name="United Arab Emirates", VinPrefix="RA-RE"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F531", Name="Taiwan", VinPrefix="RF-RK"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F532", Name="Vietnam", VinPrefix="RL-RR"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F533", Name="Saudi Arabia", VinPrefix="RS-R0"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F534", Name="United Kingdom", VinPrefix="SA-SM"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F535", Name="Germany (formerly East Germany)", VinPrefix="SN-ST"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F536", Name="Poland", VinPrefix="SU-SZ"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F537", Name="Latvia", VinPrefix="S1-S4"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F538", Name="unassigned", VinPrefix="S5-S0"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F539", Name="Switzerland", VinPrefix="TA-TH"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F540", Name="Czech Republic", VinPrefix="TJ-TP"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F541", Name="Hungary", VinPrefix="TR-TV"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F542", Name="Portugal", VinPrefix="TW-T1"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F543", Name="unassigned", VinPrefix="T2-T0"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F544", Name="unassigned", VinPrefix="UA-UG"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F545", Name="Denmark", VinPrefix="UH-UM"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F546", Name="Ireland", VinPrefix="UN-UT"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F547", Name="Romania", VinPrefix="UU-UZ"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F548", Name="unassigned", VinPrefix="U1-U4"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F549", Name="Slovakia", VinPrefix="U5-U7"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F550", Name="unassigned", VinPrefix="U8-U0"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F551", Name="Austria", VinPrefix="VA-VE"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F552", Name="France", VinPrefix="VF-VR"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F553", Name="Spain", VinPrefix="VS-VW"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F554", Name="Serbia", VinPrefix="VX-V2"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F555", Name="Croatia", VinPrefix="V3-V5"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F556", Name="Estonia", VinPrefix="V6-V0"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F557", Name="Germany (formerly West Germany)", VinPrefix="W"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F558", Name="Bulgaria", VinPrefix="XA-XE"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F559", Name="Greece", VinPrefix="XF-XK"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F561", Name="Netherlands", VinPrefix="XL-XR"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F562", Name="Russia (former USSR)", VinPrefix="XS-XW"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F563", Name="Luxembourg", VinPrefix="XX-X2"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F564", Name="Russia", VinPrefix="X3-X0"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F565", Name="Belgium", VinPrefix="YA-YE"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F566", Name="Finland", VinPrefix="YF-YK"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F567", Name="Malta", VinPrefix="YL-YR"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F568", Name="Sweden", VinPrefix="YS-YW"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F569", Name="Norway", VinPrefix="YX-Y2"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F570", Name="Belarus", VinPrefix="Y3-Y5"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F571", Name="Ukraine", VinPrefix="Y6-Y0"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F572", Name="Italy", VinPrefix="ZA-ZR"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F573", Name="unassigned", VinPrefix="ZS-ZW"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F574", Name="Slovenia", VinPrefix="ZX-Z2"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F575", Name="Lithuania", VinPrefix="Z3-Z5"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F576", Name="unassigned", VinPrefix="Z6-Z0"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F577", Name="United States", VinPrefix="5"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F578", Name="United States", VinPrefix="4"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F579", Name="United States", VinPrefix="1"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F580", Name="Canada", VinPrefix="2"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F581", Name="Mexico", VinPrefix="3A-3W"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F582", Name="Costa Rica", VinPrefix="3X-37"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F583", Name="Cayman Islands", VinPrefix="38-39"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F584", Name="unassigned", VinPrefix="30"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F585", Name="Australia", VinPrefix="6"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F586", Name="New Zealand", VinPrefix="7"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F587", Name="Argentina", VinPrefix="8A-8E"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F588", Name="Chile", VinPrefix="8F-8K"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F589", Name="Ecuador", VinPrefix="8L-8R"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F590", Name="Peru", VinPrefix="8S-8W"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F591", Name="Venezuela", VinPrefix="8X-82"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F592", Name="unassigned", VinPrefix="83-80"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F593", Name="Brazil", VinPrefix="9A-9E"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F594", Name="Colombia", VinPrefix="9F-9K"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F595", Name="Paraguay", VinPrefix="9L-9R"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F596", Name="Uruguay", VinPrefix="9S-9W"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F597", Name="Trinidad & Tobago", VinPrefix="9X-92"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F598", Name="Brazil", VinPrefix="93–99"},
			new CountryDto() { Id="4E8349F3-BE69-4A7E-9AC7-0588C7F3F599", Name="unassigned", VinPrefix="90"},
		};

		public static List<ManufacturerDto> Manufacturers = new List<ManufacturerDto>()
		{
			new ManufacturerDto() { Id = "8b6e9487-db5b-4985-9852-ecca594d0024", Name = "Toyota", VinPrefix = "" }
		};

		public static List<VinWMI> WorldManufactuerIdenifier = new List<VinWMI>()
		{
			new VinWMI() { Matcher = "6T1", Id = "8b6e9487-db5b-4985-9852-ecca594d0024", CountryId = "8b6e9487-db5b-4985-9852-ecca594d0024", ManufacturerId = "8b6e9487-db5b-4985-9852-ecca594d0024"}
		};
	}
}
