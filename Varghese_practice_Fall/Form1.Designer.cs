namespace Varghese_practice_Fall
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
            txtTextInput = new TextBox();
            label3 = new Label();
            txtNumericInput = new TextBox();
            lstOut = new ListBox();
            btnCalculate = new Button();
            btnclear = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(168, 9);
            label1.Name = "label1";
            label1.Size = new Size(250, 24);
            label1.TabIndex = 0;
            label1.Text = "Sample Transaction Form";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 48);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Text Based Input";
            label2.Click += label2_Click;
            // 
            // txtTextInput
            // 
            txtTextInput.Location = new Point(219, 48);
            txtTextInput.Name = "txtTextInput";
            txtTextInput.Size = new Size(100, 23);
            txtTextInput.TabIndex = 2;
            txtTextInput.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 90);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 3;
            label3.Text = "Numeric Based Input";
            // 
            // txtNumericInput
            // 
            txtNumericInput.Location = new Point(219, 87);
            txtNumericInput.Name = "txtNumericInput";
            txtNumericInput.Size = new Size(100, 23);
            txtNumericInput.TabIndex = 4;
            txtNumericInput.TextChanged += textBox1_TextChanged_1;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.Location = new Point(22, 163);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(530, 124);
            lstOut.TabIndex = 5;
            lstOut.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(46, 341);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 81);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate && &Display";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(219, 341);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(104, 81);
            btnclear.TabIndex = 7;
            btnclear.Text = "&Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(404, 341);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(98, 81);
            btnQuit.TabIndex = 8;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 439);
            Controls.Add(btnQuit);
            Controls.Add(btnclear);
            Controls.Add(btnCalculate);
            Controls.Add(lstOut);
            Controls.Add(txtNumericInput);
            Controls.Add(label3);
            Controls.Add(txtTextInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Varghese Sample Program";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTextInput;
        private Label label3;
        private TextBox txtNumericInput;
        private ListBox lstOut;
        private Button btnCalculate;
        private Button btnclear;
        private Button btnQuit;
    }
}
