internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите пятизначное число: ");
        int num = int.Parse(Console.ReadLine());

        if (num < 10000 || num > 99999)
        {
            Console.WriteLine("Ошибка.Ваше число не пятизначное.");
            Environment.Exit(0);
        }

        if (num < 0)
        {
            Console.WriteLine("Ваше число не полиндром.");
        }

        string num_str = num.ToString();

        if (num_str[0] + num_str[1] == num_str[4] + num_str[3])
        {
            Console.WriteLine("Ваше число полиндром");
        }
        else
        {
            Console.WriteLine("Ваше число не полиндром");
        }
    }
}