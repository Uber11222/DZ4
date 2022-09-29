int [] array = new int [8];
for (int i = 0; i < array.Length; i++)
{
     Console.WriteLine("Введите следующее число массива");
    array[i] =  Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ", ");
}