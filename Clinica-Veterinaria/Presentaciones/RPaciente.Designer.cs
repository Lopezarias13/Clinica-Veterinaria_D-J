namespace Clinica_Veterinaria.Presentaciones
{
    partial class RPaciente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label aliasLabel;
            System.Windows.Forms.Label especieLabel;
            System.Windows.Forms.Label razaLabel;
            System.Windows.Forms.Label colorDePeloLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label pesoMedioLabel;
            System.Windows.Forms.Label pesoActualLabel;
            System.Windows.Forms.Label clienteIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPaciente));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButtonIdPersona = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaVeterinariaDataSet = new Clinica_Veterinaria.ClinicaVeterinariaDataSet();
            this.aliasTextBox = new System.Windows.Forms.TextBox();
            this.especieTextBox = new System.Windows.Forms.TextBox();
            this.razaTextBox = new System.Windows.Forms.TextBox();
            this.colorDePeloTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoTextBox = new System.Windows.Forms.TextBox();
            this.pesoMedioTextBox = new System.Windows.Forms.TextBox();
            this.pesoActualTextBox = new System.Windows.Forms.TextBox();
            this.clienteIdTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.pacientesTableAdapter = new Clinica_Veterinaria.ClinicaVeterinariaDataSetTableAdapters.PacientesTableAdapter();
            this.tableAdapterManager = new Clinica_Veterinaria.ClinicaVeterinariaDataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            codigoLabel = new System.Windows.Forms.Label();
            aliasLabel = new System.Windows.Forms.Label();
            especieLabel = new System.Windows.Forms.Label();
            razaLabel = new System.Windows.Forms.Label();
            colorDePeloLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            pesoMedioLabel = new System.Windows.Forms.Label();
            pesoActualLabel = new System.Windows.Forms.Label();
            clienteIdLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaVeterinariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            codigoLabel.Location = new System.Drawing.Point(33, 126);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(67, 20);
            codigoLabel.TabIndex = 40;
            codigoLabel.Text = "Codigo:";
            // 
            // aliasLabel
            // 
            aliasLabel.AutoSize = true;
            aliasLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            aliasLabel.Location = new System.Drawing.Point(33, 159);
            aliasLabel.Name = "aliasLabel";
            aliasLabel.Size = new System.Drawing.Size(47, 20);
            aliasLabel.TabIndex = 42;
            aliasLabel.Text = "Alias:";
            // 
            // especieLabel
            // 
            especieLabel.AutoSize = true;
            especieLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            especieLabel.Location = new System.Drawing.Point(33, 192);
            especieLabel.Name = "especieLabel";
            especieLabel.Size = new System.Drawing.Size(68, 20);
            especieLabel.TabIndex = 44;
            especieLabel.Text = "Especie:";
            // 
            // razaLabel
            // 
            razaLabel.AutoSize = true;
            razaLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            razaLabel.Location = new System.Drawing.Point(33, 225);
            razaLabel.Name = "razaLabel";
            razaLabel.Size = new System.Drawing.Size(46, 20);
            razaLabel.TabIndex = 46;
            razaLabel.Text = "Raza:";
            // 
            // colorDePeloLabel
            // 
            colorDePeloLabel.AutoSize = true;
            colorDePeloLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            colorDePeloLabel.Location = new System.Drawing.Point(33, 258);
            colorDePeloLabel.Name = "colorDePeloLabel";
            colorDePeloLabel.Size = new System.Drawing.Size(113, 20);
            colorDePeloLabel.TabIndex = 48;
            colorDePeloLabel.Text = "Color De Pelo:";
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            fechaNacimientoLabel.Location = new System.Drawing.Point(33, 291);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(143, 20);
            fechaNacimientoLabel.TabIndex = 50;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // pesoMedioLabel
            // 
            pesoMedioLabel.AutoSize = true;
            pesoMedioLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            pesoMedioLabel.Location = new System.Drawing.Point(33, 324);
            pesoMedioLabel.Name = "pesoMedioLabel";
            pesoMedioLabel.Size = new System.Drawing.Size(100, 20);
            pesoMedioLabel.TabIndex = 52;
            pesoMedioLabel.Text = "Peso Medio:";
            // 
            // pesoActualLabel
            // 
            pesoActualLabel.AutoSize = true;
            pesoActualLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            pesoActualLabel.Location = new System.Drawing.Point(33, 357);
            pesoActualLabel.Name = "pesoActualLabel";
            pesoActualLabel.Size = new System.Drawing.Size(98, 20);
            pesoActualLabel.TabIndex = 54;
            pesoActualLabel.Text = "Peso Actual:";
            // 
            // clienteIdLabel
            // 
            clienteIdLabel.AutoSize = true;
            clienteIdLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            clienteIdLabel.Location = new System.Drawing.Point(699, 471);
            clienteIdLabel.Name = "clienteIdLabel";
            clienteIdLabel.Size = new System.Drawing.Size(82, 20);
            clienteIdLabel.TabIndex = 56;
            clienteIdLabel.Text = "Cliente Id:";
            clienteIdLabel.Click += new System.EventHandler(this.clienteIdLabel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.groupBox2.Location = new System.Drawing.Point(533, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(940, 334);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista Pacientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(914, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.radioButtonIdPersona);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.groupBox3.Location = new System.Drawing.Point(533, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 68);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(285, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(279, 27);
            this.textBox2.TabIndex = 3;
            // 
            // radioButtonIdPersona
            // 
            this.radioButtonIdPersona.AutoSize = true;
            this.radioButtonIdPersona.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIdPersona.Location = new System.Drawing.Point(160, 29);
            this.radioButtonIdPersona.Name = "radioButtonIdPersona";
            this.radioButtonIdPersona.Size = new System.Drawing.Size(107, 24);
            this.radioButtonIdPersona.TabIndex = 1;
            this.radioButtonIdPersona.TabStop = true;
            this.radioButtonIdPersona.Text = "Id Paciente";
            this.radioButtonIdPersona.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(codigoLabel);
            this.groupBox1.Controls.Add(this.codigoTextBox);
            this.groupBox1.Controls.Add(aliasLabel);
            this.groupBox1.Controls.Add(this.aliasTextBox);
            this.groupBox1.Controls.Add(especieLabel);
            this.groupBox1.Controls.Add(this.especieTextBox);
            this.groupBox1.Controls.Add(razaLabel);
            this.groupBox1.Controls.Add(this.razaTextBox);
            this.groupBox1.Controls.Add(colorDePeloLabel);
            this.groupBox1.Controls.Add(this.colorDePeloTextBox);
            this.groupBox1.Controls.Add(fechaNacimientoLabel);
            this.groupBox1.Controls.Add(this.fechaNacimientoTextBox);
            this.groupBox1.Controls.Add(pesoMedioLabel);
            this.groupBox1.Controls.Add(this.pesoMedioTextBox);
            this.groupBox1.Controls.Add(pesoActualLabel);
            this.groupBox1.Controls.Add(this.pesoActualTextBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonEliminar);
            this.groupBox1.Controls.Add(this.buttonCancelar);
            this.groupBox1.Controls.Add(this.buttonModificar);
            this.groupBox1.Controls.Add(this.buttonRegistrar);
            this.groupBox1.Controls.Add(this.buttonNuevo);
            this.groupBox1.Location = new System.Drawing.Point(41, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 517);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.groupBox4.Location = new System.Drawing.Point(37, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(375, 75);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dato Cliente";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(273, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "//";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente Id";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Codigo", true));
            this.codigoTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.codigoTextBox.Location = new System.Drawing.Point(202, 126);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(210, 27);
            this.codigoTextBox.TabIndex = 41;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.clinicaVeterinariaDataSet;
            // 
            // clinicaVeterinariaDataSet
            // 
            this.clinicaVeterinariaDataSet.DataSetName = "ClinicaVeterinariaDataSet";
            this.clinicaVeterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aliasTextBox
            // 
            this.aliasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Alias", true));
            this.aliasTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.aliasTextBox.Location = new System.Drawing.Point(202, 159);
            this.aliasTextBox.Name = "aliasTextBox";
            this.aliasTextBox.Size = new System.Drawing.Size(210, 27);
            this.aliasTextBox.TabIndex = 43;
            // 
            // especieTextBox
            // 
            this.especieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Especie", true));
            this.especieTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.especieTextBox.Location = new System.Drawing.Point(202, 192);
            this.especieTextBox.Name = "especieTextBox";
            this.especieTextBox.Size = new System.Drawing.Size(210, 27);
            this.especieTextBox.TabIndex = 45;
            // 
            // razaTextBox
            // 
            this.razaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Raza", true));
            this.razaTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.razaTextBox.Location = new System.Drawing.Point(202, 225);
            this.razaTextBox.Name = "razaTextBox";
            this.razaTextBox.Size = new System.Drawing.Size(210, 27);
            this.razaTextBox.TabIndex = 47;
            // 
            // colorDePeloTextBox
            // 
            this.colorDePeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "ColorDePelo", true));
            this.colorDePeloTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.colorDePeloTextBox.Location = new System.Drawing.Point(202, 258);
            this.colorDePeloTextBox.Name = "colorDePeloTextBox";
            this.colorDePeloTextBox.Size = new System.Drawing.Size(210, 27);
            this.colorDePeloTextBox.TabIndex = 49;
            // 
            // fechaNacimientoTextBox
            // 
            this.fechaNacimientoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "FechaNacimiento", true));
            this.fechaNacimientoTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.fechaNacimientoTextBox.Location = new System.Drawing.Point(202, 291);
            this.fechaNacimientoTextBox.Name = "fechaNacimientoTextBox";
            this.fechaNacimientoTextBox.Size = new System.Drawing.Size(210, 27);
            this.fechaNacimientoTextBox.TabIndex = 51;
            // 
            // pesoMedioTextBox
            // 
            this.pesoMedioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "PesoMedio", true));
            this.pesoMedioTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.pesoMedioTextBox.Location = new System.Drawing.Point(202, 324);
            this.pesoMedioTextBox.Name = "pesoMedioTextBox";
            this.pesoMedioTextBox.Size = new System.Drawing.Size(210, 27);
            this.pesoMedioTextBox.TabIndex = 53;
            // 
            // pesoActualTextBox
            // 
            this.pesoActualTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "PesoActual", true));
            this.pesoActualTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.pesoActualTextBox.Location = new System.Drawing.Point(202, 357);
            this.pesoActualTextBox.Name = "pesoActualTextBox";
            this.pesoActualTextBox.Size = new System.Drawing.Size(210, 27);
            this.pesoActualTextBox.TabIndex = 55;
            // 
            // clienteIdTextBox
            // 
            this.clienteIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "ClienteId", true));
            this.clienteIdTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.clienteIdTextBox.Location = new System.Drawing.Point(868, 471);
            this.clienteIdTextBox.Name = "clienteIdTextBox";
            this.clienteIdTextBox.Size = new System.Drawing.Size(100, 27);
            this.clienteIdTextBox.TabIndex = 57;
            this.clienteIdTextBox.TextChanged += new System.EventHandler(this.clienteIdTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.button1.Location = new System.Drawing.Point(121, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 29;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.buttonEliminar.Location = new System.Drawing.Point(336, 459);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(90, 39);
            this.buttonEliminar.TabIndex = 28;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.buttonCancelar.Location = new System.Drawing.Point(284, 414);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(90, 39);
            this.buttonCancelar.TabIndex = 27;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.buttonModificar.Location = new System.Drawing.Point(228, 459);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(90, 39);
            this.buttonModificar.TabIndex = 26;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.buttonRegistrar.Location = new System.Drawing.Point(73, 414);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(90, 39);
            this.buttonRegistrar.TabIndex = 40;
            this.buttonRegistrar.Text = "Guardar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.buttonNuevo.Location = new System.Drawing.Point(11, 459);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(90, 39);
            this.buttonNuevo.TabIndex = 25;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BitacorasTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.HistorialMedicoSetTableAdapter = null;
            this.tableAdapterManager.PacientesTableAdapter = this.pacientesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Clinica_Veterinaria.ClinicaVeterinariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VacunasTableAdapter = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clinica_Veterinaria.Properties.Resources.veterinario;
            this.pictureBox1.Location = new System.Drawing.Point(1345, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(626, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 30);
            this.button2.TabIndex = 32;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 551);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.clienteIdTextBox);
            this.Controls.Add(clienteIdLabel);
            this.Name = "RPaciente";
            this.Text = "RPaciente";
            this.Load += new System.EventHandler(this.RPaciente_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaVeterinariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButtonIdPersona;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonNuevo;
        private ClinicaVeterinariaDataSet clinicaVeterinariaDataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private ClinicaVeterinariaDataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private ClinicaVeterinariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox aliasTextBox;
        private System.Windows.Forms.TextBox especieTextBox;
        private System.Windows.Forms.TextBox razaTextBox;
        private System.Windows.Forms.TextBox colorDePeloTextBox;
        private System.Windows.Forms.TextBox fechaNacimientoTextBox;
        private System.Windows.Forms.TextBox pesoMedioTextBox;
        private System.Windows.Forms.TextBox pesoActualTextBox;
        private System.Windows.Forms.TextBox clienteIdTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}