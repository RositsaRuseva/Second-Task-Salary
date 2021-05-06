
namespace WindowsFormsApp1Task2
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
            this.salary_label = new System.Windows.Forms.Label();
            this.grossSalaryBox = new System.Windows.Forms.GroupBox();
            this.grossTextBox = new System.Windows.Forms.TextBox();
            this.netSalaryBox = new System.Windows.Forms.GroupBox();
            this.netTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.grossSalaryBox.SuspendLayout();
            this.netSalaryBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // salary_label
            // 
            this.salary_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salary_label.AutoSize = true;
            this.salary_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salary_label.ForeColor = System.Drawing.Color.Teal;
            this.salary_label.Location = new System.Drawing.Point(367, 40);
            this.salary_label.Margin = new System.Windows.Forms.Padding(4, 13, 9, 0);
            this.salary_label.Name = "salary_label";
            this.salary_label.Size = new System.Drawing.Size(201, 26);
            this.salary_label.TabIndex = 0;
            this.salary_label.Text = "Salary Converter";
            // 
            // grossSalaryBox
            // 
            this.grossSalaryBox.Controls.Add(this.grossTextBox);
            this.grossSalaryBox.ForeColor = System.Drawing.Color.Teal;
            this.grossSalaryBox.Location = new System.Drawing.Point(217, 101);
            this.grossSalaryBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grossSalaryBox.Name = "grossSalaryBox";
            this.grossSalaryBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grossSalaryBox.Size = new System.Drawing.Size(537, 134);
            this.grossSalaryBox.TabIndex = 1;
            this.grossSalaryBox.TabStop = false;
            this.grossSalaryBox.Text = "Gross Salary";
            // 
            // grossTextBox
            // 
            this.grossTextBox.Location = new System.Drawing.Point(9, 42);
            this.grossTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grossTextBox.Multiline = true;
            this.grossTextBox.Name = "grossTextBox";
            this.grossTextBox.Size = new System.Drawing.Size(516, 83);
            this.grossTextBox.TabIndex = 0;
            // 
            // netSalaryBox
            // 
            this.netSalaryBox.Controls.Add(this.netTextBox);
            this.netSalaryBox.ForeColor = System.Drawing.Color.Teal;
            this.netSalaryBox.Location = new System.Drawing.Point(217, 350);
            this.netSalaryBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.netSalaryBox.Name = "netSalaryBox";
            this.netSalaryBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.netSalaryBox.Size = new System.Drawing.Size(537, 123);
            this.netSalaryBox.TabIndex = 2;
            this.netSalaryBox.TabStop = false;
            this.netSalaryBox.Text = "Net Salary";
            // 
            // netTextBox
            // 
            this.netTextBox.Location = new System.Drawing.Point(9, 29);
            this.netTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.netTextBox.Multiline = true;
            this.netTextBox.Name = "netTextBox";
            this.netTextBox.Size = new System.Drawing.Size(516, 83);
            this.netTextBox.TabIndex = 0;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.calculateButton.ForeColor = System.Drawing.Color.Teal;
            this.calculateButton.Location = new System.Drawing.Point(307, 263);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(159, 54);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1040, 618);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.netSalaryBox);
            this.Controls.Add(this.grossSalaryBox);
            this.Controls.Add(this.salary_label);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grossSalaryBox.ResumeLayout(false);
            this.grossSalaryBox.PerformLayout();
            this.netSalaryBox.ResumeLayout(false);
            this.netSalaryBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label salary_label;
        private System.Windows.Forms.GroupBox grossSalaryBox;
        private System.Windows.Forms.TextBox grossTextBox;
        private System.Windows.Forms.GroupBox netSalaryBox;
        private System.Windows.Forms.TextBox netTextBox;
        private System.Windows.Forms.Button calculateButton;
    }
}

