// Form1.Designer.cs
namespace RailwayTicketCalculatorApp // Убедитесь, что это ваше пространство имен
{
    partial class RJDBL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelDistance = new Label();
            numericUpDownDistance = new NumericUpDown();
            labelWagonType = new Label();
            comboBoxWagonType = new ComboBox();
            labelDaysBefore = new Label();
            numericUpDownDaysBefore = new NumericUpDown();
            groupBoxServices = new GroupBox();
            checkBoxExtraBaggage = new CheckBox();
            checkBoxShower = new CheckBox();
            checkBoxLinen = new CheckBox();
            checkBoxMeal = new CheckBox();
            buttonCalculate = new Button();
            labelResultInfo = new Label();
            labelResultPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDistance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDaysBefore).BeginInit();
            groupBoxServices.SuspendLayout();
            SuspendLayout();
            // 
            // labelDistance
            // 
            labelDistance.AutoSize = true;
            labelDistance.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDistance.Location = new Point(18, 23);
            labelDistance.Name = "labelDistance";
            labelDistance.Size = new Size(105, 15);
            labelDistance.TabIndex = 10;
            labelDistance.Text = "Расстояние (км):";
            // 
            // numericUpDownDistance
            // 
            numericUpDownDistance.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDownDistance.Location = new Point(192, 22);
            numericUpDownDistance.Margin = new Padding(4);
            numericUpDownDistance.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            numericUpDownDistance.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownDistance.Name = "numericUpDownDistance";
            numericUpDownDistance.Size = new Size(114, 21);
            numericUpDownDistance.TabIndex = 0;
            numericUpDownDistance.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // labelWagonType
            // 
            labelWagonType.AutoSize = true;
            labelWagonType.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelWagonType.Location = new Point(18, 61);
            labelWagonType.Name = "labelWagonType";
            labelWagonType.Size = new Size(74, 15);
            labelWagonType.TabIndex = 11;
            labelWagonType.Text = "Тип вагона:";
            // 
            // comboBoxWagonType
            // 
            comboBoxWagonType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxWagonType.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxWagonType.FormattingEnabled = true;
            comboBoxWagonType.Location = new Point(192, 58);
            comboBoxWagonType.Margin = new Padding(4);
            comboBoxWagonType.Name = "comboBoxWagonType";
            comboBoxWagonType.Size = new Size(176, 23);
            comboBoxWagonType.TabIndex = 1;
            // 
            // labelDaysBefore
            // 
            labelDaysBefore.AutoSize = true;
            labelDaysBefore.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDaysBefore.Location = new Point(18, 98);
            labelDaysBefore.Name = "labelDaysBefore";
            labelDaysBefore.Size = new Size(173, 15);
            labelDaysBefore.TabIndex = 12;
            labelDaysBefore.Text = "Куплен за дней до отправки:";
            // 
            // numericUpDownDaysBefore
            // 
            numericUpDownDaysBefore.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDownDaysBefore.Location = new Point(192, 97);
            numericUpDownDaysBefore.Margin = new Padding(4);
            numericUpDownDaysBefore.Maximum = new decimal(new int[] { 365, 0, 0, 0 });
            numericUpDownDaysBefore.Name = "numericUpDownDaysBefore";
            numericUpDownDaysBefore.Size = new Size(114, 21);
            numericUpDownDaysBefore.TabIndex = 2;
            numericUpDownDaysBefore.Value = new decimal(new int[] { 7, 0, 0, 0 });
            // 
            // groupBoxServices
            // 
            groupBoxServices.Controls.Add(checkBoxExtraBaggage);
            groupBoxServices.Controls.Add(checkBoxShower);
            groupBoxServices.Controls.Add(checkBoxLinen);
            groupBoxServices.Controls.Add(checkBoxMeal);
            groupBoxServices.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxServices.Location = new Point(20, 136);
            groupBoxServices.Margin = new Padding(4);
            groupBoxServices.Name = "groupBoxServices";
            groupBoxServices.Padding = new Padding(4);
            groupBoxServices.Size = new Size(347, 122);
            groupBoxServices.TabIndex = 3;
            groupBoxServices.TabStop = false;
            groupBoxServices.Text = "Дополнительные услуги";
            groupBoxServices.Enter += groupBoxServices_Enter;
            // 
            // checkBoxExtraBaggage
            // 
            checkBoxExtraBaggage.AutoSize = true;
            checkBoxExtraBaggage.Location = new Point(15, 92);
            checkBoxExtraBaggage.Margin = new Padding(4);
            checkBoxExtraBaggage.Name = "checkBoxExtraBaggage";
            checkBoxExtraBaggage.Size = new Size(166, 19);
            checkBoxExtraBaggage.TabIndex = 3;
            checkBoxExtraBaggage.Text = "Дополнительный багаж";
            checkBoxExtraBaggage.UseVisualStyleBackColor = true;
            // 
            // checkBoxShower
            // 
            checkBoxShower.AutoSize = true;
            checkBoxShower.Location = new Point(15, 68);
            checkBoxShower.Margin = new Padding(4);
            checkBoxShower.Name = "checkBoxShower";
            checkBoxShower.Size = new Size(143, 19);
            checkBoxShower.TabIndex = 2;
            checkBoxShower.Text = "Душ (если доступен)";
            checkBoxShower.UseVisualStyleBackColor = true;
            // 
            // checkBoxLinen
            // 
            checkBoxLinen.AutoSize = true;
            checkBoxLinen.Location = new Point(15, 45);
            checkBoxLinen.Margin = new Padding(4);
            checkBoxLinen.Name = "checkBoxLinen";
            checkBoxLinen.Size = new Size(135, 19);
            checkBoxLinen.TabIndex = 1;
            checkBoxLinen.Text = "Постельное белье";
            checkBoxLinen.UseVisualStyleBackColor = true;
            // 
            // checkBoxMeal
            // 
            checkBoxMeal.AutoSize = true;
            checkBoxMeal.Location = new Point(15, 22);
            checkBoxMeal.Margin = new Padding(4);
            checkBoxMeal.Name = "checkBoxMeal";
            checkBoxMeal.Size = new Size(56, 19);
            checkBoxMeal.TabIndex = 0;
            checkBoxMeal.Text = "Обед";
            checkBoxMeal.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCalculate.Location = new Point(88, 272);
            buttonCalculate.Margin = new Padding(4);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(210, 42);
            buttonCalculate.TabIndex = 4;
            buttonCalculate.Text = "Рассчитать стоимость";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelResultInfo
            // 
            labelResultInfo.AutoSize = true;
            labelResultInfo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelResultInfo.Location = new Point(18, 333);
            labelResultInfo.Name = "labelResultInfo";
            labelResultInfo.Size = new Size(151, 15);
            labelResultInfo.TabIndex = 13;
            labelResultInfo.Text = "Итоговая стоимость:";
            // 
            // labelResultPrice
            // 
            labelResultPrice.BorderStyle = BorderStyle.Fixed3D;
            labelResultPrice.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelResultPrice.Location = new Point(192, 330);
            labelResultPrice.Margin = new Padding(4, 0, 4, 0);
            labelResultPrice.Name = "labelResultPrice";
            labelResultPrice.Size = new Size(175, 26);
            labelResultPrice.TabIndex = 14;
            labelResultPrice.Text = "0.00 руб.";
            labelResultPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AcceptButton = buttonCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 378);
            Controls.Add(labelResultPrice);
            Controls.Add(labelResultInfo);
            Controls.Add(buttonCalculate);
            Controls.Add(groupBoxServices);
            Controls.Add(numericUpDownDaysBefore);
            Controls.Add(labelDaysBefore);
            Controls.Add(comboBoxWagonType);
            Controls.Add(labelWagonType);
            Controls.Add(numericUpDownDistance);
            Controls.Add(labelDistance);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Калькулятор стоимости ж/д билета";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownDistance).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDaysBefore).EndInit();
            groupBoxServices.ResumeLayout(false);
            groupBoxServices.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.NumericUpDown numericUpDownDistance;
        private System.Windows.Forms.Label labelWagonType;
        private System.Windows.Forms.ComboBox comboBoxWagonType;
        private System.Windows.Forms.Label labelDaysBefore;
        private System.Windows.Forms.NumericUpDown numericUpDownDaysBefore;
        private System.Windows.Forms.GroupBox groupBoxServices;
        private System.Windows.Forms.CheckBox checkBoxExtraBaggage;
        private System.Windows.Forms.CheckBox checkBoxShower;
        private System.Windows.Forms.CheckBox checkBoxLinen;
        private System.Windows.Forms.CheckBox checkBoxMeal;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelResultInfo;
        private System.Windows.Forms.Label labelResultPrice;
    }
}