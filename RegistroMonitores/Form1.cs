using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RegistroMonitores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        static string conexionStr = "server=MPID606; database=activos; integrated security=true";
        SqlConnection conexion = new SqlConnection(conexionStr);
        
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Monitores";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtgDatosMonitores.DataSource = dt;
            conexion.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string numero_serie = txtNumSerie.Text;
            string responsable = txtResponsable.Text;
            string etiqueta = txtEtiqueta.Text;
            string ubicacion = txtUbicacion.Text;

            try
            {
                if (marca.Length == 0 || modelo.Length==0 || numero_serie.Length==0 || responsable.Length==0 || etiqueta.Length ==0 || ubicacion.Length==0)
                {
                    MessageBox.Show("Asegurese de tener llenos todos los campos del registro!");
                    return;
                }
                try
                {
                    conexion.Open();
                    string query = "INSERT INTO Monitores(Marca, Numero_Serie, Etiqueta, Responsable, Ubicacion) VALUES ('"+marca+"', '"+numero_serie+"', '"+etiqueta+"', '"+responsable+"', '"+ubicacion+"')";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.ExecuteNonQuery();

                    //Reseteamos los valores ingresados y ponemos un focus en el TextBox Marca.
                    txtMarca.Clear();
                    txtModelo.Clear();
                    txtNumSerie.Clear();
                    txtResponsable.Clear();
                    txtEtiqueta.Clear();
                    txtUbicacion.Clear();
                    txtMarca.Focus();

                    conexion.Close();
                    btnConsultar_Click(sender, e);
                }
                catch (Exception er)
                {
                    MessageBox.Show("Ocurrio un error al insertar el nuevo registro: " + er);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: !" + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(txtElimar.Text.Length == 0 ) 
            { 
                MessageBox.Show("Ingrese el ID del registro a borrar"); 
                return;
            }
        
            int idRegistro = Convert.ToInt32(txtElimar.Text);

            try
            {
                conexion.Open();
                string query = "DELETE FROM Monitores WHERE ID="+idRegistro+"";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"El registro con ID {txtElimar.Text} ha sido eliminado");
                
                //Reseteamos el contenido dentro del TextBox Eliminar y ponemos un Focus sobre el mismo
                txtElimar.Clear();
                txtElimar.Focus();

                conexion.Close();
                btnConsultar_Click (sender, e);
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al eliminar el registro!" + er);
            }
        }
    }
}
/*
create database activos;
use activos;

create table Monitores(
ID int not null identity(1,1) primary key,
Marca varchar(50) not null,
Numero_Serie varchar(60) not null,
Etiqueta varchar(50),
Responsable varchar(100) not null,
Ubicacion varchar(50) not null
);

INSERT INTO Monitores(Marca, Numero_Serie, Etiqueta, Responsable, Ubicacion) VALUES ('Samsung', 'SHDF87DSF-1', 'MPID102', 'Cristian Zamora', 'Oficinas TI');
INSERT INTO Monitores(Marca, Numero_Serie, Etiqueta, Responsable, Ubicacion) VALUES ('WesterDigital', 'POADSFD-1', 'MPID104', 'Oscar Galindo', 'Oficinas TI');
INSERT INTO Monitores(Marca, Numero_Serie, Etiqueta, Responsable, Ubicacion) VALUES ('LG', 'ASDASDAC-9', 'MPID103', 'David Hernandez', 'Oficinas TI');

select * from Monitores;
*/