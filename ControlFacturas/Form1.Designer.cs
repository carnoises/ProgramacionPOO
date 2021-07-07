
namespace ControlFacturas
{
    partial class frmFacturas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.txtNumFact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoFact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaFact = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lvRegistro = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblComision = new System.Windows.Forms.Label();
            this.lblTotalSub = new System.Windows.Forms.Label();
            this.lblTotalFact = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE FACTURAS DE VENDEDORES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "VENDEDOR";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(119, 59);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(309, 20);
            this.txtVendedor.TabIndex = 2;
            // 
            // txtNumFact
            // 
            this.txtNumFact.Location = new System.Drawing.Point(119, 85);
            this.txtNumFact.Name = "txtNumFact";
            this.txtNumFact.Size = new System.Drawing.Size(123, 20);
            this.txtNumFact.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "N. FACTURA";
            // 
            // txtMontoFact
            // 
            this.txtMontoFact.Location = new System.Drawing.Point(119, 111);
            this.txtMontoFact.Name = "txtMontoFact";
            this.txtMontoFact.Size = new System.Drawing.Size(123, 20);
            this.txtMontoFact.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "MONTO FACTURA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "FECHA FACT.";
            // 
            // dtpFechaFact
            // 
            this.dtpFechaFact.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFact.Location = new System.Drawing.Point(325, 85);
            this.dtpFechaFact.Name = "dtpFechaFact";
            this.dtpFechaFact.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaFact.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "FECHA:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(485, 62);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 13);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "lblFecha";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(325, 111);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(103, 23);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(434, 111);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lvRegistro
            // 
            this.lvRegistro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvRegistro.GridLines = true;
            this.lvRegistro.HideSelection = false;
            this.lvRegistro.Location = new System.Drawing.Point(15, 141);
            this.lvRegistro.Name = "lvRegistro";
            this.lvRegistro.Size = new System.Drawing.Size(525, 180);
            this.lvRegistro.TabIndex = 13;
            this.lvRegistro.UseCompatibleStateImageBehavior = false;
            this.lvRegistro.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NUM. FACTURA";
            this.columnHeader1.Width = 145;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FECHA FACTURACION";
            this.columnHeader2.Width = 226;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "MONTO FACTURADO";
            this.columnHeader3.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblComision);
            this.groupBox1.Controls.Add(this.lblTotalSub);
            this.groupBox1.Controls.Add(this.lblTotalFact);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(15, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 104);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MONTOS ASIGNADOS AL VENDEDOR POR EL REISTRO DE FACTURAS";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(341, 62);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(59, 13);
            this.lblComision.TabIndex = 7;
            this.lblComision.Text = "lblComision";
            // 
            // lblTotalSub
            // 
            this.lblTotalSub.AutoSize = true;
            this.lblTotalSub.Location = new System.Drawing.Point(176, 62);
            this.lblTotalSub.Name = "lblTotalSub";
            this.lblTotalSub.Size = new System.Drawing.Size(60, 13);
            this.lblTotalSub.TabIndex = 6;
            this.lblTotalSub.Text = "lblTotalSub";
            // 
            // lblTotalFact
            // 
            this.lblTotalFact.AutoSize = true;
            this.lblTotalFact.Location = new System.Drawing.Point(26, 62);
            this.lblTotalFact.Name = "lblTotalFact";
            this.lblTotalFact.Size = new System.Drawing.Size(62, 13);
            this.lblTotalFact.TabIndex = 5;
            this.lblTotalFact.Text = "lblTotalFact";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(341, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "COMISION ASIGNADA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "TOTAL SUBTOTAL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "TOTAL FACTURAS";
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 447);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvRegistro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFechaFact);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMontoFact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumFact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFacturas";
            this.Text = "Control de facturas de vendedores";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.TextBox txtNumFact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontoFact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaFact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListView lvRegistro;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label lblTotalSub;
        private System.Windows.Forms.Label lblTotalFact;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

