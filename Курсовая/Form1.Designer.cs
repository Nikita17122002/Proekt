namespace Курсовая
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.тренерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спортсменToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.названиеСекцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОГруппеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тренерToolStripMenuItem,
            this.спортсменToolStripMenuItem,
            this.названиеСекцииToolStripMenuItem,
            this.информацияОГруппеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // тренерToolStripMenuItem
            // 
            this.тренерToolStripMenuItem.Name = "тренерToolStripMenuItem";
            this.тренерToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.тренерToolStripMenuItem.Text = "Тренер";
            this.тренерToolStripMenuItem.Click += new System.EventHandler(this.тренерToolStripMenuItem_Click);
            // 
            // спортсменToolStripMenuItem
            // 
            this.спортсменToolStripMenuItem.Name = "спортсменToolStripMenuItem";
            this.спортсменToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.спортсменToolStripMenuItem.Text = "Спортсмен";
            this.спортсменToolStripMenuItem.Click += new System.EventHandler(this.спортсменToolStripMenuItem_Click);
            // 
            // названиеСекцииToolStripMenuItem
            // 
            this.названиеСекцииToolStripMenuItem.Name = "названиеСекцииToolStripMenuItem";
            this.названиеСекцииToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.названиеСекцииToolStripMenuItem.Text = "Название секции";
            this.названиеСекцииToolStripMenuItem.Click += new System.EventHandler(this.названиеСекцииToolStripMenuItem_Click);
            // 
            // информацияОГруппеToolStripMenuItem
            // 
            this.информацияОГруппеToolStripMenuItem.Name = "информацияОГруппеToolStripMenuItem";
            this.информацияОГруппеToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.информацияОГруппеToolStripMenuItem.Text = "Информация о группе";
            this.информацияОГруппеToolStripMenuItem.Click += new System.EventHandler(this.информацияОГруппеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Спортивные секции";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem тренерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спортсменToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem названиеСекцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОГруппеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

