// Create array
Console.WriteLine("Введите количество элементов строкового массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string [] strArr = new string[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите элемент "+i+": ");
    strArr[i] = Console.ReadLine();
}