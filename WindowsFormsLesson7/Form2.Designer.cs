﻿namespace WindowsFormsLesson7
{
    partial class Form2
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
            this.lblCondition = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.btnСontinue = new System.Windows.Forms.Button();
            this.lblTestShowRandomNumber = new System.Windows.Forms.Label();
            this.txtInputNumber = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(12, 26);
            this.lblCondition.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblCondition.MinimumSize = new System.Drawing.Size(290, 0);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(290, 13);
            this.lblCondition.TabIndex = 1;
            this.lblCondition.Text = "label1";
            this.lblCondition.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(115, 92);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "button1";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Location = new System.Drawing.Point(15, 127);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(35, 13);
            this.lblFirstNumber.TabIndex = 3;
            this.lblFirstNumber.Text = "label1";
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Location = new System.Drawing.Point(15, 144);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(35, 13);
            this.lblSecondNumber.TabIndex = 4;
            this.lblSecondNumber.Text = "label2";
            // 
            // btnСontinue
            // 
            this.btnСontinue.Location = new System.Drawing.Point(115, 116);
            this.btnСontinue.Name = "btnСontinue";
            this.btnСontinue.Size = new System.Drawing.Size(80, 23);
            this.btnСontinue.TabIndex = 5;
            this.btnСontinue.Text = "button1";
            this.btnСontinue.UseVisualStyleBackColor = true;
            this.btnСontinue.Click += new System.EventHandler(this.BtnСontinue_Click);
            // 
            // lblTestShowRandomNumber
            // 
            this.lblTestShowRandomNumber.AutoSize = true;
            this.lblTestShowRandomNumber.Location = new System.Drawing.Point(212, 66);
            this.lblTestShowRandomNumber.Name = "lblTestShowRandomNumber";
            this.lblTestShowRandomNumber.Size = new System.Drawing.Size(35, 13);
            this.lblTestShowRandomNumber.TabIndex = 6;
            this.lblTestShowRandomNumber.Text = "label1";
            // 
            // txtInputNumber
            // 
            this.txtInputNumber.CausesValidation = false;
            this.txtInputNumber.Location = new System.Drawing.Point(126, 59);
            this.txtInputNumber.Name = "txtInputNumber";
            this.txtInputNumber.Size = new System.Drawing.Size(52, 20);
            this.txtInputNumber.TabIndex = 7;
            this.txtInputNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 182);
            this.Controls.Add(this.txtInputNumber);
            this.Controls.Add(this.lblTestShowRandomNumber);
            this.Controls.Add(this.btnСontinue);
            this.Controls.Add(this.lblSecondNumber);
            this.Controls.Add(this.lblFirstNumber);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblCondition);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.Button btnСontinue;
        private System.Windows.Forms.Label lblTestShowRandomNumber;
        private System.Windows.Forms.MaskedTextBox txtInputNumber;
    }
}