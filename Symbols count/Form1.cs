using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CharacterCountApp
{
    public partial class Form1 : Form
    {
        private TextBox InputTextBox;
        private Button CountCharactersButton;
        private ListBox ResultListBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.CountCharactersButton = new System.Windows.Forms.Button();
            this.ResultListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(30, 30);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(200, 22);
            this.InputTextBox.TabIndex = 0;
            // 
            // CountCharactersButton
            // 
            this.CountCharactersButton.Location = new System.Drawing.Point(30, 70);
            this.CountCharactersButton.Name = "CountCharactersButton";
            this.CountCharactersButton.Size = new System.Drawing.Size(120, 30);
            this.CountCharactersButton.TabIndex = 3;
            this.CountCharactersButton.Text = "Підрахувати";
            this.CountCharactersButton.Click += new System.EventHandler(this.CountCharactersButton_Click);
            // 
            // ResultListBox
            // 
            this.ResultListBox.FormattingEnabled = true;
            this.ResultListBox.ItemHeight = 16;
            this.ResultListBox.Location = new System.Drawing.Point(30, 120);
            this.ResultListBox.Name = "ResultListBox";
            this.ResultListBox.Size = new System.Drawing.Size(300, 196);
            this.ResultListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "© 2024 Tolia Driapak";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(360, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultListBox);
            this.Controls.Add(this.CountCharactersButton);
            this.Controls.Add(this.InputTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Character Count App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CountCharactersButton_Click(object sender, EventArgs e)
        {
            string input = InputTextBox.Text;
            if (!string.IsNullOrEmpty(input))
            {
                // Створюємо словник для збереження кількості входжень кожного символу
                Dictionary<char, int> charCount = new Dictionary<char, int>();

                // Перебираємо кожен символ у введеному рядку
                foreach (char c in input)
                {
                    // Перевіряємо, чи символ уже є у словнику
                    if (charCount.ContainsKey(c))
                    {
                        // Якщо так, збільшуємо кількість входжень на 1
                        charCount[c]++;
                    }
                    else
                    {
                        // Якщо символу немає у словнику, додаємо його з кількістю 1
                        charCount.Add(c, 1);
                    }
                }

                // Очищаємо список результатів перед виведенням нових даних
                ResultListBox.Items.Clear();

                // Додаємо в список результатів кожен символ та його кількість входжень
                foreach (var entry in charCount)
                {
                    ResultListBox.Items.Add($"Символ '{entry.Key}': {entry.Value} разів");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть рядок для підрахунку символів.");
            }
        }

        private Label label1;
    }
}
