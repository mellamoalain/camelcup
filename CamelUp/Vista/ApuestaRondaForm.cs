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
    public partial class ApuestaRondaForm : Form
    {
        Modelo.Juego miJuego;
        
        public ApuestaRondaForm(Modelo.Juego j)
        {
            InitializeComponent();
            miJuego = j;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApuestaRondaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
