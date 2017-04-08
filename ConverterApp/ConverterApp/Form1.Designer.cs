namespace ConverterApp
{
    partial class frm_Main
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
            this.btn_Convert_All = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Convert = new System.Windows.Forms.Label();
            this.txt_CM_to_Inches = new System.Windows.Forms.TextBox();
            this.txt_M_to_Feet = new System.Windows.Forms.TextBox();
            this.txt_Kilometres_to_Miles = new System.Windows.Forms.TextBox();
            this.txt_Celsius_to_Farenheit = new System.Windows.Forms.TextBox();
            this.txt_Centimetres_to_Feet = new System.Windows.Forms.TextBox();
            this.lb_Results = new System.Windows.Forms.ListBox();
            this.lbl_CM_to_Inches = new System.Windows.Forms.Label();
            this.lbl_Metres_to_Feet = new System.Windows.Forms.Label();
            this.lbl_Celsius_to_Farenheit = new System.Windows.Forms.Label();
            this.lbl_Centimetres_to_Feet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Clear_all = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Convert_All
            // 
            this.btn_Convert_All.Location = new System.Drawing.Point(12, 235);
            this.btn_Convert_All.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Convert_All.Name = "btn_Convert_All";
            this.btn_Convert_All.Size = new System.Drawing.Size(78, 19);
            this.btn_Convert_All.TabIndex = 5;
            this.btn_Convert_All.Text = "Convert All";
            this.btn_Convert_All.UseVisualStyleBackColor = true;
            this.btn_Convert_All.Click += new System.EventHandler(this.btn_Convert_All_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(212, 235);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(56, 19);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_Convert
            // 
            this.lbl_Convert.AutoSize = true;
            this.lbl_Convert.Location = new System.Drawing.Point(212, 131);
            this.lbl_Convert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Convert.Name = "lbl_Convert";
            this.lbl_Convert.Size = new System.Drawing.Size(0, 13);
            this.lbl_Convert.TabIndex = 6;
            // 
            // txt_CM_to_Inches
            // 
            this.txt_CM_to_Inches.Location = new System.Drawing.Point(137, 8);
            this.txt_CM_to_Inches.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CM_to_Inches.Name = "txt_CM_to_Inches";
            this.txt_CM_to_Inches.Size = new System.Drawing.Size(131, 20);
            this.txt_CM_to_Inches.TabIndex = 0;
            // 
            // txt_M_to_Feet
            // 
            this.txt_M_to_Feet.Location = new System.Drawing.Point(137, 32);
            this.txt_M_to_Feet.Margin = new System.Windows.Forms.Padding(2);
            this.txt_M_to_Feet.Name = "txt_M_to_Feet";
            this.txt_M_to_Feet.Size = new System.Drawing.Size(131, 20);
            this.txt_M_to_Feet.TabIndex = 1;
            // 
            // txt_Kilometres_to_Miles
            // 
            this.txt_Kilometres_to_Miles.Location = new System.Drawing.Point(137, 104);
            this.txt_Kilometres_to_Miles.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Kilometres_to_Miles.Name = "txt_Kilometres_to_Miles";
            this.txt_Kilometres_to_Miles.Size = new System.Drawing.Size(131, 20);
            this.txt_Kilometres_to_Miles.TabIndex = 4;
            // 
            // txt_Celsius_to_Farenheit
            // 
            this.txt_Celsius_to_Farenheit.Location = new System.Drawing.Point(137, 56);
            this.txt_Celsius_to_Farenheit.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Celsius_to_Farenheit.Name = "txt_Celsius_to_Farenheit";
            this.txt_Celsius_to_Farenheit.Size = new System.Drawing.Size(131, 20);
            this.txt_Celsius_to_Farenheit.TabIndex = 2;
            // 
            // txt_Centimetres_to_Feet
            // 
            this.txt_Centimetres_to_Feet.Location = new System.Drawing.Point(137, 80);
            this.txt_Centimetres_to_Feet.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Centimetres_to_Feet.Name = "txt_Centimetres_to_Feet";
            this.txt_Centimetres_to_Feet.Size = new System.Drawing.Size(131, 20);
            this.txt_Centimetres_to_Feet.TabIndex = 3;
            // 
            // lb_Results
            // 
            this.lb_Results.FormattingEnabled = true;
            this.lb_Results.Location = new System.Drawing.Point(12, 135);
            this.lb_Results.Name = "lb_Results";
            this.lb_Results.Size = new System.Drawing.Size(256, 95);
            this.lb_Results.TabIndex = 15;
            this.lb_Results.TabStop = false;
            // 
            // lbl_CM_to_Inches
            // 
            this.lbl_CM_to_Inches.AutoSize = true;
            this.lbl_CM_to_Inches.Location = new System.Drawing.Point(12, 11);
            this.lbl_CM_to_Inches.Name = "lbl_CM_to_Inches";
            this.lbl_CM_to_Inches.Size = new System.Drawing.Size(112, 13);
            this.lbl_CM_to_Inches.TabIndex = 16;
            this.lbl_CM_to_Inches.Text = "Centimetres to Inches:";
            // 
            // lbl_Metres_to_Feet
            // 
            this.lbl_Metres_to_Feet.AutoSize = true;
            this.lbl_Metres_to_Feet.Location = new System.Drawing.Point(12, 35);
            this.lbl_Metres_to_Feet.Name = "lbl_Metres_to_Feet";
            this.lbl_Metres_to_Feet.Size = new System.Drawing.Size(78, 13);
            this.lbl_Metres_to_Feet.TabIndex = 17;
            this.lbl_Metres_to_Feet.Text = "Metres to Feet:";
            // 
            // lbl_Celsius_to_Farenheit
            // 
            this.lbl_Celsius_to_Farenheit.AutoSize = true;
            this.lbl_Celsius_to_Farenheit.Location = new System.Drawing.Point(12, 59);
            this.lbl_Celsius_to_Farenheit.Name = "lbl_Celsius_to_Farenheit";
            this.lbl_Celsius_to_Farenheit.Size = new System.Drawing.Size(102, 13);
            this.lbl_Celsius_to_Farenheit.TabIndex = 18;
            this.lbl_Celsius_to_Farenheit.Text = "Celsius to Farenheit:";
            // 
            // lbl_Centimetres_to_Feet
            // 
            this.lbl_Centimetres_to_Feet.AutoSize = true;
            this.lbl_Centimetres_to_Feet.Location = new System.Drawing.Point(12, 83);
            this.lbl_Centimetres_to_Feet.Name = "lbl_Centimetres_to_Feet";
            this.lbl_Centimetres_to_Feet.Size = new System.Drawing.Size(101, 13);
            this.lbl_Centimetres_to_Feet.TabIndex = 19;
            this.lbl_Centimetres_to_Feet.Text = "Centimetres to Feet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Kilometres to Miles:";
            // 
            // btn_Clear_all
            // 
            this.btn_Clear_all.Location = new System.Drawing.Point(94, 235);
            this.btn_Clear_all.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Clear_all.Name = "btn_Clear_all";
            this.btn_Clear_all.Size = new System.Drawing.Size(78, 19);
            this.btn_Clear_all.TabIndex = 6;
            this.btn_Clear_all.Text = "Clear All";
            this.btn_Clear_all.UseVisualStyleBackColor = true;
            this.btn_Clear_all.Click += new System.EventHandler(this.btn_Clear_all_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(280, 259);
            this.Controls.Add(this.btn_Clear_all);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Centimetres_to_Feet);
            this.Controls.Add(this.lbl_Celsius_to_Farenheit);
            this.Controls.Add(this.lbl_Metres_to_Feet);
            this.Controls.Add(this.lbl_CM_to_Inches);
            this.Controls.Add(this.lb_Results);
            this.Controls.Add(this.txt_Centimetres_to_Feet);
            this.Controls.Add(this.txt_Celsius_to_Farenheit);
            this.Controls.Add(this.txt_Kilometres_to_Miles);
            this.Controls.Add(this.txt_M_to_Feet);
            this.Controls.Add(this.txt_CM_to_Inches);
            this.Controls.Add(this.lbl_Convert);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Convert_All);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Main";
            this.Text = "ATCA Gas Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Convert_All;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Convert;
        private System.Windows.Forms.TextBox txt_CM_to_Inches;
        private System.Windows.Forms.TextBox txt_M_to_Feet;
        private System.Windows.Forms.TextBox txt_Kilometres_to_Miles;
        private System.Windows.Forms.TextBox txt_Celsius_to_Farenheit;
        private System.Windows.Forms.TextBox txt_Centimetres_to_Feet;
        private System.Windows.Forms.ListBox lb_Results;
        private System.Windows.Forms.Label lbl_CM_to_Inches;
        private System.Windows.Forms.Label lbl_Metres_to_Feet;
        private System.Windows.Forms.Label lbl_Celsius_to_Farenheit;
        private System.Windows.Forms.Label lbl_Centimetres_to_Feet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Clear_all;
    }
}

