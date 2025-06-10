// Enums.cs (в проекте PrintingCostCalculator)
namespace TypographyPricerLibrary
{
    /// <summary>
    /// Определяет доступные форматы бумаги для тиражирования.
    /// </summary>
    public enum PaperFormat
    {
        A5,
        A4,
        A2,
        A1,
        A0
    }

    /// <summary>
    /// Определяет условия выполнения заказа (срочность).
    /// </summary>
    public enum OrderUrgency
    {
        /// <summary>
        /// Стандартное выполнение (на следующий день).
        /// </summary>
        StandardNextDay,
        /// <summary>
        /// Срочное выполнение (в присутствии заказчика).
        /// </summary>
        UrgentInPresence
    }
}