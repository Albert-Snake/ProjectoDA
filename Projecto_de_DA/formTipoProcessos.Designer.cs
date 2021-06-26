
namespace Projecto_de_DA
{
    partial class formTipoProcessos
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.tbxDescricaoProcesso = new System.Windows.Forms.TextBox();
            this.listboxEstadosProcessos = new System.Windows.Forms.ListBox();
            this.bsTipoProcesso = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoProcesso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.BackgroundImage = global::Projecto_de_DA.Properties.Resources.unlock;
            this.btnDesbloquear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDesbloquear.FlatAppearance.BorderSize = 0;
            this.btnDesbloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesbloquear.Location = new System.Drawing.Point(355, 241);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(50, 50);
            this.btnDesbloquear.TabIndex = 76;
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(475, 231);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(115, 60);
            this.btnAtualizar.TabIndex = 75;
            this.btnAtualizar.Text = "Atualizar Dados";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(607, 231);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 60);
            this.btnEliminar.TabIndex = 74;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(483, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 24);
            this.label8.TabIndex = 73;
            this.label8.Text = "Novo Tipo de Processo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 24);
            this.label7.TabIndex = 72;
            this.label7.Text = "Tipos de Processos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Designação";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(855, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(29, 23);
            this.btnFechar.TabIndex = 70;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(740, 231);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(115, 60);
            this.btnAdicionar.TabIndex = 69;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // tbxDescricaoProcesso
            // 
            this.tbxDescricaoProcesso.Location = new System.Drawing.Point(368, 122);
            this.tbxDescricaoProcesso.Name = "tbxDescricaoProcesso";
            this.tbxDescricaoProcesso.Size = new System.Drawing.Size(483, 20);
            this.tbxDescricaoProcesso.TabIndex = 68;
            this.tbxDescricaoProcesso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listboxEstadosProcessos
            // 
            this.listboxEstadosProcessos.DataSource = this.bsTipoProcesso;
            this.listboxEstadosProcessos.FormattingEnabled = true;
            this.listboxEstadosProcessos.Location = new System.Drawing.Point(10, 36);
            this.listboxEstadosProcessos.Name = "listboxEstadosProcessos";
            this.listboxEstadosProcessos.Size = new System.Drawing.Size(265, 407);
            this.listboxEstadosProcessos.TabIndex = 67;
            this.listboxEstadosProcessos.SelectedIndexChanged += new System.EventHandler(this.listboxTipoDocumneto_SelectedIndexChanged);
            // 
            // formTipoProcessos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 453);
            this.Controls.Add(this.btnDesbloquear);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tbxDescricaoProcesso);
            this.Controls.Add(this.listboxEstadosProcessos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formTipoProcessos";
            this.Text = "formTipoProcessos";
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoProcesso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox tbxDescricaoProcesso;
        private System.Windows.Forms.ListBox listboxEstadosProcessos;
        private System.Windows.Forms.BindingSource bsTipoProcesso;
    }
}