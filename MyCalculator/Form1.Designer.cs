namespace MyCalculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblsecNumber = new System.Windows.Forms.Label();
            this.txtFirstNumber = new System.Windows.Forms.NumericUpDown();
            this.txtsecNumber = new System.Windows.Forms.NumericUpDown();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsecNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsecNumber);
            this.groupBox1.Controls.Add(this.txtFirstNumber);
            this.groupBox1.Controls.Add(this.lblsecNumber);
            this.groupBox1.Controls.Add(this.lblFirstNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Location = new System.Drawing.Point(6, 44);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(108, 20);
            this.lblFirstNumber.TabIndex = 0;
            this.lblFirstNumber.Text = "First Number :";
            // 
            // lblsecNumber
            // 
            this.lblsecNumber.AutoSize = true;
            this.lblsecNumber.Location = new System.Drawing.Point(290, 44);
            this.lblsecNumber.Name = "lblsecNumber";
            this.lblsecNumber.Size = new System.Drawing.Size(105, 20);
            this.lblsecNumber.TabIndex = 0;
            this.lblsecNumber.Text = "Sec Number :";
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Location = new System.Drawing.Point(121, 43);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(163, 26);
            this.txtFirstNumber.TabIndex = 1;
            // 
            // txtsecNumber
            // 
            this.txtsecNumber.Location = new System.Drawing.Point(401, 42);
            this.txtsecNumber.Name = "txtsecNumber";
            this.txtsecNumber.Size = new System.Drawing.Size(181, 26);
            this.txtsecNumber.TabIndex = 1;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(12, 129);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(128, 39);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(149, 129);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(147, 39);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(302, 129);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(147, 39);
            this.btnMultiplication.TabIndex = 1;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(455, 129);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(147, 39);
            this.btnDivision.TabIndex = 1;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 186);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsecNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown txtsecNumber;
        private System.Windows.Forms.NumericUpDown txtFirstNumber;
        private System.Windows.Forms.Label lblsecNumber;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivision;
    }
}

