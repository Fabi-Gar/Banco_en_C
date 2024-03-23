using Banco_C_.Controlador;
using Banco_C_.Modelo;
using Banco_C_.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_C_
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            frmLogin vistaLogin = new frmLogin();
            frmPrincipal vistaPrincipal = new frmPrincipal();
            frmAgregarCuentas vistaAgregarCuentas = new frmAgregarCuentas();
            frmDepositos vistaDepositos = new frmDepositos();

            sqlProcesos infoProcesos = new sqlProcesos();

            programaControl controlador = new programaControl(vistaLogin, vistaPrincipal, vistaAgregarCuentas, vistaDepositos, infoProcesos);

            Application.Run();
        }
    }
}
