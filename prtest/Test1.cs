// Test1.cs (или PrintingCostCalculatorTests.cs)
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TypographyPricerLibrary;
using System;

namespace prtest.Tests
{
    [TestClass]
    public class PrintingCostCalculatorTests
    {
        // Используем конкретный тип из вашей библиотеки
        private PrintingCostCalculator _calculatorInstance = null!;

        [TestInitialize]
        public void InitializeTest()
        {
            // Создаем экземпляр вашего калькулятора
            _calculatorInstance = new PrintingCostCalculator();
        }

        // --- Тесты для метода CalculateTotalCost ---

        [TestMethod]
        public void CalculateTotalCost_A4_10Copies_Standard_ReturnsCorrectValue()
        {
            // Arrange
            int copies = 10;
            PaperFormat format = PaperFormat.A4;
            OrderUrgency urgency = OrderUrgency.StandardNextDay;
            // Ожидаемая стоимость: 10 копий * 1.00 (цена A4) * 1.0 (наценка стандарт) = 10.00
            decimal expectedCost = 10.00m;

            // Act
            decimal actualCost = _calculatorInstance.CalculateTotalCost(copies, format, urgency);

            // Assert
            Assert.AreEqual(expectedCost, actualCost, "Стоимость A4, 10 копий, стандартно - неверна.");
        }

        [TestMethod]
        public void CalculateTotalCost_A0_5Copies_UrgentInPresence_ReturnsCorrectValueWithSurcharge()
        {
            // Arrange
            int copies = 5;
            PaperFormat format = PaperFormat.A0;
            OrderUrgency urgency = OrderUrgency.UrgentInPresence;
            // Ожидаемая стоимость: 5 копий * 15.00 (цена A0) * 1.5 (наценка срочно в присутствии) = 112.50
            decimal expectedCost = 112.50m;

            // Act
            decimal actualCost = _calculatorInstance.CalculateTotalCost(copies, format, urgency);

            // Assert
            Assert.AreEqual(expectedCost, actualCost, "Стоимость A0, 5 копий, срочно в присутствии - неверна.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalculateTotalCost_ZeroCopies_ThrowsException()
        {
            // Arrange
            int copies = 0;
            PaperFormat format = PaperFormat.A5;
            OrderUrgency urgency = OrderUrgency.StandardNextDay;

            // Act
            // Этот вызов должен выбросить ArgumentOutOfRangeException
            _calculatorInstance.CalculateTotalCost(copies, format, urgency);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalculateTotalCost_NegativeCopies_ThrowsException()
        {
            // Arrange
            int copies = -1;
            PaperFormat format = PaperFormat.A5;
            OrderUrgency urgency = OrderUrgency.StandardNextDay;

            // Act
            // Этот вызов должен выбросить ArgumentOutOfRangeException
            _calculatorInstance.CalculateTotalCost(copies, format, urgency);
        }

        // --- Тесты для метода GetBasePriceForFormat ---

        [TestMethod]
        public void GetBasePriceForFormat_A4_ReturnsCorrectPrice()
        {
            // Arrange
            PaperFormat format = PaperFormat.A4;
            decimal expectedPrice = 1.00m; // Базовая цена для A4 согласно реализации

            // Act
            decimal actualPrice = _calculatorInstance.GetBasePriceForFormat(format);

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, "Базовая цена для A4 - неверна.");
        }

        [TestMethod]
        public void GetBasePriceForFormat_A0_ReturnsCorrectPrice()
        {
            // Arrange
            PaperFormat format = PaperFormat.A0;
            decimal expectedPrice = 15.00m; // Базовая цена для A0 согласно реализации

            // Act
            decimal actualPrice = _calculatorInstance.GetBasePriceForFormat(format);

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, "Базовая цена для A0 - неверна.");
        }
    }
}