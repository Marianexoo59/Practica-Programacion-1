using ClasesEjercicioPrueba.Models;
using ClasesEjercicioPrueba.Repository;

namespace Winform
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            string marca = txtMarca.Text.Trim();
            string modelo = txtModelo.Text.Trim();
            string anioTexto = txtAnio.Text.Trim();

            if (string.IsNullOrEmpty(marca))
            {
                MessageBox.Show("Ingresá la marca.");
                txtMarca.Focus();
                return;
            }

            if (string.IsNullOrEmpty(modelo))
            {
                MessageBox.Show("Ingresá el modelo.");
                txtModelo.Focus();
                return;
            }

            if (!int.TryParse(anioTexto, out int anio) || anio <= 0)
            {
                MessageBox.Show("El Año debe ser un número válido.");
                txtAnio.Focus();
                return;
            }

            // Crear vehículo
            var vehiculo = new Vehiculo
            {
                marca = marca,
                modelo = modelo
                // Podés agregar más propiedades si querés
            };

            try
            {
                VehiculoRepository.GuardarVehiculo(vehiculo);
                MessageBox.Show("Vehículo registrado correctamente.");

                // Limpiar campos
                txtMarca.Clear();
                txtModelo.Clear();
                txtAnio.Clear();

                // Actualizar DataGridView
                CargarVehiculosEnGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el vehículo: " + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarVehiculosEnGrid();
        }

        private void CargarVehiculosEnGrid()
        {
            try
            {
                List<Vehiculo> lista = VehiculoRepository.ObtenerVehiculos() ?? new List<Vehiculo>();
                dgvVehiculos.DataSource = null; // limpiar antes de asignar
                dgvVehiculos.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar vehículos: " + ex.Message);
            }
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtMarca = new TextBox();
            txtAnio = new TextBox();
            txtModelo = new TextBox();
            dgvVehiculos = new DataGridView();
            btnRegistrar = new Button();
            btnMostrar = new Button();
            Marca = new Label();
            Año = new Label();
            Modelo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).BeginInit();
            SuspendLayout();
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(489, 108);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 0;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(489, 222);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(100, 23);
            txtAnio.TabIndex = 1;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(489, 164);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 2;
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Location = new Point(489, 264);
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.Size = new Size(240, 150);
            dgvVehiculos.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(372, 222);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(84, 26);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(372, 264);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(84, 26);
            btnMostrar.TabIndex = 5;
            btnMostrar.Text = "Mostrar Vehículos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Marca
            // 
            Marca.AutoSize = true;
            Marca.Location = new Point(516, 81);
            Marca.Name = "Marca";
            Marca.Size = new Size(40, 15);
            Marca.TabIndex = 6;
            Marca.Text = "Marca";
            // 
            // Año
            // 
            Año.AutoSize = true;
            Año.Location = new Point(527, 204);
            Año.Name = "Año";
            Año.Size = new Size(29, 15);
            Año.TabIndex = 7;
            Año.Text = "Año";
            // 
            // Modelo
            // 
            Modelo.AutoSize = true;
            Modelo.Location = new Point(516, 146);
            Modelo.Name = "Modelo";
            Modelo.Size = new Size(48, 15);
            Modelo.TabIndex = 8;
            Modelo.Text = "Modelo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Modelo);
            Controls.Add(Año);
            Controls.Add(Marca);
            Controls.Add(btnMostrar);
            Controls.Add(btnRegistrar);
            Controls.Add(dgvVehiculos);
            Controls.Add(txtModelo);
            Controls.Add(txtAnio);
            Controls.Add(txtMarca);
            Name = "Form1";
            Text = "App Vehículos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMarca;
        private TextBox txtAnio;
        private TextBox txtModelo;
        private DataGridView dgvVehiculos;
        private Button btnRegistrar;
        private Button btnMostrar;
        private Label Marca;
        private Label Año;
        private Label Modelo;
    }
}
