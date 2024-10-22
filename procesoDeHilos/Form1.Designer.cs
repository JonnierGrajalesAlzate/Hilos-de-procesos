namespace procesoDeHilos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.govMultiplos = new System.Windows.Forms.GroupBox();
            this.lblDelCinco = new System.Windows.Forms.Label();
            this.lblDelTres = new System.Windows.Forms.Label();
            this.lblDelDos = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnJuego = new System.Windows.Forms.Button();
            this.tmrx2 = new System.Windows.Forms.Timer(this.components);
            this.tmrx3 = new System.Windows.Forms.Timer(this.components);
            this.tmrx5 = new System.Windows.Forms.Timer(this.components);
            this.govMultiplos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(31, 28);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(24, 25);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "0";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(169, 28);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(24, 25);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "0";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(316, 28);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(24, 25);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "0";
            // 
            // govMultiplos
            // 
            this.govMultiplos.Controls.Add(this.lblDelCinco);
            this.govMultiplos.Controls.Add(this.lblDelTres);
            this.govMultiplos.Controls.Add(this.lblDelDos);
            this.govMultiplos.Controls.Add(this.btnIniciar);
            this.govMultiplos.Controls.Add(this.lbl1);
            this.govMultiplos.Controls.Add(this.lbl3);
            this.govMultiplos.Controls.Add(this.lbl2);
            this.govMultiplos.Location = new System.Drawing.Point(23, 12);
            this.govMultiplos.Name = "govMultiplos";
            this.govMultiplos.Size = new System.Drawing.Size(385, 173);
            this.govMultiplos.TabIndex = 3;
            this.govMultiplos.TabStop = false;
            this.govMultiplos.Text = "MULTIPLOS";
            // 
            // lblDelCinco
            // 
            this.lblDelCinco.AutoSize = true;
            this.lblDelCinco.Location = new System.Drawing.Point(318, 57);
            this.lblDelCinco.Name = "lblDelCinco";
            this.lblDelCinco.Size = new System.Drawing.Size(32, 13);
            this.lblDelCinco.TabIndex = 6;
            this.lblDelCinco.Text = "Del 5";
            // 
            // lblDelTres
            // 
            this.lblDelTres.AutoSize = true;
            this.lblDelTres.Location = new System.Drawing.Point(171, 57);
            this.lblDelTres.Name = "lblDelTres";
            this.lblDelTres.Size = new System.Drawing.Size(32, 13);
            this.lblDelTres.TabIndex = 5;
            this.lblDelTres.Text = "Del 3";
            // 
            // lblDelDos
            // 
            this.lblDelDos.AutoSize = true;
            this.lblDelDos.Location = new System.Drawing.Point(33, 57);
            this.lblDelDos.Name = "lblDelDos";
            this.lblDelDos.Size = new System.Drawing.Size(32, 13);
            this.lblDelDos.TabIndex = 4;
            this.lblDelDos.Text = "Del 2";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIniciar.Location = new System.Drawing.Point(130, 131);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(108, 23);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnJuego
            // 
            this.btnJuego.Location = new System.Drawing.Point(170, 204);
            this.btnJuego.Name = "btnJuego";
            this.btnJuego.Size = new System.Drawing.Size(75, 23);
            this.btnJuego.TabIndex = 4;
            this.btnJuego.Text = "Juego";
            this.btnJuego.UseVisualStyleBackColor = true;
            this.btnJuego.Click += new System.EventHandler(this.btnJuego_Click);
            // 
            // tmrx2
            // 
            this.tmrx2.Interval = 47;
            this.tmrx2.Tick += new System.EventHandler(this.tmrx2_Tick);
            // 
            // tmrx3
            // 
            this.tmrx3.Interval = 70;
            this.tmrx3.Tick += new System.EventHandler(this.tmrx3_Tick);
            // 
            // tmrx5
            // 
            this.tmrx5.Interval = 125;
            this.tmrx5.Tick += new System.EventHandler(this.tmrx5_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 245);
            this.Controls.Add(this.btnJuego);
            this.Controls.Add(this.govMultiplos);
            this.Name = "Form1";
            this.Text = "Inicio App";
            this.govMultiplos.ResumeLayout(false);
            this.govMultiplos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.GroupBox govMultiplos;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnJuego;
        private System.Windows.Forms.Timer tmrx2;
        private System.Windows.Forms.Timer tmrx3;
        private System.Windows.Forms.Timer tmrx5;
        private System.Windows.Forms.Label lblDelCinco;
        private System.Windows.Forms.Label lblDelTres;
        private System.Windows.Forms.Label lblDelDos;
    }
}

