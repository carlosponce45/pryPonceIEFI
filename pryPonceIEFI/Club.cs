using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace pryPonceIEFI
{
    internal class Club
    {
        public string nombre { get; set; }
        public string äpellido { get; set; }
        public string edad { get; set; }
        public string lugarnacimiento { get; set; }
        public string tipodesexo { get; set; }
        public string ingreso { get; set; }
        public string puntaje { get; set; }

        object oledbconnection = new OleDbConnection();
        object oledbcomando = new OleDbCommand();
        OleDbDataAdapter ojda = new OleDbDataAdapter();
        

    }
}
