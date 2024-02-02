using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.IO;

namespace Kolokwium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Kolokwium Programowanie 1.");
            Console.WriteLine("\nMenu polecen: \n");
            Console.WriteLine("1. Dzialania na plikach.");
            Console.WriteLine("2. Dzialania na stringach.");
            Console.WriteLine("3. Dzialania matematyczne");
            Console.WriteLine("4. Koniec programu");
            Console.WriteLine("\nWybierz opcję: ");
            switch (Console.ReadLine())
            {
                case "1":
                    DzialaniaNaPlikach();
                    return true;
                case "2":
                    DzialaniaNaStringach();
                    return true;
                case "3":
                    DzialaniaMatematyczne();
                    return true;
                case "4":
                    return false;
                default:
                    return true;
            }
        }
        private static void DzialaniaNaPlikach()
        {
            Console.Clear();
            Console.WriteLine("Wybrałeś Działania na plikach");
            Console.WriteLine("Utworze teraz folder Test na dysku C: i plik tekstowy dane.txt");
            if(!Directory.Exists("C:\\Test"))
            {
                Directory.CreateDirectory("C:\\Test");
            }
            if(!File.Exists("C:\\Test\\dane.txt"))
            {
                File.CreateText("C:\\Test\\dane.txt");
            }

            Console.Write("Przeniesc plik dane.txt do podkatalogu Kopia? [t/n]: ");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.KeyChar == 't' || key.KeyChar == 'T')
            {
                Console.WriteLine("\nPrzenosze...");
                if(!Directory.Exists("C:\\Test\\Kopia"))
                {
                    Directory.CreateDirectory("C:\\Test\\Kopia");
                }
                if(!File.Exists("C:\\Test\\Kopia\\dane.txt"))
                {
                    File.Move("C:\\Test\\dane.txt", "C:\\Test\\Kopia\\dane.txt");
                }
                
            }
            else if (key.KeyChar == 'n' || key.KeyChar == 'N')
            {
                Console.WriteLine("\nNie przenosze...");
            }
            else
            {
                Console.WriteLine("\nZly wybor");
            }
            Console.ReadKey();
            Koniec();
        }
        private static void DzialaniaNaStringach()
        {
            Console.Clear();
            Console.WriteLine("Wybrałeś Działania na stringach");
            Koniec();
        }
        private static void DzialaniaMatematyczne()
        {
            Console.Clear();
            Console.WriteLine("Wybrałeś Działania matematyczne");
            Koniec();
        }
        private static void Koniec()
        {
            
            Console.WriteLine("\r\nWcisnij enter by powrocic do glownego Menu");
            Console.ReadLine();
        }
    }
}