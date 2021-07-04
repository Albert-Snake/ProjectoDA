
namespace Projecto_de_DA
{
    partial class formDocumentos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxProjecto = new System.Windows.Forms.ComboBox();
            this.bsProjectos = new System.Windows.Forms.BindingSource(this.components);
            this.cbxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.bsTipoDocumentos = new System.Windows.Forms.BindingSource(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.tbxNomeDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listboxDocumentos = new System.Windows.Forms.ListBox();
            this.bsDocumentos = new System.Windows.Forms.BindingSource(this.components);
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxProjecto);
            this.groupBox1.Controls.Add(this.cbxTipoDocumento);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.buttonGuardar);
            this.groupBox1.Controls.Add(this.btnDesbloquear);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtDataEntrega);
            this.groupBox1.Controls.Add(this.tbxNomeDocumento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(40, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(361, 392);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo Documento";
            // 
            // cbxProjecto
            // 
            this.cbxProjecto.DataSource = this.bsProjectos;
            this.cbxProjecto.FormattingEnabled = true;
            this.cbxProjecto.Location = new System.Drawing.Point(170, 177);
            this.cbxProjecto.Name = "cbxProjecto";
            this.cbxProjecto.Size = new System.Drawing.Size(186, 21);
            this.cbxProjecto.TabIndex = 50;
            // 
            // cbxTipoDocumento
            // 
            this.cbxTipoDocumento.DataSource = this.bsTipoDocumentos;
            this.cbxTipoDocumento.FormattingEnabled = true;
            this.cbxTipoDocumento.Location = new System.Drawing.Point(170, 128);
            this.cbxTipoDocumento.Name = "cbxTipoDocumento";
            this.cbxTipoDocumento.Size = new System.Drawing.Size(186, 21);
            this.cbxTipoDocumento.TabIndex = 49;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(64, 335);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(292, 23);
            this.btnEliminar.TabIndex = 56;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Location = new System.Drawing.Point(64, 302);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(292, 27);
            this.btnAtualizar.TabIndex = 57;
            this.btnAtualizar.Text = "Atualizar Dados";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(64, 362);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(292, 25);
            this.buttonGuardar.TabIndex = 48;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.BackgroundImage = global::Projecto_de_DA.Properties.Resources.unlock;
            this.btnDesbloquear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDesbloquear.FlatAppearance.BorderSize = 0;
            this.btnDesbloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesbloquear.Location = new System.Drawing.Point(8, 322);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(50, 50);
            this.btnDesbloquear.TabIndex = 46;
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Tipo de Documento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Data de Entrega";
            // 
            // dtDataEntrega
            // 
            this.dtDataEntrega.Location = new System.Drawing.Point(170, 86);
            this.dtDataEntrega.Margin = new System.Windows.Forms.Padding(2);
            this.dtDataEntrega.Name = "dtDataEntrega";
            this.dtDataEntrega.Size = new System.Drawing.Size(185, 20);
            this.dtDataEntrega.TabIndex = 20;
            // 
            // tbxNomeDocumento
            // 
            this.tbxNomeDocumento.Location = new System.Drawing.Point(170, 36);
            this.tbxNomeDocumento.Name = "tbxNomeDocumento";
            this.tbxNomeDocumento.Size = new System.Drawing.Size(186, 20);
            this.tbxNomeDocumento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Titulo do Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Projecto a que pertence:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(583, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 24);
            this.label7.TabIndex = 55;
            this.label7.Text = "Documentos";
            // 
            // listboxDocumentos
            // 
            this.listboxDocumentos.DataSource = this.bsDocumentos;
            this.listboxDocumentos.FormattingEnabled = true;
            this.listboxDocumentos.Location = new System.Drawing.Point(459, 47);
            this.listboxDocumentos.Name = "listboxDocumentos";
            this.listboxDocumentos.Size = new System.Drawing.Size(362, 355);
            this.listboxDocumentos.TabIndex = 54;
            this.listboxDocumentos.SelectedIndexChanged += new System.EventHandler(this.listboxDocumentos_SelectedIndexChanged);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(861, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(29, 23);
            this.btnFechar.TabIndex = 55;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // formDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 453);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listboxDocumentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formDocumentos";
            this.Text = "formDocumentos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoDocumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtDataEntrega;
        private System.Windows.Forms.TextBox tbxNomeDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listboxDocumentos;
        private System.Windows.Forms.ComboBox cbxProjecto;
        private System.Windows.Forms.ComboBox cbxTipoDocumento;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.BindingSource bsTipoDocumentos;
        private System.Windows.Forms.BindingSource bsProjectos;
        private System.Windows.Forms.BindingSource bsDocumentos;
    }
}