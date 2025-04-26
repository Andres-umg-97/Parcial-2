using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Server
{
    public partial class Form1 : Form
    {
        private DataGridView dgvJugadores;
        private DataGridView dgvInventario;
        private ComboBox comboBoxFiltro;
        private readonly EventHandler ComboBoxFiltro_SelectedIndexChanged;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
         dgvJugadores.Columns.Add("Nombre", "Nombre");
         dgvJugadores.Columns.Add("ID", "ID");
         dgvJugadores.Columns.Add("Nivel", "Nivel");
            dgvInventario = new DataGridView
            {
                Location = new Point(10, 250), 
                Size = new Size(500, 200),    
                AllowUserToAddRows = false,   
                ReadOnly = true               
            };
           
            dgvInventario.Columns.Add("NombreItem", "Nombre del Ítem");
            dgvInventario.Columns.Add("Cantidad", "Cantidad");
            dgvInventario.Columns.Add("Tipo", "Tipo");

            this.Controls.Add(dgvInventario);

            CargarInventario();

            comboBoxFiltro = new ComboBox
            {
                Location = new Point(10, 470), 
                Size = new Size(200, 30),
                DropDownStyle = ComboBoxStyle.DropDownList 
            };

            
            comboBoxFiltro.Items.Add("Todos"); 
            comboBoxFiltro.Items.Add("Arma");
            comboBoxFiltro.Items.Add("Consumible");
            comboBoxFiltro.Items.Add("Material");

            comboBoxFiltro.SelectedIndex = 0; 
                                              
            comboBoxFiltro.SelectedIndexChanged += ComboBoxFiltro_SelectedIndexChanged;
  
            this.Controls.Add(comboBoxFiltro);

        }

        private void CargarInventario()
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNivel_TextChanged(object sender, EventArgs e)
        {
            string inputNivel = textBoxNivel.Text.Trim();

            if (string.IsNullOrEmpty(inputNivel))
                return;
            
            var existingRow = dgvJugadores.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(row => row.Cells[2].Value?.ToString().Equals(inputNivel, StringComparison.OrdinalIgnoreCase) == true);

            if (existingRow != null)
            {             
                dgvJugadores.ClearSelection();
                existingRow.Selected = true;
                dgvJugadores.FirstDisplayedScrollingRowIndex = existingRow.Index;
            }
            else
            {              
                dgvJugadores.Rows.Add(null, null, inputNivel); 
            }
        }

        
        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            string inputName = textboxNombre.Text.Trim();

            if (string.IsNullOrEmpty(inputName))
                return; 

            var existingRow = dgvJugadores.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(row => row.Cells[0].Value?.ToString().Equals(inputName, StringComparison.OrdinalIgnoreCase) == true);

            if (existingRow != null)
            {
                dgvJugadores.ClearSelection();
                existingRow.Selected = true;
                dgvJugadores.FirstDisplayedScrollingRowIndex = existingRow.Index;
            }
            else
            {
                dgvJugadores.ClearSelection();
            }
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            string inputID = textBoxID.Text.Trim();

            if (string.IsNullOrEmpty(inputID))
                return;

            var existingRow = dgvJugadores.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(row => row.Cells[1].Value?.ToString().Equals(inputID, StringComparison.OrdinalIgnoreCase) == true);

            if (existingRow != null)
            {
                dgvJugadores.ClearSelection();
                existingRow.Selected = true;
                dgvJugadores.FirstDisplayedScrollingRowIndex = existingRow.Index;
            }
            else
            {
                dgvJugadores.Rows.Add(null, inputID); 
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textboxNombre.Text.Trim();
            string id = textBoxID.Text.Trim();
            string nivel = textBoxNivel.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nivel))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de agregar un jugador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(nivel, out int nivelNumerico))
            {
                MessageBox.Show("El nivel debe ser un número válido.", "Nivel inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existingRow = dgvJugadores.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(row => row.Cells[1].Value?.ToString().Equals(id, StringComparison.OrdinalIgnoreCase) == true);

            if (existingRow != null)
            {
                MessageBox.Show("Ya existe un jugador con este ID.", "ID duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvJugadores.Rows.Add(nombre, id, nivelNumerico);
            textboxNombre.Clear();
            textBoxID.Clear();
            textBoxNivel.Clear();

            MessageBox.Show("Jugador agregado exitosamente.", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string nombre = textboxNombre.Text.Trim();
            string id = textBoxID.Text.Trim();
            string nivel = textBoxNivel.Text.Trim();

            var matchingRow = dgvJugadores.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(row =>
                    (string.IsNullOrEmpty(nombre) || row.Cells[0].Value?.ToString().Equals(nombre, StringComparison.OrdinalIgnoreCase) == true) &&
                    (string.IsNullOrEmpty(id) || row.Cells[1].Value?.ToString().Equals(id, StringComparison.OrdinalIgnoreCase) == true) &&
                    (string.IsNullOrEmpty(nivel) || row.Cells[2].Value?.ToString().Equals(nivel, StringComparison.OrdinalIgnoreCase) == true));

            if (matchingRow != null)
            {
                dgvJugadores.ClearSelection();
                matchingRow.Selected = true;
                dgvJugadores.FirstDisplayedScrollingRowIndex = matchingRow.Index;

                MessageBox.Show("Jugador encontrado.", "Búsqueda exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró ningún jugador con los criterios especificados.", "Búsqueda fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dgvJugadores.CurrentRow != null)
            {
                var confirmResult = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este jugador?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    dgvJugadores.Rows.Remove(dgvJugadores.CurrentRow);
                    MessageBox.Show("Jugador eliminado exitosamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un jugador para eliminar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (dgvJugadores.CurrentRow != null)
            {
                string nombre = textboxNombre.Text.Trim();
                string id = textBoxID.Text.Trim();
                string nivel = textBoxNivel.Text.Trim();

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nivel))
                {
                    MessageBox.Show("Por favor, completa todos los campos antes de modificar el jugador.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(nivel, out int nivelNumerico))
                {
                    MessageBox.Show("El nivel debe ser un número válido.", "Nivel inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var existingRow = dgvJugadores.Rows
                    .Cast<DataGridViewRow>()
                    .FirstOrDefault(row => row != dgvJugadores.CurrentRow && row.Cells[1].Value?.ToString().Equals(id, StringComparison.OrdinalIgnoreCase) == true);

                if (existingRow != null)
                {
                    MessageBox.Show("Ya existe un jugador con este ID.", "ID duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dgvJugadores.CurrentRow.Cells[0].Value = nombre;
                dgvJugadores.CurrentRow.Cells[1].Value = id;
                dgvJugadores.CurrentRow.Cells[2].Value = nivelNumerico;

                textboxNombre.Clear();
                textBoxID.Clear();
                textBoxNivel.Clear();

                MessageBox.Show("Jugador modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un jugador para modificar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void panelJugadores_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAgregar_Click_1(object sender, EventArgs e)
        {
            string nombre = textboxNombre.Text.Trim();
            string id = textBoxID.Text.Trim();
            string nivel = textBoxNivel.Text.Trim();
          
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nivel))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de agregar un jugador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
      
            if (!int.TryParse(nivel, out int nivelNumerico))
            {
                MessageBox.Show("El nivel debe ser un número válido.", "Nivel inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            var existingRow = dgvJugadores.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(row => row.Cells[1].Value?.ToString().Equals(id, StringComparison.OrdinalIgnoreCase) == true);

            if (existingRow != null)
            {
                MessageBox.Show("Ya existe un jugador con este ID.", "ID duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            dgvJugadores.Rows.Add(nombre, id, nivelNumerico);
            
            textboxNombre.Clear();
            textBoxID.Clear();
            textBoxNivel.Clear();
         
            MessageBox.Show("Jugador agregado exitosamente.", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
