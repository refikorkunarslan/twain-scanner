namespace Acquire_an_Image_from_TWAIN_Source
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
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.twainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.selectSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.acquirePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.nativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.memoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.twainToolStripMenuItem,
            this.optionsToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(800, 24);
         this.menuStrip1.TabIndex = 0;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "&File";
         // 
         // openToolStripMenuItem
         // 
         this.openToolStripMenuItem.Name = "openToolStripMenuItem";
         this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.openToolStripMenuItem.Text = "&Open";
         this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
         // 
         // saveToolStripMenuItem
         // 
         this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.saveToolStripMenuItem.Text = "&Save";
         this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
         // 
         // twainToolStripMenuItem
         // 
         this.twainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectSourceToolStripMenuItem,
            this.acquirePageToolStripMenuItem});
         this.twainToolStripMenuItem.Name = "twainToolStripMenuItem";
         this.twainToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
         this.twainToolStripMenuItem.Text = "&Twain";
         // 
         // selectSourceToolStripMenuItem
         // 
         this.selectSourceToolStripMenuItem.Name = "selectSourceToolStripMenuItem";
         this.selectSourceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.selectSourceToolStripMenuItem.Text = "&Select Source";
         this.selectSourceToolStripMenuItem.Click += new System.EventHandler(this.selectSourceToolStripMenuItem_Click);
         // 
         // acquirePageToolStripMenuItem
         // 
         this.acquirePageToolStripMenuItem.Name = "acquirePageToolStripMenuItem";
         this.acquirePageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.acquirePageToolStripMenuItem.Text = "&Acquire Page";
         this.acquirePageToolStripMenuItem.Click += new System.EventHandler(this.acquirePageToolStripMenuItem_Click);
         // 
         // optionsToolStripMenuItem
         // 
         this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nativeToolStripMenuItem,
            this.memoryToolStripMenuItem,
            this.fileToolStripMenuItem1});
         this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
         this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
         this.optionsToolStripMenuItem.Text = "&Options";
         // 
         // nativeToolStripMenuItem
         // 
         this.nativeToolStripMenuItem.Name = "nativeToolStripMenuItem";
         this.nativeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.nativeToolStripMenuItem.Text = "&Native";
         this.nativeToolStripMenuItem.Click += new System.EventHandler(this.nativeToolStripMenuItem_Click);
         // 
         // memoryToolStripMenuItem
         // 
         this.memoryToolStripMenuItem.Name = "memoryToolStripMenuItem";
         this.memoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.memoryToolStripMenuItem.Text = "&Memory";
         this.memoryToolStripMenuItem.Click += new System.EventHandler(this.memoryToolStripMenuItem_Click);
         // 
         // fileToolStripMenuItem1
         // 
         this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
         this.fileToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
         this.fileToolStripMenuItem1.Text = "&File";
         this.fileToolStripMenuItem1.Click += new System.EventHandler(this.fileToolStripMenuItem1_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.menuStrip1);
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "Form1";
         this.Text = "Form1";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
         this.Load += new System.EventHandler(this.Form1_Load);
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acquirePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
    }
}

