namespace Canta_Brasil_PROJ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Pesquisa = new System.Windows.Forms.TextBox();
            this.tsbNovo = new System.Windows.Forms.Button();
            this.tsbSalvar = new System.Windows.Forms.Button();
            this.tsbCancelar = new System.Windows.Forms.Button();
            this.tsbExcluir = new System.Windows.Forms.Button();
            this.tsbBuscar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.mskEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tstId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscaCep = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(592, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pesquisa
            // 
            this.Pesquisa.Location = new System.Drawing.Point(824, 12);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(213, 27);
            this.Pesquisa.TabIndex = 1;
            this.Pesquisa.TabStop = false;
            // 
            // tsbNovo
            // 
            this.tsbNovo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tsbNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovo.Image")));
            this.tsbNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbNovo.Location = new System.Drawing.Point(12, 12);
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(75, 50);
            this.tsbNovo.TabIndex = 3;
            this.tsbNovo.TabStop = false;
            this.tsbNovo.Text = "Novo";
            this.tsbNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.tsbNovo, "Criar novo cadastro");
            this.tsbNovo.UseVisualStyleBackColor = false;
            this.tsbNovo.Click += new System.EventHandler(this.tsbNovo_Click);
            this.tsbNovo.MouseHover += new System.EventHandler(this.tsbNovo_MouseHover);
            // 
            // tsbSalvar
            // 
            this.tsbSalvar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tsbSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalvar.Image")));
            this.tsbSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbSalvar.Location = new System.Drawing.Point(93, 12);
            this.tsbSalvar.Name = "tsbSalvar";
            this.tsbSalvar.Size = new System.Drawing.Size(75, 50);
            this.tsbSalvar.TabIndex = 3;
            this.tsbSalvar.TabStop = false;
            this.tsbSalvar.Text = "Salvar";
            this.tsbSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.tsbSalvar, "Salvar");
            this.tsbSalvar.UseVisualStyleBackColor = false;
            this.tsbSalvar.Click += new System.EventHandler(this.tsbSalvar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tsbCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbCancelar.Location = new System.Drawing.Point(174, 12);
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(75, 50);
            this.tsbCancelar.TabIndex = 3;
            this.tsbCancelar.TabStop = false;
            this.tsbCancelar.Text = "Limpar";
            this.tsbCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.tsbCancelar, "Limpar tudo");
            this.tsbCancelar.UseVisualStyleBackColor = false;
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tsbExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluir.Image")));
            this.tsbExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbExcluir.Location = new System.Drawing.Point(255, 12);
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(75, 50);
            this.tsbExcluir.TabIndex = 3;
            this.tsbExcluir.TabStop = false;
            this.tsbExcluir.Text = "Apagar";
            this.tsbExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.tsbExcluir, "Excluir aluno");
            this.tsbExcluir.UseVisualStyleBackColor = false;
            this.tsbExcluir.Click += new System.EventHandler(this.tsbExcluir_Click);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tsbBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.BackgroundImage")));
            this.tsbBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbBuscar.Location = new System.Drawing.Point(1042, 11);
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(29, 29);
            this.tsbBuscar.TabIndex = 3;
            this.tsbBuscar.TabStop = false;
            this.toolTip1.SetToolTip(this.tsbBuscar, "Buscar");
            this.tsbBuscar.UseVisualStyleBackColor = false;
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(134, 90);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(399, 27);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(58, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "CEP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(58, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefone 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(58, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefone 2:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(347, 33);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(467, 27);
            this.txtEndereco.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(244, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Endereço:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(890, 33);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(120, 27);
            this.txtNumero.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(844, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nº:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(132, 215);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(190, 27);
            this.txtBairro.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(58, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Bairro:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(410, 215);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(165, 27);
            this.txtCidade.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(327, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cidade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(581, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "UF:";
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(627, 215);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(122, 27);
            this.txtUf.TabIndex = 7;
            // 
            // mskEmail
            // 
            this.mskEmail.Location = new System.Drawing.Point(432, 283);
            this.mskEmail.MaxLength = 40;
            this.mskEmail.Name = "mskEmail";
            this.mskEmail.PlaceholderText = "exemplo@gmail.com";
            this.mskEmail.Size = new System.Drawing.Size(376, 27);
            this.mskEmail.TabIndex = 11;
            this.mskEmail.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(355, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 26);
            this.label11.TabIndex = 0;
            this.label11.Text = "E-mail:";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "nome",
            "cep",
            "tel1",
            "tel2",
            "email"});
            this.comboBox1.Location = new System.Drawing.Point(706, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.TabStop = false;
            this.comboBox1.Text = "...";
            // 
            // tstId
            // 
            this.tstId.Location = new System.Drawing.Point(952, 89);
            this.tstId.Name = "tstId";
            this.tstId.Size = new System.Drawing.Size(70, 27);
            this.tstId.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(911, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 26);
            this.label12.TabIndex = 0;
            this.label12.Text = "ID:";
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(113, 169);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(80, 27);
            this.mskCep.TabIndex = 2;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(170, 282);
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(160, 27);
            this.mskTelefone.TabIndex = 9;
            // 
            // mskTelefone2
            // 
            this.mskTelefone2.Location = new System.Drawing.Point(170, 325);
            this.mskTelefone2.Name = "mskTelefone2";
            this.mskTelefone2.Size = new System.Drawing.Size(160, 27);
            this.mskTelefone2.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(743, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 26);
            this.label13.TabIndex = 0;
            this.label13.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(890, 80);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(120, 27);
            this.txtComplemento.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscaCep);
            this.groupBox1.Controls.Add(this.txtComplemento);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1057, 127);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // btnBuscaCep
            // 
            this.btnBuscaCep.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnBuscaCep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaCep.BackgroundImage")));
            this.btnBuscaCep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaCep.Location = new System.Drawing.Point(187, 32);
            this.btnBuscaCep.Name = "btnBuscaCep";
            this.btnBuscaCep.Size = new System.Drawing.Size(29, 29);
            this.btnBuscaCep.TabIndex = 3;
            this.btnBuscaCep.TabStop = false;
            this.btnBuscaCep.UseVisualStyleBackColor = false;
            this.btnBuscaCep.Click += new System.EventHandler(this.btnBuscaCep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1079, 398);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tstId);
            this.Controls.Add(this.mskTelefone2);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mskEmail);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.tsbBuscar);
            this.Controls.Add(this.tsbExcluir);
            this.Controls.Add(this.tsbCancelar);
            this.Controls.Add(this.tsbSalvar);
            this.Controls.Add(this.tsbNovo);
            this.Controls.Add(this.Pesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cadastrar Aluno";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pesquisa;
        private System.Windows.Forms.Button tsbNovo;
        private System.Windows.Forms.Button tsbSalvar;
        private System.Windows.Forms.Button tsbCancelar;
        private System.Windows.Forms.Button tsbExcluir;
        private System.Windows.Forms.Button tsbBuscar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox mskEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tstId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.MaskedTextBox mskTelefone2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscaCep;
    }
}

