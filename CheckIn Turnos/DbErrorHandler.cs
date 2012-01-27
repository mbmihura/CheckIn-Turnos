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
    static class ErrorHandlerForUserInterface
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
                log(ex);
                MessageBox.Show("Ocurrió un problema con la Base de Datos y no se puedo abrir la conexion con la misma." + Environment.NewLine + ex.Message, "Error con la Base De Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                log(ex);
                MessageBox.Show("Ocurrió un problema con la Base de Datos y el programa no puede comunicarse con la misma" + Environment.NewLine + "Mensaje de Error: " + ex.Message, "Error con la Base De Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                log(ex);
                MessageBox.Show("Ocurrió un problema con la configuracion actual de la Base de Datos, por lo que el programa no puede entender la informacion devuelta por la misma." + Environment.NewLine + "Mensaje de Error: " + ex.Message, "Error con la Base De Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidCastException ex)
            {
                log(ex);
                MessageBox.Show("Ocurrió un problema con la configuracion de la base de datos, el programa no puede trabajar con la informacion devuelta." + Environment.NewLine + "Mensaje de Error: " + ex.Message, "Error con la Base De Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (OverflowException ex)
            {
                log(ex);
                MessageBox.Show("Ocurrió un problema con la configuracion de la base de datos, y el rango de enteros menejado por la base de datos es demasiado grande por su sistema operativo." + Environment.NewLine + "Mensaje de Error: " + ex.Message, "Error con la Base De Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException ex)
            {
                log(ex);
                MessageBox.Show("Ocurrió un problema con la configuracion de la base de datos, el error se registro en el log de eventos." + Environment.NewLine + "Mensaje de Error: " + ex.Message, "Error con la Base De Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                log(ex);
                MessageBox.Show("Ocurrió un error que el programa no puede solucionar." + Environment.NewLine + ex.Message + Environment.NewLine + "El mismo se registro en el log de eventos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void logTo(Log2File log)
        {
            _log = log;
        }
        private static void log(Exception ex)
        {
            if (_log != null)
                _log.TraceException(ex);
        }
    }
}
