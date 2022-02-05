using System;
using System.Collections.Generic;

namespace TSVPS_SelectSort
{
    class Program
    {
        private static List<int> elementsArray = new List<int>(); 

        private static void Print()
        {
            for (int i = 0; i < elementsArray.Count; i++)
            {
                Console.Write($"{elementsArray[i]} ");
            }
        }

        private static void GetRandomElements(int amountOfElements)
        {
            Random randomElements = new Random();
            for (int i = 0; i < amountOfElements; i++)
            {
                elementsArray.Add(randomElements.Next(0, 100));
            }
        }

        private static void SelectSort()
        {
            int minIdx = 0; int minItemFound = 0;
            for (int correntElementIdx = 0; correntElementIdx < elementsArray.Count; correntElementIdx++)
            {
                minIdx = correntElementIdx;
                for (int remainingElementIdx = correntElementIdx + 1;  remainingElementIdx < elementsArray.Count;  remainingElementIdx++)
                {
                    if (elementsArray[remainingElementIdx] < elementsArray[minIdx])
                    {
                        minIdx = remainingElementIdx;
                    }
                }
                // To view indexes of changed elements (Для просмотра индексов меняемых элементов)
                //Console.WriteLine("Меняем элемент " + correntElementIdx + " на " + minIdx);
                minItemFound = elementsArray[minIdx];
                elementsArray[minIdx] = elementsArray[correntElementIdx];
                elementsArray[correntElementIdx] = minItemFound;
            }                         
        } 

        public static void Main(string[] args)
        {
            Console.WriteLine("Сортировка массива методом SelectSort");
            Console.Write("Введите кол-во элементов массива: ");
            int amountOfElements = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nНе отсортироваванный массив на {amountOfElements} элементов");
            GetRandomElements(amountOfElements);
            Print();
            Console.WriteLine();
            
            SelectSort();

            Console.WriteLine($"Отсортироваванный массив на {amountOfElements} элементов");
            Print();
            Console.ReadLine();
        }
    }
}