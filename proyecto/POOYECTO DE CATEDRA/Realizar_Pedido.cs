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
    public partial class Realizar_Pedido : Form
    {
        int cafrijol, cmfrijol, caqueso, cmqueso, carev, cmrev, caayot, cmayot, capollo, cmpollo, cachi, cmchi;
        double totfrijol, totqueso, totrev, totayot, totpollo, totchi;

        public Realizar_Pedido()
        {
            InitializeComponent();
        }

        private void Realizar_Pedido_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            menu.Show();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            cafrijol= Convert.ToInt32(CA_frijol.Text);
            cmfrijol= Convert.ToInt32(CM_frijol.Text);
            caqueso = Convert.ToInt32(CA_queso.Text);
            cmqueso = Convert.ToInt32(CM_queso.Text);
            carev = Convert.ToInt32(CA_revuelta.Text);
            cmrev = Convert.ToInt32(CM_revuelta.Text);
            caayot = Convert.ToInt32(CA_ayote.Text);
            cmayot = Convert.ToInt32(CM_ayote.Text);
            capollo = Convert.ToInt32(CA_pollo.Text);
            cmpollo = Convert.ToInt32(CM_pollo.Text);
            cachi = Convert.ToInt32(CA_chicharron.Text);
            cmchi = Convert.ToInt32(CM_chicharron.Text);

            totfrijol = (cafrijol + cmfrijol) * 0.60;
            totqueso = (caqueso + cmqueso) * 0.75;
            totrev = (carev + cmrev) * 0.75;
            totayot = (caayot + cmayot) * 0.75;
            totpollo = (capollo + cmpollo) * 1.00;
            totchi = (cachi + cmchi) * 0.75;

            Pagos pagos = new Pagos();
            this.Hide();
            pagos.Show();
        }
    }
}
