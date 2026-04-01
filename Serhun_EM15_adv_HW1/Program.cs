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
            else
                return (kilowattsAmount * 1.44);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //Task 
            try
            {
                double target = inputDoubleNum("Введіть цільову кількість кроків: ", 0);
                double factual = inputDoubleNum("Введіть фактичну кількість кроків: ", 0);
                showSeparator("=");
                if (factual < target * 0.7)
                    Console.WriteLine("Треба більше рухатися!");
                else if (factual > target * 2)
                    Console.WriteLine("Ну ти просто машина!");
                else if (factual >= target)
                    Console.WriteLine("Ціль досягнута! Ви молодець!");
                else if (factual < target * 0.9)
                    Console.WriteLine("Ще трохи порухайтесь!");
                else
                    Console.WriteLine("Майже дійшли до цілі!");

            }
            catch (Exception e) {
                throw new Exception(e.Message);
            }
            
            //Task 2
            try
            {
                double amount = inputDoubleNum("Введіть суму покупок: ", 0);
                bool IsLoaltyCard = Convert.ToBoolean(inputDoubleNum("У вас є карта лояльності магазину?(0 - Ні , 1 - Так): ", 0, 1));
                double cashbackPercent = 0,discountPercent = 0;
                showSeparator("=");
                if (amount > 10000)
                    cashbackPercent = 0.05;
                else if (amount > 2000)
                    cashbackPercent = 0.01;
                if (cashbackPercent != 0) 
                    Console.WriteLine("Сума кешбеку: " + amount * cashbackPercent);
                if (IsLoaltyCard)
                {
                    discountPercent = 0.03;
                    if (amount > 20000)
                        discountPercent = 0.05;
                    Console.WriteLine("Сума скидки: " + amount * discountPercent);
                }
                Console.WriteLine("Загальна сума: " + (amount - amount*discountPercent));
            }
            catch (Exception e) {
                throw new Exception(e.Message);
            }
            //Task 3
            try
            {
                double kilowattsAmount = inputDoubleNum("Введіть кількість спожитих кіловать: ", 0);
                showSeparator("=");
                Console.WriteLine($"Загальна вартість {kilowattsAmount}кВт енергії: {costElecricity(kilowattsAmount)}");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }
    }
}
