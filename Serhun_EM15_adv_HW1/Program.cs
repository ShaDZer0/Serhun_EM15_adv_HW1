using System;
using System.Linq;
using System.Text;

namespace Serhun_EM15_adv_HW1
{
    internal class Program
    {
        static void errorMessage(string message)
        {
            throw new Exception(message);
        }
        static void showSeparator(string separator) {
            Console.WriteLine(string.Concat(Enumerable.Repeat(separator, 40)));
        }
        static double inputDoubleNum(string message)
        {
            Console.Write(message);
            return Convert.ToDouble(Console.ReadLine());
        }
        static double inputDoubleNum(string message, double min)
        {
            double value = inputDoubleNum(message);
            if (value < min){
                errorMessage("Error! Число не може бути меньшим за " + min);
            }
            return value;
        }
        static double inputDoubleNum(string message, int min, int max)
        {
            double value = inputDoubleNum(message);
            if (value < min || value > max) {
                errorMessage($"Error! Число повинно бути більшим за {min} та меншим за {max}");
            }
            return value;
        }
        static double costElecricity(double kilowattsAmount)
        {
            if (kilowattsAmount > 600)
                return (kilowattsAmount - 600) * 1.92 +costElecricity(600);
            else if (kilowattsAmount > 100)
                return (kilowattsAmount - 100) * 1.68 +costElecricity(100);
            else if (kilowattsAmount > 0)
                return (kilowattsAmount * 1.44);
            else
                return 0;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //Task 1
            /*
            try
            {
                double target = inputDoubleNum("Введіть цільову кількість кроків: ", 0);
                double factual = inputDoubleNum("Введіть фактичну кількість кроків: ", 0);
                showSeparator("=");
                if (factual < target * 0.7)
                    Console.WriteLine("Треба більше рухатися!");
                else if (factual >= target * 0.7 && factual < target * 0.9)
                    Console.WriteLine("Ще трохи порухайтесь!");
                else if (factual >= target * 0.9 && factual < factual * 0.99)
                    Console.WriteLine("Майже дійшли до цілі!");
                else if (factual >= target)
                    Console.WriteLine("Ціль досягнута! Ви молодець!");
                else if (factual > target * 2)
                    Console.WriteLine("Ну ти просто машина!");
            }
            catch (Exception e) {
                errorMessage(e.Message);
            }
            */
            //Task 2
            /*
            try
            {
                double amount = inputDoubleNum("Введіть суму покупок: ", 0);
                bool IsLoaltyCard = Convert.ToBoolean(inputDoubleNum("У вас є карта лояльності магазину?(0 - Ні , 1 - Так): ", 0, 1));
                double cashback = 0,discount = 0;
                if (amount > 10000)
                    cashback = amount * 0.05;
                else if (amount > 2000)
                    cashback = amount * 0.01;
                if (IsLoaltyCard)
                {
                    discount = amount * 0.03;
                    if (amount > 20000)
                        discount = amount * 0.05;
                }
                showSeparator("=");
                Console.WriteLine($"Сума кешбеку: {cashback}\nСума скидки: {discount}\nЗагальна сума: {amount-discount}");
            }
            catch (Exception e) {
            
                errorMessage(e.Message);
            }
            */
            //Task 3
            /*
            try
            {
                double kilowattsAmount = inputDoubleNum("Введіть кількість спожитих кіловать: ", 0);
                showSeparator("=");
                Console.WriteLine($"Загальна вартість {kilowattsAmount}кВт енергії: {costElecricity(kilowattsAmount)}");
            }
            catch (Exception e)
            {
                errorMessage(e.Message);
            }
            */
        }
    }
}
