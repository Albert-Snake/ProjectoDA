
namespace Projecto_de_DA
{
    partial class formTipoDocumento
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
            this.tbxDescricaoDocumento = new System.Windows.Forms.TextBox();
            this.listboxTipoDocumneto = new System.Windows.Forms.ListBox();
            this.bsTipoDocumento = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoDocumento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.BackgroundImage = global::Projecto_de_DA.Properties.Resources.unlock;
            this.btnDesbloquear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDesbloquear.FlatAppearance.BorderSize = 0;
            this.btnDesbloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesbloquear.Location = new System.Drawing.Point(361, 235);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(50, 50);
            this.btnDesbloquear.TabIndex = 56;
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Location = new System.Drawing.Point(481, 225);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(115, 60);
            this.btnAtualizar.TabIndex = 55;
            this.btnAtualizar.Text = "Atualizar Dados";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(613, 225);
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
            this.label8.Size = new System.Drawing.Size(228, 24);
            this.label8.TabIndex = 53;
            this.label8.Text = "Novo Tipo de Documento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 24);
            this.label7.TabIndex = 52;
            this.label7.Text = "Tipos de Documentos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Designação";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(861, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(29, 23);
            this.btnFechar.TabIndex = 48;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(746, 225);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(115, 60);
            this.btnAdicionar.TabIndex = 47;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // tbxDescricaoDocumento
            // 
            this.tbxDescricaoDocumento.Location = new System.Drawing.Point(374, 116);
            this.tbxDescricaoDocumento.Name = "tbxDescricaoDocumento";
            this.tbxDescricaoDocumento.Size = new System.Drawing.Size(483, 20);
            this.tbxDescricaoDocumento.TabIndex = 44;
            this.tbxDescricaoDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listboxTipoDocumneto
            // 
            this.listboxTipoDocumneto.DataSource = this.bsTipoDocumento;
            this.listboxTipoDocumneto.FormattingEnabled = true;
            this.listboxTipoDocumneto.Location = new System.Drawing.Point(16, 34);
            this.listboxTipoDocumneto.Name = "listboxTipoDocumneto";
            this.listboxTipoDocumneto.Size = new System.Drawing.Size(265, 407);
            this.listboxTipoDocumneto.TabIndex = 43;
            this.listboxTipoDocumneto.SelectedIndexChanged += new System.EventHandler(this.listboxTipoDocumneto_SelectedIndexChanged);
            // 
            // formTipoDocumento
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
            this.Controls.Add(this.tbxDescricaoDocumento);
            this.Controls.Add(this.listboxTipoDocumneto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formTipoDocumento";
            this.Text = "formTipoDocumento";
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoDocumento)).EndInit();
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
        private System.Windows.Forms.TextBox tbxDescricaoDocumento;
        private System.Windows.Forms.ListBox listboxTipoDocumneto;
        private System.Windows.Forms.BindingSource bsTipoDocumento;
    }
}