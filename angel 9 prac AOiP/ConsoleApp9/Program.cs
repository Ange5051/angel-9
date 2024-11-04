using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Определить, имеются ли в одномерном массиве случайных чисел элементы, значения которых кратны 11. Вывести такие значения.
            //int[] omas = new int[11];
            //Console.Write("Заполните одномерный массив");
            //for(int i=0;i<omas.Length;i++)
            //{
            //    Console.WriteLine($"omas=[{i}]=");
            //    omas[0] = int.Parse(Console.ReadLine());
            //    omas[1] = int.Parse(Console.ReadLine());
            //    omas[2] = int.Parse(Console.ReadLine());
            //    omas[3] = int.Parse(Console.ReadLine());
            //    omas[4] = int.Parse(Console.ReadLine());
            //}
            //foreach(int e in omas)
            //{
            //    int x = (e % 11 == 0) ?
            //        Console.Write(x);

            //}
            //Console.Read();

            //Задача 2. Найти сумму и количество положительных элементов в одномерном массиве с явной инициализацией.
            //int[] omas = new int[] { 5, -4, 8, 7, -2 };
            //int count, value = 0;
            //for(int i=0;i<omas.Length;i++)
            //{
            //    if (omas[i]>0)
            //    {
            //        value += omas[i];
            //        count ++;
            //    }
            //}
            //Console.Write($"Сумма:{value}\n Количество:{count}");
            //Console.Read();

            //Задача 3. Вывести элементы одномерного массива, заполненного с клавиатуры ,в обратном порядке.
            //const int n = 6;
            //int[] omas = new int[n];
            //Random rnd = new Random();
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    omas[i] = rnd.Next(0, 99);
            //    Console.WriteLine($"omas[{i}]={omas[i]}");
            //}
            //for (int i = omas.Length - 1; i > omas.Length; i--)
            //{
            //    Console.WriteLine(omas[i]);
            //}
            Console.Read();
        }
    }
}
