using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        DateTime fechaIngreso;

        #region Propiedades

        public int Antiguedad
        {
            get
            {
                DateTime hoy = DateTime.Now;
                return (hoy - this.fechaIngreso).Days;
            }
        }

        #endregion

        #region Métodos

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ExponerDatos());
            sb.AppendLine("Antigüedad: " + this.Antiguedad);

            return sb.ToString();
        }
        public Profesor(string nombre, string apellido, string documento)
            : base(nombre, apellido, documento)
        {

        }
        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso)
            : this(nombre, apellido, documento)
        {

        }
        protected override bool ValidarDocumentacion(string doc)
        {
            bool retorno = false;
            if (doc.Length == 8)
            {
                retorno = true;
            }
            return retorno;
        }

        #endregion
    }
}
