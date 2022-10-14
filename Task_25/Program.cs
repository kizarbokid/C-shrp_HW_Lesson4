// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Сделать в функции, сделать проверку на отрицательность.
Console.Clear();
string to_input_var(string input_text)
{
    Console.Write($"Введите {input_text} и нажмите Enter: ");
    string result = Console.ReadLine();
    return result;
}
void print(string input_text)
{
    Console.WriteLine(input_text);
}

string input_text = "число A, которое будем возводить в степень";
string input_result = to_input_var(input_text);
int a = int.Parse(input_result);

input_text = "число В (в какую степень возвести число из предыдущего шага?)";
input_result = to_input_var(input_text);
int b = int.Parse(input_result);

if (b < 0)
{
    input_text = "Степень числа не может быть отрицательной!";
    print(input_text);
}
else
{
    double power = Math.Pow(a, b);
    Console.WriteLine($"{a} ^ {b} = {power}");
}