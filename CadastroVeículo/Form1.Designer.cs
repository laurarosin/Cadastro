namespace CadastroVeículo
{
    partial class Form
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCódigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtChassi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkSim = new System.Windows.Forms.CheckBox();
            this.chkNão = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.chkSinistro = new System.Windows.Forms.CheckBox();
            this.chkFurto = new System.Windows.Forms.CheckBox();
            this.chkAluguel = new System.Windows.Forms.CheckBox();
            this.chkVenda = new System.Windows.Forms.CheckBox();
            this.chkParticular = new System.Windows.Forms.CheckBox();
            this.dgvVeiculo = new System.Windows.Forms.DataGridView();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Veículo:";
            // 
            // txtCódigo
            // 
            this.txtCódigo.Location = new System.Drawing.Point(112, 54);
            this.txtCódigo.Multiline = true;
            this.txtCódigo.Name = "txtCódigo";
            this.txtCódigo.Size = new System.Drawing.Size(115, 34);
            this.txtCódigo.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ano de Fabricação:";
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "";
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(38, 164);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(93, 26);
            this.dtpData.TabIndex = 11;
            this.dtpData.Value = new System.DateTime(2023, 2, 13, 9, 0, 50, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(332, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cor:";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(280, 156);
            this.txtCor.Multiline = true;
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(145, 34);
            this.txtCor.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(569, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Numero do Chassi:";
            // 
            // txtChassi
            // 
            this.txtChassi.Location = new System.Drawing.Point(594, 164);
            this.txtChassi.Multiline = true;
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.Size = new System.Drawing.Size(92, 34);
            this.txtChassi.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(285, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Kilometragem:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 276);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 34);
            this.textBox1.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Revisão:";
            // 
            // chkSim
            // 
            this.chkSim.AutoSize = true;
            this.chkSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSim.Location = new System.Drawing.Point(21, 376);
            this.chkSim.Name = "chkSim";
            this.chkSim.Size = new System.Drawing.Size(53, 22);
            this.chkSim.TabIndex = 21;
            this.chkSim.Text = "Sim";
            this.chkSim.UseVisualStyleBackColor = true;
            // 
            // chkNão
            // 
            this.chkNão.AutoSize = true;
            this.chkNão.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNão.Location = new System.Drawing.Point(76, 376);
            this.chkNão.Name = "chkNão";
            this.chkNão.Size = new System.Drawing.Size(55, 22);
            this.chkNão.TabIndex = 22;
            this.chkNão.Text = "Não";
            this.chkNão.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(487, 344);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Roubo_Furto:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(276, 344);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Sinistro:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 451);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "Aluguel:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(263, 451);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "Venda:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(469, 451);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 20);
            this.label16.TabIndex = 27;
            this.label16.Text = "Particular:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(285, 516);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 20);
            this.label17.TabIndex = 28;
            this.label17.Text = "Observações:";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(112, 539);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(452, 34);
            this.txtObs.TabIndex = 29;
            // 
            // chkSinistro
            // 
            this.chkSinistro.AutoSize = true;
            this.chkSinistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSinistro.Location = new System.Drawing.Point(303, 377);
            this.chkSinistro.Name = "chkSinistro";
            this.chkSinistro.Size = new System.Drawing.Size(15, 14);
            this.chkSinistro.TabIndex = 32;
            this.chkSinistro.UseVisualStyleBackColor = true;
            // 
            // chkFurto
            // 
            this.chkFurto.AutoSize = true;
            this.chkFurto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFurto.Location = new System.Drawing.Point(533, 377);
            this.chkFurto.Name = "chkFurto";
            this.chkFurto.Size = new System.Drawing.Size(15, 14);
            this.chkFurto.TabIndex = 34;
            this.chkFurto.UseVisualStyleBackColor = true;
            // 
            // chkAluguel
            // 
            this.chkAluguel.AutoSize = true;
            this.chkAluguel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAluguel.Location = new System.Drawing.Point(40, 486);
            this.chkAluguel.Name = "chkAluguel";
            this.chkAluguel.Size = new System.Drawing.Size(15, 14);
            this.chkAluguel.TabIndex = 35;
            this.chkAluguel.UseVisualStyleBackColor = true;
            // 
            // chkVenda
            // 
            this.chkVenda.AutoSize = true;
            this.chkVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVenda.Location = new System.Drawing.Point(299, 486);
            this.chkVenda.Name = "chkVenda";
            this.chkVenda.Size = new System.Drawing.Size(15, 14);
            this.chkVenda.TabIndex = 37;
            this.chkVenda.UseVisualStyleBackColor = true;
            // 
            // chkParticular
            // 
            this.chkParticular.AutoSize = true;
            this.chkParticular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkParticular.Location = new System.Drawing.Point(515, 496);
            this.chkParticular.Name = "chkParticular";
            this.chkParticular.Size = new System.Drawing.Size(15, 14);
            this.chkParticular.TabIndex = 38;
            this.chkParticular.UseVisualStyleBackColor = true;
            // 
            // dgvVeiculo
            // 
            this.dgvVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculo.Location = new System.Drawing.Point(92, 620);
            this.dgvVeiculo.Name = "dgvVeiculo";
            this.dgvVeiculo.Size = new System.Drawing.Size(542, 150);
            this.dgvVeiculo.TabIndex = 40;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(362, 54);
            this.txtModelo.Multiline = true;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(165, 29);
            this.txtModelo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo:";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(688, 653);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(95, 37);
            this.btnIncluir.TabIndex = 41;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 800);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dgvVeiculo);
            this.Controls.Add(this.chkParticular);
            this.Controls.Add(this.chkVenda);
            this.Controls.Add(this.chkAluguel);
            this.Controls.Add(this.chkFurto);
            this.Controls.Add(this.chkSinistro);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.chkNão);
            this.Controls.Add(this.chkSim);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtChassi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCódigo);
            this.Controls.Add(this.label1);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCódigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtChassi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkSim;
        private System.Windows.Forms.CheckBox chkNão;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.CheckBox chkSinistro;
        private System.Windows.Forms.CheckBox chkFurto;
        private System.Windows.Forms.CheckBox chkAluguel;
        private System.Windows.Forms.CheckBox chkVenda;
        private System.Windows.Forms.CheckBox chkParticular;
        private System.Windows.Forms.DataGridView dgvVeiculo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIncluir;
    }
}

