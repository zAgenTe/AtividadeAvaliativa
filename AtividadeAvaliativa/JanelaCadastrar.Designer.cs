namespace AtividadeAvaliativa
{
    partial class JanelaCadastrar
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
            this.grpProduto = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lstPesquisa = new System.Windows.Forms.ListBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lstItens = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.nudQuant = new System.Windows.Forms.NumericUpDown();
            this.btnAcrescentar = new System.Windows.Forms.Button();
            this.grpProduto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // grpProduto
            // 
            this.grpProduto.Controls.Add(this.txtNome);
            this.grpProduto.Controls.Add(this.txtCodigo);
            this.grpProduto.Controls.Add(this.lstPesquisa);
            this.grpProduto.Controls.Add(this.lblNome);
            this.grpProduto.Controls.Add(this.lblCodigo);
            this.grpProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProduto.Location = new System.Drawing.Point(12, 6);
            this.grpProduto.Name = "grpProduto";
            this.grpProduto.Size = new System.Drawing.Size(207, 242);
            this.grpProduto.TabIndex = 0;
            this.grpProduto.TabStop = false;
            this.grpProduto.Text = "Produto";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(78, 69);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(109, 22);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(78, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(109, 22);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyUp);
            // 
            // lstPesquisa
            // 
            this.lstPesquisa.FormattingEnabled = true;
            this.lstPesquisa.ItemHeight = 16;
            this.lstPesquisa.Location = new System.Drawing.Point(19, 115);
            this.lstPesquisa.Name = "lstPesquisa";
            this.lstPesquisa.Size = new System.Drawing.Size(168, 100);
            this.lstPesquisa.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 72);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome: ";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 34);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.lstItens);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(225, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 337);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(270, 283);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 40);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(153, 283);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(111, 40);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lstItens
            // 
            this.lstItens.FormattingEnabled = true;
            this.lstItens.ItemHeight = 16;
            this.lstItens.Location = new System.Drawing.Point(10, 31);
            this.lstItens.Name = "lstItens";
            this.lstItens.Size = new System.Drawing.Size(371, 212);
            this.lstItens.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotal.Location = new System.Drawing.Point(6, 289);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(128, 40);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "R$ ---";
            this.lblTotal.TextChanged += new System.EventHandler(this.lblTotal_TextChanged);
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(24, 271);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(84, 16);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade: ";
            // 
            // nudQuant
            // 
            this.nudQuant.Location = new System.Drawing.Point(113, 271);
            this.nudQuant.Name = "nudQuant";
            this.nudQuant.Size = new System.Drawing.Size(86, 20);
            this.nudQuant.TabIndex = 3;
            this.nudQuant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAcrescentar
            // 
            this.btnAcrescentar.Enabled = false;
            this.btnAcrescentar.Location = new System.Drawing.Point(113, 312);
            this.btnAcrescentar.Name = "btnAcrescentar";
            this.btnAcrescentar.Size = new System.Drawing.Size(86, 23);
            this.btnAcrescentar.TabIndex = 4;
            this.btnAcrescentar.Text = "Acrescentar";
            this.btnAcrescentar.UseVisualStyleBackColor = true;
            this.btnAcrescentar.Click += new System.EventHandler(this.btnAcrescentar_Click);
            // 
            // JanelaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(698, 347);
            this.Controls.Add(this.btnAcrescentar);
            this.Controls.Add(this.nudQuant);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpProduto);
            this.MaximizeBox = false;
            this.Name = "JanelaCadastrar";
            this.Text = "Cadastro de Item";
            this.grpProduto.ResumeLayout(false);
            this.grpProduto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProduto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ListBox lstPesquisa;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.NumericUpDown nudQuant;
        private System.Windows.Forms.Button btnAcrescentar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ListBox lstItens;
    }
}