
namespace DepositoVisual
{
    partial class Ventana_Categoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dvgVista = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVista)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgVista
            // 
            this.dvgVista.AllowUserToAddRows = false;
            this.dvgVista.AllowUserToDeleteRows = false;
            this.dvgVista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgVista.Location = new System.Drawing.Point(12, 12);
            this.dvgVista.Name = "dvgVista";
            this.dvgVista.ReadOnly = true;
            this.dvgVista.RowHeadersVisible = false;
            this.dvgVista.RowTemplate.Height = 25;
            this.dvgVista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgVista.Size = new System.Drawing.Size(552, 211);
            this.dvgVista.TabIndex = 0;
            this.dvgVista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgVista_CellContentClick);
            this.dvgVista.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgVista_CellMouseClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(245, 277);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(36, 23);
            this.txtId.TabIndex = 1;
            this.txtId.Visible = false;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(36, 277);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.PlaceholderText = "Ingrese una categoria";
            this.txtCategoria.ShortcutsEnabled = false;
            this.txtCategoria.Size = new System.Drawing.Size(134, 23);
            this.txtCategoria.TabIndex = 2;
            this.txtCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoria_KeyPress);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(245, 244);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 15);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id";
            this.lblId.Visible = false;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(36, 244);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(58, 15);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(36, 329);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(156, 329);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(271, 329);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(391, 329);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Ventana_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 398);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dvgVista);
            this.Name = "Ventana_Categoria";
            this.Text = "Categorias-Deposito 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.dvgVista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgVista;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCerrar;
    }
}