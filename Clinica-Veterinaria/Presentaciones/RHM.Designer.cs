namespace Clinica_Veterinaria.Presentaciones
{
    partial class RHM
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
            System.Windows.Forms.Label nombreEnfermedadLabel;
            System.Windows.Forms.Label fechaEnfermedadLabel;
            System.Windows.Forms.Label pacienteIdLabel;
            System.Windows.Forms.Label vacunaIdLabel;
            this.clinicaVeterinariaDataSet = new Clinica_Veterinaria.ClinicaVeterinariaDataSet();
            this.historialMedicoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historialMedicoSetTableAdapter = new Clinica_Veterinaria.ClinicaVeterinariaDataSetTableAdapters.HistorialMedicoSetTableAdapter();
            this.tableAdapterManager = new Clinica_Veterinaria.ClinicaVeterinariaDataSetTableAdapters.TableAdapterManager();
            this.nombreEnfermedadTextBox = new System.Windows.Forms.TextBox();
            this.fechaEnfermedadTextBox = new System.Windows.Forms.TextBox();
            this.pacienteIdTextBox = new System.Windows.Forms.TextBox();
            this.vacunaIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            nombreEnfermedadLabel = new System.Windows.Forms.Label();
            fechaEnfermedadLabel = new System.Windows.Forms.Label();
            pacienteIdLabel = new System.Windows.Forms.Label();
            vacunaIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaVeterinariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialMedicoSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreEnfermedadLabel
            // 
            nombreEnfermedadLabel.AutoSize = true;
            nombreEnfermedadLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            nombreEnfermedadLabel.Location = new System.Drawing.Point(6, 134);
            nombreEnfermedadLabel.Name = "nombreEnfermedadLabel";
            nombreEnfermedadLabel.Size = new System.Drawing.Size(166, 20);
            nombreEnfermedadLabel.TabIndex = 0;
            nombreEnfermedadLabel.Text = "Nombre Enfermedad:";
            // 
            // fechaEnfermedadLabel
            // 
            fechaEnfermedadLabel.AutoSize = true;
            fechaEnfermedadLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            fechaEnfermedadLabel.Location = new System.Drawing.Point(6, 167);
            fechaEnfermedadLabel.Name = "fechaEnfermedadLabel";
            fechaEnfermedadLabel.Size = new System.Drawing.Size(147, 20);
            fechaEnfermedadLabel.TabIndex = 2;
            fechaEnfermedadLabel.Text = "Fecha Enfermedad:";
            // 
            // pacienteIdLabel
            // 
            pacienteIdLabel.AutoSize = true;
            pacienteIdLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            pacienteIdLabel.Location = new System.Drawing.Point(6, 200);
            pacienteIdLabel.Name = "pacienteIdLabel";
            pacienteIdLabel.Size = new System.Drawing.Size(93, 20);
            pacienteIdLabel.TabIndex = 4;
            pacienteIdLabel.Text = "Paciente Id:";
            // 
            // vacunaIdLabel
            // 
            vacunaIdLabel.AutoSize = true;
            vacunaIdLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            vacunaIdLabel.Location = new System.Drawing.Point(6, 246);
            vacunaIdLabel.Name = "vacunaIdLabel";
            vacunaIdLabel.Size = new System.Drawing.Size(83, 20);
            vacunaIdLabel.TabIndex = 6;
            vacunaIdLabel.Text = "Vacuna Id:";
            // 
            // clinicaVeterinariaDataSet
            // 
            this.clinicaVeterinariaDataSet.DataSetName = "ClinicaVeterinariaDataSet";
            this.clinicaVeterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historialMedicoSetBindingSource
            // 
            this.historialMedicoSetBindingSource.DataMember = "HistorialMedicoSet";
            this.historialMedicoSetBindingSource.DataSource = this.clinicaVeterinariaDataSet;
            // 
            // historialMedicoSetTableAdapter
            // 
            this.historialMedicoSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BitacorasTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.HistorialMedicoSetTableAdapter = this.historialMedicoSetTableAdapter;
            this.tableAdapterManager.PacientesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Clinica_Veterinaria.ClinicaVeterinariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VacunasTableAdapter = null;
            // 
            // nombreEnfermedadTextBox
            // 
            this.nombreEnfermedadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historialMedicoSetBindingSource, "NombreEnfermedad", true));
            this.nombreEnfermedadTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.nombreEnfermedadTextBox.Location = new System.Drawing.Point(188, 131);
            this.nombreEnfermedadTextBox.Name = "nombreEnfermedadTextBox";
            this.nombreEnfermedadTextBox.Size = new System.Drawing.Size(193, 27);
            this.nombreEnfermedadTextBox.TabIndex = 1;
            // 
            // fechaEnfermedadTextBox
            // 
            this.fechaEnfermedadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historialMedicoSetBindingSource, "FechaEnfermedad", true));
            this.fechaEnfermedadTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.fechaEnfermedadTextBox.Location = new System.Drawing.Point(188, 164);
            this.fechaEnfermedadTextBox.Name = "fechaEnfermedadTextBox";
            this.fechaEnfermedadTextBox.Size = new System.Drawing.Size(193, 27);
            this.fechaEnfermedadTextBox.TabIndex = 3;
            // 
            // pacienteIdTextBox
            // 
            this.pacienteIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historialMedicoSetBindingSource, "PacienteId", true));
            this.pacienteIdTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.pacienteIdTextBox.Location = new System.Drawing.Point(188, 197);
            this.pacienteIdTextBox.Name = "pacienteIdTextBox";
            this.pacienteIdTextBox.Size = new System.Drawing.Size(193, 27);
            this.pacienteIdTextBox.TabIndex = 5;
            // 
            // vacunaIdTextBox
            // 
            this.vacunaIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historialMedicoSetBindingSource, "VacunaId", true));
            this.vacunaIdTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.vacunaIdTextBox.Location = new System.Drawing.Point(188, 243);
            this.vacunaIdTextBox.Name = "vacunaIdTextBox";
            this.vacunaIdTextBox.Size = new System.Drawing.Size(193, 27);
            this.vacunaIdTextBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.fechaEnfermedadTextBox);
            this.groupBox1.Controls.Add(nombreEnfermedadLabel);
            this.groupBox1.Controls.Add(this.vacunaIdTextBox);
            this.groupBox1.Controls.Add(this.nombreEnfermedadTextBox);
            this.groupBox1.Controls.Add(vacunaIdLabel);
            this.groupBox1.Controls.Add(fechaEnfermedadLabel);
            this.groupBox1.Controls.Add(this.pacienteIdTextBox);
            this.groupBox1.Controls.Add(pacienteIdLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 366);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbClientes);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.groupBox4.Location = new System.Drawing.Point(6, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(375, 75);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dato Paciente";
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(144, 33);
            this.cbClientes.Margin = new System.Windows.Forms.Padding(2);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(214, 28);
            this.cbClientes.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paciente";
            // 
            // RHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "RHM";
            this.Text = "RHM";
            this.Load += new System.EventHandler(this.RHM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clinicaVeterinariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialMedicoSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ClinicaVeterinariaDataSet clinicaVeterinariaDataSet;
        private System.Windows.Forms.BindingSource historialMedicoSetBindingSource;
        private ClinicaVeterinariaDataSetTableAdapters.HistorialMedicoSetTableAdapter historialMedicoSetTableAdapter;
        private ClinicaVeterinariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nombreEnfermedadTextBox;
        private System.Windows.Forms.TextBox fechaEnfermedadTextBox;
        private System.Windows.Forms.TextBox pacienteIdTextBox;
        private System.Windows.Forms.TextBox vacunaIdTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label label1;
    }
}