namespace Lesson_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            string Number1 = Console.ReadLine();
            int intNumber1 = int.Parse(Number1);
            Console.WriteLine("Введите второе число:");
            string Number2 = Console.ReadLine();
            int intNumber2 = int.Parse(Number2);
            Console.WriteLine("Допустимые арифметические действия:");
            Console.WriteLine("+ сложение");
            Console.WriteLine("- вычитание");
            Console.WriteLine("* умножение");
            Console.WriteLine("/ деление");
            Console.WriteLine();
            Console.WriteLine("Выберите действие:");
            string action = Console.ReadLine();
            string strToPrint = $"{intNumber1} {action} {intNumber2} = ";
            if (action == "+")
                strToPrint += Convert.ToString(intNumber1 + intNumber2);
            else if (action == "-")
                strToPrint += Convert.ToString(intNumber1 - intNumber2);
            else if (action == "/")
                strToPrint += ((double)intNumber1 / intNumber2).ToString();
            else if (action == "*")
                strToPrint += (intNumber1 * intNumber2).ToString();
            else Console.WriteLine("Некорректное действие!");
            Console.WriteLine(strToPrint);
        }
    }
}
