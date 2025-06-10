// Form1.Designer.cs

namespace TypographyWinFormsApp // Замените на ваше пространство имен, если оно другое
{
    partial class Бурбулятор
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
            labelCopiesPrompt = new Label();
            numericUpDownCopies = new NumericUpDown();
            labelFormatPrompt = new Label();
            comboBoxFormat = new ComboBox();
            labelUrgencyPrompt = new Label();
            comboBoxUrgency = new ComboBox();
            buttonCalculate = new Button();
            labelResultTitle = new Label();
            labelResultCost = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCopies).BeginInit();
            SuspendLayout();
            // 
            // labelCopiesPrompt
            // 
            labelCopiesPrompt.AutoSize = true;
            labelCopiesPrompt.Location = new Point(22, 28);
            labelCopiesPrompt.Name = "labelCopiesPrompt";
            labelCopiesPrompt.Size = new Size(112, 15);
            labelCopiesPrompt.TabIndex = 0;
            labelCopiesPrompt.Text = "Количество копий:";
            // 
            // numericUpDownCopies
            // 
            numericUpDownCopies.Location = new Point(149, 26);
            numericUpDownCopies.Margin = new Padding(4);
            numericUpDownCopies.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownCopies.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCopies.Name = "numericUpDownCopies";
            numericUpDownCopies.Size = new Size(105, 23);
            numericUpDownCopies.TabIndex = 1;
            numericUpDownCopies.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelFormatPrompt
            // 
            labelFormatPrompt.AutoSize = true;
            labelFormatPrompt.Location = new Point(22, 66);
            labelFormatPrompt.Name = "labelFormatPrompt";
            labelFormatPrompt.Size = new Size(96, 15);
            labelFormatPrompt.TabIndex = 2;
            labelFormatPrompt.Text = "Формат бумаги:";
            // 
            // comboBoxFormat
            // 
            comboBoxFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFormat.FormattingEnabled = true;
            comboBoxFormat.Location = new Point(149, 63);
            comboBoxFormat.Margin = new Padding(4);
            comboBoxFormat.Name = "comboBoxFormat";
            comboBoxFormat.Size = new Size(158, 23);
            comboBoxFormat.TabIndex = 3;
            // 
            // labelUrgencyPrompt
            // 
            labelUrgencyPrompt.AutoSize = true;
            labelUrgencyPrompt.Location = new Point(22, 103);
            labelUrgencyPrompt.Name = "labelUrgencyPrompt";
            labelUrgencyPrompt.Size = new Size(128, 15);
            labelUrgencyPrompt.TabIndex = 4;
            labelUrgencyPrompt.Text = "Условие выполнения:";
            // 
            // comboBoxUrgency
            // 
            comboBoxUrgency.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUrgency.FormattingEnabled = true;
            comboBoxUrgency.Location = new Point(149, 100);
            comboBoxUrgency.Margin = new Padding(4);
            comboBoxUrgency.Name = "comboBoxUrgency";
            comboBoxUrgency.Size = new Size(193, 23);
            comboBoxUrgency.TabIndex = 5;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCalculate.Location = new Point(96, 145);
            buttonCalculate.Margin = new Padding(4);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(175, 33);
            buttonCalculate.TabIndex = 6;
            buttonCalculate.Text = "Рассчитать стоимость";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelResultTitle
            // 
            labelResultTitle.AutoSize = true;
            labelResultTitle.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelResultTitle.Location = new Point(22, 197);
            labelResultTitle.Name = "labelResultTitle";
            labelResultTitle.Size = new Size(134, 13);
            labelResultTitle.TabIndex = 7;
            labelResultTitle.Text = "Итоговая стоимость:";
            // 
            // labelResultCost
            // 
            labelResultCost.BorderStyle = BorderStyle.Fixed3D;
            labelResultCost.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelResultCost.Location = new Point(149, 194);
            labelResultCost.Margin = new Padding(4, 0, 4, 0);
            labelResultCost.Name = "labelResultCost";
            labelResultCost.Size = new Size(158, 23);
            labelResultCost.TabIndex = 8;
            labelResultCost.Text = "0.00 руб.";
            labelResultCost.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Бурбулятор
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 244);
            Controls.Add(labelResultCost);
            Controls.Add(labelResultTitle);
            Controls.Add(buttonCalculate);
            Controls.Add(comboBoxUrgency);
            Controls.Add(labelUrgencyPrompt);
            Controls.Add(comboBoxFormat);
            Controls.Add(labelFormatPrompt);
            Controls.Add(numericUpDownCopies);
            Controls.Add(labelCopiesPrompt);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Бурбулятор";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Калькулятор стоимости тиража";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCopies).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCopiesPrompt;
        private System.Windows.Forms.NumericUpDown numericUpDownCopies;
        private System.Windows.Forms.Label labelFormatPrompt;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.Label labelUrgencyPrompt;
        private System.Windows.Forms.ComboBox comboBoxUrgency;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelResultTitle;
        private System.Windows.Forms.Label labelResultCost;
    }
}