namespace Lab3Matan
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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            LagrangeButton = new RadioButton();
            NewtonButton = new RadioButton();
            SquareButton = new RadioButton();
            PowerTextBox = new TextBox();
            label1 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1.5F;
            formsPlot1.Location = new Point(10, 39);
            formsPlot1.Margin = new Padding(2);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(1144, 681);
            formsPlot1.TabIndex = 0;
            formsPlot1.Load += formsPlot1_Load;
            // 
            // LagrangeButton
            // 
            LagrangeButton.AutoSize = true;
            LagrangeButton.Location = new Point(1246, 174);
            LagrangeButton.Margin = new Padding(2);
            LagrangeButton.Name = "LagrangeButton";
            LagrangeButton.Size = new Size(147, 24);
            LagrangeButton.TabIndex = 1;
            LagrangeButton.TabStop = true;
            LagrangeButton.Text = "Метод Лагранжа";
            LagrangeButton.UseVisualStyleBackColor = true;
            LagrangeButton.CheckedChanged += LagrangeButton_CheckedChanged;
            // 
            // NewtonButton
            // 
            NewtonButton.AutoSize = true;
            NewtonButton.Location = new Point(1246, 215);
            NewtonButton.Margin = new Padding(2);
            NewtonButton.Name = "NewtonButton";
            NewtonButton.Size = new Size(141, 24);
            NewtonButton.TabIndex = 2;
            NewtonButton.TabStop = true;
            NewtonButton.Text = "Метод Ньютона";
            NewtonButton.UseVisualStyleBackColor = true;
            NewtonButton.CheckedChanged += NewtonButton_CheckedChanged;
            // 
            // SquareButton
            // 
            SquareButton.AutoSize = true;
            SquareButton.Location = new Point(1246, 258);
            SquareButton.Margin = new Padding(2);
            SquareButton.Name = "SquareButton";
            SquareButton.Size = new Size(243, 24);
            SquareButton.TabIndex = 3;
            SquareButton.TabStop = true;
            SquareButton.Text = "Метод наименьших квадратов";
            SquareButton.UseVisualStyleBackColor = true;
            SquareButton.CheckedChanged += SquareButton_CheckedChanged;
            // 
            // PowerTextBox
            // 
            PowerTextBox.Location = new Point(1366, 294);
            PowerTextBox.Margin = new Padding(2);
            PowerTextBox.Name = "PowerTextBox";
            PowerTextBox.Size = new Size(67, 27);
            PowerTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1297, 296);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 5;
            label1.Text = "Степень:";
            // 
            // button2
            // 
            button2.Location = new Point(1250, 342);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1241, 406);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1241, 455);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1241, 511);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1241, 562);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1241, 613);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(1249, 659);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 12;
            button1.Text = "График";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1491, 819);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(PowerTextBox);
            Controls.Add(SquareButton);
            Controls.Add(NewtonButton);
            Controls.Add(LagrangeButton);
            Controls.Add(formsPlot1);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private RadioButton LagrangeButton;
        private RadioButton NewtonButton;
        private RadioButton SquareButton;
        private TextBox PowerTextBox;
        private Label label1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;

    }
}