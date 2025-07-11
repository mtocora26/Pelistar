using MySql.Data.MySqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace Pelistar_beta
{
    public partial class frmInicioSesion : Form
    {
        string connectionString = "server=localhost;port=3306;user=root;password=;database=db_task_student";

        public frmInicioSesion()
        {
            InitializeComponent();
            mostrarRol();

        }

        private void btnProbarConexionDB_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Conexi�n exitosa a la base de datos.", "conectado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string password = txtPassword.Text;
            string rolUsuario = cmbRoles.SelectedItem.ToString();

            MessageBox.Show("Los datos ingresados son:\n" +
                            "Nombre de Usuario: " + nombreUsuario + "\n" +
                            "Contraseña: " + password + "\n" +
                            "Rol de Usuario: " + rolUsuario,
                            "Datos Ingresados",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM tbl_usuario WHERE nombre_usuario = @nombreUsuario AND password_usuario = @passwordUsuario AND rol_usuario = @rolUsuario";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@passwordUsuario", password);
                    cmd.Parameters.AddWithValue("@rolUsuario", rolUsuario);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string rol = reader["rol_usuario"].ToString();
                        MessageBox.Show("Inicio de sesión exitoso. Rol: " + rol);
                        // Aquí puedes abrir otro formulario según el rol
                    }
                    else
                    {
                        MessageBox.Show("Usuario, contraseña o rol incorrectos.");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error de conexión",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Metodo para mostrar el enum en comboBox
        private void mostrarRol()
        {
            string query = "SHOW COLUMNS FROM tbl_usuario LIKE 'rol_usuario'";

            List<string> roles = new List<string>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string type = reader["Type"].ToString();
                        MatchCollection matches = Regex.Matches(type, @"'([^']*)'");
                        foreach (Match match in matches)
                        {
                            roles.Add(match.Groups[1].Value);
                        }

                    }
                }
                connection.Close();

                cmbRoles.DataSource = roles;
            }

        }
        private void cargarValoresEnum()
        {
            //string connectionString = "server=localhost;user=root;password=;database=tu_base_datos";
            string query = "SHOW COLUMNS FROM tbl_usuario LIKE 'rol_usuario'";
            List<string> roles = new List<string>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn)) //nueva conexión según query
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string type = reader["Type"].ToString();
                        // Extraer los valores usando Regex
                        MatchCollection matches = Regex.Matches(type, @"'([^']*)'");
                        foreach (Match match in matches)
                        {
                            roles.Add(match.Groups[1].Value);
                        }
                    }
                }
            }
            // Enlazar al ComboBox

            cmbRoles.DataSource = roles;
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}