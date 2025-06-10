// PrintingCostCalculator.cs
using System;
using System.Collections.Generic;

namespace TypographyPricerLibrary
{
    /// <summary>
    /// Предоставляет методы для расчета стоимости тиражирования материалов.
    /// </summary>
    public class PrintingCostCalculator
    {
        // Базовые цены за одну копию для каждого формата (условные цены)
        private readonly Dictionary<PaperFormat, decimal> _basePricePerCopy = new Dictionary<PaperFormat, decimal>
        {
            { PaperFormat.A5, 0.50m }, // 50 копеек за А5
            { PaperFormat.A4, 1.00m }, // 1 рубль за А4
            { PaperFormat.A2, 4.00m }, // 4 рубля за А2
            { PaperFormat.A1, 8.00m }, // 8 рублей за А1
            { PaperFormat.A0, 15.00m } // 15 рублей за А0
        };

        // Коэффициент наценки за срочность (например, +50%)
        private const decimal URGENCY_SURCHARGE_FACTOR = 1.5m;

        /// <summary>
        /// Вычисляет общую стоимость тиражирования материалов.
        /// </summary>
        /// <param name="numberOfCopies">Количество копий. Должно быть больше 0.</param>
        /// <param name="format">Формат бумаги (A5, A4, A2, A1, A0).</param>
        /// <param name="urgency">Условие выполнения заказа (в присутствии заказчика или на следующий день).</param>
        /// <returns>Общая стоимость тиражирования в рублях.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Выбрасывается, если количество копий меньше или равно 0.</exception>
        /// <exception cref="ArgumentException">Выбрасывается, если указан неизвестный формат бумаги.</exception>
        public decimal CalculateTotalCost(int numberOfCopies, PaperFormat format, OrderUrgency urgency)
        {
            if (numberOfCopies <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numberOfCopies), "Количество копий должно быть больше нуля.");
            }

            if (!_basePricePerCopy.TryGetValue(format, out decimal basePrice))
            {
                // Эта проверка больше для случая, если бы формат передавался строкой,
                // с enum такая ошибка маловероятна, но для полноты.
                throw new ArgumentException("Указан неизвестный или неподдерживаемый формат бумаги.", nameof(format));
            }

            decimal totalCost = numberOfCopies * basePrice;

            if (urgency == OrderUrgency.UrgentInPresence)
            {
                totalCost *= URGENCY_SURCHARGE_FACTOR;
            }

            return totalCost;
        }

        /// <summary>
        /// Получает базовую цену за одну копию для указанного формата.
        /// (Этот метод добавлен для демонстрации тестирования нескольких методов, если потребуется)
        /// </summary>
        /// <param name="format">Формат бумаги.</param>
        /// <returns>Базовая цена за одну копию.</returns>
        /// <exception cref="ArgumentException">Если формат не найден.</exception>
        public decimal GetBasePriceForFormat(PaperFormat format)
        {
            if (_basePricePerCopy.TryGetValue(format, out decimal basePrice))
            {
                return basePrice;
            }
            throw new ArgumentException("Указан неизвестный или неподдерживаемый формат бумаги.", nameof(format));
        }
    }
}