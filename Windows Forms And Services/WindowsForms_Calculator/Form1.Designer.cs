
namespace WindowsForms_Calculator
{
    partial class Form1
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
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.Addition = new System.Windows.Forms.RadioButton();
            this.Subtraction = new System.Windows.Forms.RadioButton();
            this.Multiplication = new System.Windows.Forms.RadioButton();
            this.Division = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.input1.Location = new System.Drawing.Point(50, 50);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(157, 38);
            this.input1.TabIndex = 0;
            this.input1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.input1.Click += new System.EventHandler(this.btn1);
            // 
            // input2
            // 
            this.input2.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.input2.Location = new System.Drawing.Point(50, 131);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(157, 38);
            this.input2.TabIndex = 1;
            this.input2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.input2.Click += new System.EventHandler(this.btn2);
            // 
            // Addition
            // 
            this.Addition.AutoSize = true;
            this.Addition.Location = new System.Drawing.Point(276, 39);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(63, 17);
            this.Addition.TabIndex = 2;
            this.Addition.TabStop = true;
            this.Addition.Text = "Addition";
            this.Addition.UseVisualStyleBackColor = true;
            // 
            // Subtraction
            // 
            this.Subtraction.AutoSize = true;
            this.Subtraction.Location = new System.Drawing.Point(276, 80);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(79, 17);
            this.Subtraction.TabIndex = 3;
            this.Subtraction.TabStop = true;
            this.Subtraction.Text = "Subtraction";
            this.Subtraction.UseVisualStyleBackColor = true;
            // 
            // Multiplication
            // 
            this.Multiplication.AutoSize = true;
            this.Multiplication.Location = new System.Drawing.Point(276, 122);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(86, 17);
            this.Multiplication.TabIndex = 4;
            this.Multiplication.TabStop = true;
            this.Multiplication.Text = "Multiplication";
            this.Multiplication.UseVisualStyleBackColor = true;
            // 
            // Division
            // 
            this.Division.AutoSize = true;
            this.Division.Location = new System.Drawing.Point(276, 171);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(62, 17);
            this.Division.TabIndex = 5;
            this.Division.TabStop = true;
            this.Division.Text = "Division";
            this.Division.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(442, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.RadioButton Addition;
        private System.Windows.Forms.RadioButton Subtraction;
        private System.Windows.Forms.RadioButton Multiplication;
        private System.Windows.Forms.RadioButton Division;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Button button1;
    }
}

