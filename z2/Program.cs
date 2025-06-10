// Program.cs
using System;
using StudentRecords;

namespace StudentConsoleApp
{
    /// <summary>
    /// Главный класс программы для демонстрации работы с классом Student.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в консольное приложение.
        /// </summary>
        /// <param name="args">Аргументы командной строки (не используются в данном примере).</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2: Демонстрация работы с классом Student");
            Console.WriteLine();

            // 1. Создание не менее двух объектов класса, используя разные конструкторы.

            // Создание первого объекта Student с использованием конструктора с параметрами.
            Console.WriteLine("Создание студента #1 (с использованием конструктора с параметрами):");
            Student student1 = new Student("Иванов", "Иван", "Иванович", 2, "Программная инженерия");

            // Создание второго объекта Student с использованием конструктора по умолчанию.
            Console.WriteLine("Создание студента #2 (с использованием конструктора по умолчанию):");
            Student student2 = new Student();

            Console.WriteLine();

            // 2. использование всех методов класса.
            // "Все методы" в данном контексте - это конструкторы
            // и метод отображения DisplayInfo().

            Console.WriteLine("Пример использования метода DisplayInfo() для студента #1:");
            student1.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Пример использования метода DisplayInfo() для студента #2:");
            student2.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Демонстрация завершена. Нажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}