using Notas.formulario2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cif = tbCif.Text;
                string contraseña = tbContraseña.Text;

                if(Verificar(cif, contraseña))
                {
                    Form2 frm = new Form2();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool Verificar (string cif, string contraseña)
        {
            try
            {
                FileStream mArchivoLector = new FileStream("usuarios.dat", FileMode.Open, FileAccess.Read);
                BinaryReader lector = new BinaryReader(mArchivoLector);
                
                    while (mArchivoLector.Position != mArchivoLector.Length)
                    {
                    string ci=lector.ReadString();
                    string contra= lector.ReadString();

                        if (cif.Trim() == ci && contraseña.Trim() == contra)
                        {
                        lector.Close();
                            return true;
                        }
                    }
                lector.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string cif = tbCif.Text;
                string contraseña = tbContraseña.Text;
                Registrar(cif, contraseña);
                Form2 frm = new Form2();
                frm.ShowDialog();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Registrar(string cif, string contraseña)
        {
            FileStream mArchivoEscritor = new FileStream("usuarios.dat", FileMode.OpenOrCreate, FileAccess.Write);

            BinaryWriter escritor = new BinaryWriter(mArchivoEscritor);
            
                
                escritor.Write(cif);
             
                escritor.Write(contraseña);
            escritor.Close();
            
        }
    }
}
