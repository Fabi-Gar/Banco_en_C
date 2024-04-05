using Banco_C_.Modelo;
using Banco_C_.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Banco_C_.Modelo.conexion;
using System.Windows.Forms;
using System.Data;
using System.Globalization;


namespace Banco_C_.Controlador
{
    internal class programaControl
    {
        
        //Se cargan todas las clases que usara el constructor y luego se les asigna un nombre mas comodo

        frmLogin vistaLogin;
        frmPrincipal vistaPrincipal;
        frmAgregarCuentas vistaAgregarCuentas;
        frmDepositos vistaDepositos;

        sqlProcesos infoProcesos;

        public programaControl(frmLogin vistaLogin, frmPrincipal vistaPrincipal, frmAgregarCuentas vistaAgregarCuentas, frmDepositos vistaDepositos, sqlProcesos infoProcesos)
        {
            this.vistaLogin = vistaLogin;
            this.vistaPrincipal = vistaPrincipal;
            this.vistaAgregarCuentas = vistaAgregarCuentas;
            this.vistaDepositos = vistaDepositos;
            this.infoProcesos = infoProcesos;

            //esto activa la escucha de los botones para que estos funcionen al ser clickeados
            vistaLogin.btnIniciarSesion.Click += clickBoton;
            vistaPrincipal.btnAgregar.Click += clickBoton;
            vistaPrincipal.btnDepositos.Click += clickBoton;
            vistaPrincipal.btnRetiros.Click += clickBoton;

            vistaAgregarCuentas.btnAgregarCuenta.Click += clickBoton;
            
            vistaDepositos.btnBuscar.Click += clickBoton;
            vistaDepositos.btnDepositar.Click += clickBoton;

            vistaPrincipal.FormClosing += VistaMenu_FormClosing;

            //Muestra los forms principales al momento de cargar el programa
            vistaPrincipal.Show();
            vistaLogin.ShowDialog();

        }


        // Cierra la aplicación completamente cuando se cierre el formulario VistaMenu
        private void VistaMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Este metodo es el que obtiene la informacion de que boton se presiona
        private void clickBoton(object sender, EventArgs e)
        {
            //Los ifs funcionan para saber que boton fue presionado
            if (sender == vistaLogin.btnIniciarSesion)
            {
                Miconexion.user = vistaLogin.txtUsuario.Text;
                Miconexion.pass = vistaLogin.txtContraseña.Text;

                Miconexion.abrir_conexion();
                System.Data.ConnectionState estadoConexion = Miconexion.ObtenerEstadoConexion();

                if (estadoConexion == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("login correcto");
                    vistaLogin.Close();

                }
                else
                {
                    MessageBox.Show("Contraseña o Usuario Incorrectos");
                }
            }

            if (sender == vistaPrincipal.btnAgregar)
            {
                if (vistaAgregarCuentas == null || vistaAgregarCuentas.IsDisposed)
                {
                    vistaAgregarCuentas = new frmAgregarCuentas();
                }
                vistaAgregarCuentas.Show();
                modeloTablas datos = new modeloTablas();
                DataTable dataTable = datos.TablaCuentas();
                vistaAgregarCuentas.dtAgregarCuentas.DataSource = dataTable;
            }

            if (sender == vistaPrincipal.btnDepositos)
            {
                if (vistaDepositos == null || vistaDepositos.IsDisposed)
                {
                    vistaAgregarCuentas = new frmDepositos();
                }

                vistaDepositos.Show();
            }

            if (sender == vistaAgregarCuentas.btnAgregarCuenta)
            {
                {
                    DialogResult result = MessageBox.Show("¿Quieres agregar una nueva cuenta?", "Confirmación", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        sqlProcesos.agregarCuenta(vistaAgregarCuentas.txtApellidos.Text, vistaAgregarCuentas.txtNombres.Text, vistaAgregarCuentas.txtSaldo.Text);
                        modeloTablas datos = new modeloTablas();
                        DataTable dataTable = datos.TablaCuentas();
                        vistaAgregarCuentas.dtAgregarCuentas.DataSource = dataTable;
                    }
                    else
                    {

                    }
                }
            }

            if (sender == vistaDepositos.btnBuscar)
            {
                modeloTablas datos = new modeloTablas();
                DataTable dataTable = datos.TablaDepositos(vistaDepositos.txtNumCuenta.Text);
                vistaDepositos.dtDepositos.DataSource = dataTable;

                if (dataTable.Rows.Count > 0)
                { vistaDepositos.btnDepositar.Enabled = true; }
                else
                { vistaDepositos.btnDepositar.Enabled = false; }
            }

            if (sender == vistaDepositos.btnDepositar)
            {
                

                DialogResult result = MessageBox.Show("¿Quieres agregar un nuevo deposito?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    sqlProcesos.realizarDeposito(vistaDepositos.Text, vistaDepositos.fechaDepositos.Value, vistaDepositos.txtSaldoADepositar.Text);
                    modeloTablas datos = new modeloTablas();
                    DataTable dataTable = datos.TablaDepositos(vistaDepositos.txtNumCuenta.Text);
                    vistaDepositos.dtDepositos.DataSource = dataTable;

                    vistaDepositos.txtNumCuenta.ResetText();
                    vistaDepositos.txtSaldoADepositar.ResetText();


                }
                else
                {
                    vistaDepositos.txtNumCuenta.ResetText();
                    vistaDepositos.txtSaldoADepositar.ResetText();
                    MessageBox.Show("Deposito Cancelado");
                }
            }
        }
    }
}
