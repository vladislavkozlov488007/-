// Итоговая задача. Напишите программу, которая из имеющегося массива строк форvирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо
// задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше
// обойтись исключительно массивами.

string[] firstArray = {"Hello", "Second", "Rainbow", "No", "Egg"};
string[] secondArray = new string [firstArray.Length];

FindWords(firstArray, secondArray);
System.Console.WriteLine($"Наш массив состоит из слов: ");
PrintArray(firstArray);
System.Console.WriteLine($"На выходе получаем: ");
PrintArray(secondArray);

void FindWords(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for(int i = 0; i < firstArray.Length; i++)
        if(firstArray[i].Length <= 3)
        {
            secondArray[count] = firstArray[i];
            count++;
        }
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++) 
        System.Console.Write($"{array[i]} ");
    System.Console.WriteLine();
}

