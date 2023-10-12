namespace PermutationShifr
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            choiseMethod = new ComboBox();
            label3 = new Label();
            encrypt = new Button();
            labelDopYsl = new Label();
            dopYsl = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(280, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 27);
            label1.TabIndex = 0;
            label1.Text = "Что надо шифровать";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 35);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(57, 111);
            label2.Name = "label2";
            label2.Size = new Size(225, 27);
            label2.TabIndex = 2;
            label2.Text = "Способ шифрования";
            // 
            // choiseMethod
            // 
            choiseMethod.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            choiseMethod.FormattingEnabled = true;
            choiseMethod.Items.AddRange(new object[] { "простой одинарной перестановки", "блочной одинарной перестановки", "табличной маршрутной перестановки", "вертикальной перестановки", "поворотной решетки", "магический квадрат (размер квадрата - 4х4)", "двойной перестановки", "шифра «Перекресток»", "шифры с использованием треугольника" });
            choiseMethod.Location = new Point(12, 152);
            choiseMethod.Name = "choiseMethod";
            choiseMethod.Size = new Size(316, 35);
            choiseMethod.TabIndex = 3;
            choiseMethod.SelectedIndexChanged += choiseMethod_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(268, 220);
            label3.Name = "label3";
            label3.Size = new Size(244, 27);
            label3.TabIndex = 4;
            label3.Text = "Результат шифрования";
            // 
            // encrypt
            // 
            encrypt.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            encrypt.Location = new Point(309, 397);
            encrypt.Name = "encrypt";
            encrypt.Size = new Size(164, 41);
            encrypt.TabIndex = 5;
            encrypt.Text = "Зашифровать";
            encrypt.UseVisualStyleBackColor = true;
            encrypt.Click += encrypt_Click;
            // 
            // labelDopYsl
            // 
            labelDopYsl.AutoSize = true;
            labelDopYsl.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelDopYsl.Location = new Point(483, 111);
            labelDopYsl.Name = "labelDopYsl";
            labelDopYsl.Size = new Size(269, 27);
            labelDopYsl.TabIndex = 6;
            labelDopYsl.Text = "Дополнительные данные";
            // 
            // dopYsl
            // 
            dopYsl.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dopYsl.Location = new Point(451, 152);
            dopYsl.Name = "dopYsl";
            dopYsl.Size = new Size(337, 35);
            dopYsl.TabIndex = 7;
            dopYsl.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dopYsl);
            Controls.Add(labelDopYsl);
            Controls.Add(encrypt);
            Controls.Add(label3);
            Controls.Add(choiseMethod);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ComboBox choiseMethod;
        private Label label3;
        private Button encrypt;
        private Label labelDopYsl;
        private TextBox dopYsl;
    }
}