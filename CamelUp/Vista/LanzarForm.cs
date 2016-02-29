using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamelUp
{
    public partial class LanzarForm : Form
    {
        Modelo.Juego miJuego;
        public LanzarForm(Modelo.Juego j)
        {
            InitializeComponent();
            miJuego = j;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            miJuego.Dados[0] = 3;
            
            this.Close();
        }

        private void LanzarForm_Load(object sender, EventArgs e)
        {

        }
    }
}
