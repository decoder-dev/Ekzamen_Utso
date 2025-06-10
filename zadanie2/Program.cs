using System;
using StudentApp; // Убедитесь, что это пространство имен совпадает с тем, что в Student.cs

namespace ConsoleStudentProject
{
    /// <summary>
    /// Главный класс программы для демонстрации работы с классом Student.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки (не используются).</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация работы с классом Student:");
            Console.WriteLine();

            // Создание первого объекта класса Student, используя конструктор с полным набором параметров
            Student student1 = new Student("Петров", "Василий", "Сергеевич", 2, "Информационная безопасность");

            // Создание второго объекта класса Student, используя конструктор с частичным набором параметров
            Student student2 = new Student("Сидорова", "Мария", 3);

            // Создание третьего объекта класса Student, используя конструктор по умолчанию
            // (Задание требует "не менее двух объектов", но для демонстрации разных конструкторов лучше три)
            Student student3 = new Student();


            // Примеры использования всех методов класса

            Console.WriteLine("Информация о студенте 1 (создан конструктором с всеми параметрами):");
            student1.DisplayStudentInfo(); // Использование метода отображения
            Console.WriteLine();

            Console.WriteLine("Информация о студенте 2 (создан конструктором с фамилией, именем и курсом):");
            student2.DisplayStudentInfo(); // Использование метода отображения
            Console.WriteLine();

            Console.WriteLine("Информация о студенте 3 (создан конструктором по умолчанию):");
            student3.DisplayStudentInfo(); // Использование метода отображения
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}