
namespace SolarSystem
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.europeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cometToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sunToolStripMenuItem,
            this.moonToolStripMenuItem,
            this.serpToolStripMenuItem,
            this.saturnToolStripMenuItem,
            this.marsToolStripMenuItem,
            this.europeToolStripMenuItem,
            this.cometToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(75, 20);
            this.toolStripMenuItem1.Text = "Astro Stuff";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // sunToolStripMenuItem
            // 
            this.sunToolStripMenuItem.CheckOnClick = true;
            this.sunToolStripMenuItem.Name = "sunToolStripMenuItem";
            this.sunToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sunToolStripMenuItem.Text = "Sun";
            this.sunToolStripMenuItem.Click += new System.EventHandler(this.sunToolStripMenuItem_Click);
            // 
            // moonToolStripMenuItem
            // 
            this.moonToolStripMenuItem.CheckOnClick = true;
            this.moonToolStripMenuItem.Name = "moonToolStripMenuItem";
            this.moonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moonToolStripMenuItem.Text = "Moon";
            // 
            // serpToolStripMenuItem
            // 
            this.serpToolStripMenuItem.CheckOnClick = true;
            this.serpToolStripMenuItem.Name = "serpToolStripMenuItem";
            this.serpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serpToolStripMenuItem.Text = "Serp";
            // 
            // saturnToolStripMenuItem
            // 
            this.saturnToolStripMenuItem.CheckOnClick = true;
            this.saturnToolStripMenuItem.Name = "saturnToolStripMenuItem";
            this.saturnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saturnToolStripMenuItem.Text = "Saturn";
            // 
            // marsToolStripMenuItem
            // 
            this.marsToolStripMenuItem.CheckOnClick = true;
            this.marsToolStripMenuItem.Name = "marsToolStripMenuItem";
            this.marsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.marsToolStripMenuItem.Text = "Mars";
            // 
            // europeToolStripMenuItem
            // 
            this.europeToolStripMenuItem.CheckOnClick = true;
            this.europeToolStripMenuItem.Name = "europeToolStripMenuItem";
            this.europeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.europeToolStripMenuItem.Text = "Europe";
            // 
            // cometToolStripMenuItem
            // 
            this.cometToolStripMenuItem.CheckOnClick = true;
            this.cometToolStripMenuItem.Name = "cometToolStripMenuItem";
            this.cometToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cometToolStripMenuItem.Text = "Comet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem europeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cometToolStripMenuItem;
    }
}

