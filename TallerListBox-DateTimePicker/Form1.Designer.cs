namespace TallerListBox_DateTimePicker
{
    partial class Form1
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
            this.lbLista = new System.Windows.Forms.ListBox();
            this.lbSeleccionados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnQuitarTodo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.ltvListaFinal = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.lblListsSelecVacia = new System.Windows.Forms.Label();
            this.lblFechaIniCorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.ItemHeight = 15;
            this.lbLista.Location = new System.Drawing.Point(35, 54);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(188, 229);
            this.lbLista.TabIndex = 0;
            // 
            // lbSeleccionados
            // 
            this.lbSeleccionados.FormattingEnabled = true;
            this.lbSeleccionados.ItemHeight = 15;
            this.lbSeleccionados.Location = new System.Drawing.Point(360, 54);
            this.lbSeleccionados.Name = "lbSeleccionados";
            this.lbSeleccionados.Size = new System.Drawing.Size(189, 229);
            this.lbSeleccionados.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de alumnos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(415, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Integrantes";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(249, 91);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 36);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar -->";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(249, 146);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(91, 35);
            this.btnQuitar.TabIndex = 5;
            this.btnQuitar.Text = "<-- Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnQuitarTodo
            // 
            this.btnQuitarTodo.Location = new System.Drawing.Point(249, 201);
            this.btnQuitarTodo.Name = "btnQuitarTodo";
            this.btnQuitarTodo.Size = new System.Drawing.Size(91, 39);
            this.btnQuitarTodo.TabIndex = 6;
            this.btnQuitarTodo.Text = "<-- Quitar todo";
            this.btnQuitarTodo.UseVisualStyleBackColor = true;
            this.btnQuitarTodo.Click += new System.EventHandler(this.btnQuitarTodo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Equipo de trabajo:";
            // 
            // txtEquipo
            // 
            this.txtEquipo.Location = new System.Drawing.Point(192, 305);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(148, 23);
            this.txtEquipo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de inicio:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(192, 342);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(148, 23);
            this.dtpFechaInicio.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(379, 324);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 33);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ltvListaFinal
            // 
            this.ltvListaFinal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ltvListaFinal.Location = new System.Drawing.Point(35, 388);
            this.ltvListaFinal.Name = "ltvListaFinal";
            this.ltvListaFinal.Size = new System.Drawing.Size(523, 124);
            this.ltvListaFinal.TabIndex = 12;
            this.ltvListaFinal.UseCompatibleStateImageBehavior = false;
            this.ltvListaFinal.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Alumno";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Equipo de trabajo";
            this.columnHeader2.Width = 175;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha de inicio";
            this.columnHeader3.Width = 200;
            // 
            // lblListsSelecVacia
            // 
            this.lblListsSelecVacia.AutoSize = true;
            this.lblListsSelecVacia.Location = new System.Drawing.Point(379, 286);
            this.lblListsSelecVacia.Name = "lblListsSelecVacia";
            this.lblListsSelecVacia.Size = new System.Drawing.Size(0, 15);
            this.lblListsSelecVacia.TabIndex = 13;
            // 
            // lblFechaIniCorrect
            // 
            this.lblFechaIniCorrect.AutoSize = true;
            this.lblFechaIniCorrect.Location = new System.Drawing.Point(198, 367);
            this.lblFechaIniCorrect.Name = "lblFechaIniCorrect";
            this.lblFechaIniCorrect.Size = new System.Drawing.Size(0, 15);
            this.lblFechaIniCorrect.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 542);
            this.Controls.Add(this.lblFechaIniCorrect);
            this.Controls.Add(this.lblListsSelecVacia);
            this.Controls.Add(this.ltvListaFinal);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEquipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnQuitarTodo);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSeleccionados);
            this.Controls.Add(this.lbLista);
            this.Name = "Form1";
            this.Text = "Equipos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbLista;
        private ListBox lbSeleccionados;
        private Label label1;
        private Label label2;
        private Button btnAgregar;
        private Button btnQuitar;
        private Button btnQuitarTodo;
        private Label label3;
        private TextBox txtEquipo;
        private Label label4;
        private DateTimePicker dtpFechaInicio;
        private Button btnGuardar;
        private ListView ltvListaFinal;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label lblListsSelecVacia;
        private Label lblFechaIniCorrect;
    }
}