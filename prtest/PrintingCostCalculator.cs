// PrintingCostCalculator.cs
using System;

namespace prtest
{
    public enum PaperFormat
    {
        A0,
        A1,
        A2,
        A3,
        A4,
        A5
    }

    public enum OrderUrgency
    {
        StandardNextDay,    // Стандартно, на следующий день
        UrgentSameDay,      // Срочно, сегодня
        UrgentInPresence    // Срочно, в присутствии клиента
    }

    public class PrintingCostCalculator
    {
        public decimal GetBasePriceForFormat(PaperFormat format)
        {
            switch (format)
            {
                case PaperFormat.A0:
                    return 15.00m;
                case PaperFormat.A1:
                    return 10.00m; // Пример
                case PaperFormat.A2:
                    return 5.00m;  // Пример
                case PaperFormat.A3:
                    return 2.50m;  // Пример
                case PaperFormat.A4:
                    return 1.00m;
                case PaperFormat.A5:
                    return 0.50m;  // Пример
                default:
                    throw new ArgumentOutOfRangeException(nameof(format), "Неподдерживаемый формат бумаги.");
            }
        }

        // Метод для расчета общей стоимости
        public decimal CalculateTotalCost(int copies, PaperFormat format, OrderUrgency urgency)
        {
            if (copies <= 1)
            {
                throw new ArgumentOutOfRangeException(nameof(copies), "Количество копий должно быть положительным числом.");
            }

            decimal basePricePerCopy = GetBasePriceForFormat(format);
            decimal totalBaseCost = copies * basePricePerCopy;
            decimal surchargeMultiplier = 1.0m; // По умолчанию нет наценки

            switch (urgency)
            {
                case OrderUrgency.StandardNextDay:
                    surchargeMultiplier = 1.0m;
                    break;
                case OrderUrgency.UrgentSameDay:
                    surchargeMultiplier = 1.25m; // Пример наценки 25%
                    break;
                case OrderUrgency.UrgentInPresence:
                    surchargeMultiplier = 1.5m;  // Пример наценки 50%
                    break;
                default:
                    // Можно выбросить исключение для неизвестной срочности
                    throw new ArgumentOutOfRangeException(nameof(urgency), "Неподдерживаемый тип срочности заказа.");
            }

            return totalBaseCost * surchargeMultiplier;
        }
    }
}