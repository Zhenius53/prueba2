using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace PruebasAlmacen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class ListaGrid
        {
            public string incidencias;
        }

        public void mostrarresultado(string incidencia)
        {
            incidencia = dg_incidencias.Columns.Count.ToString();
        }
    }
}
