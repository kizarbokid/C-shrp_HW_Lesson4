// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
string to_input_var(string input_text)
{
    Console.Write($"Введите {input_text} и нажмите Enter: ");
    string result = Console.ReadLine();
    return result;
}
void print(int input_text)
{
    Console.WriteLine(input_text);
}

int sum = 0;

string input_text = "число";
string input_result = to_input_var(input_text);

for (int i = 0; i < input_result.Length; i++)
    {sum=sum+(int)Char.GetNumericValue(input_result[i]);}

print(sum);
    