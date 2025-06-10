// Form1.cs
using System;
using System.Collections.Generic; // Понадобится для словаря коэффициентов
using System.Windows.Forms;

namespace RailwayTicketCalculatorApp
{
    // Перечисление для типов вагонов можно оставить здесь или вынести в отдельный файл, если хотите
    public enum WagonTypeForForm
    {
        Platzkart, // Плацкартный
        Coupe,     // Купе
        Premium    // Повышенной комфортности (Люкс/СВ)
    }

    public partial class RJDBL : Form
    {
        // --- Перемещаем константы и словари прямо в класс формы ---

        // Базовые тарифы и коэффициенты (условные значения)
        private const decimal BASE_PRICE_PER_KM_FORM = 2.5m; // рублей за километр

        // Используем другое имя для словаря, чтобы не конфликтовать, если WagonType определен где-то еще
        private Dictionary<WagonTypeForForm, decimal> _wagonTypeCoefficientsForm = new Dictionary<WagonTypeForForm, decimal>
        {
            { WagonTypeForForm.Platzkart, 1.0m },
            { WagonTypeForForm.Coupe, 1.6m },
            { WagonTypeForForm.Premium, 2.5m }
        };

        // Цены на дополнительные услуги
        private const decimal MEAL_PRICE_FORM = 500m;
        private const decimal LINEN_PRICE_FORM = 200m;
        private const decimal SHOWER_PRICE_FORM = 300m;
        private const decimal EXTRA_BAGGAGE_PRICE_FORM = 400m;


        public RJDBL()
        {
            InitializeComponent(); // Важно! Для инициализации элементов, созданных в дизайнере
            LoadWagonTypes();
        }

        private void LoadWagonTypes()
        {
            // Заполняем ComboBox типами вагонов из Enum
            comboBoxWagonType.DataSource = Enum.GetValues(typeof(WagonTypeForForm));
            comboBoxWagonType.SelectedIndex = 0; // Выбираем первый тип по умолчанию
        }

        // --- Метод расчета стоимости, теперь он является частью Form1 ---
        private decimal CalculateTicketPriceInForm(
            int distanceKm,
            WagonTypeForForm wagonType, // Используем локальное перечисление
            int daysBeforeDeparture,
            bool includeMeal,
            bool includeLinen,
            bool includeShower,
            bool includeExtraBaggage)
        {
            if (distanceKm <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(distanceKm), "Расстояние должно быть положительным числом.");
            }

            // 1. Базовая стоимость по расстоянию
            decimal basePrice = distanceKm * BASE_PRICE_PER_KM_FORM;

            // 2. Учет типа вагона
            if (!_wagonTypeCoefficientsForm.TryGetValue(wagonType, out decimal wagonCoefficient))
            {
                // Эта ошибка маловероятна при использовании Enum из ComboBox, но для полноты
                throw new ArgumentException("Неизвестный тип вагона.", nameof(wagonType));
            }
            decimal priceAfterWagonType = basePrice * wagonCoefficient;

            // 3. Учет времени покупки
            decimal purchaseTimeFactor = 1.0m;
            if (daysBeforeDeparture > 30) // Куплен очень заранее
            {
                purchaseTimeFactor = 0.85m; // Скидка 15%
            }
            else if (daysBeforeDeparture >= 7 && daysBeforeDeparture <= 30) // Стандартно
            {
                purchaseTimeFactor = 1.0m; // Без изменений
            }
            else if (daysBeforeDeparture >= 1 && daysBeforeDeparture < 7) // Незадолго до
            {
                purchaseTimeFactor = 1.10m; // Наценка 10%
            }
            else if (daysBeforeDeparture == 0) // В день отправления
            {
                purchaseTimeFactor = 1.25m; // Наценка 25%
            }
            else // Отрицательное значение дней - ошибка
            {
                throw new ArgumentOutOfRangeException(nameof(daysBeforeDeparture), "Количество дней до отправления не может быть отрицательным.");
            }

            decimal priceAfterPurchaseTime = priceAfterWagonType * purchaseTimeFactor;

            // 4. Стоимость дополнительных услуг
            decimal servicesCost = 0m;
            if (includeMeal) servicesCost += MEAL_PRICE_FORM;
            if (includeLinen) servicesCost += LINEN_PRICE_FORM;
            if (includeShower)
            {
                if (wagonType == WagonTypeForForm.Coupe || wagonType == WagonTypeForForm.Premium)
                {
                    servicesCost += SHOWER_PRICE_FORM;
                }
            }
            if (includeExtraBaggage) servicesCost += EXTRA_BAGGAGE_PRICE_FORM;

            // 5. Итоговая стоимость
            decimal finalPrice = priceAfterPurchaseTime + servicesCost;

            return finalPrice;
        }


        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Сбор данных с формы
                int distance = (int)numericUpDownDistance.Value;
                // Используем локальное перечисление WagonTypeForForm
                WagonTypeForForm wagonType = (WagonTypeForForm)comboBoxWagonType.SelectedItem;
                int daysBefore = (int)numericUpDownDaysBefore.Value;

                bool meal = checkBoxMeal.Checked;
                bool linen = checkBoxLinen.Checked;
                bool shower = checkBoxShower.Checked;
                bool extraBaggage = checkBoxExtraBaggage.Checked;

                // Вызов метода расчета, который теперь находится в этом же классе
                decimal totalPrice = CalculateTicketPriceInForm(
                    distance,
                    wagonType,
                    daysBefore,
                    meal,
                    linen,
                    shower,
                    extraBaggage
                );

                // Отображение результата
                labelResultPrice.Text = $"{totalPrice:C2} руб."; // :C2 для формата валюты
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Ошибка ввода: {ex.ParamName} - {ex.Message.Split(new[] { Environment.NewLine }, StringSplitOptions.None)[0]}", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelResultPrice.Text = "Ошибка";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка конфигурации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelResultPrice.Text = "Ошибка";
            }
            catch (Exception ex) // Общий обработчик для других непредвиденных ошибок
            {
                MessageBox.Show($"Произошла непредвиденная ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelResultPrice.Text = "Ошибка";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxServices_Enter(object sender, EventArgs e)
        {

        }
    }
}