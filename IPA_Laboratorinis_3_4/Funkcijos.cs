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
            Console.WriteLine("4. Isvesti surusiuotus studentus i du atskirus failus");
            //Console.WriteLine("5. Sugeneruoti penkis studentu failus");
            //Console.WriteLine("6. Sugeneruoti penkis studentu failus ir juos surusiuoti i vargsiukus ir kietiakus, bei parodyti laika (Istrins dabartiniu programos issaugotus studentus)");
            Console.WriteLine("99. Baigti darba");
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
                    DuomenuRusiavimasIFailus();
                    break;

                /*case "5":
                    StudentuGeneravimas();
                    break;*/

                /*case "6":
                    StudentuGeneravimasNuskaitymasRusiavimasLaikas();
                    break;*/

                case "99":
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


        void DuomenuRusiavimasIFailus()
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Vargsiukai.txt")))
            {
                foreach (Studentas stud in studentai)
                {
                    if (stud.galutinis_vid < 5)
                    {
                        outputFile.WriteLine(stud.vardas.PadRight(15, ' ') + stud.pavarde.PadRight(20, ' ') + (String.Format("{0:0.00}", stud.nd_rez[0])).PadLeft(7, ' ') + (String.Format("{0:0.00}", stud.nd_rez[1])).PadLeft(7, ' ') + (String.Format("{0:0.00}", stud.nd_rez[2])).PadLeft(7, ' ') + (String.Format("{0:0.00}", stud.nd_rez[3])).PadLeft(7, ' ') + (String.Format("{0:0.00}", stud.nd_rez[4])).PadLeft(7, ' ') + (String.Format("{0:0.00}", stud.nd_rez[5])).PadLeft(7, ' ') + (String.Format("{0:0.00}", stud.egz_rez)).PadLeft(7, ' '));
                    }
                }
            }
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Kietiakai.txt")))
            {
                foreach (Studentas stud in studentai)
                {
                    if (stud.galutinis_vid > 5)
                    {
                        outputFile.WriteLine(stud.vardas.PadRight(15, ' ') + stud.pavarde.PadRight(20, ' ') + (String.Format("{0:0.00}", stud.nd_rez[0])).PadLeft(7, ' ') + (String.Format("{0:0.00}", stud.nd_rez[1])).PadLeft(7, ' ') + (String.Format("{0:0.00}", stud.nd_rez[2])).PadLeft(7, ' ') + (String.Format("{0:0.00}", stud.nd_rez[3])).PadLeft(7, ' ') + (String.Format("{0:0.00}", stud.nd_rez[4])).PadLeft(7, ' ') + (String.Format("{0:0.00}", stud.nd_rez[5])).PadLeft(7, ' ') + (String.Format("{0:0.00}", stud.egz_rez)).PadLeft(7, ' '));
                    }
                }
            }

            watch.Stop();
            var elapsedMsRusiavimas = watch.ElapsedMilliseconds;
            Console.WriteLine($"Time to complete student sorting:  {elapsedMsRusiavimas}");
            Menu();

        }


        void StudentuGeneravimas()
        {
            Strukturos.Stud stud;
            stud.nd_rez = new List<int>();
            Random rnd = new Random();
 
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "10.txt")))
            {
                for (int i = 1; i<=10;i++)
                {
                    stud.nd_rez.Clear();
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.egz_rez = rnd.Next(1, 11);

                    if (i != 10)
                    {
                        outputFile.WriteLine($"Vardas{i}".PadRight(15, ' ') + $"Pavarde{i}".PadRight(20, ' ') + $"{stud.nd_rez[0]}".PadLeft(7, ' ') + $"{stud.nd_rez[1]}".PadLeft(7, ' ') + $"{stud.nd_rez[2]}".PadLeft(7, ' ') + $"{stud.nd_rez[3]}".PadLeft(7, ' ') + $"{stud.nd_rez[4]}".PadLeft(7, ' ') + $"{stud.nd_rez[5]}".PadLeft(7, ' ') + $"{stud.egz_rez}".PadLeft(7, ' '));
                    }
                    else
                    {
                        outputFile.Write($"Vardas{i}".PadRight(15, ' ') + $"Pavarde{i}".PadRight(20, ' ') + $"{stud.nd_rez[0]}".PadLeft(7, ' ') + $"{stud.nd_rez[1]}".PadLeft(7, ' ') + $"{stud.nd_rez[2]}".PadLeft(7, ' ') + $"{stud.nd_rez[3]}".PadLeft(7, ' ') + $"{stud.nd_rez[4]}".PadLeft(7, ' ') + $"{stud.nd_rez[5]}".PadLeft(7, ' ') + $"{stud.egz_rez}".PadLeft(7, ' '));
                    }
                }
            }
            watch.Stop();
            var elapsedMs10 = watch.ElapsedMilliseconds;
            watch.Restart();
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "100.txt")))
            {
                for (int i = 1; i <= 100; i++)
                {
                    stud.nd_rez.Clear();
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.egz_rez = rnd.Next(1, 11);


                    if (i != 100)
                    {
                        outputFile.WriteLine($"Vardas{i}".PadRight(15, ' ') + $"Pavarde{i}".PadRight(20, ' ') + $"{stud.nd_rez[0]}".PadLeft(7, ' ') + $"{stud.nd_rez[1]}".PadLeft(7, ' ') + $"{stud.nd_rez[2]}".PadLeft(7, ' ') + $"{stud.nd_rez[3]}".PadLeft(7, ' ') + $"{stud.nd_rez[4]}".PadLeft(7, ' ') + $"{stud.nd_rez[5]}".PadLeft(7, ' ') + $"{stud.egz_rez}".PadLeft(7, ' '));
                    }
                    else
                    {
                        outputFile.Write($"Vardas{i}".PadRight(15, ' ') + $"Pavarde{i}".PadRight(20, ' ') + $"{stud.nd_rez[0]}".PadLeft(7, ' ') + $"{stud.nd_rez[1]}".PadLeft(7, ' ') + $"{stud.nd_rez[2]}".PadLeft(7, ' ') + $"{stud.nd_rez[3]}".PadLeft(7, ' ') + $"{stud.nd_rez[4]}".PadLeft(7, ' ') + $"{stud.nd_rez[5]}".PadLeft(7, ' ') + $"{stud.egz_rez}".PadLeft(7, ' '));
                    }
                }
            }
            watch.Stop();
            var elapsedMs100 = watch.ElapsedMilliseconds;
            watch.Restart();
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "1000.txt")))
            {
                for (int i = 1; i <= 1000; i++)
                {
                    stud.nd_rez.Clear();
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.egz_rez = rnd.Next(1, 11);


                    if (i != 1000)
                    {
                        outputFile.WriteLine($"Vardas{i}".PadRight(15, ' ') + $"Pavarde{i}".PadRight(20, ' ') + $"{stud.nd_rez[0]}".PadLeft(7, ' ') + $"{stud.nd_rez[1]}".PadLeft(7, ' ') + $"{stud.nd_rez[2]}".PadLeft(7, ' ') + $"{stud.nd_rez[3]}".PadLeft(7, ' ') + $"{stud.nd_rez[4]}".PadLeft(7, ' ') + $"{stud.nd_rez[5]}".PadLeft(7, ' ') + $"{stud.egz_rez}".PadLeft(7, ' '));
                    }
                    else
                    {
                        outputFile.Write($"Vardas{i}".PadRight(15, ' ') + $"Pavarde{i}".PadRight(20, ' ') + $"{stud.nd_rez[0]}".PadLeft(7, ' ') + $"{stud.nd_rez[1]}".PadLeft(7, ' ') + $"{stud.nd_rez[2]}".PadLeft(7, ' ') + $"{stud.nd_rez[3]}".PadLeft(7, ' ') + $"{stud.nd_rez[4]}".PadLeft(7, ' ') + $"{stud.nd_rez[5]}".PadLeft(7, ' ') + $"{stud.egz_rez}".PadLeft(7, ' '));
                    }
                }
            }
            watch.Stop();
            var elapsedMs1000 = watch.ElapsedMilliseconds;
            watch.Restart();
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "10000.txt")))
            {
                for (int i = 1; i <= 10000; i++)
                {
                    stud.nd_rez.Clear();
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.egz_rez = rnd.Next(1, 11);


                    if (i != 10000)
                    {
                        outputFile.WriteLine($"Vardas{i}".PadRight(15, ' ') + $"Pavarde{i}".PadRight(20, ' ') + $"{stud.nd_rez[0]}".PadLeft(7, ' ') + $"{stud.nd_rez[1]}".PadLeft(7, ' ') + $"{stud.nd_rez[2]}".PadLeft(7, ' ') + $"{stud.nd_rez[3]}".PadLeft(7, ' ') + $"{stud.nd_rez[4]}".PadLeft(7, ' ') + $"{stud.nd_rez[5]}".PadLeft(7, ' ') + $"{stud.egz_rez}".PadLeft(7, ' '));
                    }
                    else
                    {
                        outputFile.Write($"Vardas{i}".PadRight(15, ' ') + $"Pavarde{i}".PadRight(20, ' ') + $"{stud.nd_rez[0]}".PadLeft(7, ' ') + $"{stud.nd_rez[1]}".PadLeft(7, ' ') + $"{stud.nd_rez[2]}".PadLeft(7, ' ') + $"{stud.nd_rez[3]}".PadLeft(7, ' ') + $"{stud.nd_rez[4]}".PadLeft(7, ' ') + $"{stud.nd_rez[5]}".PadLeft(7, ' ') + $"{stud.egz_rez}".PadLeft(7, ' '));
                    }
                }
            }
            watch.Stop();
            var elapsedMs10000 = watch.ElapsedMilliseconds;
            watch.Restart();
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "100000.txt")))
            {
                for (int i = 1; i <= 100000; i++)
                {
                    stud.nd_rez.Clear();
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.egz_rez = rnd.Next(1, 11);


                    if (i != 100000)
                    {
                        outputFile.WriteLine($"Vardas{i}".PadRight(15, ' ') + $"Pavarde{i}".PadRight(20, ' ') + $"{stud.nd_rez[0]}".PadLeft(7, ' ') + $"{stud.nd_rez[1]}".PadLeft(7, ' ') + $"{stud.nd_rez[2]}".PadLeft(7, ' ') + $"{stud.nd_rez[3]}".PadLeft(7, ' ') + $"{stud.nd_rez[4]}".PadLeft(7, ' ') + $"{stud.nd_rez[5]}".PadLeft(7, ' ') + $"{stud.egz_rez}".PadLeft(7, ' '));
                    }
                    else
                    {
                        outputFile.Write($"Vardas{i}".PadRight(15, ' ') + $"Pavarde{i}".PadRight(20, ' ') + $"{stud.nd_rez[0]}".PadLeft(7, ' ') + $"{stud.nd_rez[1]}".PadLeft(7, ' ') + $"{stud.nd_rez[2]}".PadLeft(7, ' ') + $"{stud.nd_rez[3]}".PadLeft(7, ' ') + $"{stud.nd_rez[4]}".PadLeft(7, ' ') + $"{stud.nd_rez[5]}".PadLeft(7, ' ') + $"{stud.egz_rez}".PadLeft(7, ' '));
                    }
                }
            }
            watch.Stop();
            var elapsedMs100000 = watch.ElapsedMilliseconds;
            watch.Restart();

            Console.WriteLine($"Time to complete 10:  {elapsedMs10}");
            Console.WriteLine($"Time to complete 100:  {elapsedMs100}");
            Console.WriteLine($"Time to complete 1000:  {elapsedMs1000}");
            Console.WriteLine($"Time to complete 10000:  {elapsedMs10000}");
            Console.WriteLine($"Time to complete 100000:  {elapsedMs100000}");


            Menu();


        }


        void StudentuGeneravimasNuskaitymasRusiavimasLaikas()
        {
            Strukturos.Stud stud;
            stud.nd_rez = new List<int>();
            Random rnd = new Random();

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            studentai.Clear();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "10.txt")))
            {
                for (int i = 1; i <= 10; i++)
                {
                    stud.nd_rez.Clear();
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.egz_rez = rnd.Next(1, 11);


                    if (i != 10)
                    {
                        outputFile.WriteLine($"Vardas{i}".PadRight(15, ' ') + $"Pavarde{i}".PadRight(20, ' ') + $"{stud.nd_rez[0]}".PadLeft(7, ' ') + $"{stud.nd_rez[1]}".PadLeft(7, ' ') + $"{stud.nd_rez[2]}".PadLeft(7, ' ') + $"{stud.nd_rez[3]}".PadLeft(7, ' ') + $"{stud.nd_rez[4]}".PadLeft(7, ' ') + $"{stud.nd_rez[5]}".PadLeft(7, ' ') + $"{stud.egz_rez}".PadLeft(7, ' '));
                    }
                    else
                    {
                        outputFile.Write($"Vardas{i}".PadRight(15, ' ') + $"Pavarde{i}".PadRight(20, ' ') + $"{stud.nd_rez[0]}".PadLeft(7, ' ') + $"{stud.nd_rez[1]}".PadLeft(7, ' ') + $"{stud.nd_rez[2]}".PadLeft(7, ' ') + $"{stud.nd_rez[3]}".PadLeft(7, ' ') + $"{stud.nd_rez[4]}".PadLeft(7, ' ') + $"{stud.nd_rez[5]}".PadLeft(7, ' ') + $"{stud.egz_rez}".PadLeft(7, ' '));
                    }
                }
            }
            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.Combine(docPath, "10.txt")))
            {
                int count = -1;
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (count == -1)
                    {
                        count++;
                    }
                    else
                    {
                        string[] ssplit = line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                        Strukturos.Stud studas;
                        studas.nd_rez = new List<int>();

                        studas.vardas = ssplit[0];
                        studas.pavarde = ssplit[1];
                        int.TryParse(ssplit[2], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[3], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[4], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[5], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[6], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[7], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[8], out studas.egz_rez);

                        studentai.Add(new Studentas(studas.vardas, studas.pavarde, studas.nd_rez, studas.egz_rez));

                        count++;
                    }
                }
                file.Close();
            }
            
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Vargsiukai10.txt")))
            {
                foreach (Studentas studi in studentai)
                {

                    if (studi.galutinis_vid < 5)
                    {
                        outputFile.WriteLine(studi.vardas.PadRight(15, ' ') + studi.pavarde.PadRight(20, ' ') + (String.Format("{0:0.00}", studi.nd_rez[0])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[1])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[2])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[3])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[4])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[5])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.egz_rez)).PadLeft(7, ' '));
                    }
                }
            }
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Kietiakai10.txt")))
            {
                foreach (Studentas studi in studentai)
                {
                    if (studi.galutinis_vid > 5)
                    {
                        outputFile.WriteLine(studi.vardas.PadRight(15, ' ') + studi.pavarde.PadRight(20, ' ') + (String.Format("{0:0.00}", studi.nd_rez[0])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[1])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[2])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[3])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[4])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[5])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.egz_rez)).PadLeft(7, ' '));
                    }
                }
            }
            watch.Stop();
            var elapsedMs10 = watch.ElapsedMilliseconds;
            studentai.Clear();
            watch.Restart();
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "100.txt")))
            {
                for (int i = 1; i <= 100; i++)
                {
                    stud.nd_rez.Clear();
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.egz_rez = rnd.Next(1, 11);


                    if (i != 100)
                    {
                        outputFile.WriteLine($"Vardas{i}".PadRight(15, ' ') + $"Pavarde{i}".PadRight(20, ' ') + $"{stud.nd_rez[0]}".PadLeft(7, ' ') + $"{stud.nd_rez[1]}".PadLeft(7, ' ') + $"{stud.nd_rez[2]}".PadLeft(7, ' ') + $"{stud.nd_rez[3]}".PadLeft(7, ' ') + $"{stud.nd_rez[4]}".PadLeft(7, ' ') + $"{stud.nd_rez[5]}".PadLeft(7, ' ') + $"{stud.egz_rez}".PadLeft(7, ' '));
                    }
                    else
                    {
                        outputFile.Write($"Vardas{i}".PadRight(15, ' ') + $"Pavarde{i}".PadRight(20, ' ') + $"{stud.nd_rez[0]}".PadLeft(7, ' ') + $"{stud.nd_rez[1]}".PadLeft(7, ' ') + $"{stud.nd_rez[2]}".PadLeft(7, ' ') + $"{stud.nd_rez[3]}".PadLeft(7, ' ') + $"{stud.nd_rez[4]}".PadLeft(7, ' ') + $"{stud.nd_rez[5]}".PadLeft(7, ' ') + $"{stud.egz_rez}".PadLeft(7, ' '));
                    }
                }
            }
            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.Combine(docPath, "100.txt")))
            {
                int count = -1;
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (count == -1)
                    {
                        count++;
                    }
                    else
                    {
                        string[] ssplit = line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                        Strukturos.Stud studas;
                        studas.nd_rez = new List<int>();

                        studas.vardas = ssplit[0];
                        studas.pavarde = ssplit[1];
                        int.TryParse(ssplit[2], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[3], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[4], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[5], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[6], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[7], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[8], out studas.egz_rez);

                        studentai.Add(new Studentas(studas.vardas, studas.pavarde, studas.nd_rez, studas.egz_rez));

                        count++;
                    }
                }
                file.Close();
            }
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Vargsiukai100.txt")))
            {
                foreach (Studentas studi in studentai)
                {
                    if (studi.galutinis_vid < 5)
                    {
                        outputFile.WriteLine(studi.vardas.PadRight(15, ' ') + studi.pavarde.PadRight(20, ' ') + (String.Format("{0:0.00}", studi.nd_rez[0])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[1])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[2])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[3])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[4])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[5])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.egz_rez)).PadLeft(7, ' '));
                    }
                }
            }
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Kietiakai100.txt")))
            {
                foreach (Studentas studi in studentai)
                {
                    if (studi.galutinis_vid > 5)
                    {
                        outputFile.WriteLine(studi.vardas.PadRight(15, ' ') + studi.pavarde.PadRight(20, ' ') + (String.Format("{0:0.00}", studi.nd_rez[0])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[1])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[2])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[3])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[4])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[5])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.egz_rez)).PadLeft(7, ' '));
                    }
                }
            }
            watch.Stop();
            var elapsedMs100 = watch.ElapsedMilliseconds;
            studentai.Clear();
            watch.Restart();
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "1000.txt")))
            {
                for (int i = 1; i <= 1000; i++)
                {
                    stud.nd_rez.Clear();
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.egz_rez = rnd.Next(1, 11);


                    if (i != 1000)
                    {
                        outputFile.WriteLine($"Vardas{i}".PadRight(15, ' ') + $"Pavarde{i}".PadRight(20, ' ') + $"{stud.nd_rez[0]}".PadLeft(7, ' ') + $"{stud.nd_rez[1]}".PadLeft(7, ' ') + $"{stud.nd_rez[2]}".PadLeft(7, ' ') + $"{stud.nd_rez[3]}".PadLeft(7, ' ') + $"{stud.nd_rez[4]}".PadLeft(7, ' ') + $"{stud.nd_rez[5]}".PadLeft(7, ' ') + $"{stud.egz_rez}".PadLeft(7, ' '));
                    }
                    else
                    {
                        outputFile.Write($"Vardas{i}".PadRight(15, ' ') + $"Pavarde{i}".PadRight(20, ' ') + $"{stud.nd_rez[0]}".PadLeft(7, ' ') + $"{stud.nd_rez[1]}".PadLeft(7, ' ') + $"{stud.nd_rez[2]}".PadLeft(7, ' ') + $"{stud.nd_rez[3]}".PadLeft(7, ' ') + $"{stud.nd_rez[4]}".PadLeft(7, ' ') + $"{stud.nd_rez[5]}".PadLeft(7, ' ') + $"{stud.egz_rez}".PadLeft(7, ' '));
                    }
                }
            }
            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.Combine(docPath, "1000.txt")))
            {
                int count = -1;
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (count == -1)
                    {
                        count++;
                    }
                    else
                    {
                        string[] ssplit = line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                        Strukturos.Stud studas;
                        studas.nd_rez = new List<int>();

                        studas.vardas = ssplit[0];
                        studas.pavarde = ssplit[1];
                        int.TryParse(ssplit[2], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[3], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[4], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[5], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[6], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[7], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[8], out studas.egz_rez);

                        studentai.Add(new Studentas(studas.vardas, studas.pavarde, studas.nd_rez, studas.egz_rez));

                        count++;
                    }
                }
                file.Close();
            }
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Vargsiukai1000.txt")))
            {
                foreach (Studentas studi in studentai)
                {
                    if (studi.galutinis_vid < 5)
                    {
                        outputFile.WriteLine(studi.vardas.PadRight(15, ' ') + studi.pavarde.PadRight(20, ' ') + (String.Format("{0:0.00}", studi.nd_rez[0])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[1])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[2])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[3])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[4])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[5])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.egz_rez)).PadLeft(7, ' '));
                    }
                }
            }
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Kietiakai1000.txt")))
            {
                foreach (Studentas studi in studentai)
                {
                    if (studi.galutinis_vid > 5)
                    {
                        outputFile.WriteLine(studi.vardas.PadRight(15, ' ') + studi.pavarde.PadRight(20, ' ') + (String.Format("{0:0.00}", studi.nd_rez[0])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[1])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[2])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[3])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[4])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[5])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.egz_rez)).PadLeft(7, ' '));
                    }
                }
            }
            watch.Stop();
            var elapsedMs1000 = watch.ElapsedMilliseconds;
            studentai.Clear();
            watch.Restart();
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "10000.txt")))
            {
                for (int i = 1; i <= 10000; i++)
                {
                    stud.nd_rez.Clear();
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.egz_rez = rnd.Next(1, 11);


                    if (i != 10000)
                    {
                        outputFile.WriteLine($"Vardas{i}".PadRight(15, ' ') + $"Pavarde{i}".PadRight(20, ' ') + $"{stud.nd_rez[0]}".PadLeft(7, ' ') + $"{stud.nd_rez[1]}".PadLeft(7, ' ') + $"{stud.nd_rez[2]}".PadLeft(7, ' ') + $"{stud.nd_rez[3]}".PadLeft(7, ' ') + $"{stud.nd_rez[4]}".PadLeft(7, ' ') + $"{stud.nd_rez[5]}".PadLeft(7, ' ') + $"{stud.egz_rez}".PadLeft(7, ' '));
                    }
                    else
                    {
                        outputFile.Write($"Vardas{i}".PadRight(15, ' ') + $"Pavarde{i}".PadRight(20, ' ') + $"{stud.nd_rez[0]}".PadLeft(7, ' ') + $"{stud.nd_rez[1]}".PadLeft(7, ' ') + $"{stud.nd_rez[2]}".PadLeft(7, ' ') + $"{stud.nd_rez[3]}".PadLeft(7, ' ') + $"{stud.nd_rez[4]}".PadLeft(7, ' ') + $"{stud.nd_rez[5]}".PadLeft(7, ' ') + $"{stud.egz_rez}".PadLeft(7, ' '));
                    }
                }
            }
            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.Combine(docPath, "10000.txt")))
            {
                int count = -1;
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (count == -1)
                    {
                        count++;
                    }
                    else
                    {
                        string[] ssplit = line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                        Strukturos.Stud studas;
                        studas.nd_rez = new List<int>();

                        studas.vardas = ssplit[0];
                        studas.pavarde = ssplit[1];
                        int.TryParse(ssplit[2], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[3], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[4], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[5], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[6], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[7], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[8], out studas.egz_rez);

                        studentai.Add(new Studentas(studas.vardas, studas.pavarde, studas.nd_rez, studas.egz_rez));

                        count++;
                    }
                }
                file.Close();
            }
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Vargsiukai10000.txt")))
            {
                foreach (Studentas studi in studentai)
                {
                    if (studi.galutinis_vid < 5)
                    {
                        outputFile.WriteLine(studi.vardas.PadRight(15, ' ') + studi.pavarde.PadRight(20, ' ') + (String.Format("{0:0.00}", studi.nd_rez[0])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[1])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[2])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[3])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[4])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[5])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.egz_rez)).PadLeft(7, ' '));
                    }
                }
            }
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Kietiakai10000.txt")))
            {
                foreach (Studentas studi in studentai)
                {
                    if (studi.galutinis_vid > 5)
                    {
                        outputFile.WriteLine(studi.vardas.PadRight(15, ' ') + studi.pavarde.PadRight(20, ' ') + (String.Format("{0:0.00}", studi.nd_rez[0])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[1])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[2])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[3])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[4])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[5])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.egz_rez)).PadLeft(7, ' '));
                    }
                }
            }
            watch.Stop();
            var elapsedMs10000 = watch.ElapsedMilliseconds;
            studentai.Clear();
            watch.Restart();
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "100000.txt")))
            {
                for (int i = 1; i <= 100000; i++)
                {
                    stud.nd_rez.Clear();
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.nd_rez.Add(rnd.Next(1, 11));
                    stud.egz_rez = rnd.Next(1, 11);


                    if (i != 100000)
                    {
                        outputFile.WriteLine($"Vardas{i}".PadRight(15, ' ') + $"Pavarde{i}".PadRight(20, ' ') + $"{stud.nd_rez[0]}".PadLeft(7, ' ') + $"{stud.nd_rez[1]}".PadLeft(7, ' ') + $"{stud.nd_rez[2]}".PadLeft(7, ' ') + $"{stud.nd_rez[3]}".PadLeft(7, ' ') + $"{stud.nd_rez[4]}".PadLeft(7, ' ') + $"{stud.nd_rez[5]}".PadLeft(7, ' ') + $"{stud.egz_rez}".PadLeft(7, ' '));
                    }
                    else
                    {
                        outputFile.Write($"Vardas{i}".PadRight(15, ' ') + $"Pavarde{i}".PadRight(20, ' ') + $"{stud.nd_rez[0]}".PadLeft(7, ' ') + $"{stud.nd_rez[1]}".PadLeft(7, ' ') + $"{stud.nd_rez[2]}".PadLeft(7, ' ') + $"{stud.nd_rez[3]}".PadLeft(7, ' ') + $"{stud.nd_rez[4]}".PadLeft(7, ' ') + $"{stud.nd_rez[5]}".PadLeft(7, ' ') + $"{stud.egz_rez}".PadLeft(7, ' '));
                    }
                }
            }
            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.Combine(docPath, "100000.txt")))
            {
                int count = -1;
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (count == -1)
                    {
                        count++;
                    }
                    else
                    {
                        string[] ssplit = line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                        Strukturos.Stud studas;
                        studas.nd_rez = new List<int>();

                        studas.vardas = ssplit[0];
                        studas.pavarde = ssplit[1];
                        int.TryParse(ssplit[2], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[3], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[4], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[5], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[6], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[7], out studas.egz_rez);
                        studas.nd_rez.Add(studas.egz_rez);
                        int.TryParse(ssplit[8], out studas.egz_rez);

                        studentai.Add(new Studentas(studas.vardas, studas.pavarde, studas.nd_rez, studas.egz_rez));

                        count++;
                    }
                }
                file.Close();
            }
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Vargsiukai100000.txt")))
            {
                foreach (Studentas studi in studentai)
                {
                    if (studi.galutinis_vid < 5)
                    {
                        outputFile.WriteLine(studi.vardas.PadRight(15, ' ') + studi.pavarde.PadRight(20, ' ') + (String.Format("{0:0.00}", studi.nd_rez[0])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[1])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[2])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[3])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[4])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[5])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.egz_rez)).PadLeft(7, ' '));
                    }
                }
            }
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Kietiakai100000.txt")))
            {
                foreach (Studentas studi in studentai)
                {
                    if (studi.galutinis_vid > 5)
                    {
                        outputFile.WriteLine(studi.vardas.PadRight(15, ' ') + studi.pavarde.PadRight(20, ' ') + (String.Format("{0:0.00}", studi.nd_rez[0])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[1])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[2])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[3])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[4])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.nd_rez[5])).PadLeft(7, ' ') + (String.Format("{0:0.00}", studi.egz_rez)).PadLeft(7, ' '));
                    }
                }
            }
            watch.Stop();
            var elapsedMs100000 = watch.ElapsedMilliseconds;
            watch.Restart();

            Console.WriteLine($"Time to complete 10:  {elapsedMs10}");
            Console.WriteLine($"Time to complete 100:  {elapsedMs100}");
            Console.WriteLine($"Time to complete 1000:  {elapsedMs1000}");
            Console.WriteLine($"Time to complete 10000:  {elapsedMs10000}");
            Console.WriteLine($"Time to complete 100000:  {elapsedMs100000}");
            Console.WriteLine($"Time to complete everything:  {elapsedMs100000+elapsedMs10000+elapsedMs1000+elapsedMs100+elapsedMs10}");

            Console.WriteLine($"\n\n");

            Menu();


        }
    }



}

