using System;
using System.Collections.Generic;

namespace IPA_Laboratorinis_3_4
{
    class Program
    {

        static List<Studentas> studentai = new List<Studentas>();
        static int Main(string[] args)
        {

            


            Menu();

            return 0;
        } 


        static void Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Ivesti nauja studenta");
            Console.WriteLine("2. Spausdinti duomenis (vid)");
            Console.WriteLine("3. Spausdinti duomenis (med)");
            Console.WriteLine("4. Baigti darba");
            Console.WriteLine("\nPasirinkimas:");
            string a = Console.ReadLine();

            switch (a)
            {
                case "1":
                    IvestiStudenta();
                    break;

                case "2":
                    DuomenysVid();
                    break;

                case "3":
                    DuomenysMed();
                    break;

                case "4":
                    break;

                default:
                    Menu();
                    break;
            }
        }


        static void IvestiStudenta()
        {
            string vardas;
            string pavarde;
            int[] nd_rez = new int[1];
            int egz_rez;


            Console.WriteLine("Enter students name: ");
            vardas = Console.ReadLine();
            Console.WriteLine("Enter students last name: ");
            pavarde = Console.ReadLine();

            string ats;

            Console.WriteLine("Enter 'r' if you want to randomly generate students grades:");
            ats = Console.ReadLine();


            if (ats == "r")
            {
                Random rnd = new Random();
                Array.Resize(ref nd_rez, 6);
                nd_rez[0] = rnd.Next(1, 11);
                nd_rez[1] = rnd.Next(1, 11);
                nd_rez[2] = rnd.Next(1, 11);
                nd_rez[3] = rnd.Next(1, 11);
                nd_rez[4] = rnd.Next(1, 11);
                nd_rez[5] = rnd.Next(1, 11);
                egz_rez = rnd.Next(1, 11);
            }
            else
            {
                for (int i = 0; i <= nd_rez.Length; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("Enter a homework grade: ");
                        int.TryParse(Console.ReadLine(), out egz_rez);
                        Array.Resize(ref nd_rez, nd_rez.Length + 1);
                        nd_rez[0] = egz_rez;
                    }
                    else
                    {
                        Console.WriteLine("Enter another homework grade?(Y/N)");
                        ats = Console.ReadLine();
                        if (ats == "Y")
                        {
                            Console.WriteLine("Enter grade: ");
                            int.TryParse(Console.ReadLine(), out egz_rez);
                            Array.Resize(ref nd_rez, nd_rez.Length + 1);
                            nd_rez[0] = egz_rez;
                        }
                        else if (ats == "N")
                        {
                            Array.Resize(ref nd_rez, nd_rez.Length - 1);
                            break;
                        }
                        else
                        {
                            i--;
                        }
                    }

                }


                Console.WriteLine("Enter students exam grade: ");
                int.TryParse(Console.ReadLine(), out egz_rez);
            }

            


            studentai.Add(new Studentas(vardas, pavarde, nd_rez, egz_rez));

            Menu();

        }


        static void DuomenysVid()
        {
            Console.WriteLine("Vardas".PadRight(15, ' ') + "Pavarde".PadRight(20, ' ') + "Galutinis (Vid)");
            Console.WriteLine("".PadRight(50, '-'));

            foreach (Studentas studentas in studentai)
            {
                Console.WriteLine(studentas.vardas.PadRight(15, ' ') + studentas.pavarde.PadRight(20, ' ') + (String.Format("{0:0.00}", studentas.galutinis_vid)).PadLeft(15,' '));
            }

            Console.WriteLine("\n\n");

            Menu();
        }


        static void DuomenysMed()
        {
            Console.WriteLine("Vardas".PadRight(15, ' ') + "Pavarde".PadRight(20, ' ') + "Galutinis (Med)");
            Console.WriteLine("".PadRight(50, '-'));

            foreach (Studentas studentas in studentai)
            {
                Console.WriteLine(studentas.vardas.PadRight(15, ' ') + studentas.pavarde.PadRight(20, ' ') + (String.Format("{0:0.00}", studentas.galutinis_med)).PadLeft(15, ' '));
            }

            Console.WriteLine("\n\n");

            Menu();
        }

    }
}