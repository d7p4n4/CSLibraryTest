using TaroltEljarasKonstans2;
using Naplo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Szolgaltatas;

namespace TaroltEljaras
{
    public class Ugy_Kezeles
    {
        
        public SqlConnection AdatbazisKapcsolat { get; set; }

        public Ugy_Kezeles(){}

        public Ugy_Kezeles(SqlConnection adatbazisKapcsolat)
        {
            AdatbazisKapcsolat = adatbazisKapcsolat;
        }
			

        public EljarasHalmazEredmeny CibFioklistaLekerdezese(
                    Boritek boritek

            )
        {

            EljarasHalmazEredmeny eredmeny = new EljarasHalmazEredmeny();

            NaplozasEsemenyBoritek naplozasEsemenyBoritek = new NaplozasEsemenyBoritek()
            {
                Eljaras = MethodBase.GetCurrentMethod().Name,
                Felhasznalo = boritek.Naplozas.Felhasznalo
            };

            try
            {

                NaplozasReszletek naplozasReszletek = new NaplozasReszletek();



                boritek.Naplozas.Bejegyzes(
                    naploSzint: Naplozas.NaploSzint.Nyomkovetes
                        , esemeny: Naplozas.ESEMENY_ELEJE
                        , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                        {
                            new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                            ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_RESZLET, naplozasReszletek)
                        }
                    );

                using (SqlCommand command = new SqlCommand(Ugy_KezelesKonstans.TaroltEljaras, AdatbazisKapcsolat))
                {

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMsMuvelet, SqlDbType.VarChar).Value = Ugy_KezelesKonstans.MuveletCibFioklistaLekerdezese;


                    command.ExecuteNonQuery();
				}
			}
            catch (Exception _exception)
            {

                eredmeny.EljarasVegrehajtasEredmeny.HibasVegrehajtas(_exception.Message, _exception.StackTrace);

                boritek.Naplozas.Bejegyzes(
                        naploSzint: Naplozas.NaploSzint.Hiba
                        , esemeny: Naplozas.ESEMENY_HIBA
                        , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                        {
                            new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                            ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_EREDMENY, eredmeny)
                        }
                    );

            } // catch

            boritek.Naplozas.Bejegyzes(
                    naploSzint: Naplozas.NaploSzint.Nyomkovetes
                    , esemeny: Naplozas.ESEMENY_VEGE
                    , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                    {
                        new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                        ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_EREDMENY, eredmeny)
                    }
                );

            return eredmeny;

        } // UgynokadatokLekerdezese

        public EljarasHalmazEredmeny UgynokholdingokLekerdezese(
                    Boritek boritek

            )
        {

            EljarasHalmazEredmeny eredmeny = new EljarasHalmazEredmeny();

            NaplozasEsemenyBoritek naplozasEsemenyBoritek = new NaplozasEsemenyBoritek()
            {
                Eljaras = MethodBase.GetCurrentMethod().Name,
                Felhasznalo = boritek.Naplozas.Felhasznalo
            };

            try
            {

                NaplozasReszletek naplozasReszletek = new NaplozasReszletek();



                boritek.Naplozas.Bejegyzes(
                    naploSzint: Naplozas.NaploSzint.Nyomkovetes
                        , esemeny: Naplozas.ESEMENY_ELEJE
                        , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                        {
                            new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                            ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_RESZLET, naplozasReszletek)
                        }
                    );

                using (SqlCommand command = new SqlCommand(Ugy_KezelesKonstans.TaroltEljaras, AdatbazisKapcsolat))
                {

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMsMuvelet, SqlDbType.VarChar).Value = Ugy_KezelesKonstans.MuveletUgynokholdingokLekerdezese;


                    command.ExecuteNonQuery();
				}
			}
            catch (Exception _exception)
            {

                eredmeny.EljarasVegrehajtasEredmeny.HibasVegrehajtas(_exception.Message, _exception.StackTrace);

                boritek.Naplozas.Bejegyzes(
                        naploSzint: Naplozas.NaploSzint.Hiba
                        , esemeny: Naplozas.ESEMENY_HIBA
                        , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                        {
                            new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                            ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_EREDMENY, eredmeny)
                        }
                    );

            } // catch

            boritek.Naplozas.Bejegyzes(
                    naploSzint: Naplozas.NaploSzint.Nyomkovetes
                    , esemeny: Naplozas.ESEMENY_VEGE
                    , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                    {
                        new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                        ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_EREDMENY, eredmeny)
                    }
                );

            return eredmeny;

        } // UgynokadatokLekerdezese

        public EljarasHalmazEredmeny UgynokadatokModositasa(
                    Boritek boritek
                    , int lAZ
                    , int lSzemAZ
                    , int lParAZ
                    , int lUgyHoldAZ
                    , string sKulsoAZ
                    , DateTime? dKezdete
                    , DateTime? dVege
                    , int lCIBFiok
                    , string sMegjegyzes
                    , int lLetszam

            )
        {

            EljarasHalmazEredmeny eredmeny = new EljarasHalmazEredmeny();

            NaplozasEsemenyBoritek naplozasEsemenyBoritek = new NaplozasEsemenyBoritek()
            {
                Eljaras = MethodBase.GetCurrentMethod().Name,
                Felhasznalo = boritek.Naplozas.Felhasznalo
            };

            try
            {

                NaplozasReszletek naplozasReszletek = new NaplozasReszletek();

                naplozasReszletek.UjElemHaVanErtek("lAZ", lAZ);
                naplozasReszletek.UjElemHaVanErtek("lSzemAZ", lSzemAZ);
                naplozasReszletek.UjElemHaVanErtek("lParAZ", lParAZ);
                naplozasReszletek.UjElemHaVanErtek("lUgyHoldAZ", lUgyHoldAZ);
                naplozasReszletek.UjElemHaVanErtek("sKulsoAZ", sKulsoAZ);
                naplozasReszletek.UjElemHaVanErtek("dKezdete", dKezdete);
                naplozasReszletek.UjElemHaVanErtek("dVege", dVege);
                naplozasReszletek.UjElemHaVanErtek("lCIBFiok", lCIBFiok);
                naplozasReszletek.UjElemHaVanErtek("sMegjegyzes", sMegjegyzes);
                naplozasReszletek.UjElemHaVanErtek("lLetszam", lLetszam);


                boritek.Naplozas.Bejegyzes(
                    naploSzint: Naplozas.NaploSzint.Nyomkovetes
                        , esemeny: Naplozas.ESEMENY_ELEJE
                        , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                        {
                            new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                            ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_RESZLET, naplozasReszletek)
                        }
                    );

                using (SqlCommand command = new SqlCommand(Ugy_KezelesKonstans.TaroltEljaras, AdatbazisKapcsolat))
                {

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMsMuvelet, SqlDbType.VarChar).Value = Ugy_KezelesKonstans.MuveletUgynokadatokModositasa;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMlAZ, SqlDbType.Int).Value = lAZ;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMlSzemAZ, SqlDbType.Int).Value = lSzemAZ;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMlParAZ, SqlDbType.Int).Value = lParAZ;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMlUgyHoldAZ, SqlDbType.Int).Value = lUgyHoldAZ;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMsKulsoAZ, SqlDbType.VarChar).Value = sKulsoAZ;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMdKezdete, SqlDbType.SmallDateTime).Value = dKezdete;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMdVege, SqlDbType.SmallDateTime).Value = dVege;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMlCIBFiok, SqlDbType.Int).Value = lCIBFiok;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMsMegjegyzes, SqlDbType.VarChar).Value = sMegjegyzes;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMlLetszam, SqlDbType.Int).Value = lLetszam;


                    command.ExecuteNonQuery();
				}
			}
            catch (Exception _exception)
            {

                eredmeny.EljarasVegrehajtasEredmeny.HibasVegrehajtas(_exception.Message, _exception.StackTrace);

                boritek.Naplozas.Bejegyzes(
                        naploSzint: Naplozas.NaploSzint.Hiba
                        , esemeny: Naplozas.ESEMENY_HIBA
                        , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                        {
                            new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                            ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_EREDMENY, eredmeny)
                        }
                    );

            } // catch

            boritek.Naplozas.Bejegyzes(
                    naploSzint: Naplozas.NaploSzint.Nyomkovetes
                    , esemeny: Naplozas.ESEMENY_VEGE
                    , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                    {
                        new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                        ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_EREDMENY, eredmeny)
                    }
                );

            return eredmeny;

        } // UgynokadatokLekerdezese

        public EljarasHalmazEredmeny PartnerLekerdezese(
                    Boritek boritek
                    , int lAZ

            )
        {

            EljarasHalmazEredmeny eredmeny = new EljarasHalmazEredmeny();

            NaplozasEsemenyBoritek naplozasEsemenyBoritek = new NaplozasEsemenyBoritek()
            {
                Eljaras = MethodBase.GetCurrentMethod().Name,
                Felhasznalo = boritek.Naplozas.Felhasznalo
            };

            try
            {

                NaplozasReszletek naplozasReszletek = new NaplozasReszletek();

                naplozasReszletek.UjElemHaVanErtek("lAZ", lAZ);


                boritek.Naplozas.Bejegyzes(
                    naploSzint: Naplozas.NaploSzint.Nyomkovetes
                        , esemeny: Naplozas.ESEMENY_ELEJE
                        , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                        {
                            new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                            ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_RESZLET, naplozasReszletek)
                        }
                    );

                using (SqlCommand command = new SqlCommand(Ugy_KezelesKonstans.TaroltEljaras, AdatbazisKapcsolat))
                {

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMsMuvelet, SqlDbType.VarChar).Value = Ugy_KezelesKonstans.MuveletPartnerLekerdezese;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMlAZ, SqlDbType.Int).Value = lAZ;


                    command.ExecuteNonQuery();
				}
			}
            catch (Exception _exception)
            {

                eredmeny.EljarasVegrehajtasEredmeny.HibasVegrehajtas(_exception.Message, _exception.StackTrace);

                boritek.Naplozas.Bejegyzes(
                        naploSzint: Naplozas.NaploSzint.Hiba
                        , esemeny: Naplozas.ESEMENY_HIBA
                        , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                        {
                            new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                            ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_EREDMENY, eredmeny)
                        }
                    );

            } // catch

            boritek.Naplozas.Bejegyzes(
                    naploSzint: Naplozas.NaploSzint.Nyomkovetes
                    , esemeny: Naplozas.ESEMENY_VEGE
                    , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                    {
                        new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                        ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_EREDMENY, eredmeny)
                    }
                );

            return eredmeny;

        } // UgynokadatokLekerdezese

        public EljarasHalmazEredmeny UjUgynokRogzitese(
                    Boritek boritek
                    , int lSzemAZ
                    , int lParAZ
                    , int lUgyHoldAZ
                    , string sKulsoAZ
                    , DateTime? dKezdete
                    , DateTime? dVege
                    , int lCIBFiok
                    , string sMegjegyzes
                    , int lLetszam

            )
        {

            EljarasHalmazEredmeny eredmeny = new EljarasHalmazEredmeny();

            NaplozasEsemenyBoritek naplozasEsemenyBoritek = new NaplozasEsemenyBoritek()
            {
                Eljaras = MethodBase.GetCurrentMethod().Name,
                Felhasznalo = boritek.Naplozas.Felhasznalo
            };

            try
            {

                NaplozasReszletek naplozasReszletek = new NaplozasReszletek();

                naplozasReszletek.UjElemHaVanErtek("lSzemAZ", lSzemAZ);
                naplozasReszletek.UjElemHaVanErtek("lParAZ", lParAZ);
                naplozasReszletek.UjElemHaVanErtek("lUgyHoldAZ", lUgyHoldAZ);
                naplozasReszletek.UjElemHaVanErtek("sKulsoAZ", sKulsoAZ);
                naplozasReszletek.UjElemHaVanErtek("dKezdete", dKezdete);
                naplozasReszletek.UjElemHaVanErtek("dVege", dVege);
                naplozasReszletek.UjElemHaVanErtek("lCIBFiok", lCIBFiok);
                naplozasReszletek.UjElemHaVanErtek("sMegjegyzes", sMegjegyzes);
                naplozasReszletek.UjElemHaVanErtek("lLetszam", lLetszam);


                boritek.Naplozas.Bejegyzes(
                    naploSzint: Naplozas.NaploSzint.Nyomkovetes
                        , esemeny: Naplozas.ESEMENY_ELEJE
                        , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                        {
                            new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                            ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_RESZLET, naplozasReszletek)
                        }
                    );

                using (SqlCommand command = new SqlCommand(Ugy_KezelesKonstans.TaroltEljaras, AdatbazisKapcsolat))
                {

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMsMuvelet, SqlDbType.VarChar).Value = Ugy_KezelesKonstans.MuveletUjUgynokRogzitese;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMlSzemAZ, SqlDbType.Int).Value = lSzemAZ;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMlParAZ, SqlDbType.Int).Value = lParAZ;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMlUgyHoldAZ, SqlDbType.Int).Value = lUgyHoldAZ;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMsKulsoAZ, SqlDbType.VarChar).Value = sKulsoAZ;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMdKezdete, SqlDbType.SmallDateTime).Value = dKezdete;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMdVege, SqlDbType.SmallDateTime).Value = dVege;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMlCIBFiok, SqlDbType.Int).Value = lCIBFiok;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMsMegjegyzes, SqlDbType.VarChar).Value = sMegjegyzes;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMlLetszam, SqlDbType.Int).Value = lLetszam;


                    command.ExecuteNonQuery();
				}
			}
            catch (Exception _exception)
            {

                eredmeny.EljarasVegrehajtasEredmeny.HibasVegrehajtas(_exception.Message, _exception.StackTrace);

                boritek.Naplozas.Bejegyzes(
                        naploSzint: Naplozas.NaploSzint.Hiba
                        , esemeny: Naplozas.ESEMENY_HIBA
                        , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                        {
                            new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                            ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_EREDMENY, eredmeny)
                        }
                    );

            } // catch

            boritek.Naplozas.Bejegyzes(
                    naploSzint: Naplozas.NaploSzint.Nyomkovetes
                    , esemeny: Naplozas.ESEMENY_VEGE
                    , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                    {
                        new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                        ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_EREDMENY, eredmeny)
                    }
                );

            return eredmeny;

        } // UgynokadatokLekerdezese

        public EljarasHalmazEredmeny SzemelyadatokLekerdezeseAzonositoAlapjan(
                    Boritek boritek

            )
        {

            EljarasHalmazEredmeny eredmeny = new EljarasHalmazEredmeny();

            NaplozasEsemenyBoritek naplozasEsemenyBoritek = new NaplozasEsemenyBoritek()
            {
                Eljaras = MethodBase.GetCurrentMethod().Name,
                Felhasznalo = boritek.Naplozas.Felhasznalo
            };

            try
            {

                NaplozasReszletek naplozasReszletek = new NaplozasReszletek();



                boritek.Naplozas.Bejegyzes(
                    naploSzint: Naplozas.NaploSzint.Nyomkovetes
                        , esemeny: Naplozas.ESEMENY_ELEJE
                        , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                        {
                            new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                            ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_RESZLET, naplozasReszletek)
                        }
                    );

                using (SqlCommand command = new SqlCommand(Ugy_KezelesKonstans.TaroltEljaras, AdatbazisKapcsolat))
                {

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMsMuvelet, SqlDbType.VarChar).Value = Ugy_KezelesKonstans.MuveletSzemelyadatokLekerdezeseAzonositoAlapjan;


                    command.ExecuteNonQuery();
				}
			}
            catch (Exception _exception)
            {

                eredmeny.EljarasVegrehajtasEredmeny.HibasVegrehajtas(_exception.Message, _exception.StackTrace);

                boritek.Naplozas.Bejegyzes(
                        naploSzint: Naplozas.NaploSzint.Hiba
                        , esemeny: Naplozas.ESEMENY_HIBA
                        , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                        {
                            new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                            ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_EREDMENY, eredmeny)
                        }
                    );

            } // catch

            boritek.Naplozas.Bejegyzes(
                    naploSzint: Naplozas.NaploSzint.Nyomkovetes
                    , esemeny: Naplozas.ESEMENY_VEGE
                    , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                    {
                        new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                        ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_EREDMENY, eredmeny)
                    }
                );

            return eredmeny;

        } // UgynokadatokLekerdezese

        public EljarasHalmazEredmeny UgynokkeresesSzemelyazonositoAlapjan(
                    Boritek boritek
                    , int lAZ

            )
        {

            EljarasHalmazEredmeny eredmeny = new EljarasHalmazEredmeny();

            NaplozasEsemenyBoritek naplozasEsemenyBoritek = new NaplozasEsemenyBoritek()
            {
                Eljaras = MethodBase.GetCurrentMethod().Name,
                Felhasznalo = boritek.Naplozas.Felhasznalo
            };

            try
            {

                NaplozasReszletek naplozasReszletek = new NaplozasReszletek();

                naplozasReszletek.UjElemHaVanErtek("lAZ", lAZ);


                boritek.Naplozas.Bejegyzes(
                    naploSzint: Naplozas.NaploSzint.Nyomkovetes
                        , esemeny: Naplozas.ESEMENY_ELEJE
                        , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                        {
                            new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                            ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_RESZLET, naplozasReszletek)
                        }
                    );

                using (SqlCommand command = new SqlCommand(Ugy_KezelesKonstans.TaroltEljaras, AdatbazisKapcsolat))
                {

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMsMuvelet, SqlDbType.VarChar).Value = Ugy_KezelesKonstans.MuveletUgynokkeresesSzemelyazonositoAlapjan;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMlAZ, SqlDbType.Int).Value = lAZ;


                    command.ExecuteNonQuery();
				}
			}
            catch (Exception _exception)
            {

                eredmeny.EljarasVegrehajtasEredmeny.HibasVegrehajtas(_exception.Message, _exception.StackTrace);

                boritek.Naplozas.Bejegyzes(
                        naploSzint: Naplozas.NaploSzint.Hiba
                        , esemeny: Naplozas.ESEMENY_HIBA
                        , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                        {
                            new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                            ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_EREDMENY, eredmeny)
                        }
                    );

            } // catch

            boritek.Naplozas.Bejegyzes(
                    naploSzint: Naplozas.NaploSzint.Nyomkovetes
                    , esemeny: Naplozas.ESEMENY_VEGE
                    , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                    {
                        new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                        ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_EREDMENY, eredmeny)
                    }
                );

            return eredmeny;

        } // UgynokadatokLekerdezese

        public EljarasHalmazEredmeny UgynokadatokLekerdezese(
                    Boritek boritek
                    , int lAZ
                    , int lSzemAZ
                    , int lParAZ

            )
        {

            EljarasHalmazEredmeny eredmeny = new EljarasHalmazEredmeny();

            NaplozasEsemenyBoritek naplozasEsemenyBoritek = new NaplozasEsemenyBoritek()
            {
                Eljaras = MethodBase.GetCurrentMethod().Name,
                Felhasznalo = boritek.Naplozas.Felhasznalo
            };

            try
            {

                NaplozasReszletek naplozasReszletek = new NaplozasReszletek();

                naplozasReszletek.UjElemHaVanErtek("lAZ", lAZ);
                naplozasReszletek.UjElemHaVanErtek("lSzemAZ", lSzemAZ);
                naplozasReszletek.UjElemHaVanErtek("lParAZ", lParAZ);


                boritek.Naplozas.Bejegyzes(
                    naploSzint: Naplozas.NaploSzint.Nyomkovetes
                        , esemeny: Naplozas.ESEMENY_ELEJE
                        , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                        {
                            new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                            ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_RESZLET, naplozasReszletek)
                        }
                    );

                using (SqlCommand command = new SqlCommand(Ugy_KezelesKonstans.TaroltEljaras, AdatbazisKapcsolat))
                {

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMsMuvelet, SqlDbType.VarChar).Value = Ugy_KezelesKonstans.MuveletUgynokadatokLekerdezese;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMlAZ, SqlDbType.Int).Value = lAZ;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMlSzemAZ, SqlDbType.Int).Value = lSzemAZ;
                    command.Parameters.Add(Ugy_KezelesKonstans.ARGUMENTUMlParAZ, SqlDbType.Int).Value = lParAZ;


                    command.ExecuteNonQuery();
				}
			}
            catch (Exception _exception)
            {

                eredmeny.EljarasVegrehajtasEredmeny.HibasVegrehajtas(_exception.Message, _exception.StackTrace);

                boritek.Naplozas.Bejegyzes(
                        naploSzint: Naplozas.NaploSzint.Hiba
                        , esemeny: Naplozas.ESEMENY_HIBA
                        , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                        {
                            new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                            ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_EREDMENY, eredmeny)
                        }
                    );

            } // catch

            boritek.Naplozas.Bejegyzes(
                    naploSzint: Naplozas.NaploSzint.Nyomkovetes
                    , esemeny: Naplozas.ESEMENY_VEGE
                    , naplozottInformacioLista: new List<KeyValuePair<string, object>>()
                    {
                        new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_BORITEK, naplozasEsemenyBoritek)
                        ,new NaplozottInformacio().UjElem(Naplozas.NAPLOELEM_EREDMENY, eredmeny)
                    }
                );

            return eredmeny;

        } // UgynokadatokLekerdezese
}
}