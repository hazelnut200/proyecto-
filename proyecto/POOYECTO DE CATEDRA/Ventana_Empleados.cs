using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOYECTO_DE_CATEDRA
{
    public partial class Ventana_Empleados : Form
    {
        public Ventana_Empleados()
        {
            InitializeComponent();
        }

        private void Ventana_Empleados_Load(object sender, EventArgs e)
        {

        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {

        }

        private void btnRevisar_Click(object sender, EventArgs e)
        {

        }

        private void btnPeRealizados_Click(object sender, EventArgs e)
        {

        }

        bool expandirMenu = false;
        private void transicion_menú_Tick(object sender, EventArgs e)
        {
            if (expandirMenu == false)
            {
                menuConteiner1.Height += 25;
                if (menuConteiner2.Height >= 162)
                {
                    transicion_menú.Stop();
                    expandirMenu = true;
                }
            }
            else
            {
                menuConteiner1.Height -= 25;
                if (menuConteiner1.Height <= 49)
                {
                    transicion_menú.Stop();
                    expandirMenu = false;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            transicion_menú.Start();
        }
        bool expandirMenu2 = false;
        private void transicion_menú2_Tick(object sender, EventArgs e)
        {
            if (expandirMenu2 == false)
            {
                menuConteiner2.Height += 25;
                if (menuConteiner2.Height >= 110)
                {
                    transicion_menú2.Stop();
                    expandirMenu2 = true;
                }
            }
            else
            {
                menuConteiner2.Height -= 25;
                if (menuConteiner2.Height <= 49)
                {
                    transicion_menú2.Stop();
                    expandirMenu2 = false;
                }
            }
        }

        private void menu2_Click(object sender, EventArgs e)
        {
            transicion_menú2.Start();
        }

        bool expandirBarra = false;

        private void timerbarra_Tick(object sender, EventArgs e)
        {
            if (expandirBarra)
            {
                barraMenu.Width -= 25;
                if (barraMenu.Width <= 55)
                {
                    timerbarra.Stop();
                    expandirBarra = false;
                }
            }
            else
            {
                barraMenu.Width += 25;
                if (barraMenu.Width >= 220)
                {
                    timerbarra.Stop();
                    expandirBarra = true;
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerbarra.Start();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuConteiner2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
