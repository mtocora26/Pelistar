namespace Pelistar_beta
{
    partial class frmInicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIniciarSesion = new Button();
            btnProbarConexionDB = new Button();
            lblNombreUsuario = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombreUsuario = new TextBox();
            txtPassword = new TextBox();
            cmbRoles = new ComboBox();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.Transparent;
            btnIniciarSesion.Font = new Font("Open Sans", 9.792F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciarSesion.ForeColor = Color.Black;
            btnIniciarSesion.ImageAlign = ContentAlignment.TopCenter;
            btnIniciarSesion.Location = new Point(833, 94);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(123, 35);
            btnIniciarSesion.TabIndex = 1;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.TextImageRelation = TextImageRelation.ImageAboveText;
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // btnProbarConexionDB
            // 
            btnProbarConexionDB.Location = new Point(293, 167);
            btnProbarConexionDB.Name = "btnProbarConexionDB";
            btnProbarConexionDB.Size = new Size(260, 29);
            btnProbarConexionDB.TabIndex = 10;
            btnProbarConexionDB.Text = "Probar Conexión a DB";
            btnProbarConexionDB.UseVisualStyleBackColor = true;
            btnProbarConexionDB.Click += btnProbarConexionDB_Click;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Open Sans", 9.216F);
            lblNombreUsuario.ForeColor = Color.Transparent;
            lblNombreUsuario.Location = new Point(293, 62);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(164, 23);
            lblNombreUsuario.TabIndex = 11;
            lblNombreUsuario.Text = "Nombre de Usuario:";
            lblNombreUsuario.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans", 9.216F);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(487, 62);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 12;
            label2.Text = "Password:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Open Sans", 9.216F);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(649, 62);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 13;
            label3.Text = "Rol de Usuario:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = Color.FromArgb(44, 52, 64);
            txtNombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtNombreUsuario.ForeColor = Color.White;
            txtNombreUsuario.Location = new Point(293, 99);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(150, 29);
            txtNombreUsuario.TabIndex = 14;
            txtNombreUsuario.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(44, 52, 64);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(487, 99);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(131, 29);
            txtPassword.TabIndex = 15;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // cmbRoles
            // 
            cmbRoles.BackColor = Color.FromArgb(44, 52, 64);
            cmbRoles.ForeColor = Color.White;
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(649, 99);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(158, 29);
            cmbRoles.TabIndex = 16;
            cmbRoles.SelectedIndexChanged += cmbRoles_SelectedIndexChanged;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 24, 28);
            ClientSize = new Size(972, 325);
            Controls.Add(cmbRoles);
            Controls.Add(txtPassword);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblNombreUsuario);
            Controls.Add(btnProbarConexionDB);
            Controls.Add(btnIniciarSesion);
            Name = "frmInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pelistar - Catálogo de Películas y Series";
            Load += frmInicioSesion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnIniciarSesion;
        private Button btnProbarConexionDB;
        private Label lblNombreUsuario;
        private Label label2;
        private Label label3;
        private TextBox txtNombreUsuario;
        private TextBox txtPassword;
        private ComboBox cmbRoles;
    }
}
