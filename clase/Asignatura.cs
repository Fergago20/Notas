using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas.clase
{
    internal class Asignatura
    {
       
            public string Nombre { set; get; }
            public int NMatematicas { set; get; }
            public int NEspañol { set; get; }
            public int NBiologia { set; get; }
            public double Promedio { set; get; }

        public Asignatura()
        {

        }

       public Asignatura(string nombre, int matematica, int español, int biologia)
        {
            Nombre = nombre;
            NMatematicas = matematica;
            NEspañol = español;
            NBiologia = biologia;
            Promedio = (double)(NMatematicas + NEspañol + NBiologia) / 3.0;
        }

        List<Asignatura> alumnos = new List<Asignatura>();

        public List<Asignatura> Mostrar()
        {
            return alumnos;
        }

        public void Agregar(string nombre, int matematica, int español, int biologia)
        {
            Asignatura alum = new Asignatura();
            alum.Nombre = nombre;
            alum.NMatematicas = matematica;
            alum.NEspañol = español;
            alum.NBiologia = biologia;
            alum.Promedio = (double)(NMatematicas + NEspañol + NBiologia) / 3.0;
            alumnos.Add(alum);
        }

        public void Eliminar(string nombre)
        {
            for(int i=0; i< alumnos.Count; i++)
            {
                if (alumnos[i].Nombre == nombre)
                {
                    alumnos.RemoveAt(i);
                }
            }
        }

        public void Actualizar(Asignatura alum, string Nombre)
        {
            int index = alumnos.FindIndex(alu => alu.Nombre == Nombre);
            if (index!= -1)
            {
                alumnos[index] = alum;
            }
        }



    }
}
