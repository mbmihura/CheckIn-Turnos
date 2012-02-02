using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dbTurnos.Excepciones;
using CheckIn_Turnos.Excepciones;
using dbTurnos;

namespace CheckIn_Turnos
{
    static class ErrorHandlerForGUI
    {
        private static Log2File _log;

        public static void intentar(Action sinManejoDeExcepciones)
        {          
            try
            {
                sinManejoDeExcepciones();
            }
            catch (UsuarioCancelaException)
            {
                //no hacer nada: como el usuario cancelo, no devuele id de usuario por lo que no me interesa seguir con el flujo normal del CU
            }
            catch (System.Data.OleDb.OleDbException ex)
            {
                TraceException(ex, "App fin");
                ShowMessageBox(ex, "Ocurrió un problema con la Base de Datos y no se puedo abrir la conexion con la misma. " + ex.Message, false);
            } 
            catch (InvalidOperationException ex)
            {
                TraceException(ex, "App fin");
                ShowMessageBox(ex, "Ocurrió un problema con la Base de Datos y el programa no puede trabajar con la misma.");

            }
            catch (FormatException ex)
            {
                TraceException(ex, "App fin");
                ShowMessageBox(ex, "Ocurrió un problema con la configuracion actual de la Base de Datos, por lo que el programa no puede entender la informacion devuelta por la misma.");
            }
            catch (InvalidCastException ex)
            {
                TraceException(ex, "App fin");
                ShowMessageBox(ex, "Ocurrió un problema con la configuracion de la base de datos, el programa no puede trabajar con la informacion devuelta.");
            }
            catch (OverflowException ex)
            {
                TraceException(ex, "App fin");
                ShowMessageBox(ex, "Ocurrió un problema con la configuracion de la base de datos, y el rango de enteros menejado por la base de datos es demasiado grande por su sistema operativo.");
            }
            catch (IndexOutOfRangeException ex)
            {
                TraceException(ex, "App fin");
                ShowMessageBox(ex, "Ocurrió un problema con la configuracion de la base de datos. " + ex.Message);
            }
            catch (Exception ex)
            {
                TraceException(ex, "App fin");
                ShowMessageBox(ex);
            }
        }

        public static  void LogTo(Log2File log)
        { _log = log; }

        internal static void TraceException(Exception ex)
        {
            if (_log != null)
                _log.TraceException(ex, "ErrHandler4GUI");
        }
        internal static void TraceException(Exception ex, string msj = "")
        {
            if (_log != null)
            {
                if (msj != "")
                    msj = ": " + msj;
                _log.TraceException(ex, "ErrHandler4GUI");
            }
        }
        internal static void ShowMessageBox(Exception ex, string msj = "Ocurrió un error que el programa no puede solucionar.", bool displayErrorType = true)
        {
            string errType = "";
            TurnosForm.DetenerTimers = 
            if (displayErrorType)
                errType = "Tipo de error:" + ex.GetType();
            if (DialogResult.Yes == MessageBox.Show(msj + errType + Environment.NewLine + Environment.NewLine + "El error se registró en el log, el programa se finalizará. ¿Desea reiniciarlo a continuación?", "Error con la Base De Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Error,MessageBoxDefaultButton.Button2))
                    Application.Restart();
                else
                    Application.Exit();
        }
    }
}
