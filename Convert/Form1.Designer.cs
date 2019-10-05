//Student: Barbara Sullivan
//Instructor: Dr. Jerry Mamo
//Class: CIST 2341 – C# Programming – 60485 – Summer 2019
//Lab #2 – Assign 2 
namespace Convert
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
            this.components = new System.ComponentModel.Container();
            this.FahrLbl = new System.Windows.Forms.Label();
            this.CelsiusLbl = new System.Windows.Forms.Label();
            this.CelsiusTxtB = new System.Windows.Forms.TextBox();
            this.FahrTxtB = new System.Windows.Forms.TextBox();
            this.FtoCRbtn = new System.Windows.Forms.RadioButton();
            this.CtoFRbtn = new System.Windows.Forms.RadioButton();
            this.ConvBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.tempLbl = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // FahrLbl
            // 
            this.FahrLbl.AutoSize = true;
            this.FahrLbl.BackColor = System.Drawing.SystemColors.Control;
            this.FahrLbl.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FahrLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FahrLbl.Location = new System.Drawing.Point(285, 60);
            this.FahrLbl.Name = "FahrLbl";
            this.FahrLbl.Size = new System.Drawing.Size(130, 29);
            this.FahrLbl.TabIndex = 0;
            this.FahrLbl.Text = "Fahrenheit";
            this.FahrLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // CelsiusLbl
            // 
            this.CelsiusLbl.AutoSize = true;
            this.CelsiusLbl.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelsiusLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CelsiusLbl.Location = new System.Drawing.Point(65, 60);
            this.CelsiusLbl.Name = "CelsiusLbl";
            this.CelsiusLbl.Size = new System.Drawing.Size(88, 29);
            this.CelsiusLbl.TabIndex = 1;
            this.CelsiusLbl.Text = "Celsius";
            // 
            // CelsiusTxtB
            // 
            this.CelsiusTxtB.BackColor = System.Drawing.SystemColors.Info;
            this.CelsiusTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelsiusTxtB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CelsiusTxtB.Location = new System.Drawing.Point(70, 126);
            this.CelsiusTxtB.Name = "CelsiusTxtB";
            this.CelsiusTxtB.Size = new System.Drawing.Size(150, 34);
            this.CelsiusTxtB.TabIndex = 2;
            this.CelsiusTxtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CelsiusTxtB.TextChanged += new System.EventHandler(this.CelsiusTxtB_TextChanged);
            // 
            // FahrTxtB
            // 
            this.FahrTxtB.BackColor = System.Drawing.SystemColors.Info;
            this.FahrTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FahrTxtB.Location = new System.Drawing.Point(290, 126);
            this.FahrTxtB.Name = "FahrTxtB";
            this.FahrTxtB.Size = new System.Drawing.Size(150, 34);
            this.FahrTxtB.TabIndex = 3;
            this.FahrTxtB.TextChanged += new System.EventHandler(this.FahrTxtB_TextChanged);
            // 
            // FtoCRbtn
            // 
            this.FtoCRbtn.AutoSize = true;
            this.FtoCRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FtoCRbtn.Location = new System.Drawing.Point(554, 200);
            this.FtoCRbtn.Name = "FtoCRbtn";
            this.FtoCRbtn.Size = new System.Drawing.Size(156, 28);
            this.FtoCRbtn.TabIndex = 4;
            this.FtoCRbtn.TabStop = true;
            this.FtoCRbtn.Text = "Fahr to Celsius";
            this.FtoCRbtn.UseVisualStyleBackColor = true;
            this.FtoCRbtn.CheckedChanged += new System.EventHandler(this.FtoCRbtn_CheckedChanged);
            // 
            // CtoFRbtn
            // 
            this.CtoFRbtn.AutoSize = true;
            this.CtoFRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtoFRbtn.Location = new System.Drawing.Point(554, 243);
            this.CtoFRbtn.Name = "CtoFRbtn";
            this.CtoFRbtn.Size = new System.Drawing.Size(156, 28);
            this.CtoFRbtn.TabIndex = 5;
            this.CtoFRbtn.TabStop = true;
            this.CtoFRbtn.Text = "Celsius to Fahr";
            this.CtoFRbtn.UseVisualStyleBackColor = true;
            this.CtoFRbtn.CheckedChanged += new System.EventHandler(this.CtoFRbtn_CheckedChanged);
            // 
            // ConvBtn
            // 
            this.ConvBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConvBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ConvBtn.Location = new System.Drawing.Point(115, 369);
            this.ConvBtn.Name = "ConvBtn";
            this.ConvBtn.Size = new System.Drawing.Size(105, 43);
            this.ConvBtn.TabIndex = 6;
            this.ConvBtn.Text = "Convert";
            this.toolTip1.SetToolTip(this.ConvBtn, "Click here to convert");
            this.ConvBtn.UseVisualStyleBackColor = false;
            this.ConvBtn.Click += new System.EventHandler(this.ConvBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ExitBtn.Location = new System.Drawing.Point(577, 369);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(105, 43);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // tempLbl
            // 
            this.tempLbl.AutoSize = true;
            this.tempLbl.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tempLbl.Location = new System.Drawing.Point(65, 242);
            this.tempLbl.Name = "tempLbl";
            this.tempLbl.Size = new System.Drawing.Size(29, 32);
            this.tempLbl.TabIndex = 8;
            this.tempLbl.Text = "  ";
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ClearBtn.Location = new System.Drawing.Point(348, 369);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(105, 43);
            this.ClearBtn.TabIndex = 9;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.tempLbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ConvBtn);
            this.Controls.Add(this.CtoFRbtn);
            this.Controls.Add(this.FtoCRbtn);
            this.Controls.Add(this.FahrTxtB);
            this.Controls.Add(this.CelsiusTxtB);
            this.Controls.Add(this.CelsiusLbl);
            this.Controls.Add(this.FahrLbl);
            this.Name = "Form1";
            this.Text = "Convert";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FahrLbl;
        private System.Windows.Forms.Label CelsiusLbl;
        private System.Windows.Forms.TextBox CelsiusTxtB;
        private System.Windows.Forms.TextBox FahrTxtB;
        private System.Windows.Forms.RadioButton FtoCRbtn;
        private System.Windows.Forms.RadioButton CtoFRbtn;
        private System.Windows.Forms.Button ConvBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label tempLbl;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

