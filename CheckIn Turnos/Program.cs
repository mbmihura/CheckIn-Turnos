﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using dbTurnos;

namespace CheckIn_Turnos
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Log2File log = new Log2File(Application.StartupPath + "\\AppException.log", false);
                log.WriteLine("INICIA APPLICACION ...........................");
                InterfazDb.Iniciar(Application.StartupPath, log);
                ErrorHandlerForGUI.LogTo(log);
            }
            catch (LoadingLog2FileException ex)
            {
                MessageBox.Show(ex.Message, "Falla Sistema de Registro de Eventos: Log", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Application.Run(new TurnosForm());
        }
    }
}
