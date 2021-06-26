
namespace Projecto_de_DA
{
    partial class formProcessos
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
            this.bsProjetos = new System.Windows.Forms.BindingSource(this.components);
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.dataInicio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxEstadoProcesso = new System.Windows.Forms.ComboBox();
            this.bsEstadoProcesso = new System.Windows.Forms.BindingSource(this.components);
            this.cbxPromotor = new System.Windows.Forms.ComboBox();
            this.bsPromotor = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.listboxProcessos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjetos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadoProcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPromotor)).BeginInit();
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
            // dataInicio
            // 
            this.dataInicio.Location = new System.Drawing.Point(171, 51);
            this.dataInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dataInicio.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.Size = new System.Drawing.Size(185, 20);
            this.dataInicio.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(542, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 56;
            this.label7.Text = "Processos";
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
            this.label6.Location = new System.Drawing.Point(15, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Data de inicio do processo";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(420, 319);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(165, 60);
            this.btnAtualizar.TabIndex = 58;
            this.btnAtualizar.Text = "Atualizar Dados";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(613, 319);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(169, 60);
            this.btnEliminar.TabIndex = 57;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Estado do Processo";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(862, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(29, 23);
            this.btnFechar.TabIndex = 60;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxEstadoProcesso);
            this.groupBox1.Controls.Add(this.cbxPromotor);
            this.groupBox1.Controls.Add(this.buttonGuardar);
            this.groupBox1.Controls.Add(this.btnDesbloquear);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dataInicio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(361, 392);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo processo";
            // 
            // cbxEstadoProcesso
            // 
            this.cbxEstadoProcesso.DataSource = this.bsEstadoProcesso;
            this.cbxEstadoProcesso.FormattingEnabled = true;
            this.cbxEstadoProcesso.Location = new System.Drawing.Point(171, 137);
            this.cbxEstadoProcesso.Name = "cbxEstadoProcesso";
            this.cbxEstadoProcesso.Size = new System.Drawing.Size(185, 21);
            this.cbxEstadoProcesso.TabIndex = 50;
            // 
            // cbxPromotor
            // 
            this.cbxPromotor.DataSource = this.bsPromotor;
            this.cbxPromotor.FormattingEnabled = true;
            this.cbxPromotor.Location = new System.Drawing.Point(171, 90);
            this.cbxPromotor.Name = "cbxPromotor";
            this.cbxPromotor.Size = new System.Drawing.Size(185, 21);
            this.cbxPromotor.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Promotor";
            // 
            // listboxProcessos
            // 
            this.listboxProcessos.DataSource = this.bsProjetos;
            this.listboxProcessos.FormattingEnabled = true;
            this.listboxProcessos.Location = new System.Drawing.Point(420, 53);
            this.listboxProcessos.Name = "listboxProcessos";
            this.listboxProcessos.Size = new System.Drawing.Size(362, 225);
            this.listboxProcessos.TabIndex = 55;
            this.listboxProcessos.SelectedIndexChanged += new System.EventHandler(this.listboxProcessos_SelectedIndexChanged);
            // 
            // formProcessos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 453);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listboxProcessos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formProcessos";
            this.Text = "formProcessos";
            ((System.ComponentModel.ISupportInitialize)(this.bsProjetos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadoProcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPromotor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsProjetos;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.DateTimePicker dataInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listboxProcessos;
        private System.Windows.Forms.ComboBox cbxEstadoProcesso;
        private System.Windows.Forms.ComboBox cbxPromotor;
        private System.Windows.Forms.BindingSource bsPromotor;
        private System.Windows.Forms.BindingSource bsEstadoProcesso;
    }
}