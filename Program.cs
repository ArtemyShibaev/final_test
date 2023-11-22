/* Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
 */


static string[] CountStringAndCreateNewArr(string[] arr)
{
    // Считаем количество строк, удовлетворяющих условию длины
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Trim().Length <= 3)
        {
            count++;
        }
    }

    // Инициализируем новый массив нужной длины
    string[] resultStrings = new string[count];
    
    // Заполняем новый массив подходящими строками
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Trim().Length <= 3)
        {
            resultStrings[index] = arr[i].Trim();
            index++;
        }
    }

    return resultStrings;
}

// Запрашиваем у пользователя ввод строк и сохраняем их в массиве
Console.Write("Введите строки через запятую: ");
string inputString = Console.ReadLine();
string[] inputArray = inputString.Split(',');

// Вызываем функцию для фильтрации строк и создание нового массива
string[] newArray = CountStringAndCreateNewArr(inputArray);

// Вывод результата
Console.WriteLine("Исходный массив строк: " + string.Join(", ", inputArray));
Console.WriteLine("Новый массив строк (длина не более 3 символов): " + string.Join(", ", newArray));