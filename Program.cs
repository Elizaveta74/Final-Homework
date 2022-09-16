/* 
Задача: Написать программу, которая из имеющегося массива строк формирует
новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

1. Создаем запрос у пользователя размера массива.
2. Проводим проверку, что введено числовое значение и что размер массива > 0.
3. Инициализируем пустой строковый массив с указанным размером.
4. Заполняем массив в цикле. Считаем количество строковых элементов,
удовлетворяющих условию задачи (т.е количество элементов итогового массива).
5. Инициализируем итоговый массив.
6. Цикл по начальному массиву с проверкой длины каждого элемента.
Заполняем итоговый массив.
7. Выводим начальный и итоговый массивы на экран.
*/



Console.Write("Введите размер массива: ");
string enteredValue = Console.ReadLine();

bool initialArraySizeConvertedOk = int.TryParse(enteredValue, out int initialArraySize);
if (!initialArraySizeConvertedOk)
{
    Console.WriteLine("Ожидалось числовое значение");
    return;
}

if (initialArraySize <= 0)
{
    Console.WriteLine("Ожидалось положительное целое число");
    return; 
}

string[] initialArray = new string[initialArraySize];
int resultArraySize = 0;
const int maxAllowedElementLength = 3;

for (int i = 0; i < initialArraySize; i++)
{
    Console.Write($"Введите элемент массива[{i}]: ");
    string elementValue = Console.ReadLine();
    initialArray[i] = elementValue;
    if (elementValue.Length <= maxAllowedElementLength)
    {
        resultArraySize++;
    }
}


string[] resultArray = new string[resultArraySize];
int resultArrayIndex = 0;
for (int i = 0; i < initialArraySize; i++)
{
    if (initialArray[i].Length < maxAllowedElementLength)
    {
        resultArray[resultArrayIndex] = initialArray[i];
        resultArrayIndex++;
    }
}

string initialArrayAsString = string.Join(", ", initialArray);
string resultArrayAsString = string.Join(", ", resultArray);

string finalMessage = $"[{initialArrayAsString}] → [{resultArrayAsString}]";
Console.WriteLine(finalMessage);

