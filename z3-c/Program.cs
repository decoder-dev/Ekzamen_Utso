// Program.cs в TypographyConsoleApp
using System;
using TypographyPricerLibrary;

namespace TypographyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор стоимости тиражирования в типографии");
            Console.WriteLine("----------------------------------------------");

            try
            {
                PrintingCostCalculator calculator = new PrintingCostCalculator();

                Console.Write("Введите количество копий: ");
                int copies = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите формат бумаги:");
                int i = 0;
                foreach (PaperFormat formatValue in Enum.GetValues(typeof(PaperFormat)))
                {
                    Console.WriteLine($"{i++}: {formatValue}");
                }
                Console.Write("Ваш выбор (номер): ");
                int formatChoice = int.Parse(Console.ReadLine());
                PaperFormat selectedFormat = (PaperFormat)formatChoice;

                Console.WriteLine("Условие выполнения заказа:");
                Console.WriteLine($"0: {OrderUrgency.StandardNextDay} (На следующий день)");
                Console.WriteLine($"1: {OrderUrgency.UrgentInPresence} (В присутствии заказчика)");
                Console.Write("Ваш выбор (номер): ");
                int urgencyChoice = int.Parse(Console.ReadLine());
                OrderUrgency selectedUrgency = (OrderUrgency)urgencyChoice;

                decimal totalCost = calculator.CalculateTotalCost(copies, selectedFormat, selectedUrgency);
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine($"Ориентировочная стоимость заказа: {totalCost:C2} руб."); // :C2 для формата валюты
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: Введено неверное числовое значение.");
                Console.ResetColor();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ошибка ввода: {ex.ParamName} - {ex.Message.Substring(0, ex.Message.IndexOf('.') + 1)}");
                Console.ResetColor();
            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex) // Общий обработчик
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
                Console.ResetColor();
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}