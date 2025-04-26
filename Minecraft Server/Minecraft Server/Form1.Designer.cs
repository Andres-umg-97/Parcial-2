using System.Windows.Forms;

namespace Minecraft_Server
{
    partial class Form1
    {
        /// <summary>  
        /// Variable del diseñador necesaria.  
        /// </summary>  
        private System.ComponentModel.IContainer components = null;

        /// <summary>  
        /// Limpiar los recursos que se estén usando.  
        /// </summary>  
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>  
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms  

        /// <summary>  
        /// Método necesario para admitir el Diseñador. No se puede modificar  
        /// el contenido de este método con el editor de código.  
        /// </summary>  
        private void InitializeComponent()
        {
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.panelJugadores = new System.Windows.Forms.Panel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelNivel = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNivel = new System.Windows.Forms.TextBox();
            this.textboxNombre = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            this.panelJugadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Location = new System.Drawing.Point(56, 309);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.RowHeadersWidth = 51;
            this.dgvJugadores.Size = new System.Drawing.Size(600, 150);
            this.dgvJugadores.TabIndex = 0;
            // 
            // panelJugadores
            // 
            this.panelJugadores.Controls.Add(this.labelNombre);
            this.panelJugadores.Controls.Add(this.labelID);
            this.panelJugadores.Controls.Add(this.labelNivel);
            this.panelJugadores.Controls.Add(this.textBoxID);
            this.panelJugadores.Controls.Add(this.textBoxNivel);
            this.panelJugadores.Controls.Add(this.textboxNombre);
            this.panelJugadores.Controls.Add(this.buttonAgregar);
            this.panelJugadores.Controls.Add(this.buttonModificar);
            this.panelJugadores.Controls.Add(this.buttonBuscar);
            this.panelJugadores.Controls.Add(this.buttonEliminar);
            this.panelJugadores.Controls.Add(this.dgvJugadores);
            this.panelJugadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelJugadores.Location = new System.Drawing.Point(0, 0);
            this.panelJugadores.Name = "panelJugadores";
            this.panelJugadores.Size = new System.Drawing.Size(693, 480);
            this.panelJugadores.TabIndex = 0;
            // 
            // labelNombre
            // 
            this.labelNombre.Location = new System.Drawing.Point(119, 76);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(100, 23);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // labelID
            // 
            this.labelID.Location = new System.Drawing.Point(119, 123);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(100, 23);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // labelNivel
            // 
            this.labelNivel.Location = new System.Drawing.Point(119, 172);
            this.labelNivel.Name = "labelNivel";
            this.labelNivel.Size = new System.Drawing.Size(100, 23);
            this.labelNivel.TabIndex = 0;
            this.labelNivel.Text = "Nivel";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(225, 120);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 0;
            // 
            // textBoxNivel
            // 
            this.textBoxNivel.Location = new System.Drawing.Point(225, 169);
            this.textBoxNivel.Name = "textBoxNivel";
            this.textBoxNivel.Size = new System.Drawing.Size(100, 22);
            this.textBoxNivel.TabIndex = 0;
            // 
            // textboxNombre
            // 
            this.textboxNombre.Location = new System.Drawing.Point(225, 73);
            this.textboxNombre.Name = "textboxNombre";
            this.textboxNombre.Size = new System.Drawing.Size(100, 22);
            this.textboxNombre.TabIndex = 0;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(225, 244);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(123, 59);
            this.buttonAgregar.TabIndex = 0;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click_1);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(439, 362);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(123, 59);
            this.buttonModificar.TabIndex = 0;
            this.buttonModificar.Text = "Modificar";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(225, 362);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(123, 59);
            this.buttonBuscar.TabIndex = 0;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(439, 244);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(123, 59);
            this.buttonEliminar.TabIndex = 0;
            this.buttonEliminar.Text = "Eliminar";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(693, 480);
            this.Controls.Add(this.panelJugadores);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            this.panelJugadores.ResumeLayout(false);
            this.panelJugadores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNivel;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNivel;
        private System.Windows.Forms.TextBox textboxNombre;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Panel panelJugadores; // Ensure the panel is declared as a field  
    }
}

