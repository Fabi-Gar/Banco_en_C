namespace Banco_C_.Vistas
{
    partial class frmDepositos
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
            this.txtNumCuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaDepositos = new System.Windows.Forms.DateTimePicker();
            this.txtSaldoADepositar = new System.Windows.Forms.TextBox();
            this.dtDepositos = new System.Windows.Forms.DataGridView();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtDepositos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de deposito";
            // 
            // txtNumCuenta
            // 
            this.txtNumCuenta.Location = new System.Drawing.Point(115, 25);
            this.txtNumCuenta.Name = "txtNumCuenta";
            this.txtNumCuenta.Size = new System.Drawing.Size(221, 20);
            this.txtNumCuenta.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Saldo a Depositar";
            // 
            // fechaDepositos
            // 
            this.fechaDepositos.Location = new System.Drawing.Point(115, 321);
            this.fechaDepositos.Name = "fechaDepositos";
            this.fechaDepositos.Size = new System.Drawing.Size(221, 20);
            this.fechaDepositos.TabIndex = 4;
            // 
            // txtSaldoADepositar
            // 
            this.txtSaldoADepositar.Location = new System.Drawing.Point(115, 354);
            this.txtSaldoADepositar.Name = "txtSaldoADepositar";
            this.txtSaldoADepositar.Size = new System.Drawing.Size(221, 20);
            this.txtSaldoADepositar.TabIndex = 5;
            // 
            // dtDepositos
            // 
            this.dtDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDepositos.Location = new System.Drawing.Point(12, 50);
            this.dtDepositos.Name = "dtDepositos";
            this.dtDepositos.Size = new System.Drawing.Size(541, 253);
            this.dtDepositos.TabIndex = 6;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(416, 415);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(123, 34);
            this.btnDepositar.TabIndex = 7;
            this.btnDepositar.Text = "Realizar Deposito";
            this.btnDepositar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(352, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(201, 22);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmDepositos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.dtDepositos);
            this.Controls.Add(this.txtSaldoADepositar);
            this.Controls.Add(this.fechaDepositos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDepositos";
            this.Text = "Depositos";
            ((System.ComponentModel.ISupportInitialize)(this.dtDepositos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtNumCuenta;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtSaldoADepositar;
        public System.Windows.Forms.Button btnDepositar;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.DataGridView dtDepositos;
        public System.Windows.Forms.DateTimePicker fechaDepositos;
    }
}