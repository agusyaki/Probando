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
    public partial class Form2 : Form
    {
        OleDbConnection cn;
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            cn = new OleDbConnection();
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Probando.accdb";

        }

        private void Btncambiar_Click(object sender, EventArgs e)
        {
            string cambio = txtcambiar.Text;
            cn.Open();
            OleDbCommand cambiar;

            cambiar = new OleDbCommand("UPDATE Registro SET '" + cambio + "' WHERE Nombre y Apellido = 'Agus';");

            cambiar.Connection = cn;

            cambiar.ExecuteNonQuery();
            cn.Close();

            
        }
    }
}
