using System;
using System.Collections.Generic;
using System.Linq;

public class DuplicatesFinder
{
    public static void FindAndCountDuplicates(int[] arr)
    {
        // Используем Dictionary для хранения значений и их количества.
        // Ключ - это значение из массива, а значение - это количество повторений.
        Dictionary<int, int> duplicateCounts = new Dictionary<int, int>();

        // Перебираем массив.
        foreach (int num in arr)
        {
            // Если значение уже есть в словаре, увеличиваем счетчик.
            if (duplicateCounts.ContainsKey(num))
            {
                duplicateCounts[num]++;
            }
            // Иначе, добавляем значение в словарь с начальным счетчиком 1.
            else
            {
                duplicateCounts[num] = 1;
            }
        }

        // Выводим дубликаты и их количество.
        foreach (var kvp in duplicateCounts)
        {
            // Выводим только те значения, которые встречались более одного раза (дубликаты).
            if (kvp.Value > 1)
            {
                Console.WriteLine($"Значение: {kvp.Key}    Кол-во: {kvp.Value}");
            }
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        string input = Console.ReadLine();

        // Разбиваем введенную строку на отдельные элементы, разделенные пробелами.
        string[] stringArray = input.Split(' ');

        // Создаем целочисленный массив для хранения введенных чисел.
        int[] intArray = new int[stringArray.Length];

        // Пытаемся преобразовать каждый элемент строки в целое число и сохраняем в массиве.
        // Если преобразование не удается, выводим сообщение об ошибке и завершаем программу.
        try
        {
            for (int i = 0; i < stringArray.Length; i++)
            {
                intArray[i] = int.Parse(stringArray[i]);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введены некорректные данные. Пожалуйста, введите целые числа через пробел.");
            return; // Завершаем программу, если введены некорректные данные.
        }

        FindAndCountDuplicates(intArray); // Вызов функции для нахождения и вывода дубликатов.

    }
}
