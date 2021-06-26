
namespace Projecto_de_DA
{
    partial class formFuncionarios
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
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.tbxNomeFuncionario = new System.Windows.Forms.TextBox();
            this.tbxExtencaoFuncionario = new System.Windows.Forms.TextBox();
            this.tbxNumeroFuncionario = new System.Windows.Forms.TextBox();
            this.listBoxFuncionarios = new System.Windows.Forms.ListBox();
            this.bsFuncionarios = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.BackgroundImage = global::Projecto_de_DA.Properties.Resources.unlock;
            this.btnDesbloquear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDesbloquear.FlatAppearance.BorderSize = 0;
            this.btnDesbloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesbloquear.Location = new System.Drawing.Point(295, 386);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(50, 50);
            this.btnDesbloquear.TabIndex = 42;
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(464, 369);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(115, 60);
            this.btnAtualizar.TabIndex = 41;
            this.btnAtualizar.Text = "Atualizar Dados";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(596, 369);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 60);
            this.btnEliminar.TabIndex = 40;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(489, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 24);
            this.label8.TabIndex = 39;
            this.label8.Text = "Detalhes do Funcionario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 38;
            this.label7.Text = "Funcionarios";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Extencao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Numero";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(855, 7);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(29, 23);
            this.btnFechar.TabIndex = 31;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(729, 369);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(115, 60);
            this.btnAdicionar.TabIndex = 30;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // tbxNomeFuncionario
            // 
            this.tbxNomeFuncionario.Location = new System.Drawing.Point(361, 142);
            this.tbxNomeFuncionario.Name = "tbxNomeFuncionario";
            this.tbxNomeFuncionario.Size = new System.Drawing.Size(496, 20);
            this.tbxNomeFuncionario.TabIndex = 29;
            this.tbxNomeFuncionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxExtencaoFuncionario
            // 
            this.tbxExtencaoFuncionario.Location = new System.Drawing.Point(361, 168);
            this.tbxExtencaoFuncionario.Name = "tbxExtencaoFuncionario";
            this.tbxExtencaoFuncionario.Size = new System.Drawing.Size(496, 20);
            this.tbxExtencaoFuncionario.TabIndex = 28;
            this.tbxExtencaoFuncionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNumeroFuncionario
            // 
            this.tbxNumeroFuncionario.Location = new System.Drawing.Point(361, 116);
            this.tbxNumeroFuncionario.Name = "tbxNumeroFuncionario";
            this.tbxNumeroFuncionario.Size = new System.Drawing.Size(496, 20);
            this.tbxNumeroFuncionario.TabIndex = 24;
            this.tbxNumeroFuncionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBoxFuncionarios
            // 
            this.listBoxFuncionarios.DataSource = this.bsFuncionarios;
            this.listBoxFuncionarios.FormattingEnabled = true;
            this.listBoxFuncionarios.Location = new System.Drawing.Point(7, 39);
            this.listBoxFuncionarios.Name = "listBoxFuncionarios";
            this.listBoxFuncionarios.Size = new System.Drawing.Size(265, 407);
            this.listBoxFuncionarios.TabIndex = 23;
            this.listBoxFuncionarios.SelectedIndexChanged += new System.EventHandler(this.listBoxFuncionarios_SelectedIndexChanged);
            // 
            // formFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 453);
            this.Controls.Add(this.btnDesbloquear);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tbxNomeFuncionario);
            this.Controls.Add(this.tbxExtencaoFuncionario);
            this.Controls.Add(this.tbxNumeroFuncionario);
            this.Controls.Add(this.listBoxFuncionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formFuncionarios";
            this.Text = "formFuncionarios";
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox tbxNomeFuncionario;
        private System.Windows.Forms.TextBox tbxExtencaoFuncionario;
        private System.Windows.Forms.TextBox tbxNumeroFuncionario;
        private System.Windows.Forms.ListBox listBoxFuncionarios;
        private System.Windows.Forms.BindingSource bsFuncionarios;
    }
}