namespace Historial_Clinico
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.labPacienteActual = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.labApellido = new System.Windows.Forms.Label();
            this.labNacimiento = new System.Windows.Forms.Label();
            this.labGenero = new System.Windows.Forms.Label();
            this.labDireccion = new System.Windows.Forms.Label();
            this.labTelefono = new System.Windows.Forms.Label();
            this.labNombre1 = new System.Windows.Forms.Label();
            this.labApellido1 = new System.Windows.Forms.Label();
            this.labNacimiento1 = new System.Windows.Forms.Label();
            this.labGenero1 = new System.Windows.Forms.Label();
            this.labDireccion1 = new System.Windows.Forms.Label();
            this.labTelefono1 = new System.Windows.Forms.Label();
            this.labTurno = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labFecha = new System.Windows.Forms.Label();
            this.labHora = new System.Windows.Forms.Label();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.textHora = new System.Windows.Forms.TextBox();
            this.textMotivo = new System.Windows.Forms.TextBox();
            this.labMotivo = new System.Windows.Forms.Label();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.btAgregarHistorial = new System.Windows.Forms.Button();
            this.textHistorial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turno del paciente:";
            // 
            // labPacienteActual
            // 
            this.labPacienteActual.AutoSize = true;
            this.labPacienteActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPacienteActual.Location = new System.Drawing.Point(12, 45);
            this.labPacienteActual.Name = "labPacienteActual";
            this.labPacienteActual.Size = new System.Drawing.Size(128, 31);
            this.labPacienteActual.TabIndex = 1;
            this.labPacienteActual.Text = "Paciente:";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.Location = new System.Drawing.Point(148, 9);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(110, 31);
            this.labNombre.TabIndex = 2;
            this.labNombre.Text = "Nombre";
            // 
            // labApellido
            // 
            this.labApellido.AutoSize = true;
            this.labApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApellido.Location = new System.Drawing.Point(264, 9);
            this.labApellido.Name = "labApellido";
            this.labApellido.Size = new System.Drawing.Size(110, 31);
            this.labApellido.TabIndex = 3;
            this.labApellido.Text = "Apellido";
            // 
            // labNacimiento
            // 
            this.labNacimiento.AutoSize = true;
            this.labNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNacimiento.Location = new System.Drawing.Point(380, 9);
            this.labNacimiento.Name = "labNacimiento";
            this.labNacimiento.Size = new System.Drawing.Size(150, 31);
            this.labNacimiento.TabIndex = 4;
            this.labNacimiento.Text = "Nacimiento";
            // 
            // labGenero
            // 
            this.labGenero.AutoSize = true;
            this.labGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGenero.Location = new System.Drawing.Point(536, 9);
            this.labGenero.Name = "labGenero";
            this.labGenero.Size = new System.Drawing.Size(104, 31);
            this.labGenero.TabIndex = 5;
            this.labGenero.Text = "Genero";
            // 
            // labDireccion
            // 
            this.labDireccion.AutoSize = true;
            this.labDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDireccion.Location = new System.Drawing.Point(646, 9);
            this.labDireccion.Name = "labDireccion";
            this.labDireccion.Size = new System.Drawing.Size(128, 31);
            this.labDireccion.TabIndex = 6;
            this.labDireccion.Text = "Direccion";
            // 
            // labTelefono
            // 
            this.labTelefono.AutoSize = true;
            this.labTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTelefono.Location = new System.Drawing.Point(780, 9);
            this.labTelefono.Name = "labTelefono";
            this.labTelefono.Size = new System.Drawing.Size(120, 31);
            this.labTelefono.TabIndex = 7;
            this.labTelefono.Text = "Telefono";
            // 
            // labNombre1
            // 
            this.labNombre1.AutoSize = true;
            this.labNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre1.Location = new System.Drawing.Point(148, 45);
            this.labNombre1.Name = "labNombre1";
            this.labNombre1.Size = new System.Drawing.Size(0, 31);
            this.labNombre1.TabIndex = 8;
            // 
            // labApellido1
            // 
            this.labApellido1.AutoSize = true;
            this.labApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApellido1.Location = new System.Drawing.Point(264, 45);
            this.labApellido1.Name = "labApellido1";
            this.labApellido1.Size = new System.Drawing.Size(0, 31);
            this.labApellido1.TabIndex = 9;
            // 
            // labNacimiento1
            // 
            this.labNacimiento1.AutoSize = true;
            this.labNacimiento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNacimiento1.Location = new System.Drawing.Point(380, 45);
            this.labNacimiento1.Name = "labNacimiento1";
            this.labNacimiento1.Size = new System.Drawing.Size(0, 31);
            this.labNacimiento1.TabIndex = 10;
            // 
            // labGenero1
            // 
            this.labGenero1.AutoSize = true;
            this.labGenero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGenero1.Location = new System.Drawing.Point(536, 45);
            this.labGenero1.Name = "labGenero1";
            this.labGenero1.Size = new System.Drawing.Size(0, 31);
            this.labGenero1.TabIndex = 11;
            // 
            // labDireccion1
            // 
            this.labDireccion1.AutoSize = true;
            this.labDireccion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDireccion1.Location = new System.Drawing.Point(646, 45);
            this.labDireccion1.Name = "labDireccion1";
            this.labDireccion1.Size = new System.Drawing.Size(0, 31);
            this.labDireccion1.TabIndex = 12;
            // 
            // labTelefono1
            // 
            this.labTelefono1.AutoSize = true;
            this.labTelefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTelefono1.Location = new System.Drawing.Point(780, 45);
            this.labTelefono1.Name = "labTelefono1";
            this.labTelefono1.Size = new System.Drawing.Size(0, 31);
            this.labTelefono1.TabIndex = 13;
            // 
            // labTurno
            // 
            this.labTurno.AutoSize = true;
            this.labTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTurno.Location = new System.Drawing.Point(264, 101);
            this.labTurno.Name = "labTurno";
            this.labTurno.Size = new System.Drawing.Size(0, 31);
            this.labTurno.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 50);
            this.button1.TabIndex = 15;
            this.button1.Text = "Actualizar o fijar Turno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labFecha
            // 
            this.labFecha.AutoSize = true;
            this.labFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFecha.Location = new System.Drawing.Point(12, 274);
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(90, 31);
            this.labFecha.TabIndex = 16;
            this.labFecha.Text = "Fecha";
            // 
            // labHora
            // 
            this.labHora.AutoSize = true;
            this.labHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHora.Location = new System.Drawing.Point(12, 350);
            this.labHora.Name = "labHora";
            this.labHora.Size = new System.Drawing.Size(73, 31);
            this.labHora.TabIndex = 17;
            this.labHora.Text = "Hora";
            // 
            // textFecha
            // 
            this.textFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFecha.Location = new System.Drawing.Point(18, 309);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(317, 38);
            this.textFecha.TabIndex = 18;
            // 
            // textHora
            // 
            this.textHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHora.Location = new System.Drawing.Point(18, 384);
            this.textHora.Name = "textHora";
            this.textHora.Size = new System.Drawing.Size(317, 38);
            this.textHora.TabIndex = 19;
            // 
            // textMotivo
            // 
            this.textMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMotivo.Location = new System.Drawing.Point(18, 459);
            this.textMotivo.Name = "textMotivo";
            this.textMotivo.Size = new System.Drawing.Size(317, 38);
            this.textMotivo.TabIndex = 21;
            // 
            // labMotivo
            // 
            this.labMotivo.AutoSize = true;
            this.labMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMotivo.Location = new System.Drawing.Point(12, 425);
            this.labMotivo.Name = "labMotivo";
            this.labMotivo.Size = new System.Drawing.Size(94, 31);
            this.labMotivo.TabIndex = 20;
            this.labMotivo.Text = "Motivo";
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(341, 148);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Size = new System.Drawing.Size(613, 349);
            this.dgvHistorial.TabIndex = 22;
            // 
            // btAgregarHistorial
            // 
            this.btAgregarHistorial.Location = new System.Drawing.Point(18, 528);
            this.btAgregarHistorial.Name = "btAgregarHistorial";
            this.btAgregarHistorial.Size = new System.Drawing.Size(317, 50);
            this.btAgregarHistorial.TabIndex = 23;
            this.btAgregarHistorial.Text = "Actualizar Historial";
            this.btAgregarHistorial.UseVisualStyleBackColor = true;
            this.btAgregarHistorial.Click += new System.EventHandler(this.btAgregarHistorial_Click);
            // 
            // textHistorial
            // 
            this.textHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHistorial.Location = new System.Drawing.Point(18, 584);
            this.textHistorial.Name = "textHistorial";
            this.textHistorial.Size = new System.Drawing.Size(936, 38);
            this.textHistorial.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(686, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "(Porfavor ingrese fecha y luego escriba las observaciones para cargar al historia" +
    "l)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(317, 50);
            this.button2.TabIndex = 26;
            this.button2.Text = "Eliminar Turno";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(960, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 120);
            this.button3.TabIndex = 27;
            this.button3.Text = "salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 633);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textHistorial);
            this.Controls.Add(this.btAgregarHistorial);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.textMotivo);
            this.Controls.Add(this.labMotivo);
            this.Controls.Add(this.textHora);
            this.Controls.Add(this.textFecha);
            this.Controls.Add(this.labHora);
            this.Controls.Add(this.labFecha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labTurno);
            this.Controls.Add(this.labTelefono1);
            this.Controls.Add(this.labDireccion1);
            this.Controls.Add(this.labGenero1);
            this.Controls.Add(this.labNacimiento1);
            this.Controls.Add(this.labApellido1);
            this.Controls.Add(this.labNombre1);
            this.Controls.Add(this.labTelefono);
            this.Controls.Add(this.labDireccion);
            this.Controls.Add(this.labGenero);
            this.Controls.Add(this.labNacimiento);
            this.Controls.Add(this.labApellido);
            this.Controls.Add(this.labNombre);
            this.Controls.Add(this.labPacienteActual);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labPacienteActual;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label labApellido;
        private System.Windows.Forms.Label labNacimiento;
        private System.Windows.Forms.Label labGenero;
        private System.Windows.Forms.Label labDireccion;
        private System.Windows.Forms.Label labTelefono;
        private System.Windows.Forms.Label labNombre1;
        private System.Windows.Forms.Label labApellido1;
        private System.Windows.Forms.Label labNacimiento1;
        private System.Windows.Forms.Label labGenero1;
        private System.Windows.Forms.Label labDireccion1;
        private System.Windows.Forms.Label labTelefono1;
        private System.Windows.Forms.Label labTurno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labFecha;
        private System.Windows.Forms.Label labHora;
        private System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.TextBox textHora;
        private System.Windows.Forms.TextBox textMotivo;
        private System.Windows.Forms.Label labMotivo;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Button btAgregarHistorial;
        private System.Windows.Forms.TextBox textHistorial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}