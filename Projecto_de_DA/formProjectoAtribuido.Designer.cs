
namespace Projecto_de_DA
{
    partial class formProjectoAtribuido
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.listboxProjetosAtribuidos = new System.Windows.Forms.ListBox();
            this.bsProjectosAtribuidos = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbxFuncionario = new System.Windows.Forms.ComboBox();
            this.bsFuncionarios = new System.Windows.Forms.BindingSource(this.components);
            this.cbxProjeto = new System.Windows.Forms.ComboBox();
            this.bsProjectos = new System.Windows.Forms.BindingSource(this.components);
            this.dataAtribuicao = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjectosAtribuidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjectos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Projecto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Funcionario";
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.BackgroundImage = global::Projecto_de_DA.Properties.Resources.unlock;
            this.btnDesbloquear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDesbloquear.FlatAppearance.BorderSize = 0;
            this.btnDesbloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesbloquear.Location = new System.Drawing.Point(292, 387);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(50, 50);
            this.btnDesbloquear.TabIndex = 86;
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Location = new System.Drawing.Point(461, 370);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(115, 60);
            this.btnAtualizar.TabIndex = 85;
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
            this.btnEliminar.TabIndex = 84;
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
            this.label8.Size = new System.Drawing.Size(198, 24);
            this.label8.TabIndex = 83;
            this.label8.Text = "Detalhes da Atribuição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 24);
            this.label7.TabIndex = 82;
            this.label7.Text = "Projectos Atribuidos";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(852, 8);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(29, 23);
            this.btnFechar.TabIndex = 81;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(731, 370);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(115, 60);
            this.btnAdicionar.TabIndex = 80;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // listboxProjetosAtribuidos
            // 
            this.listboxProjetosAtribuidos.DataSource = this.bsProjectosAtribuidos;
            this.listboxProjetosAtribuidos.FormattingEnabled = true;
            this.listboxProjetosAtribuidos.Location = new System.Drawing.Point(13, 37);
            this.listboxProjetosAtribuidos.Name = "listboxProjetosAtribuidos";
            this.listboxProjetosAtribuidos.Size = new System.Drawing.Size(265, 407);
            this.listboxProjetosAtribuidos.TabIndex = 79;
            this.listboxProjetosAtribuidos.SelectedIndexChanged += new System.EventHandler(this.listboxProjetosAtribuidos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Data";
            // 
            // cbxFuncionario
            // 
            this.cbxFuncionario.DataSource = this.bsFuncionarios;
            this.cbxFuncionario.FormattingEnabled = true;
            this.cbxFuncionario.Location = new System.Drawing.Point(439, 174);
            this.cbxFuncionario.Name = "cbxFuncionario";
            this.cbxFuncionario.Size = new System.Drawing.Size(439, 21);
            this.cbxFuncionario.TabIndex = 93;
            // 
            // cbxProjeto
            // 
            this.cbxProjeto.DataSource = this.bsProjectos;
            this.cbxProjeto.FormattingEnabled = true;
            this.cbxProjeto.Location = new System.Drawing.Point(439, 147);
            this.cbxProjeto.Name = "cbxProjeto";
            this.cbxProjeto.Size = new System.Drawing.Size(439, 21);
            this.cbxProjeto.TabIndex = 92;
            // 
            // dataAtribuicao
            // 
            this.dataAtribuicao.Location = new System.Drawing.Point(439, 121);
            this.dataAtribuicao.Name = "dataAtribuicao";
            this.dataAtribuicao.Size = new System.Drawing.Size(439, 20);
            this.dataAtribuicao.TabIndex = 91;
            // 
            // formProjectoAtribuido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxFuncionario);
            this.Controls.Add(this.cbxProjeto);
            this.Controls.Add(this.dataAtribuicao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDesbloquear);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.listboxProjetosAtribuidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formProjectoAtribuido";
            this.Text = "formProjectoAtribuido";
            ((System.ComponentModel.ISupportInitialize)(this.bsProjectosAtribuidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox listboxProjetosAtribuidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxFuncionario;
        private System.Windows.Forms.ComboBox cbxProjeto;
        private System.Windows.Forms.DateTimePicker dataAtribuicao;
        private System.Windows.Forms.BindingSource bsProjectosAtribuidos;
        private System.Windows.Forms.BindingSource bsFuncionarios;
        private System.Windows.Forms.BindingSource bsProjectos;
    }
}