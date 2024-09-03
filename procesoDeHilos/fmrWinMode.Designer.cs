namespace procesoDeHilos
{
    partial class fmrWinMode
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.picUFO = new System.Windows.Forms.PictureBox();
            this.tmrUFO = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picUFO)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIniciar.Location = new System.Drawing.Point(185, 426);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // picUFO
            // 
            this.picUFO.Location = new System.Drawing.Point(0, 0);
            this.picUFO.Name = "picUFO";
            this.picUFO.Size = new System.Drawing.Size(128, 128);
            this.picUFO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUFO.TabIndex = 1;
            this.picUFO.TabStop = false;
            // 
            // tmrUFO
            // 
            this.tmrUFO.Tick += new System.EventHandler(this.tmrUFO_Tick);
            // 
            // fmrWinMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.picUFO);
            this.Controls.Add(this.btnIniciar);
            this.Name = "fmrWinMode";
            this.Text = "fmrWinMode";
            this.Load += new System.EventHandler(this.fmrWinMode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUFO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox picUFO;
        private System.Windows.Forms.Timer tmrUFO;
    }
}