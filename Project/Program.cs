internal class Program
{
    private static void Main(string[] args)
    {
        void Zadacha64()
        {
            //Задайте значения M и N. Напишите рекурсионный метод,
            //который выведет все натуральные числа кратные 3-ём в промежутке от M до N.

            Console.WriteLine("Введите число M");
            int numberM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N");
            int numberN = Convert.ToInt32(Console.ReadLine());

            void Recurcion(int numberM, int numberN)
            {
                if (numberM > numberN)
                {
                    return;
                }
                else if (numberM % 3 == 0)
                {
                    Console.Write(numberM + " ");
                }
                numberM++;
                Recurcion(numberM, numberN);
            }
            Recurcion(numberM, numberN); 
        }
        
        void Zadacha66()
        {

            //Задайте значения M и N. Напишите рекурсионный метод,
            //который найдёт сумму натуральных элементов в промежутке от M до N.

            Console.WriteLine("Введите число M");
            int numberM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N");
            int numberN = Convert.ToInt32(Console.ReadLine());

            void Recurcion(int numberM, int numberN, int sum)
            {
                if (numberM > numberN)
                {
                    Console.WriteLine($"Сумма элементов в промежутке от M до N равна {sum}");
                    return;
                }
                sum = sum + numberM++;
                Recurcion(numberM, numberN, sum);
            }
            Recurcion(numberM, numberN, 0);
        }

        void Zadacha68()
        {
            //Напишите программу вычисления функции Аккермана с помощью рекурсии.
            //Даны два неотрицательных числа m и n.

            Console.WriteLine("Введите число M");
            int numberM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N");
            int numberN = Convert.ToInt32(Console.ReadLine());

            int akkerman = Ack(numberM, numberN);
            int Ack(int numberM, int numberN)
            {
                if (numberM == 0) return numberN + 1;
                else if (numberM > 0 && numberN == 0) return Ack(numberM - 1, 1);
                else if (numberM > 0 && numberN > 0) return Ack(numberM - 1, Ack(numberM, numberN - 1));
                else return numberN + 1;
            }
            Console.WriteLine($"Функция Аккермана: {akkerman}");
        }

        //Zadacha64();
        //Zadacha66();
        Zadacha68();
    }
}
