using System;
using static System.Console;

//Janne Rajuvaara
//NTK17SP

namespace H3T2
{
    class Program
    {
        static void Main(string[] args)
        {
            ViikonPaiva paiva;
            do {
                try
                {
                    Write("Anna luku väliltä 1-7: ");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    if (numero >= 1 && numero <= 7)
                    {
                        paiva = (ViikonPaiva)numero;
                        WriteLine($"Lukua {numero} vastaa päivä {paiva}.");
                        ReadLine();
                        break;
                    }
                    else
                    {
                        throw new Exception("Luku ei ole väliltä 1-7.");
                    }
                }
                catch (FormatException)
                {
                    WriteLine("Syöte ei ole kokonaisluku");
                }
                catch (OverflowException)
                {
                    WriteLine("Ei tommone mahu ees integeriin kaveri.");
                }
                catch (Exception e)
                {
                    WriteLine(e.Message);
                }

            } while (true);
        }

        public enum ViikonPaiva
        {
            Maanantai = 1,
            Tiistai,
            Keskiviikko,
            Torstai,
            Perjantai,
            Lauantai,
            Sunnuntai
        }
    }
}
