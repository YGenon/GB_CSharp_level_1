namespace WindowsFormsAppLesson7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buhfnmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.игратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(184, 44);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(75, 23);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "+1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.BtnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(184, 89);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(75, 23);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "х2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.BtnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(184, 130);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(6, 22);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(35, 13);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "label1";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(6, 21);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(35, 13);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "label3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buhfnmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(281, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buhfnmToolStripMenuItem
            // 
            //this.buhfnmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            //this.игратьToolStripMenuItem});
            //this.buhfnmToolStripMenuItem.Name = "buhfnmToolStripMenuItem";
            //this.buhfnmToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            //this.buhfnmToolStripMenuItem.Text = "Меню";
            //this.buhfnmToolStripMenuItem.Click += new System.EventHandler(this.BuhfnmToolStripMenuItem_Click);
            // 
            // игратьToolStripMenuItem
            // 
            this.игратьToolStripMenuItem.Name = "игратьToolStripMenuItem";
            this.игратьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.игратьToolStripMenuItem.Text = "Играть";
            this.игратьToolStripMenuItem.Click += new System.EventHandler(this.ИгратьToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCount);
            this.groupBox1.Location = new System.Drawing.Point(17, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 43);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Количество ходов";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNumber);
            this.groupBox2.Location = new System.Drawing.Point(17, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 41);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 170);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buhfnmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem игратьToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

