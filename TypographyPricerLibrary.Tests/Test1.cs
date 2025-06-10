// PrintingCostCalculatorTests.cs (или Test1.cs, если вы предпочитаете)
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TypographyPricerLibrary; // Убедитесь, что это пространство имен вашей библиотеки
using System;

namespace TypographyPricerLibrary.Tests // Пространство имен для тестов
{
    [TestClass]
    // public sealed class Test1 // Если нужно именно такое имя класса
    public sealed class PrintingCostCalculatorTests // Рекомендуемое имя класса
    {
        private PrintingCostCalculator _calculator;

        // Метод, который выполняется перед каждым тестовым методом в этом классе.
        // Используется для инициализации общих ресурсов, таких как экземпляр калькулятора.
        [TestInitialize]
        public void Setup()
        {
            _calculator = new PrintingCostCalculator();
        }

        // --- Тесты для метода CalculateTotalCost ---
        // Задание требует "не менее двух тестов на каждый метод"

        [TestMethod]
        public void CalculateTotalCost_A4_10Copies_StandardUrgency_ReturnsCorrectCost()
        {
            // Arrange (Подготовка данных)
            int copies = 10;
            PaperFormat format = PaperFormat.A4; // Базовая цена A4 = 1.00m
            OrderUrgency urgency = OrderUrgency.StandardNextDay; // Без наценки за срочность
            decimal expectedCost = 10 * 1.00m; // Ожидаемый результат: 10.00m

            // Act (Выполнение тестируемого действия)
            decimal actualCost = _calculator.CalculateTotalCost(copies, format, urgency);

            // Assert (Проверка результата)
            Assert.AreEqual(expectedCost, actualCost, "Стоимость для A4, 10 копий, стандартная срочность, рассчитана неверно.");
        }

        [TestMethod]
        public void CalculateTotalCost_A0_5Copies_UrgentInPresence_ReturnsCorrectCostWithSurcharge()
        {
            // Arrange
            int copies = 5;
            PaperFormat format = PaperFormat.A0; // Базовая цена A0 = 15.00m
            OrderUrgency urgency = OrderUrgency.UrgentInPresence; // Коэффициент срочности = 1.5m
            decimal expectedCost = (5 * 15.00m) * 1.5m; // Ожидаемый результат: 75.00m * 1.5 = 112.50m

            // Act
            decimal actualCost = _calculator.CalculateTotalCost(copies, format, urgency);

            // Assert
            Assert.AreEqual(expectedCost, actualCost, "Стоимость для A0, 5 копий, срочно, рассчитана неверно.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))] // Атрибут для проверки ожидаемого исключения
        public void CalculateTotalCost_ZeroCopies_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            int copies = 0; // Недопустимое количество копий
            PaperFormat format = PaperFormat.A5;
            OrderUrgency urgency = OrderUrgency.StandardNextDay;

            // Act
            // При вызове этого метода с copies = 0 должно быть выброшено исключение ArgumentOutOfRangeException
            _calculator.CalculateTotalCost(copies, format, urgency);

            // Assert (не требуется явный Assert, так как ExpectedException проверяет исключение)
        }

        [TestMethod]
        public void CalculateTotalCost_A2_LargeVolume_StandardUrgency_ReturnsCorrectCost()
        {
            // Arrange
            int copies = 1000;
            PaperFormat format = PaperFormat.A2; // Базовая цена A2 = 4.00m
            OrderUrgency urgency = OrderUrgency.StandardNextDay;
            decimal expectedCost = 1000 * 4.00m; // Ожидаемый результат: 4000.00m

            // Act
            decimal actualCost = _calculator.CalculateTotalCost(copies, format, urgency);

            // Assert
            Assert.AreEqual(expectedCost, actualCost, "Стоимость для A2, 1000 копий, стандартно, рассчитана неверно.");
        }


        // --- Тесты для метода GetBasePriceForFormat ---
        // Задание требует "не менее двух тестов на каждый метод"

        [TestMethod]
        public void GetBasePriceForFormat_A5_ReturnsCorrectBasePrice()
        {
            // Arrange
            PaperFormat format = PaperFormat.A5;
            decimal expectedPrice = 0.50m; // Базовая цена для A5

            // Act
            decimal actualPrice = _calculator.GetBasePriceForFormat(format);

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, "Базовая цена для формата A5 возвращена неверно.");
        }

        [TestMethod]
        public void GetBasePriceForFormat_A1_ReturnsCorrectBasePrice()
        {
            // Arrange
            PaperFormat format = PaperFormat.A1;
            decimal expectedPrice = 8.00m; // Базовая цена для A1

            // Act
            decimal actualPrice = _calculator.GetBasePriceForFormat(format);

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, "Базовая цена для формата A1 возвращена неверно.");
        }

        // Если бы был метод с неподдерживаемым форматом, можно было бы добавить тест на исключение:
        // [TestMethod]
        // [ExpectedException(typeof(ArgumentException))]
        // public void GetBasePriceForFormat_InvalidFormat_ThrowsArgumentException()
        // {
        //     // Arrange
        //     PaperFormat invalidFormat = (PaperFormat)99; // Пример недопустимого значения enum
        //
        //     // Act
        //     _calculator.GetBasePriceForFormat(invalidFormat);
        // }
        // Однако, в текущей реализации GetBasePriceForFormat с использованием Dictionary,
        // передача несуществующего значения enum приведет к ошибке еще на этапе TryGetValue,
        // но строгая типизация enum в вызове метода это предотвращает.
        // Если бы метод принимал строку или int, такой тест был бы более актуален.
    }
}