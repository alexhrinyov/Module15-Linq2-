using System;

namespace U2Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу с бесконечным циклом, как в предыдущем юните, которая будет:

            //ожидать ввода числа с клавиатуры(используйте Console.ReadLine());
            //добавлять число в список, хранящийся в памяти;
            //выводить после добавления следующую информацию: количество чисел в списке, 
            //    сумму всех чисел списка, наибольшее и наименьшее числа, а также их среднее значение.
            Console.WriteLine("Enter -end- to finish ");
            int number = 0;
            List<int> list = new List<int>();
            while (true)
            {                  
                var entered = Console.ReadLine();
                switch (entered)
                {
                    case "end":
                        Console.WriteLine("Количество:" + list.Count());
                        Console.WriteLine("Сумма:" + list.Sum());
                        Console.WriteLine("Меньшее:" + list.Min());
                        Console.WriteLine("Большее:" + list.Max());
                        Console.WriteLine("Среднее:" + list.Average());
                        continue;
                        break;
                    default:
                        if (int.TryParse(entered, out number))
                        {   
                            list.Add(number);   
                        }
                        else
                        {
                            Console.WriteLine("Enter a number,please");
                            continue;
                        }
                        break;
                }




            }
        }
    }
}