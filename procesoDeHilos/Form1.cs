using System;
using System.Windows.Forms;
/*Jonnier Grajales Alzate
 28/08/2024
 Hilos De Proceso - Juego*/

namespace procesoDeHilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
           
            tmrx2.Enabled = true;
            tmrx3.Enabled = true;
            tmrx5.Enabled = true;
        }

        private void tmrx2_Tick(object sender, EventArgs e)
        {
            lbl1.Text = Convert.ToString(Convert.ToInt32(lbl1.Text) + 2);
            if(lbl1.Text == "100")
            {
                tmrx2.Enabled = false;
            }
        }

        private void tmrx3_Tick(object sender, EventArgs e)
        {
            lbl2.Text = Convert.ToString(Convert.ToInt32(lbl2.Text) + 3);
            if (lbl2.Text == "99")
            {
                tmrx3.Enabled = false;
            }
        }

        private void tmrx5_Tick(object sender, EventArgs e)
        {
            lbl3.Text = Convert.ToString(Convert.ToInt32(lbl3.Text) + 5);
            if (lbl3.Text == "100")
            {
                tmrx5.Enabled = false;
            }
        }

        private void btnJuego_Click(object sender, EventArgs e)
        {
            frmJuegoNave nuevoFormulario = new frmJuegoNave();
            this.Hide();
            nuevoFormulario.FormClosed += (s, args) => this.Close();
            nuevoFormulario.Show();
        }
    }
}
