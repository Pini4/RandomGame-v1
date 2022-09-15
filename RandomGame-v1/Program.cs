internal class Program
{
    private static void Main(string[] args)
    {
        Random rand = new Random();
        int a = rand.Next(51);
        int count = 1;

        Console.WriteLine("Компьютер загадал число от 0 до 50. У вас есть очень много попыток, чтобы отгадать число:D.");
        Console.WriteLine("Введите первое число:");

        int b = Convert.ToInt32(Console.ReadLine());

        while (count <= 1000000)
        {
            if (a == b)
            {
                Console.WriteLine($"Поздровляю вы угадали число с {count} попытки!");
                break;
            }
            else
            {
                count++;

                Console.WriteLine($"Вы не угадали число. У вас есть еще попытка :D");
                b = Convert.ToInt32(Console.ReadLine());


            }



        }
    }
}