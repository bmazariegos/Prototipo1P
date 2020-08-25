using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo1P
{
    public partial class Cuenta_Corriente : Form
    {
        Conexion con = new Conexion();
        public Cuenta_Corriente()
        {
            InitializeComponent();
        }


        public void llenado()
        {
            try
            {
                string strSql = "SELECT saldorestante_cobro  FROM tbl_cobro WHERE fk_idfactura_cobro = " + txt_factura.Text + ";";
                OdbcCommand command = new OdbcCommand(strSql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txt_saldo.Text = reader[0].ToString();
                  
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
        public void llenado_total()
        {
            try
            {
                string strSql1 = "SELECT total_factura  FROM tbl_factura WHERE pk_id_factura = " + txt_factura.Text + ";";
                OdbcCommand command1 = new OdbcCommand(strSql1, con.conexion());
                OdbcDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    txt_total_paar.Text = reader1[0].ToString();

                }
                reader1.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
        public void limpiar()
        {
            txt_deposito.Text = "";
            txt_total_paar.Text = "";
            txt_pagado.Text = "";
            txt_saldo.Text = "";
            txt_factura.Text = "";
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_factura_TextChanged(object sender, EventArgs e)
        {
            llenado();
            llenado_total();
            int pagado = (Convert.ToInt32(txt_total_paar.Text)) - (Convert.ToInt32(txt_saldo.Text));
            txt_pagado.Text = Convert.ToString(pagado);
            
        }

        private void Cuenta_Corriente_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
