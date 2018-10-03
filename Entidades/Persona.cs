using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        string apellido;
        string documento;
        string nombre;

        #region Propiedades

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public string Documento
        {
            get
            {
                return this.documento;
            }
            set
            {
                if (this.ValidarDocumentacion(value))
                {
                    this.documento = value;
                }
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        #endregion

        #region Métodos

        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Apellido: " + this.apellido);
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Documento: " + this.documento);

            return sb.ToString();
        }

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Documento = documento;
        }

        protected abstract bool ValidarDocumentacion(string doc);

        #endregion
    }
}
