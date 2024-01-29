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
            buttonGetJalaliSeasonName = new Button();
            buttonJalaliToMiladi = new Button();
            buttonLib = new Button();
            buttonToJalaliAndDays_out = new Button();
            buttonToJalaliAndDays_ref = new Button();
            buttonToJalaliAndDaysTouple = new Button();
            SuspendLayout();
            // 
            // buttonToJalali
            // 
            buttonToJalali.Location = new Point(12, 12);
            buttonToJalali.Name = "buttonToJalali";
            buttonToJalali.Size = new Size(179, 23);
            buttonToJalali.TabIndex = 0;
            buttonToJalali.Text = "To Jalali";
            buttonToJalali.UseVisualStyleBackColor = true;
            buttonToJalali.Click += buttonToJalali_Click;
            // 
            // buttonGetJalaliMonth
            // 
            buttonGetJalaliMonth.Location = new Point(12, 41);
            buttonGetJalaliMonth.Name = "buttonGetJalaliMonth";
            buttonGetJalaliMonth.Size = new Size(179, 23);
            buttonGetJalaliMonth.TabIndex = 1;
            buttonGetJalaliMonth.Text = "Get Jalali Month";
            buttonGetJalaliMonth.UseVisualStyleBackColor = true;
            buttonGetJalaliMonth.Click += buttonGetJalaliMonth_Click;
            // 
            // buttonGetJalaliSeasonName
            // 
            buttonGetJalaliSeasonName.Location = new Point(12, 70);
            buttonGetJalaliSeasonName.Name = "buttonGetJalaliSeasonName";
            buttonGetJalaliSeasonName.Size = new Size(179, 23);
            buttonGetJalaliSeasonName.TabIndex = 2;
            buttonGetJalaliSeasonName.Text = "Get Jalali Season Name";
            buttonGetJalaliSeasonName.UseVisualStyleBackColor = true;
            buttonGetJalaliSeasonName.Click += buttonGetJalaliSeasonName_Click;
            // 
            // buttonJalaliToMiladi
            // 
            buttonJalaliToMiladi.Location = new Point(12, 99);
            buttonJalaliToMiladi.Name = "buttonJalaliToMiladi";
            buttonJalaliToMiladi.Size = new Size(179, 23);
            buttonJalaliToMiladi.TabIndex = 3;
            buttonJalaliToMiladi.Text = "Jalali To Miladi";
            buttonJalaliToMiladi.UseVisualStyleBackColor = true;
            buttonJalaliToMiladi.Click += buttonJalaliToMiladi_Click;
            // 
            // buttonLib
            // 
            buttonLib.Location = new Point(12, 128);
            buttonLib.Name = "buttonLib";
            buttonLib.Size = new Size(179, 23);
            buttonLib.TabIndex = 4;
            buttonLib.Text = "Use Lib";
            buttonLib.UseVisualStyleBackColor = true;
            buttonLib.Click += buttonLib_Click;
            // 
            // buttonToJalaliAndDays_out
            // 
            buttonToJalaliAndDays_out.Location = new Point(273, 12);
            buttonToJalaliAndDays_out.Name = "buttonToJalaliAndDays_out";
            buttonToJalaliAndDays_out.Size = new Size(178, 23);
            buttonToJalaliAndDays_out.TabIndex = 5;
            buttonToJalaliAndDays_out.Text = "Out Example";
            buttonToJalaliAndDays_out.UseVisualStyleBackColor = true;
            buttonToJalaliAndDays_out.Click += buttonToJalaliAndDays_out_Click;
            // 
            // buttonToJalaliAndDays_ref
            // 
            buttonToJalaliAndDays_ref.Location = new Point(273, 41);
            buttonToJalaliAndDays_ref.Name = "buttonToJalaliAndDays_ref";
            buttonToJalaliAndDays_ref.Size = new Size(178, 23);
            buttonToJalaliAndDays_ref.TabIndex = 6;
            buttonToJalaliAndDays_ref.Text = "Ref Example";
            buttonToJalaliAndDays_ref.UseVisualStyleBackColor = true;
            buttonToJalaliAndDays_ref.Click += buttonToJalaliAndDays_ref_Click;
            // 
            // buttonToJalaliAndDaysTouple
            // 
            buttonToJalaliAndDaysTouple.Location = new Point(273, 70);
            buttonToJalaliAndDaysTouple.Name = "buttonToJalaliAndDaysTouple";
            buttonToJalaliAndDaysTouple.Size = new Size(178, 23);
            buttonToJalaliAndDaysTouple.TabIndex = 7;
            buttonToJalaliAndDaysTouple.Text = "Touple Example";
            buttonToJalaliAndDaysTouple.UseVisualStyleBackColor = true;
            buttonToJalaliAndDaysTouple.Click += buttonToJalaliAndDaysTouple_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonToJalaliAndDaysTouple);
            Controls.Add(buttonToJalaliAndDays_ref);
            Controls.Add(buttonToJalaliAndDays_out);
            Controls.Add(buttonLib);
            Controls.Add(buttonJalaliToMiladi);
            Controls.Add(buttonGetJalaliSeasonName);
            Controls.Add(buttonGetJalaliMonth);
            Controls.Add(buttonToJalali);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonToJalali;
        private Button buttonGetJalaliMonth;
        private Button buttonGetJalaliSeasonName;
        private Button buttonJalaliToMiladi;
        private Button buttonLib;
        private Button buttonToJalaliAndDays_out;
        private Button buttonToJalaliAndDays_ref;
        private Button buttonToJalaliAndDaysTouple;
    }
}
