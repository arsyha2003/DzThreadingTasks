namespace DzThreadingTasks
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
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 0;
            label1.Text = "Начальная граница";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 51);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 1;
            label2.Text = "Конечная граница";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(190, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(190, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 93);
            button1.Name = "button1";
            button1.Size = new Size(303, 29);
            button1.TabIndex = 4;
            button1.Text = "Start Generating Numbers";
            button1.UseVisualStyleBackColor = true;
            button1.Click += StartGeneratingNumbersButton;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(321, 95);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(12, 128);
            button2.Name = "button2";
            button2.Size = new Size(303, 29);
            button2.TabIndex = 6;
            button2.Text = "Stop Generating Numbers";
            button2.UseVisualStyleBackColor = true;
            button2.Click += StopGeneratingNumbersButton;
            // 
            // button3
            // 
            button3.Location = new Point(12, 163);
            button3.Name = "button3";
            button3.Size = new Size(303, 29);
            button3.TabIndex = 7;
            button3.Text = "Pause Generating Numbers";
            button3.UseVisualStyleBackColor = true;
            button3.Click += PauseGeneratingButtons;
            // 
            // button4
            // 
            button4.Location = new Point(12, 198);
            button4.Name = "button4";
            button4.Size = new Size(303, 29);
            button4.TabIndex = 8;
            button4.Text = "Unpause Generating Numbers";
            button4.UseVisualStyleBackColor = true;
            button4.Click += UnpauseGeneratingButtons;
            // 
            // button5
            // 
            button5.Location = new Point(520, 200);
            button5.Name = "button5";
            button5.Size = new Size(303, 29);
            button5.TabIndex = 12;
            button5.Text = "Unpause Generating Fiboncacci";
            button5.UseVisualStyleBackColor = true;
            button5.Click += UnpauseGeneratingFibonacciButtons;
            // 
            // button6
            // 
            button6.Location = new Point(520, 165);
            button6.Name = "button6";
            button6.Size = new Size(303, 29);
            button6.TabIndex = 11;
            button6.Text = "Pause Generating Fiboncacci";
            button6.UseVisualStyleBackColor = true;
            button6.Click += PauseGeneratingFibonacciButtons;
            // 
            // button7
            // 
            button7.Location = new Point(520, 130);
            button7.Name = "button7";
            button7.Size = new Size(303, 29);
            button7.TabIndex = 10;
            button7.Text = "Stop Generating Fiboncacci";
            button7.UseVisualStyleBackColor = true;
            button7.Click += StopGeneratingFibonacciButton;
            // 
            // button8
            // 
            button8.Location = new Point(520, 95);
            button8.Name = "button8";
            button8.Size = new Size(303, 29);
            button8.TabIndex = 9;
            button8.Text = "Start Generating Fiboncacci";
            button8.TextImageRelation = TextImageRelation.ImageAboveText;
            button8.UseVisualStyleBackColor = true;
            button8.Click += StartGeneratingFibonacciButton;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(840, 95);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(268, 444);
            listBox1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 565);
            Controls.Add(listBox1);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private ListBox listBox1;
    }
}
