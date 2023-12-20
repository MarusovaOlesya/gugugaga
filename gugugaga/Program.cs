using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace gugugaga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            num_15();
            //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
        }
         
        static void num_1()
        {
            int a = 1;
            while(a <= 10)
            {
                Console.WriteLine(a);
                a++;
            }
        }

        static void num_2()
        {
            Console.WriteLine("Введите строку: ");
            string a = Console.ReadLine();

            Console.WriteLine("Введите числоN: ");
            int N = int.Parse(Console.ReadLine());

            int i = 0;
            while(i < N)
            {
                Console.WriteLine(a);
                i++;
            }
        }

       static void num_3()
        {
            int i = 1;
            while (i <= 10)
            {
                int j = 1;
                while (j <= 10)
                {
                    Console.Write("S");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }

        static void num_4()
        {
            int i = 1;
            while (i <= 10)
            {
                int j = 1;
                while (j <= 10)
                {
                    Console.Write(i * j + " ");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }

        static void num_5()
        {
            for(int i = 1; i <= 100; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void num_6()
        {
            Console.WriteLine("M: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("N: ");
            int n = int.Parse(Console.ReadLine());

            for(int i =0; i<=m; i++)
            {
              for(int j =0; j<=n; j++)
                {
                    Console.Write("8");
                }
                Console.WriteLine("");
            }
        }

        static void num_7()
        {
            for(int i = 0; i < 10; i++)
            {
                for( int j =0; j<=i; j++)
                {
                    Console.Write("8");
                }
                Console.WriteLine();
            }
            
        }

        static void num_8()
        {
            for(int i = 0; i<10; i++)
            {
                Console.Write("8");
            }
            for(int j =0; j<10; j++)
            {
                Console.WriteLine("8");
            }
        }
        static void num_9()
        {
            int a = 0;
            while(a < 100)
            {
                Console.WriteLine("Я никогда не буду работать за копейки.");
            }
        }
        static void num_10()
        {
            Console.WriteLine("Введите три числа: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
            int min = Math.Min(Math.Min(a, b), c);
            int max = Math.Max(Math.Max(a, b), c);

            int srch = ( a + b + c ) - (min + max);
            Console.WriteLine("Среднее число = " + srch);
        }

        static void num_11()
        {
            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите день вашего рождения");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц вашего рождения");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год вашего рождения");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Меня зовут " + name);
            Console.WriteLine("Я родился " + d + "." + m + "." + y);

        }
        static void num_12()
        {
            string[] m = new string[10];

            for (int i = 0; i < 8; i++)
            {
                m[i] = Console.ReadLine();
            }
            for (int j = 9;  j >= 0; j--)
            {
                Console.WriteLine(m[j]);
            }
        }
        static void num_13()
        {
            int[] m = new int[10];

            for(int i = 0;i < 10; i++)
            {
                m[i] = int.Parse(Console.ReadLine());
            }
            for(int j = 9;j >= 0; j--)
            {
                Console.WriteLine(m[j]);
            }

        }
        static void num_14()
        {
            int[] m = new int[20];
            int[] a = new int[10];
            int[] b = new int[10];
            for(int i = 0; i<m.Length; i++)
            {
                m[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < a.Length; j++)
            {
                a[j] = m[j];
            }
            for (int y = 10, s = 0; y < m.Length && s < b.Length; y++, s++)
            {
                b[s] = m[y];
            }
            Console.WriteLine("/////////////////////////////////////////////");
            for(int o = 0; o < b.Length; o++)
            {
                Console.WriteLine(b[o]);
            }
            
        }
        static void num_15()
        {
            int[] m = new int[15];
            int ul1 = 0;
            int ul2 = 0;
            for (int i = 0; i < m.Length; i++)
            {
                m[i] = int.Parse(Console.ReadLine());
            }
            for(int j = 0;j < m.Length; j++)
            {
                if (j%2 != 0)
                {
                    ul1 = ul1 + m[j];

                }
                if(j%2 == 0 && j == 0) 
                {
                    ul2 = ul2 + m[j];
                }
            }
            if (ul1 > ul2)
            {
                Console.WriteLine("В домах с нечетными номерами проживает больше жителей.");
            }
            else
            {
                Console.WriteLine("В домах с четными номерами проживает больше жителей.");
            }
        }

    }
    }
    


