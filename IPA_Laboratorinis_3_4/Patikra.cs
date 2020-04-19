using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPA_Laboratorinis_3_4
{
    class Patikra
    {

        public void Start()
        {

            SugeneruotiStudentus();
            ListTest();
            LinkedListTest();
            QueueTest();

            IstrintiFailus();

            




        }

        public void SugeneruotiStudentus()
        {
            Strukturos.Stud stud;
            stud.nd_rez = new List<int>();
            Random rnd = new Random();

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

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
        }

        public void ListTest()
        {
            List<Studentas> studentai = new List<Studentas>();
            Strukturos.Stud stud;
            stud.nd_rez = new List<int>();
            Random rnd = new Random();

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var watch = System.Diagnostics.Stopwatch.StartNew();

            Console.WriteLine("List<T> speed test:");

            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.Combine(docPath, "10.txt")))
            {
                int count = 0;
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
            Console.WriteLine("10 students - " + elapsedMs10 + "ms");
            studentai.Clear();
            watch.Restart();

            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.Combine(docPath, "100.txt")))
            {
                int count = 0;
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
            Console.WriteLine("100 students - " + elapsedMs100 + "ms");
            studentai.Clear();
            watch.Restart();

            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.Combine(docPath, "1000.txt")))
            {
                int count = -1;
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (count == 0)
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
            Console.WriteLine("1000 students - " + elapsedMs1000 + "ms");
            studentai.Clear();
            watch.Restart();

            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.Combine(docPath, "10000.txt")))
            {
                int count = -1;
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (count == 0)
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
            Console.WriteLine("10000 students - " + elapsedMs10000 + "ms");
            studentai.Clear();
            watch.Restart();

            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.Combine(docPath, "100000.txt")))
            {
                int count = -1;
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (count == 0)
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
            Console.WriteLine("100000 students - " + elapsedMs100000 + "ms\n");
        }

        public void LinkedListTest()
        {
            LinkedList<Studentas> studentai = new LinkedList<Studentas>();
            Strukturos.Stud stud;
            stud.nd_rez = new List<int>();
            Random rnd = new Random();

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var watch = System.Diagnostics.Stopwatch.StartNew();

            Console.WriteLine("LinkedList<T> speed test:");

            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.Combine(docPath, "10.txt")))
            {
                int count = 0;
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

                        studentai.AddLast(new Studentas(studas.vardas, studas.pavarde, studas.nd_rez, studas.egz_rez));

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
            Console.WriteLine("10 students - " + elapsedMs10 + "ms");
            studentai.Clear();
            watch.Restart();

            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.Combine(docPath, "100.txt")))
            {
                int count = 0;
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

                        studentai.AddLast(new Studentas(studas.vardas, studas.pavarde, studas.nd_rez, studas.egz_rez));

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
            Console.WriteLine("100 students - " + elapsedMs100 + "ms");
            studentai.Clear();
            watch.Restart();

            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.Combine(docPath, "1000.txt")))
            {
                int count = -1;
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (count == 0)
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

                        studentai.AddLast(new Studentas(studas.vardas, studas.pavarde, studas.nd_rez, studas.egz_rez));

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
            Console.WriteLine("1000 students - " + elapsedMs1000 + "ms");
            studentai.Clear();
            watch.Restart();

            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.Combine(docPath, "10000.txt")))
            {
                int count = -1;
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (count == 0)
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

                        studentai.AddLast(new Studentas(studas.vardas, studas.pavarde, studas.nd_rez, studas.egz_rez));

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
            Console.WriteLine("10000 students - " + elapsedMs10000 + "ms");
            studentai.Clear();
            watch.Restart();

            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.Combine(docPath, "100000.txt")))
            {
                int count = -1;
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (count == 0)
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

                        studentai.AddLast(new Studentas(studas.vardas, studas.pavarde, studas.nd_rez, studas.egz_rez));

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
            Console.WriteLine("100000 students - " + elapsedMs100000 + "ms\n");
        }

        public void QueueTest()
        {
            Queue<Studentas> studentai = new Queue<Studentas>();
            Strukturos.Stud stud;
            stud.nd_rez = new List<int>();
            Random rnd = new Random();

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var watch = System.Diagnostics.Stopwatch.StartNew();

            Console.WriteLine("LinkedList<T> speed test:");

            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.Combine(docPath, "10.txt")))
            {
                int count = 0;
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

                        studentai.Enqueue(new Studentas(studas.vardas, studas.pavarde, studas.nd_rez, studas.egz_rez));

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
            Console.WriteLine("10 students - " + elapsedMs10 + "ms");
            studentai.Clear();
            watch.Restart();

            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.Combine(docPath, "100.txt")))
            {
                int count = 0;
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

                        studentai.Enqueue(new Studentas(studas.vardas, studas.pavarde, studas.nd_rez, studas.egz_rez));

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
            Console.WriteLine("100 students - " + elapsedMs100 + "ms");
            studentai.Clear();
            watch.Restart();

            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.Combine(docPath, "1000.txt")))
            {
                int count = -1;
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (count == 0)
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

                        studentai.Enqueue(new Studentas(studas.vardas, studas.pavarde, studas.nd_rez, studas.egz_rez));

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
            Console.WriteLine("1000 students - " + elapsedMs1000 + "ms");
            studentai.Clear();
            watch.Restart();

            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.Combine(docPath, "10000.txt")))
            {
                int count = -1;
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (count == 0)
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

                        studentai.Enqueue(new Studentas(studas.vardas, studas.pavarde, studas.nd_rez, studas.egz_rez));

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
            Console.WriteLine("10000 students - " + elapsedMs10000 + "ms");
            studentai.Clear();
            watch.Restart();

            using (System.IO.StreamReader file = new System.IO.StreamReader(Path.Combine(docPath, "100000.txt")))
            {
                int count = -1;
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (count == 0)
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

                        studentai.Enqueue(new Studentas(studas.vardas, studas.pavarde, studas.nd_rez, studas.egz_rez));

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
            Console.WriteLine("100000 students - " + elapsedMs100000 + "ms\n");
        }

        public void IstrintiFailus()
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (File.Exists(Path.Combine(docPath, "10.txt")))
            {
                // If file found, delete it    
                File.Delete(Path.Combine(docPath, "10.txt"));
            }
            if (File.Exists(Path.Combine(docPath, "Vargsiukai10.txt")))
            {
                // If file found, delete it    
                File.Delete(Path.Combine(docPath, "Vargsiukai10.txt"));
            }
            if (File.Exists(Path.Combine(docPath, "Kietiakai10.txt")))
            {
                // If file found, delete it    
                File.Delete(Path.Combine(docPath, "Kietiakai10.txt"));
            }
            if (File.Exists(Path.Combine(docPath, "100.txt")))
            {
                // If file found, delete it    
                File.Delete(Path.Combine(docPath, "100.txt"));
            }
            if (File.Exists(Path.Combine(docPath, "Vargsiukai100.txt")))
            {
                // If file found, delete it    
                File.Delete(Path.Combine(docPath, "Vargsiukai100.txt"));
            }
            if (File.Exists(Path.Combine(docPath, "Kietiakai100.txt")))
            {
                // If file found, delete it    
                File.Delete(Path.Combine(docPath, "Kietiakai100.txt"));
            }
            if (File.Exists(Path.Combine(docPath, "1000.txt")))
            {
                // If file found, delete it    
                File.Delete(Path.Combine(docPath, "1000.txt"));
            }
            if (File.Exists(Path.Combine(docPath, "Vargsiukai1000.txt")))
            {
                // If file found, delete it    
                File.Delete(Path.Combine(docPath, "Vargsiukai1000.txt"));
            }
            if (File.Exists(Path.Combine(docPath, "Kietiakai1000.txt")))
            {
                // If file found, delete it    
                File.Delete(Path.Combine(docPath, "Kietiakai1000.txt"));
            }
            if (File.Exists(Path.Combine(docPath, "10000.txt")))
            {
                // If file found, delete it    
                File.Delete(Path.Combine(docPath, "10000.txt"));
            }
            if (File.Exists(Path.Combine(docPath, "Vargsiukai10000.txt")))
            {
                // If file found, delete it    
                File.Delete(Path.Combine(docPath, "Vargsiukai10000.txt"));
            }
            if (File.Exists(Path.Combine(docPath, "Kietiakai10000.txt")))
            {
                // If file found, delete it    
                File.Delete(Path.Combine(docPath, "Kietiakai10000.txt"));
            }
            if (File.Exists(Path.Combine(docPath, "100000.txt")))
            {
                // If file found, delete it    
                File.Delete(Path.Combine(docPath, "100000.txt"));
            }
            if (File.Exists(Path.Combine(docPath, "Vargsiukai100000.txt")))
            {
                // If file found, delete it    
                File.Delete(Path.Combine(docPath, "Vargsiukai100000.txt"));
            }
            if (File.Exists(Path.Combine(docPath, "Kietiakai100000.txt")))
            {
                // If file found, delete it    
                File.Delete(Path.Combine(docPath, "Kietiakai100000.txt"));
            }

        }

    }
}
