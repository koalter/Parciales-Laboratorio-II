using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        short anio;
        Divisiones division;

        #region Propiedades

        public string AnioDivision
        {
            get
            {
                return this.anio + "º" + this.division;
            }
        }

        #endregion

        #region Métodos

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division)
            : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
                
            sb.Append(base.ExponerDatos());
            sb.AppendLine("Curso: " + this.AnioDivision);
            sb.AppendLine("");

            return sb.ToString();
        }
        protected override bool ValidarDocumentacion(string doc)
        {
            bool retorno = false;
            int length = doc.Length;
            if (doc == "^\\d{2}-\\d{4}-\\d{1}")
            {
                retorno = true;
            }
            return retorno;
        }

        #endregion
    }
}
