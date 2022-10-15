/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы задаются рандомно (диапазон выбрать самостоятельно) 
Итоговый массив должен содержать в себе суммы цифр числа. Т.е. необходимо подсчитывать суммы цифр 
каждого числа и записывать их в новый массив. */
Console.Clear();
var rand = new Random();
int[] nums_array = new int[8];
int[] sums_array = new int[8];
int sum;
string temp = "";

for (int i = 0; i < 8; i++)
{
    nums_array[i] = rand.Next(1, 1001);
    Console.Write($"{nums_array[i]}---");
    temp = nums_array[i].ToString(); /* временная перем для преобр числа в строку */
    sum = 0; /* занулить сумму цифр числа */
    for (int j = 0; j < temp.Length; j++)
        {sum = sum + (int)Char.GetNumericValue(temp[j]);}
    sums_array[i]=sum;
    Console.WriteLine(sums_array[i]);
}
Console.WriteLine();
/* temp=nums_array[2].ToString();
Console.WriteLine(temp.Length);

Console.WriteLine((int)Char.GetNumericValue(temp[0])+(int)Char.GetNumericValue(temp[1])); */