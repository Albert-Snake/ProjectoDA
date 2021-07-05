
namespace Projecto_de_DA
{
    partial class formEspecialista
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbxFuncionarios = new System.Windows.Forms.ComboBox();
            this.bsFuncionarios = new System.Windows.Forms.BindingSource(this.components);
            this.cbxTipoProjeto = new System.Windows.Forms.ComboBox();
            this.bsTipoProjetos = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.listboxEspecialistas = new System.Windows.Forms.ListBox();
            this.bsEspecialistas = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoProjetos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEspecialistas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Tipo Projecto";
            // 
            // cbxFuncionarios
            // 
            this.cbxFuncionarios.DataSource = this.bsFuncionarios;
            this.cbxFuncionarios.FormattingEnabled = true;
            this.cbxFuncionarios.Location = new System.Drawing.Point(415, 170);
            this.cbxFuncionarios.Name = "cbxFuncionarios";
            this.cbxFuncionarios.Size = new System.Drawing.Size(439, 21);
            this.cbxFuncionarios.TabIndex = 75;
            // 
            // cbxTipoProjeto
            // 
            this.cbxTipoProjeto.DataSource = this.bsTipoProjetos;
            this.cbxTipoProjeto.FormattingEnabled = true;
            this.cbxTipoProjeto.Location = new System.Drawing.Point(415, 143);
            this.cbxTipoProjeto.Name = "cbxTipoProjeto";
            this.cbxTipoProjeto.Size = new System.Drawing.Size(439, 21);
            this.cbxTipoProjeto.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Funcionario";
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.BackgroundImage = global::Projecto_de_DA.Properties.Resources.unlock;
            this.btnDesbloquear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDesbloquear.Enabled = false;
            this.btnDesbloquear.FlatAppearance.BorderSize = 0;
            this.btnDesbloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesbloquear.Location = new System.Drawing.Point(292, 387);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(50, 50);
            this.btnDesbloquear.TabIndex = 72;
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Visible = false;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Location = new System.Drawing.Point(461, 370);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(115, 60);
            this.btnAtualizar.TabIndex = 71;
            this.btnAtualizar.Text = "Atualizar Dados";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(593, 370);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 60);
            this.btnEliminar.TabIndex = 70;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(486, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 24);
            this.label8.TabIndex = 69;
            this.label8.Text = "Detalhes do Especialista";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 24);
            this.label7.TabIndex = 68;
            this.label7.Text = "Especialistas";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(852, 8);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(29, 23);
            this.btnFechar.TabIndex = 67;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(726, 370);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(115, 60);
            this.btnAdicionar.TabIndex = 66;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // listboxEspecialistas
            // 
            this.listboxEspecialistas.DataSource = this.bsEspecialistas;
            this.listboxEspecialistas.FormattingEnabled = true;
            this.listboxEspecialistas.Location = new System.Drawing.Point(13, 37);
            this.listboxEspecialistas.Name = "listboxEspecialistas";
            this.listboxEspecialistas.Size = new System.Drawing.Size(265, 407);
            this.listboxEspecialistas.TabIndex = 64;
            this.listboxEspecialistas.SelectedIndexChanged += new System.EventHandler(this.listboxEspecialistas_SelectedIndexChanged);
            // 
            // formEspecialista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxFuncionarios);
            this.Controls.Add(this.cbxTipoProjeto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDesbloquear);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.listboxEspecialistas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formEspecialista";
            this.Text = "formEspecialista";
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoProjetos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEspecialistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxFuncionarios;
        private System.Windows.Forms.ComboBox cbxTipoProjeto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox listboxEspecialistas;
        private System.Windows.Forms.BindingSource bsEspecialistas;
        private System.Windows.Forms.BindingSource bsTipoProjetos;
        private System.Windows.Forms.BindingSource bsFuncionarios;
    }
}