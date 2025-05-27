namespace WindowsCalculator
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonPlus = new Button();
            buttonMin = new Button();
            buttonClear = new Button();
            button0 = new Button();
            buttonIs = new Button();
            meldingLabel = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(362, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowFrame;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(32, 256);
            button1.Name = "button1";
            button1.Size = new Size(86, 56);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowFrame;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(124, 256);
            button2.Name = "button2";
            button2.Size = new Size(86, 56);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.WindowFrame;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(216, 256);
            button3.Name = "button3";
            button3.Size = new Size(86, 56);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.WindowFrame;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(32, 184);
            button4.Name = "button4";
            button4.Size = new Size(86, 56);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.WindowFrame;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(124, 184);
            button5.Name = "button5";
            button5.Size = new Size(86, 56);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.WindowFrame;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(216, 184);
            button6.Name = "button6";
            button6.Size = new Size(86, 56);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.WindowFrame;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(32, 113);
            button7.Name = "button7";
            button7.Size = new Size(86, 56);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.WindowFrame;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(124, 113);
            button8.Name = "button8";
            button8.Size = new Size(86, 56);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.WindowFrame;
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button9.ForeColor = SystemColors.ButtonHighlight;
            button9.Location = new Point(216, 113);
            button9.Name = "button9";
            button9.Size = new Size(86, 56);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.BackColor = Color.FromArgb(255, 106, 0);
            buttonPlus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonPlus.ForeColor = SystemColors.InfoText;
            buttonPlus.Location = new Point(308, 184);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(86, 56);
            buttonPlus.TabIndex = 11;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMin
            // 
            buttonMin.BackColor = Color.FromArgb(255, 106, 0);
            buttonMin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonMin.ForeColor = SystemColors.InfoText;
            buttonMin.Location = new Point(308, 256);
            buttonMin.Name = "buttonMin";
            buttonMin.Size = new Size(86, 56);
            buttonMin.TabIndex = 12;
            buttonMin.Text = "-";
            buttonMin.UseVisualStyleBackColor = false;
            buttonMin.Click += buttonMin_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(255, 106, 0);
            buttonClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonClear.ForeColor = SystemColors.InfoText;
            buttonClear.Location = new Point(308, 113);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(86, 56);
            buttonClear.TabIndex = 14;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // button0
            // 
            button0.BackColor = SystemColors.WindowFrame;
            button0.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button0.ForeColor = SystemColors.ButtonHighlight;
            button0.Location = new Point(124, 326);
            button0.Name = "button0";
            button0.Size = new Size(86, 56);
            button0.TabIndex = 15;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click;
            // 
            // buttonIs
            // 
            buttonIs.BackColor = Color.FromArgb(255, 106, 0);
            buttonIs.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonIs.ForeColor = SystemColors.InfoText;
            buttonIs.Location = new Point(308, 326);
            buttonIs.Name = "buttonIs";
            buttonIs.Size = new Size(86, 56);
            buttonIs.TabIndex = 16;
            buttonIs.Text = "=";
            buttonIs.UseVisualStyleBackColor = false;
            buttonIs.Click += buttonIs_Click;
            // 
            // meldingLabel
            // 
            meldingLabel.AutoSize = true;
            meldingLabel.Location = new Point(32, 26);
            meldingLabel.Name = "meldingLabel";
            meldingLabel.Size = new Size(42, 25);
            meldingLabel.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 450);
            Controls.Add(meldingLabel);
            Controls.Add(buttonIs);
            Controls.Add(button0);
            Controls.Add(buttonClear);
            Controls.Add(buttonMin);
            Controls.Add(buttonPlus);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonPlus;
        private Button buttonMin;
        private Button buttonClear;
        private Button button0;
        private Button buttonIs;
        private Label meldingLabel;
    }
}
