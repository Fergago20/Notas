using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notas.clase;

namespace Notas.formulario2
{
    public partial class Form2 : Form
    {
        Asignatura asig = new Asignatura();
        public Form2()
        {
            InitializeComponent();
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = tbNombre.Text;
                int matematica = int.Parse(tbMate.Text);
                int español = int.Parse(tbEspa.Text);
                int biologia = int.Parse(tbBio.Text);
               
                asig.Agregar(nombre, matematica, español, biologia);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            asig.Eliminar(nombre);

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            int matematica = int.Parse(tbMate.Text);
            int español = int.Parse(tbEspa.Text);
            int biologia = int.Parse(tbBio.Text);

            Asignatura asi= new Asignatura(nombre, matematica, español, biologia);
            asig.Actualizar(asi,nombre);
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            dgvSalida.DataSource = null;
            dgvSalida.DataSource = asig.Mostrar();
        }
    }
}
