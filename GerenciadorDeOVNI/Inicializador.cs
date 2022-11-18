using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeOVNI
{
    public partial class Inicializador : Form
    {
        public Inicializador()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarInterface();
        {
            grbTripulacao.Visible = ovni.situacao;
            grbPlanet.Visible = ovni.situacao;
            grbEstatisticas,Visible = GerenciadorDeOVNI.situacao;

        }



        private void Inicializador_Load(object sender, EventArgs e)
        {

        }

        private void Inicializador_Activated(object sender, EventArgs e)
        {

        }

        private void btncriar_Click(object sender, EventArgs e)
        {
            string planetaOrigem = cmbPlanetas.Text;
            int maxtripulantes = (int)txbtripulantes.Value;
            int maxabduzidos = (int)txbabduzidos.Value;
            //

            BibliotecaOVNI.OVNI = new BibliotecaOVNI.OVNI(maxtripulantes, maxabduzidos, planetaOrigem);

            // Mudar de Janela:
            Gerenciador gerenciador = new Gerenciador(ovni);
            gerenciador.showdialog();
        }
    }
}
