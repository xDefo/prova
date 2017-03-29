namespace Mate
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.risolviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovaEspressioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semplificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Input_textbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.creaToolStripMenuItem,
            this.risolviToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1157, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // creaToolStripMenuItem
            // 
            this.creaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovaEspressioneToolStripMenuItem});
            this.creaToolStripMenuItem.Name = "creaToolStripMenuItem";
            this.creaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.creaToolStripMenuItem.Text = "Crea";
            // 
            // risolviToolStripMenuItem
            // 
            this.risolviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.semplificaToolStripMenuItem});
            this.risolviToolStripMenuItem.Name = "risolviToolStripMenuItem";
            this.risolviToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.risolviToolStripMenuItem.Text = "Risolvi";
            // 
            // nuovaEspressioneToolStripMenuItem
            // 
            this.nuovaEspressioneToolStripMenuItem.Name = "nuovaEspressioneToolStripMenuItem";
            this.nuovaEspressioneToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.nuovaEspressioneToolStripMenuItem.Text = "Nuova espressione";
            this.nuovaEspressioneToolStripMenuItem.Click += new System.EventHandler(this.nuovaEspressioneToolStripMenuItem_Click);
            // 
            // semplificaToolStripMenuItem
            // 
            this.semplificaToolStripMenuItem.Name = "semplificaToolStripMenuItem";
            this.semplificaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.semplificaToolStripMenuItem.Text = "Semplifica";
            this.semplificaToolStripMenuItem.Click += new System.EventHandler(this.semplificaToolStripMenuItem_Click);
            // 
            // Input_textbox
            // 
            this.Input_textbox.Location = new System.Drawing.Point(12, 27);
            this.Input_textbox.Name = "Input_textbox";
            this.Input_textbox.Size = new System.Drawing.Size(1133, 20);
            this.Input_textbox.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1133, 540);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 605);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Input_textbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovaEspressioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem risolviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semplificaToolStripMenuItem;
        private System.Windows.Forms.TextBox Input_textbox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

