using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.vista
{
    class Estudiante
    {
        private long _numerocontrol;
        private string _nombre;
        private byte _edad;
        private char _genero;

        public long numerocontrol;
        public string nombre;
        public int edad;
        public char genero;

        public long NumeroControl
        {
            get
            {
                return this._numerocontrol;
            }
            set
            {
                if (value>0)
                {
                    this._numerocontrol = value;
                }
            }
        }
    }
}
