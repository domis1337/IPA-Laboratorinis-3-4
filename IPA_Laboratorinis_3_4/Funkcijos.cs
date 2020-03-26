using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPA_Laboratorinis_3_4
{
    class Funkcijos
    {

        static List<Studentas> studentai = new List<Studentas>();
       

        public void Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Ivesti nauja studenta");
            Console.WriteLine("2. Ivesti is failo");
            Console.WriteLine("3. Spausdinti duomenis");
            Console.WriteLine("4. Baigti darba");
            Console.WriteLine("\nPasirinkimas:");
            string a = Console.ReadLine();

            switch (a)
            {
                case "1":
                    IvestiStudenta();
                    break;

                case "2":
                    IvestiIsFailo();
                    break;

                case "3":
                    DuomenuIsvedimas();
                    break;

                case "4":
                    break;

                default:
                    Menu();
                    break;
            }
        }


        void IvestiStudenta()
        {
            Strukturos.Stud stud;
            stud.nd_rez = new List<int>();

            string ats;

            Console.WriteLine("Enter students name: ");
            stud.vardas = Console.ReadLine();
            Console.WriteLine("Enter students last name: ");
            stud.pavarde = Console.ReadLine();

            Console.WriteLine("Enter 'r' if you want to generate students grades:");
            ats = Console.ReadLine();

            if (ats == "r")
            {
                Random rnd = new Random();
                stud.nd_rez.Add(rnd.Next(1, 11));
                stud.nd_rez.Add(rnd.Next(1, 11));
                stud.nd_rez.Add(rnd.Next(1, 11));
                stud.nd_rez.Add(rnd.Next(1, 11));
                stud.nd_rez.Add(rnd.Next(1, 11));
                stud.nd_rez.Add(rnd.Next(1, 11));
                stud.egz_rez = rnd.Next(1, 11);
            }
            else
            {
                for (int i = 0; i <= stud.nd_rez.Count; i++)
                {
                    Console.WriteLine("Enter a homework grade?(Y/N)");
                    ats = Console.ReadLine();
                    if (ats == "Y")
                    {
                        Console.WriteLine("Enter grade: ");
                        int.TryParse(Console.ReadLine(), out stud.egz_rez);
                        stud.nd_rez.Add(stud.egz_rez);
                    }
                    else if (ats == "N")
                    {
                        break;
                    }
                    else
                    {
                        i--;
                    }

                }


                Console.WriteLine("Enter students exam grade: ");
                int.TryParse(Console.ReadLine(), out stud.egz_rez);
            }

            studentai.Add(new Studentas(stud.vardas, stud.pavarde, stud.nd_rez, stud.egz_rez));

            Menu();


        }


        void IvestiIsFailo()
        {
            string filename;
            int count = -1;
            string line;

            Console.WriteLine("Iveskite pilna failo kelia");
            filename = Console.ReadLine();
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(filename))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        if (count == -1)
                        {
                            count++;
                        }
                        else
                        {
                            string[] ssplit = line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                            Strukturos.Stud stud;
                            stud.nd_rez = new List<int>();

                            stud.vardas = ssplit[0];
                            stud.pavarde = ssplit[1];
                            int.TryParse(ssplit[2], out stud.egz_rez);
                            stud.nd_rez.Add(stud.egz_rez);
                            int.TryParse(ssplit[3], out stud.egz_rez);
                            stud.nd_rez.Add(stud.egz_rez);
                            int.TryParse(ssplit[4], out stud.egz_rez);
                            stud.nd_rez.Add(stud.egz_rez);
                            int.TryParse(ssplit[5], out stud.egz_rez);
                            stud.nd_rez.Add(stud.egz_rez);
                            int.TryParse(ssplit[6], out stud.egz_rez);
                            stud.nd_rez.Add(stud.egz_rez);
                            int.TryParse(ssplit[7], out stud.egz_rez);
                            stud.nd_rez.Add(stud.egz_rez);
                            int.TryParse(ssplit[8], out stud.egz_rez);

                            studentai.Add(new Studentas(stud.vardas, stud.pavarde, stud.nd_rez, stud.egz_rez));

                            count++;
                        }
                    }
                    file.Close();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            Menu();
        }


        void DuomenuIsvedimas()
        {
            Console.WriteLine("Vardas".PadRight(15, ' ') + "Pavarde".PadRight(20, ' ') + "Galutinis (Vid)" + "Galutinis (Med)".PadLeft(20, ' '));
            Console.WriteLine("".PadRight(70, '-'));

            studentai.Sort(delegate (Studentas a, Studentas b)
            {
                int xdiff = a.vardas.CompareTo(b.vardas);
                if (xdiff != 0) return xdiff;
                else return a.pavarde.CompareTo(b.pavarde);
            });

            foreach (Studentas studentas in studentai)
            {
                Console.WriteLine(studentas.vardas.PadRight(15, ' ') + studentas.pavarde.PadRight(20, ' ') + (String.Format("{0:0.00}", studentas.galutinis_vid)).PadLeft(15, ' ') + (String.Format("{0:0.00}", studentas.galutinis_med)).PadLeft(20, ' '));
            }

            Console.WriteLine("\n\n");

            Menu();

        }       
    }



}

