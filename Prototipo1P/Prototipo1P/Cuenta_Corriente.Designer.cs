namespace Prototipo1P
{
    partial class Cuenta_Corriente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_factura = new System.Windows.Forms.TextBox();
            this.lbl_factura = new System.Windows.Forms.Label();
            this.lbl_total_pagar = new System.Windows.Forms.Label();
            this.txt_total_paar = new System.Windows.Forms.TextBox();
            this.lbl_pagado = new System.Windows.Forms.Label();
            this.txt_pagado = new System.Windows.Forms.TextBox();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.lbl_deposito = new System.Windows.Forms.Label();
            this.txt_deposito = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_factura
            // 
            this.txt_factura.Location = new System.Drawing.Point(141, 61);
            this.txt_factura.Name = "txt_factura";
            this.txt_factura.Size = new System.Drawing.Size(153, 20);
            this.txt_factura.TabIndex = 0;
            this.txt_factura.TextChanged += new System.EventHandler(this.txt_factura_TextChanged);
            // 
            // lbl_factura
            // 
            this.lbl_factura.AutoSize = true;
            this.lbl_factura.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factura.Location = new System.Drawing.Point(21, 59);
            this.lbl_factura.Name = "lbl_factura";
            this.lbl_factura.Size = new System.Drawing.Size(103, 20);
            this.lbl_factura.TabIndex = 1;
            this.lbl_factura.Text = "No. Factura";
            // 
            // lbl_total_pagar
            // 
            this.lbl_total_pagar.AutoSize = true;
            this.lbl_total_pagar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.lbl_total_pagar.Location = new System.Drawing.Point(315, 59);
            this.lbl_total_pagar.Name = "lbl_total_pagar";
            this.lbl_total_pagar.Size = new System.Drawing.Size(119, 20);
            this.lbl_total_pagar.TabIndex = 3;
            this.lbl_total_pagar.Text = "Total a pagar";
            // 
            // txt_total_paar
            // 
            this.txt_total_paar.Location = new System.Drawing.Point(440, 61);
            this.txt_total_paar.Name = "txt_total_paar";
            this.txt_total_paar.Size = new System.Drawing.Size(153, 20);
            this.txt_total_paar.TabIndex = 2;
            // 
            // lbl_pagado
            // 
            this.lbl_pagado.AutoSize = true;
            this.lbl_pagado.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.lbl_pagado.Location = new System.Drawing.Point(44, 112);
            this.lbl_pagado.Name = "lbl_pagado";
            this.lbl_pagado.Size = new System.Drawing.Size(69, 20);
            this.lbl_pagado.TabIndex = 5;
            this.lbl_pagado.Text = "Pagado";
            this.lbl_pagado.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_pagado
            // 
            this.txt_pagado.Location = new System.Drawing.Point(141, 112);
            this.txt_pagado.Name = "txt_pagado";
            this.txt_pagado.Size = new System.Drawing.Size(153, 20);
            this.txt_pagado.TabIndex = 4;
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.lbl_saldo.Location = new System.Drawing.Point(356, 116);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(54, 20);
            this.lbl_saldo.TabIndex = 7;
            this.lbl_saldo.Text = "Saldo";
            // 
            // txt_saldo
            // 
            this.txt_saldo.Location = new System.Drawing.Point(440, 116);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(153, 20);
            this.txt_saldo.TabIndex = 6;
            // 
            // lbl_deposito
            // 
            this.lbl_deposito.AutoSize = true;
            this.lbl_deposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_deposito.Location = new System.Drawing.Point(342, 170);
            this.lbl_deposito.Name = "lbl_deposito";
            this.lbl_deposito.Size = new System.Drawing.Size(73, 20);
            this.lbl_deposito.TabIndex = 9;
            this.lbl_deposito.Text = "Deposito";
            // 
            // txt_deposito
            // 
            this.txt_deposito.Location = new System.Drawing.Point(440, 172);
            this.txt_deposito.Name = "txt_deposito";
            this.txt_deposito.Size = new System.Drawing.Size(153, 20);
            this.txt_deposito.TabIndex = 8;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.btn_guardar.Location = new System.Drawing.Point(454, 248);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(139, 56);
            this.btn_guardar.TabIndex = 10;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Cuenta_Corriente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lbl_deposito);
            this.Controls.Add(this.txt_deposito);
            this.Controls.Add(this.lbl_saldo);
            this.Controls.Add(this.txt_saldo);
            this.Controls.Add(this.lbl_pagado);
            this.Controls.Add(this.txt_pagado);
            this.Controls.Add(this.lbl_total_pagar);
            this.Controls.Add(this.txt_total_paar);
            this.Controls.Add(this.lbl_factura);
            this.Controls.Add(this.txt_factura);
            this.Name = "Cuenta_Corriente";
            this.Text = "Cuenta_Corriente";
            this.Load += new System.EventHandler(this.Cuenta_Corriente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_factura;
        private System.Windows.Forms.Label lbl_factura;
        private System.Windows.Forms.Label lbl_total_pagar;
        private System.Windows.Forms.TextBox txt_total_paar;
        private System.Windows.Forms.Label lbl_pagado;
        private System.Windows.Forms.TextBox txt_pagado;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.TextBox txt_saldo;
        private System.Windows.Forms.Label lbl_deposito;
        private System.Windows.Forms.TextBox txt_deposito;
        private System.Windows.Forms.Button btn_guardar;
    }
}