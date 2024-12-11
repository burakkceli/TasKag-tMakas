using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagitMakas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            int OyuncuSkor = 0;
            int RakipSkor = 0;

            Console.WriteLine("Taş-Kağıt-Makasa hoşgeldin!");

            while (OyuncuSkor != 3 && RakipSkor != 3)
            {
                Console.WriteLine("Oyuncu Skor: - " + OyuncuSkor + "Rakip Skor: - " + RakipSkor);
                Console.WriteLine("Taş için 't' - kağıt için 'k' - makas için 'm'");
                string OyncSeçim = Console.ReadLine();

                int RakipSeçim = random.Next(0, 3);

                if (RakipSeçim == 0)
                {
                    Console.WriteLine("Rakip seçimi = 'taş'");

                    switch (OyncSeçim)
                    {
                        case "t":
                            Console.WriteLine("Berabere");
                            break;
                        case "k":
                            Console.WriteLine("Oyuncu kazandı!");
                            OyuncuSkor++;
                            break;
                        case "m":
                            Console.WriteLine("Rakip Kazandı!");
                            RakipSkor++;
                            break;

                    }

                }
                else if (RakipSeçim == 1)
                {
                    Console.WriteLine("Rakip seçimi = 'kağıt'");
                    switch (OyncSeçim)
                    {
                        case "t":
                            Console.WriteLine("Rakip kazandı!");
                            RakipSkor++;
                            break;
                        case "k":
                            Console.WriteLine("Berabere!");
                            break;
                        case "m":
                            Console.WriteLine("Oyuncu Kazandı!");
                            OyuncuSkor++;
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Rakip seçimi = 'makas'");
                    switch (OyncSeçim)
                    {
                        case "t":
                            Console.WriteLine("Oyuncu kazandı!");
                            OyuncuSkor++;
                            break;
                        case "k":
                            Console.WriteLine("Rakip kazandı!");
                            RakipSkor++;
                            break;
                        case "m":
                            Console.WriteLine("Berabere");
                            break;
                    }

                }
            }

            if (OyuncuSkor == 3)
            {
                Console.WriteLine("Oyuncu kazandı!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Rakip kazandı!");
                Console.ReadLine();
            }

        }



    }
}
