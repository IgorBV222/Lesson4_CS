using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.IO;
using System.Text.RegularExpressions; //регулярные выражения

namespace Lesson4_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Environment.Exit(0);
            //var path =Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // возвращаем путь к папке
            /*var path = Environment.CurrentDirectory;
            DirectoryInfo myDirInfo = new DirectoryInfo(path);
            foreach (var item in myDirInfo.EnumerateDirectories())
            {
                Console.WriteLine($"Каталог {item}");
            }
            foreach (var item in myDirInfo.EnumerateFiles())
            {
                Console.WriteLine($"Файл {item} имеет размер {item.Length} байт, был изменён {item.LastWriteTime}");
            }*/

            /*string path;
            if (args.Length > 0)
            {
                path = args[0];
            }
            else
            {
                path = Environment.CurrentDirectory;
            }
            DirectoryInfo myDirInfo = new DirectoryInfo(path);
            foreach (var item in myDirInfo.EnumerateDirectories())
            {
                Console.WriteLine($"Каталог {item}");
            }
            foreach (var item in myDirInfo.EnumerateFiles())
            {
                Console.WriteLine($"Файл {item} имеет размер {item.Length} байт, был изменён {item.LastWriteTime}");
            }*/

            /*string path;
            try
            {
                path = args[0];
            }
            catch (Exception)
            {
                //Console.WriteLine(eOO.Massange);
                path = Environment.CurrentDirectory;

            }
            DirectoryInfo myDirInfo = new DirectoryInfo(path);
            foreach (var item in myDirInfo.EnumerateDirectories())
            {
                Console.WriteLine($"Каталог {item}");
            }
            foreach (var item in myDirInfo.EnumerateFiles())
            {
                Console.WriteLine($"Файл {item} имеет размер {item.Length} байт, был изменён {item.LastWriteTime}");
            }*/

            // Environment.Exit(0);
            // var path =Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // возвращаем путь к папке
            /*var path = Environment.CurrentDirectory;
            string path;
            DirectoryInfo myDirInfo = new DirectoryInfo(path);
            foreach (var item in myDirInfo.EnumerateDirectories())
            {
                Console.WriteLine($"Каталог {item}");
            }
            foreach (var item in myDirInfo.EnumerateFiles())
            {
                Console.WriteLine($"Файл {item} имеет размер {item.Length} байт, был изменён {item.LastWriteTime}");
                var lastModified = myDirInfo.LastWriteTime;
                TimeSpan delta = item.LastAccessTime - lastModified;
                //delta.Ticks 
                int year = int.Parse(item.LastWriteTime.ToString("yyyy"));
            }*/
            //вывод кодов цифр
            /*for (int i = (int)'0'; i <= (int)'9'; i++) 
            {
                Console.WriteLine(((char)i).ToString()+" имеет код " + i);
            }*/

            //Регулярные выражения

            string input = "23 * 45 =\r\n12 - 5 =";
            var regexLeft = new Regex(@"\d+\s*(\+|\-|\*|\/)");
            var regexRigth = new Regex(@"(\+|\-|\*|\/)\s*\d+");
            var regNumber = new Regex(@"\d+");
            var regexOperation = new Regex(@"(\+|\-|\*|\/)");
            MatchCollection matchesLeft = regexLeft.Matches(input);
            MatchCollection matchesRigth = regexRigth.Matches(input);
            foreach (Match match in matchesLeft)
            {                
                Console.WriteLine("Левый оперант и операция: " + match.ToString());
                MatchCollection numberLeft = regNumber.Matches(match.ToString());
                Console.WriteLine("Левый оперант " + numberLeft[0]);
            }
            foreach (Match match in matchesRigth)
            {
                Console.WriteLine("Правый оперант и операция: " + match.ToString());
                MatchCollection numberRigth = regNumber.Matches(match.ToString());
                Console.WriteLine("Правый оперант " + numberRigth[0]);
            }
            Console.ReadKey();




        }
    }
}
