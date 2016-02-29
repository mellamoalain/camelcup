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
    public partial class ApuestaFinalForm : Form
    {
        Modelo.Juego miJuego;
       
        public ApuestaFinalForm(Modelo.Juego j)
        {
            InitializeComponent();
            miJuego = j;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApuestaFinalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
