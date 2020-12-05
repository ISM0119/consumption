using System;
using System.Security.Cryptography.X509Certificates;

namespace Uzemanyag_Szamolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                                   Üzemanyag számláló                  Dátum: {0}",DateTime.Now);




            Console.WriteLine();





            try
            {
                double uzemanyagAr_Benzin = 364;
                double uzemanyagAr_Dizel = 382;
                double tavlosagKM;

                Console.WriteLine("Milyen üzemanyagot fogyaszt a járműved?   (1)--> Benzin   (2)--> Dízel");
                int valasz = int.Parse(Console.ReadLine());
                switch (valasz)
                {
                    case 1:
                        Console.Write("Benzin ára: {0} Ft", uzemanyagAr_Benzin);
                        break;

                    case 2:
                        Console.Write("Dízel ára: {0} Ft", uzemanyagAr_Dizel);
                        break;

                    default:
                        break;
                }

                
                //fogyasztás
                
                double fogyasztas;
                /*
                Console.Write("\nMennyi az autó fogyasztása?");
                fogyasztas = double.Parse(Console.R eadLine());
                */


                //üzemanyagtank legyen most 50 liter maximum
                Console.WriteLine();
                Console.Write("\nHány literes a tank?: ");
                double tank = double.Parse(Console.ReadLine());
                //maxra tankolás esetén mennyit kell költeni
                Console.WriteLine("\nSzeretné kiszámolni a tele tank költségét?   (1) --> Igen   (2) --> Nem");
                int valasz2 = int.Parse(Console.ReadLine());
                switch (valasz2)
                {
                    case 1:
                        switch (valasz)
                        {
                            case 1:
                                Console.WriteLine("Ennyi lenne a tank teletöltésének a költsége HA nincs benne üzemanyag (Benzin): {0} Ft", uzemanyagAr_Benzin * tank);
                                break;
                            case 2:
                                Console.WriteLine("Ennyi lenne a tank teletöltésének a költsége HA nincs benne üzemanyag (Dízel): {0} Ft", uzemanyagAr_Dizel * tank);
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Rendben");
                        break;
                    default:
                        break;
                }
                

                //Ha már van benne valamennyi üzemanyag annak a tele töltésének a költsége


                Console.WriteLine();
                Console.Write("\nMennyi üzemanyag van az autóban? (Liter): ");
                double tank2 = double.Parse(Console.ReadLine());
                Console.WriteLine("\nSzeretné kiszámolni a tele tank költségét?   (1) --> Igen   (2) --> Nem");
                int valasz3 = int.Parse(Console.ReadLine());
                switch (valasz3)
                {
                    case 1:
                        switch (valasz)
                        {
                            case 1:
                                Console.WriteLine("Tele tank költsége (Benzin): {0} Ft", uzemanyagAr_Benzin * (tank - tank2));
                                break;
                            case 2:
                                Console.WriteLine("Tele tank költsége (Dízel): {0} Ft", uzemanyagAr_Dizel * (tank - tank2));
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Rendben");
                        break;
                    default:
                        break;
                }
               
                

                



                //útra való üzemanyag kiszámítása fogyasztás nélkül egyenlőre
                //Figyelembe kell venni, hogy mennyi üzemanyagunk van a tankban!! Fogyasztás!!!
                Console.WriteLine("\nSzeretne utazni?   (1) --> Igen   (2) --> Nem");
                int utazas = int.Parse(Console.ReadLine());
                switch (utazas)
                {
                    case 1:
                        //fogyasztás, számoljunk 7 literrel
                        Console.Write("\nMennyi a fogyasztása az autónak 100 kilóméteren?: ");
                        fogyasztas = double.Parse(Console.ReadLine());

                        Console.Write("\nMilyen távol szeretne utazni? (Kilóméter): ");
                        tavlosagKM = double.Parse(Console.ReadLine());

                        Console.WriteLine("\nAz üzemanyag állása az út után: {0} liter", tank2 - (fogyasztas * (tavlosagKM / 100)));
                        switch (valasz)
                        {
                            case 1:
                                Console.WriteLine("\nAz út költsége (Benzin): {0} Ft", uzemanyagAr_Benzin * (fogyasztas * (tavlosagKM / 100)));
                                break;
                            case 2:
                                Console.WriteLine("Az út költsége (Dízel): {0} Ft", uzemanyagAr_Dizel * (fogyasztas * (tavlosagKM / 100)));
                                break;
                            default:
                                break;
                        }

                        //költség oda-vissza
                        Console.WriteLine("\nSzeretné a teljes uti költséget kiszámítani (oda-vissza) ?   (1) --> Igen   (2) --> Nem");
                        int valasz4 = int.Parse(Console.ReadLine());
                        switch (valasz4)
                        {
                            case 1:

                                switch (valasz)
                                {
                                    case 1:
                                        Console.WriteLine("\nAz út költsége oda-vissza (Benzin): {0} Ft", (uzemanyagAr_Benzin * (fogyasztas * (tavlosagKM / 100))) * 2);
                                        break;
                                    case 2:
                                        Console.WriteLine("Az út költsége oda-vissza (Dízel): {0} Ft", (uzemanyagAr_Dizel * (fogyasztas * (tavlosagKM / 100))) * 2);
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 2:
                                Console.WriteLine("Rendben");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Rendben");
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Készült: {0}", DateTime.Today.Date);
                //2020.12.05
                Console.ReadKey();
            }
            catch (Exception error)
            {

                Console.WriteLine("Hiba: {0}", error.Message); ;
            }
            
        }
    }
}
