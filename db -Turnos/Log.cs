using System;
using System.Diagnostics;
using System.IO;

namespace dbTurnos
{
    public class LoadingLog2FileException : Exception
    {
        public LoadingLog2FileException(Exception innerException) : base("Ocurrio un error al cargar el sistema de registro de eventos, el cual se encarga de monitorear y registrar posibles errores de la aplicacion." + Environment.NewLine + "Puede usar a aplicacion detodas formas pero el sistema de registro de eventos sera desactivado hasta que se reinicie la aplicación.", innerException) { }
    }

    /// <summary>
    /// Listener/Log que escribe a un archivo txt.
    /// </summary>
    public class Log2File : TextWriterTraceListener
    {
        private bool _activado = true;
        public bool Acivado { set { _activado = value; } get { return _activado; } }

        /// <exception cref="dbTurnos.LoadingLog2FileException">Ocurre cuando el no se puede crear el logFile, y/o su listener. Encapsula el error original.</exception>
        public Log2File(string filePath, bool addToTraceListenersList):base(filePath)
        {
            try
            {
                // Creates the new trace listener.
                if (addToTraceListenersList)
                    Trace.Listeners.Add(this); ;
            }
            catch (Exception ex)
            {
                throw new LoadingLog2FileException(ex);
            }
        }
        public override void WriteLine(string msg)
        {
            if (_activado)
                base.WriteLine(string.Format("{0:G}: {1}", System.DateTime.Now, msg));
        }
        public void TraceException(Exception ex, string msg = "")
        {
            if (msg == "")
                WriteLine(string.Format("{1} {2}: {3} ({4})", ex.Source,ex.TargetSite, ex.Message, ex.StackTrace));
            else
                WriteLine(string.Format("{1} {2}: [msg: {3}] {4} ({5})", ex.Source, ex.TargetSite,msg , ex.Message, ex.StackTrace));

            if (ex.InnerException != null)
            {
                IndentLevel += 1;
                TraceException(ex.InnerException);
                IndentLevel -= 1;
            }
            Trace.Flush();
        }
    }

    

}
