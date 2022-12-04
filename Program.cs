// Create array
Console.WriteLine("Введите количество элементов строкового массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int countLessThenThree = 0;
string[] strArr = new string[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите элемент " + i + ": ");
    strArr[i] = Console.ReadLine();
    if (strArr[i].Length <= 3) countLessThenThree++;
}
// Create new array with <= 3 symbols strings
string[] strArrLessThenThree = new string[countLessThenThree];
int k = 0;
for (int j = 0; j < n; j++)
{
    if (strArr[j].Length <= 3)
    {
        strArrLessThenThree[k] = strArr[j];
        Console.Write(strArrLessThenThree[k] + " ");
        k++;
    }
}