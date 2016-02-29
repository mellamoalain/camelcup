using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamelUp.Modelo;

namespace CamelUp
{
    public partial class FormPrincipal : Form
    {
        //Controller.Controlador c = new Controller.Controlador();
        Juego j;
        string temp = "";

        public FormPrincipal()
        {
            InitializeComponent();
            j = new Juego(4);
            
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            refrescarTodo();

        }

        private void nuevaPartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            j.reiniciarJuego();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void instruccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeCamelUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About f1 = new About();
            f1.ShowDialog();
        }
    
        private void btnLanzarDado_Click(object sender, EventArgs e)
        {
            LanzarForm f1 = new LanzarForm(j);
            f1.ShowDialog();
        }

        private void btnApuestaFinal_Click(object sender, EventArgs e)
        {
            ApuestaFinalForm f = new ApuestaFinalForm(j);
            f.ShowDialog();
        }

        private void btnApostarRonda_Click(object sender, EventArgs e)
        {
            ApuestaRondaForm f = new ApuestaRondaForm(j);
            f.ShowDialog(this);
        }

        private void btnColocarLoseta_Click(object sender, EventArgs e)
        {
            LosetaForm f = new LosetaForm(j);
            f.ShowDialog();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Primer dado: " + j.Dados[0]);
            //Console.WriteLine("Primer dado: " + j.Dados[0]);
            refrescarTodo();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {

        }



        public void refrescarTodo()
        {
            refrescarCamellos();
            refrescarDados();
            lbNota.Text = j.UltimaAccion;
            lbMonedas.Text = j.Jugadores[0].Dinero.ToString();

        }
        private void refrescarCamellos()
        {
            List<Label> labels;
            int i;
            
            foreach (Control cComponente in panelTablero.Controls)
            {
                //Recorrer 16 paneles para ver en que casillas están los camellos
                if (cComponente is Panel && cComponente.Name.Substring(0,4).Equals("pCas"))
                {
                    int numCasilla = int.Parse(cComponente.Tag.ToString());
                    Casilla cas = j.Tablero[numCasilla];
                    labels = enlistarLabels(numCasilla);
                    i = 0;
                    foreach (Label l in labels)
                    {
                        if (i < cas.Camellos.Count)
                        {
                            l.Visible = true;
                            l.Text = cas.Camellos[i].Nombre;
                            l.BackColor = cas.Camellos[i].ColCam;
                            i++; 
                        }
                        else
                        {
                            l.Visible = false;
                        }
                        
                    }

                }
            }

            //Casilla 0
            Casilla cas0 = j.Tablero[0];
            labels = enlistarLabels(0);
            i = 0;
            foreach (Label l in labels)
            {
                if (i < cas0.Camellos.Count)
                {
                    l.Visible = true;
                    l.Text = cas0.Camellos[i].Nombre;
                    l.BackColor = cas0.Camellos[i].ColCam;
                    i++;
                }
            }

            //Casilla 17
            Casilla cas17 = j.Tablero[17];
            labels = enlistarLabels(17);
            i = 0;
            foreach (Label l in labels)
            {
                if (i < cas17.Camellos.Count)
                {
                    l.Visible = true;
                    l.Text = cas17.Camellos[i].Nombre;
                    l.BackColor = cas17.Camellos[i].ColCam;
                    i++;
                }
            }
        }

        private List<Label> enlistarLabels(int casilla)
        {
            List<Label> labels = new List<Label>();
            switch(casilla)
            {
                case 0:
                    labels.Add(lbCas16Cam1);
                    labels.Add(lbCas16Cam2);
                    labels.Add(lbCas16Cam3);
                    labels.Add(lbCas16Cam4);
                    labels.Add(lbCas16Cam5);
                    break;
                case 1:
                    labels.Add(lbCas1Cam1);
                    labels.Add(lbCas1Cam2);
                    labels.Add(lbCas1Cam3);
                    labels.Add(lbCas1Cam4);
                    labels.Add(lbCas1Cam5);
                    break;
                case 2:
                    labels.Add(lbCas2Cam1);
                    labels.Add(lbCas2Cam2);
                    labels.Add(lbCas2Cam3);
                    labels.Add(lbCas2Cam4);
                    labels.Add(lbCas2Cam5);
                    break;
                case 3:
                    labels.Add(lbCas3Cam1);
                    labels.Add(lbCas3Cam2);
                    labels.Add(lbCas3Cam3);
                    labels.Add(lbCas3Cam4);
                    labels.Add(lbCas3Cam5);
                    break;
                case 4:
                    labels.Add(lbCas4Cam1);
                    labels.Add(lbCas4Cam2);
                    labels.Add(lbCas4Cam3);
                    labels.Add(lbCas4Cam4);
                    labels.Add(lbCas4Cam5);
                    break;
                case 5:
                    labels.Add(lbCas5Cam1);
                    labels.Add(lbCas5Cam2);
                    labels.Add(lbCas5Cam3);
                    labels.Add(lbCas5Cam4);
                    labels.Add(lbCas5Cam5);
                    break;
                case 6:
                    labels.Add(lbCas6Cam1);
                    labels.Add(lbCas6Cam2);
                    labels.Add(lbCas6Cam3);
                    labels.Add(lbCas6Cam4);
                    labels.Add(lbCas6Cam5);
                    break;
                case 7:
                    labels.Add(lbCas7Cam1);
                    labels.Add(lbCas7Cam2);
                    labels.Add(lbCas7Cam3);
                    labels.Add(lbCas7Cam4);
                    labels.Add(lbCas7Cam5);
                    break;
                case 8:
                    labels.Add(lbCas8Cam1);
                    labels.Add(lbCas8Cam2);
                    labels.Add(lbCas8Cam3);
                    labels.Add(lbCas8Cam4);
                    labels.Add(lbCas8Cam5);
                    break;
                case 9:
                    labels.Add(lbCas9Cam1);
                    labels.Add(lbCas9Cam2);
                    labels.Add(lbCas9Cam3);
                    labels.Add(lbCas9Cam4);
                    labels.Add(lbCas9Cam5);
                    break;
                case 10:
                    labels.Add(lbCas10Cam1);
                    labels.Add(lbCas10Cam2);
                    labels.Add(lbCas10Cam3);
                    labels.Add(lbCas10Cam4);
                    labels.Add(lbCas10Cam5);
                    break;
                case 11:
                    labels.Add(lbCas11Cam1);
                    labels.Add(lbCas11Cam2);
                    labels.Add(lbCas11Cam3);
                    labels.Add(lbCas11Cam4);
                    labels.Add(lbCas11Cam5);
                    break;
                case 12:
                    labels.Add(lbCas12Cam1);
                    labels.Add(lbCas12Cam2);
                    labels.Add(lbCas12Cam3);
                    labels.Add(lbCas12Cam4);
                    labels.Add(lbCas12Cam5);
                    break;
                case 13:
                    labels.Add(lbCas13Cam1);
                    labels.Add(lbCas13Cam2);
                    labels.Add(lbCas13Cam3);
                    labels.Add(lbCas13Cam4);
                    labels.Add(lbCas13Cam5);
                    break;
                case 14:
                    labels.Add(lbCas14Cam1);
                    labels.Add(lbCas14Cam2);
                    labels.Add(lbCas14Cam3);
                    labels.Add(lbCas14Cam4);
                    labels.Add(lbCas14Cam5);
                    break;
                case 15:
                    labels.Add(lbCas15Cam1);
                    labels.Add(lbCas15Cam2);
                    labels.Add(lbCas15Cam3);
                    labels.Add(lbCas15Cam4);
                    labels.Add(lbCas15Cam5);
                    break;
                case 16:
                    labels.Add(lbCas16Cam1);
                    labels.Add(lbCas16Cam2);
                    labels.Add(lbCas16Cam3);
                    labels.Add(lbCas16Cam4);
                    labels.Add(lbCas16Cam5);
                    break;
                case 17:
                    labels.Add(lbCas1Cam1);
                    labels.Add(lbCas1Cam2);
                    labels.Add(lbCas1Cam3);
                    labels.Add(lbCas1Cam4);
                    labels.Add(lbCas1Cam5);
                    break;
            }
            return labels;
        }

        private void refrescarDados()
        {
            foreach (Control cComponente in pDados.Controls)
            {
                int numDado = int.Parse(cComponente.Tag.ToString());
                Label lab = (Label) cComponente;
                if (j.Dados[numDado] != 0)
                {
                    lab.Text = j.Dados[numDado].ToString();
                }
                else
                {
                    lab.Text = "";
                }
                
            }
        }

      
    }
}
