using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Probando
{
    public partial class Form1 : Form
    {
        /*
         * Creo el objeto para conectar la base de datos
         */
        OleDbConnection cn;
        /*
        * Creo la variable para que se guarde el datoo ingresado
        */
        string Nombre;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * Creo la conexión
             */
            cn = new OleDbConnection();
            /*
             * Conecto con la base de datos
             */
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Probando.accdb";



            /*
             * Buscar:
             * OleDbCommand 
             * OleDbDataAdapter
             * DataSet
             */

        }

        private void BtnListo_Click(object sender, EventArgs e)
        {
            Nombre = txtNombre.Text;
            cn.Open();
            /*
             *declaro el objeto de mi comando
             */
            OleDbCommand MiComando;
            /*
            /*
             * asigno la funcion del comando
             */
            MiComando = new OleDbCommand("INSERT INTO Registro (Nombre_y_Apellido) VALUES ('" + Nombre + "');");
            /*
             * asigno el comando a la base de datos sobre la que lo voy a ejecutar
             */
            MiComando.Connection = cn;
            /*
             * ejecuto el comando
             */
            MiComando.ExecuteNonQuery();
            cn.Close();
            Form2 formaSiguiente = new Form2();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2

        }


    }
}
