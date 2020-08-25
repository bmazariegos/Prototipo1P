using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo1P
{
    public partial class ContenedorMenu : Form
    {
        public ContenedorMenu()
        {
            InitializeComponent();
        }

        private void cuentaCorrienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cuenta_Corriente cc = new Cuenta_Corriente();
            cc.Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura factu = new Factura();
            factu.Show();

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario inv = new Inventario();
            inv.Show();
        }
    }
}
