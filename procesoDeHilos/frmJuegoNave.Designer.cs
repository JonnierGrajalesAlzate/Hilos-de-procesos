namespace procesoDeHilos
{
    partial class frmJuegoNave
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
            this.tmrUFO = new System.Windows.Forms.Timer(this.components);
            this.msRegresar = new System.Windows.Forms.MenuStrip();
            this.picUFO = new System.Windows.Forms.PictureBox();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msRegresar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUFO)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrUFO
            // 
            this.tmrUFO.Tick += new System.EventHandler(this.tmrUFO_Tick);
            // 
            // msRegresar
            // 
            this.msRegresar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarToolStripMenuItem});
            this.msRegresar.Location = new System.Drawing.Point(0, 0);
            this.msRegresar.Name = "msRegresar";
            this.msRegresar.Size = new System.Drawing.Size(484, 24);
            this.msRegresar.TabIndex = 2;
            this.msRegresar.Text = "msRegresar";
            // 
            // picUFO
            // 
            this.picUFO.ErrorImage = global::procesoDeHilos.Properties.Resources.alien;
            this.picUFO.Location = new System.Drawing.Point(1, 32);
            this.picUFO.Name = "picUFO";
            this.picUFO.Size = new System.Drawing.Size(128, 128);
            this.picUFO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUFO.TabIndex = 1;
            this.picUFO.TabStop = false;
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarToolStripMenuItem.Image = global::procesoDeHilos.Properties.Resources.volver;
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // frmJuegoNave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 192);
            this.Controls.Add(this.picUFO);
            this.Controls.Add(this.msRegresar);
            this.MainMenuStrip = this.msRegresar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmJuegoNave";
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.fmrWinMode_Load);
            this.msRegresar.ResumeLayout(false);
            this.msRegresar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUFO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picUFO;
        private System.Windows.Forms.Timer tmrUFO;
        private System.Windows.Forms.MenuStrip msRegresar;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
    }
}