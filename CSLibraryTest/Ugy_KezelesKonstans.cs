using System;

namespace TaroltEljarasKonstans2
{
	class Ugy_KezelesKonstans
	{
	
		public enum Muvelet
        {
            CibFioklistaLekerdezese = 0,
            UgynokholdingokLekerdezese = 1,
            UgynokadatokModositasa = 2,
            PartnerLekerdezese = 3,
            UjUgynokRogzitese = 4,
            SzemelyadatokLekerdezeseAzonositoAlapjan = 5,
            UgynokkeresesSzemelyazonositoAlapjan = 6,
            UgynokadatokLekerdezese = 7,

        }
	
		public const string TaroltEljaras = "Ugy_Kezeles";
	
		public const string MuveletCibFioklistaLekerdezese = "";
		public const string MuveletUgynokholdingokLekerdezese = "";
		public const string MuveletUgynokadatokModositasa = "";
		public const string MuveletPartnerLekerdezese = "";
		public const string MuveletUjUgynokRogzitese = "";
		public const string MuveletSzemelyadatokLekerdezeseAzonositoAlapjan = "";
		public const string MuveletUgynokkeresesSzemelyazonositoAlapjan = "";
		public const string MuveletUgynokadatokLekerdezese = "";

		
		public const string ARGUMENTUMsMuvelet = "@sMuvelet";
		public const string ARGUMENTUMlAZ = "@lAZ";
		public const string ARGUMENTUMlSzemAZ = "@lSzemAZ";
		public const string ARGUMENTUMlParAZ = "@lParAZ";
		public const string ARGUMENTUMlUgyHoldAZ = "@lUgyHoldAZ";
		public const string ARGUMENTUMsKulsoAZ = "@sKulsoAZ";
		public const string ARGUMENTUMdKezdete = "@dKezdete";
		public const string ARGUMENTUMdVege = "@dVege";
		public const string ARGUMENTUMlCIBFiok = "@lCIBFiok";
		public const string ARGUMENTUMsMegjegyzes = "@sMegjegyzes";
		public const string ARGUMENTUMlLetszam = "@lLetszam";


		public static readonly string[] Muveletnev = { "Cib fióklista lekérdezése", "Ügynökholdingok lekérdezése", "Ügynökadatok módosítása", "Partner lekérdezése", "Új ügynök rögzítése", "Személyadatok lekérdezése azonosító alapján", "Ügynökkeresés személyazonosító alapján", "Ügynökadatok lekérdezése" };
	}
}
