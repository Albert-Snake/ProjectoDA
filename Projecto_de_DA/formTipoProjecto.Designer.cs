
namespace Projecto_de_DA
{
    partial class formTipoProjecto
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.listBoxTiposProjectos = new System.Windows.Forms.ListBox();
            this.bsTipoProjectos = new System.Windows.Forms.BindingSource(this.components);
            this.numericNumerodeDias = new System.Windows.Forms.NumericUpDown();
            this.tbxDesignacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTipoProjecto = new System.Windows.Forms.ComboBox();
            this.chekboxTipoPorjecto = new System.Windows.Forms.CheckBox();
            this.bsTipoProjectoCBX = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoProjectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumerodeDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoProjectoCBX)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.BackgroundImage = global::Projecto_de_DA.Properties.Resources.unlock;
            this.btnDesbloquear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDesbloquear.FlatAppearance.BorderSize = 0;
            this.btnDesbloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesbloquear.Location = new System.Drawing.Point(332, 374);
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
            this.label8.Size = new System.Drawing.Size(227, 24);
            this.label8.TabIndex = 53;
            this.label8.Text = "Detalhes do Tipo Projecto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 24);
            this.label7.TabIndex = 52;
            this.label7.Text = "Tipos de Projectos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Designação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Nº de Dias para aprovação";
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
            // listBoxTiposProjectos
            // 
            this.listBoxTiposProjectos.DataSource = this.bsTipoProjectos;
            this.listBoxTiposProjectos.FormattingEnabled = true;
            this.listBoxTiposProjectos.Location = new System.Drawing.Point(16, 31);
            this.listBoxTiposProjectos.Name = "listBoxTiposProjectos";
            this.listBoxTiposProjectos.Size = new System.Drawing.Size(265, 407);
            this.listBoxTiposProjectos.TabIndex = 43;
            this.listBoxTiposProjectos.SelectedIndexChanged += new System.EventHandler(this.listBoxTiposProjectos_SelectedIndexChanged);
            // 
            // numericNumerodeDias
            // 
            this.numericNumerodeDias.Location = new System.Drawing.Point(464, 117);
            this.numericNumerodeDias.Name = "numericNumerodeDias";
            this.numericNumerodeDias.Size = new System.Drawing.Size(346, 20);
            this.numericNumerodeDias.TabIndex = 57;
            // 
            // tbxDesignacao
            // 
            this.tbxDesignacao.Location = new System.Drawing.Point(464, 143);
            this.tbxDesignacao.Name = "tbxDesignacao";
            this.tbxDesignacao.Size = new System.Drawing.Size(346, 20);
            this.tbxDesignacao.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Projecto dependente";
            // 
            // cbxTipoProjecto
            // 
            this.cbxTipoProjecto.DataSource = this.bsTipoProjectoCBX;
            this.cbxTipoProjecto.Enabled = false;
            this.cbxTipoProjecto.FormattingEnabled = true;
            this.cbxTipoProjecto.Location = new System.Drawing.Point(485, 169);
            this.cbxTipoProjecto.Name = "cbxTipoProjecto";
            this.cbxTipoProjecto.Size = new System.Drawing.Size(325, 21);
            this.cbxTipoProjecto.TabIndex = 60;
            // 
            // chekboxTipoPorjecto
            // 
            this.chekboxTipoPorjecto.AutoSize = true;
            this.chekboxTipoPorjecto.Location = new System.Drawing.Point(464, 172);
            this.chekboxTipoPorjecto.Name = "chekboxTipoPorjecto";
            this.chekboxTipoPorjecto.Size = new System.Drawing.Size(15, 14);
            this.chekboxTipoPorjecto.TabIndex = 61;
            this.chekboxTipoPorjecto.UseVisualStyleBackColor = true;
            this.chekboxTipoPorjecto.CheckedChanged += new System.EventHandler(this.chekboxTipoPorjecto_CheckedChanged);
            // 
            // formTipoProjecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 453);
            this.Controls.Add(this.chekboxTipoPorjecto);
            this.Controls.Add(this.cbxTipoProjecto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDesignacao);
            this.Controls.Add(this.numericNumerodeDias);
            this.Controls.Add(this.btnDesbloquear);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.listBoxTiposProjectos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formTipoProjecto";
            this.Text = "formTipoProjecto";
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoProjectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumerodeDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoProjectoCBX)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox listBoxTiposProjectos;
        private System.Windows.Forms.BindingSource bsTipoProjectos;
        private System.Windows.Forms.NumericUpDown numericNumerodeDias;
        private System.Windows.Forms.TextBox tbxDesignacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipoProjecto;
        private System.Windows.Forms.CheckBox chekboxTipoPorjecto;
        private System.Windows.Forms.BindingSource bsTipoProjectoCBX;
    }
}