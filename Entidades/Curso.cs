using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        List<Alumno> alumnos;
        short anio;
        Divisiones division;
        Profesor profesor;

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

        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor)
            : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        #endregion

        #region Operadores

        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(c.AnioDivision);

            foreach (Alumno alumno in c.alumnos)
            {
                sb.Append(alumno.ExponerDatos());
            }

            return sb.ToString();
        }
        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }
        public static Curso operator +(Curso c, Alumno a)
        {
            if (c == a)
            {
                 c.alumnos.Add(a);
            }

            return c;
        }
        public static bool operator ==(Curso c, Alumno a)
        {
            return c.AnioDivision == a.AnioDivision;
        }

        #endregion
    }
}
