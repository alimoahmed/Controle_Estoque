namespace Controle_estoque
{
    partial class Listagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listagem));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtsetor = new System.Windows.Forms.TextBox();
            this.txtqtdmax = new System.Windows.Forms.TextBox();
            this.txtqtdmin = new System.Windows.Forms.TextBox();
            this.txtqtdatual = new System.Windows.Forms.TextBox();
            this.txtemailfor = new System.Windows.Forms.TextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.ProdutosDataGridView = new System.Windows.Forms.DataGridView();
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtemailcom = new System.Windows.Forms.TextBox();
            this.txtvalidade = new System.Windows.Forms.MaskedTextBox();
            this.btncomprimir = new System.Windows.Forms.Button();
            this.btnetiqueta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Controle_estoque.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(10, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(9, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 56;
            this.label3.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(9, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 58;
            this.label5.Text = "Validade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(607, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 18);
            this.label6.TabIndex = 63;
            this.label6.Text = "Email Fornecedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(992, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 62;
            this.label7.Text = "Qtd Atual";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(800, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 61;
            this.label8.Text = "Qtd Max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(607, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 18);
            this.label9.TabIndex = 60;
            this.label9.Text = "Qtd Min";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(286, 429);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 18);
            this.label10.TabIndex = 59;
            this.label10.Text = "Setor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(607, 429);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 18);
            this.label11.TabIndex = 64;
            this.label11.Text = "Email Comprador";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(12, 346);
            this.txtnome.MaxLength = 40;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(562, 26);
            this.txtnome.TabIndex = 65;
            this.txtnome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnome_KeyPress);
            // 
            // txtdescricao
            // 
            this.txtdescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.Location = new System.Drawing.Point(12, 399);
            this.txtdescricao.MaxLength = 40;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(562, 26);
            this.txtdescricao.TabIndex = 66;
            // 
            // txtsetor
            // 
            this.txtsetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsetor.Location = new System.Drawing.Point(289, 449);
            this.txtsetor.MaxLength = 40;
            this.txtsetor.Name = "txtsetor";
            this.txtsetor.Size = new System.Drawing.Size(285, 26);
            this.txtsetor.TabIndex = 69;
            // 
            // txtqtdmax
            // 
            this.txtqtdmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtdmax.Location = new System.Drawing.Point(803, 346);
            this.txtqtdmax.MaxLength = 40;
            this.txtqtdmax.Name = "txtqtdmax";
            this.txtqtdmax.Size = new System.Drawing.Size(186, 26);
            this.txtqtdmax.TabIndex = 71;
            this.txtqtdmax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqtdmax_KeyPress);
            // 
            // txtqtdmin
            // 
            this.txtqtdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtdmin.Location = new System.Drawing.Point(610, 346);
            this.txtqtdmin.MaxLength = 40;
            this.txtqtdmin.Name = "txtqtdmin";
            this.txtqtdmin.Size = new System.Drawing.Size(186, 26);
            this.txtqtdmin.TabIndex = 72;
            this.txtqtdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqtdmin_KeyPress);
            // 
            // txtqtdatual
            // 
            this.txtqtdatual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtdatual.Location = new System.Drawing.Point(995, 346);
            this.txtqtdatual.MaxLength = 40;
            this.txtqtdatual.Name = "txtqtdatual";
            this.txtqtdatual.Size = new System.Drawing.Size(177, 26);
            this.txtqtdatual.TabIndex = 73;
            this.txtqtdatual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqtdatual_KeyPress);
            // 
            // txtemailfor
            // 
            this.txtemailfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailfor.Location = new System.Drawing.Point(610, 400);
            this.txtemailfor.MaxLength = 40;
            this.txtemailfor.Name = "txtemailfor";
            this.txtemailfor.Size = new System.Drawing.Size(562, 26);
            this.txtemailfor.TabIndex = 74;
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.btncadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.btncadastrar.ForeColor = System.Drawing.Color.White;
            this.btncadastrar.Location = new System.Drawing.Point(577, 12);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(96, 33);
            this.btncadastrar.TabIndex = 77;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.btnexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnexcluir.ForeColor = System.Drawing.Color.White;
            this.btnexcluir.Location = new System.Drawing.Point(780, 12);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(96, 33);
            this.btnexcluir.TabIndex = 78;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.Location = new System.Drawing.Point(679, 12);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(96, 33);
            this.btnedit.TabIndex = 79;
            this.btnedit.Text = "Editar";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnreset.ForeColor = System.Drawing.Color.White;
            this.btnreset.Location = new System.Drawing.Point(882, 12);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(96, 33);
            this.btnreset.TabIndex = 80;
            this.btnreset.Text = "Limpar";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // ProdutosDataGridView
            // 
            this.ProdutosDataGridView.AllowUserToAddRows = false;
            this.ProdutosDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProdutosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProdutosDataGridView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.ProdutosDataGridView.Location = new System.Drawing.Point(12, 51);
            this.ProdutosDataGridView.Name = "ProdutosDataGridView";
            this.ProdutosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdutosDataGridView.Size = new System.Drawing.Size(1160, 267);
            this.ProdutosDataGridView.TabIndex = 81;
            this.ProdutosDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdutosDataGridView_CellClick);
            // 
            // produtoBindingSource1
            // 
            this.produtoBindingSource1.DataMember = "produto";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            // 
            // txtemailcom
            // 
            this.txtemailcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailcom.Location = new System.Drawing.Point(610, 449);
            this.txtemailcom.MaxLength = 40;
            this.txtemailcom.Name = "txtemailcom";
            this.txtemailcom.Size = new System.Drawing.Size(563, 26);
            this.txtemailcom.TabIndex = 75;
            // 
            // txtvalidade
            // 
            this.txtvalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtvalidade.Location = new System.Drawing.Point(12, 449);
            this.txtvalidade.Mask = "  00/00/0000";
            this.txtvalidade.Name = "txtvalidade";
            this.txtvalidade.Size = new System.Drawing.Size(269, 26);
            this.txtvalidade.TabIndex = 82;
            this.txtvalidade.ValidatingType = typeof(System.DateTime);
            this.txtvalidade.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtvalidade_MaskInputRejected);
            this.txtvalidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalidade_KeyPress);
            // 
            // btncomprimir
            // 
            this.btncomprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(79)))));
            this.btncomprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncomprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.btncomprimir.ForeColor = System.Drawing.Color.White;
            this.btncomprimir.Location = new System.Drawing.Point(1086, 12);
            this.btncomprimir.Name = "btncomprimir";
            this.btncomprimir.Size = new System.Drawing.Size(86, 33);
            this.btncomprimir.TabIndex = 83;
            this.btncomprimir.Text = "Excel";
            this.btncomprimir.UseVisualStyleBackColor = false;
            this.btncomprimir.Click += new System.EventHandler(this.btncomprimir_Click);
            // 
            // btnetiqueta
            // 
            this.btnetiqueta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.btnetiqueta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnetiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnetiqueta.ForeColor = System.Drawing.Color.White;
            this.btnetiqueta.Location = new System.Drawing.Point(984, 12);
            this.btnetiqueta.Name = "btnetiqueta";
            this.btnetiqueta.Size = new System.Drawing.Size(96, 33);
            this.btnetiqueta.TabIndex = 84;
            this.btnetiqueta.Text = "Etiqueta";
            this.btnetiqueta.UseVisualStyleBackColor = false;
            this.btnetiqueta.Click += new System.EventHandler(this.btnetiqueta_Click);
            // 
            // Listagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1187, 495);
            this.Controls.Add(this.btnetiqueta);
            this.Controls.Add(this.btncomprimir);
            this.Controls.Add(this.txtvalidade);
            this.Controls.Add(this.ProdutosDataGridView);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtemailcom);
            this.Controls.Add(this.txtemailfor);
            this.Controls.Add(this.txtqtdatual);
            this.Controls.Add(this.txtqtdmin);
            this.Controls.Add(this.txtqtdmax);
            this.Controls.Add(this.txtsetor);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Listagem";
            this.Text = "Listagem de produto";
            this.Load += new System.EventHandler(this.Listagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtsetor;
        private System.Windows.Forms.TextBox txtqtdmax;
        private System.Windows.Forms.TextBox txtqtdmin;
        private System.Windows.Forms.TextBox txtqtdatual;
        private System.Windows.Forms.TextBox txtemailfor;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.DataGridView ProdutosDataGridView;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdmaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdatualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailforDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailcomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtemailcom;
        private System.Windows.Forms.BindingSource produtoBindingSource1;
        private System.Windows.Forms.MaskedTextBox txtvalidade;
        private System.Windows.Forms.Button btncomprimir;
        private System.Windows.Forms.Button btnetiqueta;
    }
}

