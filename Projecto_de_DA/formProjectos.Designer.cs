
namespace Projecto_de_DA
{
    partial class formProjectos
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
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.DataAprovecao = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.DataInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxProcesso = new System.Windows.Forms.ComboBox();
            this.bsProcesso = new System.Windows.Forms.BindingSource(this.components);
            this.cbxTipoProjeto = new System.Windows.Forms.ComboBox();
            this.bsTipoProjeto = new System.Windows.Forms.BindingSource(this.components);
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxNomeProjeto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listboxProjetos = new System.Windows.Forms.ListBox();
            this.bsProjetos = new System.Windows.Forms.BindingSource(this.components);
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoProjeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjetos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(85, 327);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(271, 41);
            this.buttonGuardar.TabIndex = 48;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // DataAprovecao
            // 
            this.DataAprovecao.Location = new System.Drawing.Point(171, 136);
            this.DataAprovecao.Margin = new System.Windows.Forms.Padding(2);
            this.DataAprovecao.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.DataAprovecao.Name = "DataAprovecao";
            this.DataAprovecao.Size = new System.Drawing.Size(160, 20);
            this.DataAprovecao.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Data de Aprovação";
            // 
            // DataInicio
            // 
            this.DataInicio.Location = new System.Drawing.Point(171, 87);
            this.DataInicio.Margin = new System.Windows.Forms.Padding(2);
            this.DataInicio.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.Size = new System.Drawing.Size(160, 20);
            this.DataInicio.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxProcesso);
            this.groupBox1.Controls.Add(this.cbxTipoProjeto);
            this.groupBox1.Controls.Add(this.buttonGuardar);
            this.groupBox1.Controls.Add(this.btnDesbloquear);
            this.groupBox1.Controls.Add(this.DataAprovecao);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DataInicio);
            this.groupBox1.Controls.Add(this.tbxNomeProjeto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(51, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(361, 392);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo projeto";
            // 
            // cbxProcesso
            // 
            this.cbxProcesso.DataSource = this.bsProcesso;
            this.cbxProcesso.FormattingEnabled = true;
            this.cbxProcesso.Location = new System.Drawing.Point(171, 229);
            this.cbxProcesso.Name = "cbxProcesso";
            this.cbxProcesso.Size = new System.Drawing.Size(160, 21);
            this.cbxProcesso.TabIndex = 51;
            // 
            // cbxTipoProjeto
            // 
            this.cbxTipoProjeto.DataSource = this.bsTipoProjeto;
            this.cbxTipoProjeto.FormattingEnabled = true;
            this.cbxTipoProjeto.Location = new System.Drawing.Point(171, 179);
            this.cbxTipoProjeto.Name = "cbxTipoProjeto";
            this.cbxTipoProjeto.Size = new System.Drawing.Size(160, 21);
            this.cbxTipoProjeto.TabIndex = 50;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Data de inicio do projeto";
            // 
            // tbxNomeProjeto
            // 
            this.tbxNomeProjeto.Location = new System.Drawing.Point(171, 39);
            this.tbxNomeProjeto.Name = "tbxNomeProjeto";
            this.tbxNomeProjeto.Size = new System.Drawing.Size(160, 20);
            this.tbxNomeProjeto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Estado do Projeto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tipo de projeto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Processo";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(444, 304);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(165, 60);
            this.btnAtualizar.TabIndex = 52;
            this.btnAtualizar.Text = "Atualizar Dados";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(637, 304);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(169, 60);
            this.btnEliminar.TabIndex = 51;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(566, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 49;
            this.label7.Text = "Projetos";
            // 
            // listboxProjetos
            // 
            this.listboxProjetos.DataSource = this.bsProjetos;
            this.listboxProjetos.FormattingEnabled = true;
            this.listboxProjetos.Location = new System.Drawing.Point(444, 38);
            this.listboxProjetos.Name = "listboxProjetos";
            this.listboxProjetos.Size = new System.Drawing.Size(362, 225);
            this.listboxProjetos.TabIndex = 48;
            this.listboxProjetos.SelectedIndexChanged += new System.EventHandler(this.listboxProjetos_SelectedIndexChanged);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(859, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(29, 23);
            this.btnFechar.TabIndex = 54;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // formProjectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 453);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listboxProjetos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formProjectos";
            this.Text = "formProjectos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoProjeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjetos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.DateTimePicker DataAprovecao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DataInicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxNomeProjeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listboxProjetos;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.BindingSource bsProjetos;
        private System.Windows.Forms.ComboBox cbxProcesso;
        private System.Windows.Forms.ComboBox cbxTipoProjeto;
        private System.Windows.Forms.BindingSource bsTipoProjeto;
        private System.Windows.Forms.BindingSource bsProcesso;
    }
}