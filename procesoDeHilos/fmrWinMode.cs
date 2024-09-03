using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace procesoDeHilos
{
    public partial class fmrWinMode : Form
    {
        public fmrWinMode()
        {
            InitializeComponent();
        }

        bool glMoverDer = true;
        int gnVelocidadNave = 20;

        private void fmrWinMode_Load(object sender, EventArgs e)
        {
            picUFO.ImageLocation = Application.StartupPath + ("//nave.PNG");
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            tmrUFO.Enabled = true; 
        }

        private void tmrUFO_Tick(object sender, EventArgs e)
        {
            if (glMoverDer)
            {
                picUFO.Left += gnVelocidadNave;
            }
            else
            {
                picUFO.Left -= gnVelocidadNave;
            }

            if (picUFO.Right >= this.ClientSize.Width)
            {
                glMoverDer = false; 
            }
            else if (picUFO.Left <= 0)
            {
                glMoverDer = true;
            }
        }
    }
}