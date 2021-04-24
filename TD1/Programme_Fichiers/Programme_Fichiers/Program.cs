using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Programme_Fichiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //var path = "out";
            //Directory.CreateDirectory(path);
            //string fileName = @"c:\monFichier.txt";
            // c:\user\....
            // c/User/...

            string fileName = "monFichier.txt";
            //string pathAndFile = path +"/"+ fileName;
            string pathAndFile = Path.Combine(path,fileName);
            Console.WriteLine("Fichier :" + pathAndFile);
            /*var noms = new List<string>()
            {
                "Jean",
                "Paul",
                "Martin"
            };*/
            //---------------------------------------------------------------
            /*StringBuilder texte = new StringBuilder();
            int nblignes = 10000000;
            Console.WriteLine("preparation des donnees ....");
            for (int i =1; i<= nblignes; i++ )
            {
                texte.Append("ligne" + i + "\n"); 
            }
            Console.WriteLine("ok");
            Console.WriteLine("ecriture des donnees ....");
            File.WriteAllText(pathAndFile, texte.ToString());
            Console.WriteLine("ok");*/
            //-----------------------------------------------------------
            int nblignes = 10000000;
            Console.WriteLine("preparation des donnees ....");

            using(var writeScream = File.CreateText(pathAndFile))
            {
                for (int i = 1; i <= nblignes; i++)
                {
                    writeScream.Write("ligne" + i + "\n");
                }
                Console.WriteLine("ok");
            }
            

            //lecture d'un scream
            ;
            //using (var readScream = File.OpenText(pathAndFile))
            //{
            //   while(true)
            //    {
            //        var line = readScream.ReadLine();
            //        if (line == null)
            //        {
            //            break;
            //        }
            //        Console.WriteLine(line);
            //    }
            //}
            File.Copy("monFichier.txt", "c2.txt");
            File.Delete("c2.txt");
            File.Move("monFichier2.txt", "monFichier.txt");
            //File.AppendAllText(fileName, "\n je rajoute ce texte");
            //File.WriteAllLines(pathAndFile, noms);
            //try
            //{
            //    // string result = File.ReadAllText(fileName);
            //    var lignes = File.ReadAllLines(pathAndFile);
            //    foreach(var ligne in lignes)
            //    {
            //        Console.WriteLine(ligne);
            //    }

            //}
            //catch
            //{
            //    Console.WriteLine("Error: ce fichier n'existe pas");
            //}
        }
    }
}
