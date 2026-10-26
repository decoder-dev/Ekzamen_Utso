// Form1.cs
using System;
using System.Windows.Forms;
using TypographyPricerLibrary; // Убедитесь, что эта ссылка на вашу библиотеку корректна

namespace TypographyWinFormsApp
{
    public partial class Бурбулятор : Form
    {
        private PrintingCostCalculator _calculator;

        public Бурбулятор()
        {
            InitializeComponent();

            _calculator = new PrintingCostCalculator();
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            if (comboBoxFormat == null)
            {
                MessageBox.Show("comboBoxFormat не инициализирован!", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxUrgency == null)
            {
                MessageBox.Show("comboBoxUrgency не инициализирован!", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Заполнение ComboBox для форматов
            comboBoxFormat.DataSource = Enum.GetValues(typeof(PaperFormat));
            comboBoxFormat.SelectedIndex = 0; // Выбрать первый элемент по умолчанию

            // Заполнение ComboBox для срочности
            var urgencyOptions = new BindingSource();
            urgencyOptions.DataSource = new[] {
                new { Display = "На следующий день", Value = OrderUrgency.StandardNextDay },
                new { Display = "В присутствии заказчика (срочно)", Value = OrderUrgency.UrgentInPresence }
            };
            comboBoxUrgency.DataSource = urgencyOptions;
            comboBoxUrgency.DisplayMember = "Display";
            comboBoxUrgency.ValueMember = "Value";
            comboBoxUrgency.SelectedIndex = 0;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Убедимся, что numericUpDownCopies также инициализирован
                if (numericUpDownCopies == null)
                {
                    MessageBox.Show("numericUpDownCopies не инициализирован!", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int copies = (int)numericUpDownCopies.Value;

                if (comboBoxFormat.SelectedItem == null || comboBoxUrgency.SelectedValue == null)
                {
                    MessageBox.Show("Пожалуйста, выберите все опции.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PaperFormat selectedFormat = (PaperFormat)comboBoxFormat.SelectedItem;
                OrderUrgency selectedUrgency = (OrderUrgency)comboBoxUrgency.SelectedValue;

                decimal totalCost = _calculator.CalculateTotalCost(copies, selectedFormat, selectedUrgency);
                if (labelResultCost == null)
                {
                    MessageBox.Show("labelResultCost не инициализирован!", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                labelResultCost.Text = $"Стоимость: {totalCost:C2} руб.";
            }
            catch (ArgumentOutOfRangeException ex)
            {
                string message = ex.Message.Contains(".") ? ex.Message.Substring(0, ex.Message.IndexOf('.') + 1) : ex.Message;
                MessageBox.Show($"Ошибка ввода: {ex.ParamName} - {message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (labelResultCost != null) labelResultCost.Text = "Ошибка";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (labelResultCost != null) labelResultCost.Text = "Ошибка";
            }
            catch (Exception exGeneral)
            {
                MessageBox.Show($"Произошла ошибка: {exGeneral.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (labelResultCost != null) labelResultCost.Text = "Ошибка";
            }
        }
    }
}