
namespace Projecto_de_DA
{
    partial class Promotores
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbxNomePromotor = new System.Windows.Forms.TextBox();
            this.tbxCodigoAcessoPromotor = new System.Windows.Forms.TextBox();
            this.tbxTelemovelPromotor = new System.Windows.Forms.TextBox();
            this.tbxEmailPromotor = new System.Windows.Forms.TextBox();
            this.tbxMoradaPromotor = new System.Windows.Forms.TextBox();
            this.tbxNIFPromotor = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.bsPromotores = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.tbxSenhaPromotor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsPromotores)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.bsPromotores;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 407);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tbxNomePromotor
            // 
            this.tbxNomePromotor.Location = new System.Drawing.Point(366, 111);
            this.tbxNomePromotor.Name = "tbxNomePromotor";
            this.tbxNomePromotor.Size = new System.Drawing.Size(496, 20);
            this.tbxNomePromotor.TabIndex = 2;
            this.tbxNomePromotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxCodigoAcessoPromotor
            // 
            this.tbxCodigoAcessoPromotor.Location = new System.Drawing.Point(408, 241);
            this.tbxCodigoAcessoPromotor.Name = "tbxCodigoAcessoPromotor";
            this.tbxCodigoAcessoPromotor.Size = new System.Drawing.Size(454, 20);
            this.tbxCodigoAcessoPromotor.TabIndex = 3;
            this.tbxCodigoAcessoPromotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxCodigoAcessoPromotor.UseSystemPasswordChar = true;
            // 
            // tbxTelemovelPromotor
            // 
            this.tbxTelemovelPromotor.Location = new System.Drawing.Point(366, 215);
            this.tbxTelemovelPromotor.Name = "tbxTelemovelPromotor";
            this.tbxTelemovelPromotor.Size = new System.Drawing.Size(496, 20);
            this.tbxTelemovelPromotor.TabIndex = 4;
            this.tbxTelemovelPromotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxEmailPromotor
            // 
            this.tbxEmailPromotor.Location = new System.Drawing.Point(366, 189);
            this.tbxEmailPromotor.Name = "tbxEmailPromotor";
            this.tbxEmailPromotor.Size = new System.Drawing.Size(496, 20);
            this.tbxEmailPromotor.TabIndex = 5;
            this.tbxEmailPromotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxMoradaPromotor
            // 
            this.tbxMoradaPromotor.Location = new System.Drawing.Point(366, 163);
            this.tbxMoradaPromotor.Name = "tbxMoradaPromotor";
            this.tbxMoradaPromotor.Size = new System.Drawing.Size(496, 20);
            this.tbxMoradaPromotor.TabIndex = 6;
            this.tbxMoradaPromotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNIFPromotor
            // 
            this.tbxNIFPromotor.Location = new System.Drawing.Point(366, 137);
            this.tbxNIFPromotor.Name = "tbxNIFPromotor";
            this.tbxNIFPromotor.Size = new System.Drawing.Size(496, 20);
            this.tbxNIFPromotor.TabIndex = 7;
            this.tbxNIFPromotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(734, 364);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(115, 60);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(860, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(29, 23);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Telemovel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Codigo de Acesso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "NIF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Morada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Promotores";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(494, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Detalhes do Promotor";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(601, 364);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 60);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(469, 364);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(115, 60);
            this.btnAtualizar.TabIndex = 19;
            this.btnAtualizar.Text = "Atualizar Dados";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.BackgroundImage = global::Projecto_de_DA.Properties.Resources.unlock;
            this.btnDesbloquear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDesbloquear.FlatAppearance.BorderSize = 0;
            this.btnDesbloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesbloquear.Location = new System.Drawing.Point(300, 381);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(50, 50);
            this.btnDesbloquear.TabIndex = 20;
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Senha";
            // 
            // tbxSenhaPromotor
            // 
            this.tbxSenhaPromotor.Location = new System.Drawing.Point(366, 267);
            this.tbxSenhaPromotor.Name = "tbxSenhaPromotor";
            this.tbxSenhaPromotor.Size = new System.Drawing.Size(496, 20);
            this.tbxSenhaPromotor.TabIndex = 21;
            this.tbxSenhaPromotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxSenhaPromotor.UseSystemPasswordChar = true;
            // 
            // Promotores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 453);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxSenhaPromotor);
            this.Controls.Add(this.btnDesbloquear);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tbxNIFPromotor);
            this.Controls.Add(this.tbxMoradaPromotor);
            this.Controls.Add(this.tbxEmailPromotor);
            this.Controls.Add(this.tbxTelemovelPromotor);
            this.Controls.Add(this.tbxCodigoAcessoPromotor);
            this.Controls.Add(this.tbxNomePromotor);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Promotores";
            this.Text = "Promotores";
            ((System.ComponentModel.ISupportInitialize)(this.bsPromotores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbxNomePromotor;
        private System.Windows.Forms.TextBox tbxCodigoAcessoPromotor;
        private System.Windows.Forms.TextBox tbxTelemovelPromotor;
        private System.Windows.Forms.TextBox tbxEmailPromotor;
        private System.Windows.Forms.TextBox tbxMoradaPromotor;
        private System.Windows.Forms.TextBox tbxNIFPromotor;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.BindingSource bsPromotores;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxSenhaPromotor;
    }
}