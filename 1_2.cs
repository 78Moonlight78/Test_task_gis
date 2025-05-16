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
                Console.WriteLine($"Значение: {kvp.Key}    Кол-во: {kvp.Value -1}"); //  -1 потому что мы считаем сколько раз это дубликат, а не общее число
            }
        }
    }

    public static void Main(string[] args)
    {
        int[] arr = { 2, 2, 3, 4, 5, 6, 7, 7, 7, 8, 10 };
        FindAndCountDuplicates(arr); // Вызов функции для нахождения и вывода дубликатов.

        // Дополнительные тесты:
        Console.WriteLine("\nТест 2 (Пустой массив):");
        int[] arr2 = {};
        FindAndCountDuplicates(arr2);

        Console.WriteLine("\nТест 3 (Массив без дубликатов):");
        int[] arr3 = {1, 2, 3, 4, 5};
        FindAndCountDuplicates(arr3);

        Console.WriteLine("\nТест 4 (Массив с несколькими дубликатами):");
        int[] arr4 = {1, 1, 2, 2, 2, 3, 3, 4, 5, 5, 5, 5};
        FindAndCountDuplicates(arr4);
    }
}
