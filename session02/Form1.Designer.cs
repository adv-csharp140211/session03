namespace session02
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
            buttonToJalali = new Button();
            buttonGetJalaliMonth = new Button();
            SuspendLayout();
            // 
            // buttonToJalali
            // 
            buttonToJalali.Location = new Point(12, 12);
            buttonToJalali.Name = "buttonToJalali";
            buttonToJalali.Size = new Size(129, 23);
            buttonToJalali.TabIndex = 0;
            buttonToJalali.Text = "To Jalali";
            buttonToJalali.UseVisualStyleBackColor = true;
            buttonToJalali.Click += buttonToJalali_Click;
            // 
            // buttonGetJalaliMonth
            // 
            buttonGetJalaliMonth.Location = new Point(12, 41);
            buttonGetJalaliMonth.Name = "buttonGetJalaliMonth";
            buttonGetJalaliMonth.Size = new Size(129, 23);
            buttonGetJalaliMonth.TabIndex = 1;
            buttonGetJalaliMonth.Text = "Get Jalali Month";
            buttonGetJalaliMonth.UseVisualStyleBackColor = true;
            buttonGetJalaliMonth.Click += buttonGetJalaliMonth_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGetJalaliMonth);
            Controls.Add(buttonToJalali);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonToJalali;
        private Button buttonGetJalaliMonth;
    }
}
