
namespace AmIPositive
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
            this.InputIntergerLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.IntergerButton = new System.Windows.Forms.Button();
            this.OutputTextBox1 = new System.Windows.Forms.TextBox();
            this.OutputTextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputIntergerLabel
            // 
            this.InputIntergerLabel.AutoSize = true;
            this.InputIntergerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputIntergerLabel.Location = new System.Drawing.Point(91, 63);
            this.InputIntergerLabel.Name = "InputIntergerLabel";
            this.InputIntergerLabel.Size = new System.Drawing.Size(213, 31);
            this.InputIntergerLabel.TabIndex = 0;
            this.InputIntergerLabel.Text = "Input an Interger";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(336, 66);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(100, 31);
            this.InputTextBox.TabIndex = 1;
            // 
            // IntergerButton
            // 
            this.IntergerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntergerButton.Location = new System.Drawing.Point(336, 139);
            this.IntergerButton.Name = "IntergerButton";
            this.IntergerButton.Size = new System.Drawing.Size(100, 50);
            this.IntergerButton.TabIndex = 2;
            this.IntergerButton.Text = "Enter";
            this.IntergerButton.UseVisualStyleBackColor = true;
            this.IntergerButton.Click += new System.EventHandler(this.IntergerButton_Click);
            // 
            // OutputTextBox1
            // 
            this.OutputTextBox1.BackColor = System.Drawing.Color.DarkGray;
            this.OutputTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputTextBox1.ForeColor = System.Drawing.Color.Black;
            this.OutputTextBox1.Location = new System.Drawing.Point(133, 258);
            this.OutputTextBox1.Name = "OutputTextBox1";
            this.OutputTextBox1.Size = new System.Drawing.Size(500, 24);
            this.OutputTextBox1.TabIndex = 3;
            // 
            // OutputTextBox2
            // 
            this.OutputTextBox2.BackColor = System.Drawing.Color.DarkGray;
            this.OutputTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputTextBox2.ForeColor = System.Drawing.Color.Black;
            this.OutputTextBox2.Location = new System.Drawing.Point(133, 329);
            this.OutputTextBox2.Name = "OutputTextBox2";
            this.OutputTextBox2.Size = new System.Drawing.Size(500, 24);
            this.OutputTextBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputTextBox2);
            this.Controls.Add(this.OutputTextBox1);
            this.Controls.Add(this.IntergerButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.InputIntergerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputIntergerLabel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button IntergerButton;
        private System.Windows.Forms.TextBox OutputTextBox1;
        private System.Windows.Forms.TextBox OutputTextBox2;
    }
}

