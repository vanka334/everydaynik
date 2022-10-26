using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace everydaynik
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int a = 5;

            DateTime date = new DateTime(2022, 10, 26);
            dnik zamtka = new dnik();
            zamtka.name = "мувы";
            zamtka.data = new DateTime(2022, 10, 26);
            zamtka.telo = "gogo";
            dnik zamtka1 = new dnik();
            zamtka1.name = "париж";
            zamtka1.data = new DateTime(2022, 10, 26);
            zamtka1.telo = "France";
            dnik zamtka2 = new dnik();
            zamtka2.name = "Мувы";
            zamtka2.data = new DateTime(2022, 10, 24);
            zamtka2.telo = "луи";
            dnik zamtka3 = new dnik();
            zamtka3.name = "Сходить туда";
            zamtka3.data = new DateTime(2022, 10, 27);
            zamtka3.telo = "хочу";


            List<dnik> dniks = new List<dnik>();
            dniks.Add(zamtka);
            dniks.Add(zamtka1);
            dniks.Add(zamtka2);
            dniks.Add(zamtka3);
            int position = 1;
            ConsoleKeyInfo clavisha = Console.ReadKey();

            while (clavisha.Key != ConsoleKey.Escape)

            {
                List<dnik> kolvo = dniks.Where(x => x.data.Date == date.Date).ToList();
                int kolvo1 = kolvo.Count();

                kolvo1 += 1;

                if ((clavisha.Key == ConsoleKey.UpArrow) && (kolvo1 != 0))
                {

                    position--;
                    if (position == 0)
                    {
                        position = kolvo1;
                    }
                }
                else if ((clavisha.Key == ConsoleKey.DownArrow) && (kolvo1 != 0))
                {
                    position++;
                    if (position == kolvo1 + 1)
                    {
                        position = 1;
                    }

                }
                Console.Clear();
                Console.WriteLine(date);
                foreach (var item in kolvo)
                {



                    Console.WriteLine("  " + item.name);
                    for (int i = 0; i < position; i++)
                    {

                        if (clavisha.Key == ConsoleKey.Enter)
                        {

                            otkrivashka(kolvo[i]);

                        }

                    }

                }
                if (clavisha.Key == ConsoleKey.Tab)
                
                    dniks.Add(dobavka());
                


                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                clavisha = Console.ReadKey();
                if (clavisha.Key == ConsoleKey.LeftArrow)
                {
                    date = date.AddDays(-1);
                }
                else if (clavisha.Key == ConsoleKey.RightArrow)
                {
                    date = date.AddDays(+1);


                }




            }



        }
        static void otkrivashka(dnik kolvo)
        {
            Console.Clear();
            Console.WriteLine("Ваши задачи на сегодня");

            Console.WriteLine(' ' + kolvo.telo);
        }
        static dnik dobavka()
        {
            Console.Clear();
            dnik newzametka = new dnik();
            Console.WriteLine("Введите дату в которую добавить заметку");
            string input = Console.ReadLine();
            string[] split = input.Split('.');
            double day = Double.Parse(split[0]);
            double month = Double.Parse(split[1]);
            double year = Double.Parse(split[2]);
            int day1 = Convert.ToInt32(day);
            int month2 = Convert.ToInt32(month);
            int year3 = Convert.ToInt32(year);
            Console.WriteLine("Введите имя заметки");
            newzametka.name = Console.ReadLine();
            Console.WriteLine("Введите описание заметки");
            newzametka.telo = Console.ReadLine();
            newzametka.data = new DateTime(year3, month2, day1);
            List<dnik> list = new List<dnik>();
            list.Add(newzametka);
            Console.Clear();
            return newzametka;
        }




    }

}