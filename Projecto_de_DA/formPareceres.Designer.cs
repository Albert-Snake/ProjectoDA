
namespace Projecto_de_DA
{
    partial class formPareceres
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.tbxTextoParecer = new System.Windows.Forms.TextBox();
            this.bsPareceres = new System.Windows.Forms.BindingSource(this.components);
            this.dataParecer = new System.Windows.Forms.DateTimePicker();
            this.cbxProjeto = new System.Windows.Forms.ComboBox();
            this.cbxFuncionario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bsProjeto = new System.Windows.Forms.BindingSource(this.components);
            this.bsFuncionario = new System.Windows.Forms.BindingSource(this.components);
            this.listboxPareceres = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsPareceres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionario)).BeginInit();
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
            this.btnDesbloquear.TabIndex = 56;
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(464, 369);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(115, 60);
            this.btnAtualizar.TabIndex = 55;
            this.btnAtualizar.Text = "Atualizar Dados";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(596, 369);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 60);
            this.btnEliminar.TabIndex = 54;
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
            this.label8.Size = new System.Drawing.Size(181, 24);
            this.label8.TabIndex = 53;
            this.label8.Text = "Detalhes do Parecer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 24);
            this.label7.TabIndex = 52;
            this.label7.Text = "Pareceres";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(855, 7);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(29, 23);
            this.btnFechar.TabIndex = 48;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(729, 369);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(115, 60);
            this.btnAdicionar.TabIndex = 47;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // tbxTextoParecer
            // 
            this.tbxTextoParecer.Location = new System.Drawing.Point(418, 196);
            this.tbxTextoParecer.Multiline = true;
            this.tbxTextoParecer.Name = "tbxTextoParecer";
            this.tbxTextoParecer.Size = new System.Drawing.Size(439, 53);
            this.tbxTextoParecer.TabIndex = 45;
            this.tbxTextoParecer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataParecer
            // 
            this.dataParecer.Location = new System.Drawing.Point(418, 116);
            this.dataParecer.Name = "dataParecer";
            this.dataParecer.Size = new System.Drawing.Size(439, 20);
            this.dataParecer.TabIndex = 57;
            // 
            // cbxProjeto
            // 
            this.cbxProjeto.DataSource = this.bsProjeto;
            this.cbxProjeto.FormattingEnabled = true;
            this.cbxProjeto.Location = new System.Drawing.Point(418, 142);
            this.cbxProjeto.Name = "cbxProjeto";
            this.cbxProjeto.Size = new System.Drawing.Size(439, 21);
            this.cbxProjeto.TabIndex = 58;
            // 
            // cbxFuncionario
            // 
            this.cbxFuncionario.DataSource = this.bsFuncionario;
            this.cbxFuncionario.FormattingEnabled = true;
            this.cbxFuncionario.Location = new System.Drawing.Point(418, 169);
            this.cbxFuncionario.Name = "cbxFuncionario";
            this.cbxFuncionario.Size = new System.Drawing.Size(439, 21);
            this.cbxFuncionario.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Projecto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Funcionario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Texto do Parecer";
            // 
            // listboxPareceres
            // 
            this.listboxPareceres.DataSource = this.bsPareceres;
            this.listboxPareceres.FormattingEnabled = true;
            this.listboxPareceres.Location = new System.Drawing.Point(16, 36);
            this.listboxPareceres.Name = "listboxPareceres";
            this.listboxPareceres.Size = new System.Drawing.Size(265, 407);
            this.listboxPareceres.TabIndex = 43;
            this.listboxPareceres.SelectedIndexChanged += new System.EventHandler(this.listboxPareceres_SelectedIndexChanged);
            // 
            // formPareceres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 453);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxFuncionario);
            this.Controls.Add(this.cbxProjeto);
            this.Controls.Add(this.dataParecer);
            this.Controls.Add(this.btnDesbloquear);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tbxTextoParecer);
            this.Controls.Add(this.listboxPareceres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPareceres";
            this.Text = "formPareceres";
            ((System.ComponentModel.ISupportInitialize)(this.bsPareceres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox tbxTextoParecer;
        private System.Windows.Forms.BindingSource bsPareceres;
        private System.Windows.Forms.DateTimePicker dataParecer;
        private System.Windows.Forms.ComboBox cbxProjeto;
        private System.Windows.Forms.ComboBox cbxFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bsProjeto;
        private System.Windows.Forms.BindingSource bsFuncionario;
        private System.Windows.Forms.ListBox listboxPareceres;
    }
}