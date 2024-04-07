using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Encuestas.BKEND
{
    public class ListaEncuestas
    {

        public DataTable ListadorEncuestasDT { get; set; } = new DataTable();

        public ListaEncuestas()
        {
            ListadorEncuestasDT.TableName = "Encuestas-Registradas";
            ListadorEncuestasDT.Columns.Add("NumeroEncuesta", typeof(int));
            ListadorEncuestasDT.Columns.Add("Ambiente", typeof(int));
            ListadorEncuestasDT.Columns.Add("Jefes", typeof(int));
            ListadorEncuestasDT.Columns.Add("Salario", typeof(int));
            Lector();
        }

        public void Lector()
        {
            if (System.IO.File.Exists("Encuestas-Registradas.xml"))
            {
                ListadorEncuestasDT.ReadXml("Encuestas-Registradas.xml");
            }
        }

        public void InsertEncuesta(Encuesta aEncuesta)
        {
            int NumeroEncuesta = NuevoCod();

            ListadorEncuestasDT.Rows.Add();
            int NuevoRenglon = ListadorEncuestasDT.Rows.Count - 1;
            ListadorEncuestasDT.Rows[NuevoRenglon]["NumeroEncuesta"] = NumeroEncuesta;
            ListadorEncuestasDT.Rows[NuevoRenglon]["Ambiente"] = aEncuesta.Ambiente;
            ListadorEncuestasDT.Rows[NuevoRenglon]["Jefes"] = aEncuesta.Jefes;
            ListadorEncuestasDT.Rows[NuevoRenglon]["Salario"] = aEncuesta.Salario;


            ListadorEncuestasDT.WriteXml("Encuestas-Registradas.xml");
        }

        public int NuevoCod()
        {
            int Nuevocod = 0;

            foreach (DataRow fila in ListadorEncuestasDT.Rows)
            {
                if (Nuevocod < Convert.ToInt32(fila["NumeroEncuesta"]))
                {
                    Nuevocod = Convert.ToInt32(fila["NumeroEncuesta"]);
                }
            }

            Nuevocod++;
            return Nuevocod;
        }

    }
}
