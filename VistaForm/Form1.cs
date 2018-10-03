using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class frmVista : Form
    {
        Curso curso;

        public frmVista()
        {
            InitializeComponent();
        }

        private void frmVista_Load(object sender, EventArgs e)
        {
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));
        }
        
        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
            curso = new Curso((short)nudAnioCurso.Value, division, new Profesor(txtNombreProfe.Text, txtApellidoProfe.Text, txtDocumentoProfe.Text));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
            Alumno a = new Alumno(txtNombre.Text, txtApellido.Text, txtDocumento.Text, (short)nudAnio.Value, division);
            curso += a;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (!(curso is null))
            {
                rtbDatos.Text = (string)curso;
            }
            else
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
