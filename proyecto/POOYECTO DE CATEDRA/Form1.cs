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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Realizar_Pedido realizarPedido;
        Ventana_Empleados Empleados;
        Gerente_Dueño Dueño;
        Pagos Pagos;
        
        bool expandirMenu = false;
        bool expandirMenu2 = false;

        private void transicion_menú_Tick(object sender, EventArgs e)
        {
            if (expandirMenu == false)
            {
                menuConteiner1.Height += 25;
                if (menuConteiner1.Height >= 162)
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
                if(barraMenu.Width <=55)
                {
                    timerbarra.Stop();
                    expandirBarra = false;
                }
            }
            else
            {
                barraMenu.Width += 25;
                if(barraMenu.Width >=220)
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

        //Boton de iniciar sesion, atraves de un login se determinara si abrir una ventana u otra 
        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        //Ventana para realizar pedidos
        private void btnRpedido_Click(object sender, EventArgs e)
        {
            if (realizarPedido == null)
            { 
                realizarPedido = new Realizar_Pedido();
                realizarPedido.FormClosed += Realizar_Pedido_FormClosed;
                realizarPedido.MdiParent = this;
                realizarPedido.Show();
            }
            else
            {
                realizarPedido.Activate();
            }
        }
        private void Realizar_Pedido_FormClosed(object sender, EventArgs e)
        {
            realizarPedido= null;
        }

        //Ventana para realizar pagos
        private void btnPagos_Click(object sender, EventArgs e)
        {
            if (Pagos == null)
            {
                Pagos = new Pagos();
                Pagos.FormClosed += Pagos_FormClosed;
                Pagos.MdiParent = this;
                Pagos.Show();
            }
            else
            {
                realizarPedido.Activate();
            }
        }
        private void Pagos_FormClosed(object sender, EventArgs e)
        {
            realizarPedido = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barraMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

