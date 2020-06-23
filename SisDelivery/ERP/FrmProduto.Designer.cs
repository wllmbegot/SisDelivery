    namespace SisDelivery
{
    partial class FrmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.btnProdSalvar = new System.Windows.Forms.Button();
            this.btnProdAlterar = new System.Windows.Forms.Button();
            this.btnProdExcluir = new System.Windows.Forms.Button();
            this.lblProdNome = new System.Windows.Forms.Label();
            this.txtProdNome = new System.Windows.Forms.TextBox();
            this.lblProdPreco = new System.Windows.Forms.Label();
            this.cmbProUni = new System.Windows.Forms.ComboBox();
            this.lblProUni = new System.Windows.Forms.Label();
            this.cmbProCategoria = new System.Windows.Forms.ComboBox();
            this.lblProCategoria = new System.Windows.Forms.Label();
            this.gridViewProdutos = new System.Windows.Forms.DataGridView();
            this.lblProdCodigo = new System.Windows.Forms.Label();
            this.txtProdPreco = new System.Windows.Forms.MaskedTextBox();
            this.txtProdCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProdSalvar
            // 
            this.btnProdSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdSalvar.Location = new System.Drawing.Point(623, 66);
            this.btnProdSalvar.Name = "btnProdSalvar";
            this.btnProdSalvar.Size = new System.Drawing.Size(128, 40);
            this.btnProdSalvar.TabIndex = 1;
            this.btnProdSalvar.Text = "Salvar";
            this.btnProdSalvar.UseVisualStyleBackColor = true;
            this.btnProdSalvar.Click += new System.EventHandler(this.btnProdSalvar_Click);
            // 
            // btnProdAlterar
            // 
            this.btnProdAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdAlterar.Location = new System.Drawing.Point(623, 112);
            this.btnProdAlterar.Name = "btnProdAlterar";
            this.btnProdAlterar.Size = new System.Drawing.Size(128, 40);
            this.btnProdAlterar.TabIndex = 2;
            this.btnProdAlterar.Text = "Alterar";
            this.btnProdAlterar.UseVisualStyleBackColor = true;
            this.btnProdAlterar.Click += new System.EventHandler(this.btnProdAlterar_Click);
            // 
            // btnProdExcluir
            // 
            this.btnProdExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdExcluir.Location = new System.Drawing.Point(623, 158);
            this.btnProdExcluir.Name = "btnProdExcluir";
            this.btnProdExcluir.Size = new System.Drawing.Size(128, 40);
            this.btnProdExcluir.TabIndex = 3;
            this.btnProdExcluir.Text = "Excluir";
            this.btnProdExcluir.UseVisualStyleBackColor = true;
            this.btnProdExcluir.Click += new System.EventHandler(this.BtnProdExcluir_Click);
            // 
            // lblProdNome
            // 
            this.lblProdNome.AutoSize = true;
            this.lblProdNome.Location = new System.Drawing.Point(130, 138);
            this.lblProdNome.Name = "lblProdNome";
            this.lblProdNome.Size = new System.Drawing.Size(0, 17);
            this.lblProdNome.TabIndex = 4;
            // 
            // txtProdNome
            // 
            this.txtProdNome.Location = new System.Drawing.Point(146, 99);
            this.txtProdNome.Name = "txtProdNome";
            this.txtProdNome.Size = new System.Drawing.Size(274, 22);
            this.txtProdNome.TabIndex = 5;
            // 
            // lblProdPreco
            // 
            this.lblProdPreco.AutoSize = true;
            this.lblProdPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdPreco.Location = new System.Drawing.Point(20, 172);
            this.lblProdPreco.Name = "lblProdPreco";
            this.lblProdPreco.Size = new System.Drawing.Size(110, 20);
            this.lblProdPreco.TabIndex = 7;
            this.lblProdPreco.Text = "Preço Venda:";
            // 
            // cmbProUni
            // 
            this.cmbProUni.FormattingEnabled = true;
            this.cmbProUni.Items.AddRange(new object[] {
            "Kilograma",
            "Litro",
            "Metro",
            "Lata"});
            this.cmbProUni.Location = new System.Drawing.Point(146, 135);
            this.cmbProUni.Name = "cmbProUni";
            this.cmbProUni.Size = new System.Drawing.Size(121, 24);
            this.cmbProUni.TabIndex = 9;
            // 
            // lblProUni
            // 
            this.lblProUni.AutoSize = true;
            this.lblProUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProUni.Location = new System.Drawing.Point(49, 138);
            this.lblProUni.Name = "lblProUni";
            this.lblProUni.Size = new System.Drawing.Size(75, 20);
            this.lblProUni.TabIndex = 10;
            this.lblProUni.Text = "Unidade:";
            // 
            // cmbProCategoria
            // 
            this.cmbProCategoria.FormattingEnabled = true;
            this.cmbProCategoria.Items.AddRange(new object[] {
            "Selecione"});
            this.cmbProCategoria.Location = new System.Drawing.Point(146, 205);
            this.cmbProCategoria.Name = "cmbProCategoria";
            this.cmbProCategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbProCategoria.TabIndex = 11;
            // 
            // lblProCategoria
            // 
            this.lblProCategoria.AutoSize = true;
            this.lblProCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProCategoria.Location = new System.Drawing.Point(38, 211);
            this.lblProCategoria.Name = "lblProCategoria";
            this.lblProCategoria.Size = new System.Drawing.Size(86, 20);
            this.lblProCategoria.TabIndex = 12;
            this.lblProCategoria.Text = "Categoria:";
            // 
            // gridViewProdutos
            // 
            this.gridViewProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewProdutos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridViewProdutos.Location = new System.Drawing.Point(0, 253);
            this.gridViewProdutos.Name = "gridViewProdutos";
            this.gridViewProdutos.RowTemplate.Height = 24;
            this.gridViewProdutos.Size = new System.Drawing.Size(799, 256);
            this.gridViewProdutos.TabIndex = 13;
            this.gridViewProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewProdutos_CellDoubleClick);
            // 
            // lblProdCodigo
            // 
            this.lblProdCodigo.AutoSize = true;
            this.lblProdCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdCodigo.Location = new System.Drawing.Point(54, 64);
            this.lblProdCodigo.Name = "lblProdCodigo";
            this.lblProdCodigo.Size = new System.Drawing.Size(66, 20);
            this.lblProdCodigo.TabIndex = 14;
            this.lblProdCodigo.Text = "Código:";
            this.lblProdCodigo.Visible = false;
            // 
            // txtProdPreco
            // 
            this.txtProdPreco.Location = new System.Drawing.Point(146, 172);
            this.txtProdPreco.Name = "txtProdPreco";
            this.txtProdPreco.Size = new System.Drawing.Size(121, 22);
            this.txtProdPreco.TabIndex = 15;
            // 
            // txtProdCodigo
            // 
            this.txtProdCodigo.Location = new System.Drawing.Point(146, 65);
            this.txtProdCodigo.Name = "txtProdCodigo";
            this.txtProdCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtProdCodigo.TabIndex = 16;
            this.txtProdCodigo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Produto Nome:";
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProdCodigo);
            this.Controls.Add(this.txtProdPreco);
            this.Controls.Add(this.lblProdCodigo);
            this.Controls.Add(this.gridViewProdutos);
            this.Controls.Add(this.lblProCategoria);
            this.Controls.Add(this.cmbProCategoria);
            this.Controls.Add(this.lblProUni);
            this.Controls.Add(this.cmbProUni);
            this.Controls.Add(this.lblProdPreco);
            this.Controls.Add(this.txtProdNome);
            this.Controls.Add(this.lblProdNome);
            this.Controls.Add(this.btnProdExcluir);
            this.Controls.Add(this.btnProdAlterar);
            this.Controls.Add(this.btnProdSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProdSalvar;
        private System.Windows.Forms.Button btnProdAlterar;
        private System.Windows.Forms.Button btnProdExcluir;
        private System.Windows.Forms.Label lblProdNome;
        private System.Windows.Forms.TextBox txtProdNome;
        private System.Windows.Forms.Label lblProdPreco;
        private System.Windows.Forms.ComboBox cmbProUni;
        private System.Windows.Forms.Label lblProUni;
        private System.Windows.Forms.ComboBox cmbProCategoria;
        private System.Windows.Forms.Label lblProCategoria;
        private System.Windows.Forms.DataGridView gridViewProdutos;
        private System.Windows.Forms.Label lblProdCodigo;
        private System.Windows.Forms.MaskedTextBox txtProdPreco;
        private System.Windows.Forms.TextBox txtProdCodigo;
        private System.Windows.Forms.Label label1;
    }
}

