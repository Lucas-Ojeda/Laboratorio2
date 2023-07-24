namespace Historial_Clinico
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
            this.labNombre = new System.Windows.Forms.Label();
            this.labApellido = new System.Windows.Forms.Label();
            this.labFechaNacimiento = new System.Windows.Forms.Label();
            this.labGenero = new System.Windows.Forms.Label();
            this.labDireccion = new System.Windows.Forms.Label();
            this.labTelefono = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textGenero = new System.Windows.Forms.TextBox();
            this.textNacimiento = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.butGuardar = new System.Windows.Forms.Button();
            this.butModificar = new System.Windows.Forms.Button();
            this.butEliminar = new System.Windows.Forms.Button();
            this.DGVPacientes = new System.Windows.Forms.DataGridView();
            this.labID = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buTurnos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.Location = new System.Drawing.Point(22, 32);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(110, 31);
            this.labNombre.TabIndex = 0;
            this.labNombre.Text = "Nombre";
            // 
            // labApellido
            // 
            this.labApellido.AutoSize = true;
            this.labApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApellido.Location = new System.Drawing.Point(138, 32);
            this.labApellido.Name = "labApellido";
            this.labApellido.Size = new System.Drawing.Size(110, 31);
            this.labApellido.TabIndex = 1;
            this.labApellido.Text = "Apellido";
            // 
            // labFechaNacimiento
            // 
            this.labFechaNacimiento.AutoSize = true;
            this.labFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFechaNacimiento.Location = new System.Drawing.Point(254, 32);
            this.labFechaNacimiento.Name = "labFechaNacimiento";
            this.labFechaNacimiento.Size = new System.Drawing.Size(150, 31);
            this.labFechaNacimiento.TabIndex = 2;
            this.labFechaNacimiento.Text = "Nacimiento";
            // 
            // labGenero
            // 
            this.labGenero.AutoSize = true;
            this.labGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGenero.Location = new System.Drawing.Point(410, 32);
            this.labGenero.Name = "labGenero";
            this.labGenero.Size = new System.Drawing.Size(104, 31);
            this.labGenero.TabIndex = 3;
            this.labGenero.Text = "Genero";
            // 
            // labDireccion
            // 
            this.labDireccion.AutoSize = true;
            this.labDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDireccion.Location = new System.Drawing.Point(520, 32);
            this.labDireccion.Name = "labDireccion";
            this.labDireccion.Size = new System.Drawing.Size(128, 31);
            this.labDireccion.TabIndex = 4;
            this.labDireccion.Text = "Direccion";
            // 
            // labTelefono
            // 
            this.labTelefono.AutoSize = true;
            this.labTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTelefono.Location = new System.Drawing.Point(664, 32);
            this.labTelefono.Name = "labTelefono";
            this.labTelefono.Size = new System.Drawing.Size(120, 31);
            this.labTelefono.TabIndex = 5;
            this.labTelefono.Text = "Telefono";
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(28, 80);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 31);
            this.textNombre.TabIndex = 6;
            // 
            // textTelefono
            // 
            this.textTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefono.Location = new System.Drawing.Point(670, 80);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(130, 31);
            this.textTelefono.TabIndex = 7;
            // 
            // textGenero
            // 
            this.textGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGenero.Location = new System.Drawing.Point(416, 80);
            this.textGenero.Name = "textGenero";
            this.textGenero.Size = new System.Drawing.Size(100, 31);
            this.textGenero.TabIndex = 8;
            // 
            // textNacimiento
            // 
            this.textNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNacimiento.Location = new System.Drawing.Point(260, 80);
            this.textNacimiento.Name = "textNacimiento";
            this.textNacimiento.Size = new System.Drawing.Size(144, 31);
            this.textNacimiento.TabIndex = 9;
            // 
            // textApellido
            // 
            this.textApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido.Location = new System.Drawing.Point(144, 80);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(100, 31);
            this.textApellido.TabIndex = 10;
            // 
            // textDireccion
            // 
            this.textDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDireccion.Location = new System.Drawing.Point(526, 80);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(138, 31);
            this.textDireccion.TabIndex = 11;
            // 
            // butGuardar
            // 
            this.butGuardar.Location = new System.Drawing.Point(806, 12);
            this.butGuardar.Name = "butGuardar";
            this.butGuardar.Size = new System.Drawing.Size(144, 50);
            this.butGuardar.TabIndex = 12;
            this.butGuardar.Text = "Guardar";
            this.butGuardar.UseVisualStyleBackColor = true;
            this.butGuardar.Click += new System.EventHandler(this.butGuardar_Click);
            // 
            // butModificar
            // 
            this.butModificar.Location = new System.Drawing.Point(806, 73);
            this.butModificar.Name = "butModificar";
            this.butModificar.Size = new System.Drawing.Size(144, 50);
            this.butModificar.TabIndex = 13;
            this.butModificar.Text = "Modificar";
            this.butModificar.UseVisualStyleBackColor = true;
            this.butModificar.Click += new System.EventHandler(this.butModificar_Click);
            // 
            // butEliminar
            // 
            this.butEliminar.Location = new System.Drawing.Point(806, 129);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(144, 50);
            this.butEliminar.TabIndex = 14;
            this.butEliminar.Text = "Eliminar";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.butEliminar_Click);
            // 
            // DGVPacientes
            // 
            this.DGVPacientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPacientes.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGVPacientes.Location = new System.Drawing.Point(12, 202);
            this.DGVPacientes.Name = "DGVPacientes";
            this.DGVPacientes.Size = new System.Drawing.Size(743, 421);
            this.DGVPacientes.TabIndex = 15;
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labID.Location = new System.Drawing.Point(22, 114);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(439, 31);
            this.labID.TabIndex = 16;
            this.labID.Text = "Ingresar Id para, modificar, eliminar";
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(526, 129);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(84, 31);
            this.textID.TabIndex = 17;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "o acceder a la gestion de tunos e H.C.";
            // 
            // buTurnos
            // 
            this.buTurnos.Location = new System.Drawing.Point(956, 12);
            this.buTurnos.Name = "buTurnos";
            this.buTurnos.Size = new System.Drawing.Size(144, 111);
            this.buTurnos.TabIndex = 19;
            this.buTurnos.Text = "Turnos/ Historial Clinico";
            this.buTurnos.UseVisualStyleBackColor = true;
            this.buTurnos.Click += new System.EventHandler(this.buTurnos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(874, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 111);
            this.button1.TabIndex = 20;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 635);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buTurnos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.labID);
            this.Controls.Add(this.DGVPacientes);
            this.Controls.Add(this.butEliminar);
            this.Controls.Add(this.butModificar);
            this.Controls.Add(this.butGuardar);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNacimiento);
            this.Controls.Add(this.textGenero);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.labTelefono);
            this.Controls.Add(this.labDireccion);
            this.Controls.Add(this.labGenero);
            this.Controls.Add(this.labFechaNacimiento);
            this.Controls.Add(this.labApellido);
            this.Controls.Add(this.labNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label labApellido;
        private System.Windows.Forms.Label labFechaNacimiento;
        private System.Windows.Forms.Label labGenero;
        private System.Windows.Forms.Label labDireccion;
        private System.Windows.Forms.Label labTelefono;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textGenero;
        private System.Windows.Forms.TextBox textNacimiento;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Button butGuardar;
        private System.Windows.Forms.Button butModificar;
        private System.Windows.Forms.Button butEliminar;
        private System.Windows.Forms.DataGridView DGVPacientes;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buTurnos;
        private System.Windows.Forms.Button button1;
    }
}

