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
using System.IO;

namespace ReproductorMp3
{
    public partial class PantallaPrincipal : Form
    {
        String[] archmp3;
        String[] rutas;
        List<String> listRutas = new List<string>();
        String data_source = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True";

        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;      

        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            getDatos();
            if (listRutas.Count == 0)
                label1.Text = "No hay canciones";
            else
                label1.Text = "Cantidad de canciones: " + listRutas.Count;
        }

        private void getDatos()
        {
            conexion = new SqlConnection(data_source);
            conexion.Open();
            String query = "SELECT Nombre,Ruta FROM Canciones";
            comando = new SqlCommand(query, conexion);
            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                listBoxCanciones.Items.Add(lector.GetString(0));
                listRutas.Add(lector.GetString(1));
            }               

            conexion.Close();
        }

        private void setDatos(String nom,String ruta)
        {
            //hay que cambiar el AttachDbFilename
            conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ger\Desktop\Reproductor\ReproductorMp3\ReproductorMp3\Database.mdf;Integrated Security=True");
            conexion.Open();            
            String query = "INSERT INTO Canciones(Nombre,Ruta) values(@nombre,@ruta)";
            comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombre", nom);
            comando.Parameters.AddWithValue("@ruta", ruta);
            comando.ExecuteNonQuery();
            conexion.Close();            
        }

        private void eliminarRegistros(String nom)
        {
            //hay que cambiar el AttachDbFilename
            conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ger\Desktop\Reproductor\ReproductorMp3\ReproductorMp3\Database.mdf;Integrated Security=True");
            conexion.Open();
            String query = "DELETE FROM Canciones WHERE Nombre= @nombre";
            comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombre", nom);          
            if(comando.ExecuteNonQuery()== 1)
                MessageBox.Show("Las canciones se eliminaron correctamente", "Listo", MessageBoxButtons.OK);
            conexion.Close();

        }       

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            //ReproductorMp3.Ctlcontrols.stop();
            int i = 0;
            OpenFileDialog BusquedaArchivos = new OpenFileDialog();
            BusquedaArchivos.Multiselect = true;
            if (BusquedaArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                archmp3 = BusquedaArchivos.SafeFileNames;
                rutas = BusquedaArchivos.FileNames;

                foreach (var Archivo in archmp3)
                {
                    listRutas.Add(rutas[i]);
                    listBoxCanciones.Items.Add(Archivo);
                    setDatos(Archivo, rutas[i]);
                    i++;
                }
                MessageBox.Show("Las canciones se almacenaron correctamente", "Listo", MessageBoxButtons.OK);
                ReproductorMp3.URL = listRutas[0];
                listBoxCanciones.SelectedIndex = 0;
                label1.Text = "Cantidad de canciones: " + listRutas.Count;
            }

        }

        private void buttonEliminar_Click(object sender, EventArgs e) 
        {
            try
            {
                ReproductorMp3.Ctlcontrols.stop();
                eliminarRegistros(listBoxCanciones.SelectedItem.ToString());
                listRutas.RemoveAt(listBoxCanciones.SelectedIndex);
                listBoxCanciones.Items.RemoveAt(listBoxCanciones.SelectedIndex);               
                label1.Text = "Cantidad de canciones= " + listRutas.Count;

            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione la cancion a eliminar", "Atención", MessageBoxButtons.OK);
               
            }
            
        }   

        private void listBoxCanciones_Click(object sender, EventArgs e)
        {
            if(listRutas.Count != 0)
            {
                String ruta = listRutas[listBoxCanciones.SelectedIndex];
                if (File.Exists(ruta))
                {
                    try
                    {
                        ReproductorMp3.URL = ruta;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se pudo reproducir la cancion: "+ listBoxCanciones.SelectedItem.ToString(), "Atención", MessageBoxButtons.OK);
                        throw;
                    }
                    
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("No se puede reproducir la cancion ya que la ruta" + "\"" + ruta + "\" " + "no existe\n"+ "¿Desea eliminar la cancion?", "Atención", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        eliminarRegistros(listBoxCanciones.SelectedItem.ToString());
                        listRutas.RemoveAt(listBoxCanciones.SelectedIndex);
                        listBoxCanciones.Items.RemoveAt(listBoxCanciones.SelectedIndex);
                        label1.Text = "Cantidad de canciones= " + listRutas.Count;                       
                    }
                    

                }

            }            

        }


    }
}
