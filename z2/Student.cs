// Student.cs
using System;

namespace StudentRecords
{
    /// <summary>
    /// Представляет студента с его личными данными и информацией об обучении.
    /// </summary>
    public class Student
    {
        private string фамилия;
        private string имя;
        private string отчество;
        private int курс;
        private string специальность;

        /// <summary>
        /// Публичный конструктор по умолчанию.
        /// Инициализирует объект Student значениями по умолчанию.
        /// Фамилия, имя, отчество, специальность: "Не указано(а)". Курс: 0.
        /// </summary>
        public Student()
        {
            this.фамилия = "Не указано";
            this.имя = "Не указано";
            this.отчество = "Не указано";
            this.курс = 0;
            this.специальность = "Не указана";
        }

        /// <summary>
        /// Публичный конструктор с параметрами для полной инициализации объекта Student.
        /// </summary>
        /// <param name="фамилия">Фамилия студента.</param>
        /// <param name="имя">Имя студента.</param>
        /// <param name="отчество">Отчество студента.</param>
        /// <param name="курс">Курс обучения студента.</param>
        /// <param name="специальность">Специальность студента.</param>
        public Student(string фамилия, string имя, string отчество, int курс, string специальность)
        {
            this.фамилия = фамилия;
            this.имя = имя;
            this.отчество = отчество;
            this.курс = курс;
            this.специальность = специальность;
        }

        // В задании указано "публичные – конструктор И метод отображения".

        /// <summary>
        /// Публичный метод для отображения информации о студенте на экране (консоли).
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine("=== Информация о студенте ===");
            Console.WriteLine($"Фамилия: {this.фамилия}");
            Console.WriteLine($"Имя: {this.имя}");
            Console.WriteLine($"Отчество: {this.отчество}");
            Console.WriteLine($"Курс: {this.курс}");
            Console.WriteLine($"Специальность: {this.специальность}");
            Console.WriteLine("=============================");
        }
    }
}