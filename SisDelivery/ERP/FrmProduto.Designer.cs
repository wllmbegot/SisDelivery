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
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.btnProdSalvar = new System.Windows.Forms.Button();
            this.btnProdAlterar = new System.Windows.Forms.Button();
            this.btnProdExcluir = new System.Windows.Forms.Button();
            this.lblProdNome = new System.Windows.Forms.Label();
            this.txtProdNome = new System.Windows.Forms.TextBox();
            this.txtProdPreco = new System.Windows.Forms.TextBox();
            this.lblProdPreco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProUni = new System.Windows.Forms.ComboBox();
            this.lblProUni = new System.Windows.Forms.Label();
            this.cmbProCategoria = new System.Windows.Forms.ComboBox();
            this.lblProCategoria = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.Goldenrod;
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(599, 38);
            this.panelCabecalho.TabIndex = 0;
            // 
            // btnProdSalvar
            // 
            this.btnProdSalvar.Location = new System.Drawing.Point(451, 78);
            this.btnProdSalvar.Name = "btnProdSalvar";
            this.btnProdSalvar.Size = new System.Drawing.Size(128, 40);
            this.btnProdSalvar.TabIndex = 1;
            this.btnProdSalvar.Text = "Salvar";
            this.btnProdSalvar.UseVisualStyleBackColor = true;
            // 
            // btnProdAlterar
            // 
            this.btnProdAlterar.Location = new System.Drawing.Point(451, 124);
            this.btnProdAlterar.Name = "btnProdAlterar";
            this.btnProdAlterar.Size = new System.Drawing.Size(128, 40);
            this.btnProdAlterar.TabIndex = 2;
            this.btnProdAlterar.Text = "Alterar";
            this.btnProdAlterar.UseVisualStyleBackColor = true;
            // 
            // btnProdExcluir
            // 
            this.btnProdExcluir.Location = new System.Drawing.Point(451, 170);
            this.btnProdExcluir.Name = "btnProdExcluir";
            this.btnProdExcluir.Size = new System.Drawing.Size(128, 40);
            this.btnProdExcluir.TabIndex = 3;
            this.btnProdExcluir.Text = "Excluir";
            this.btnProdExcluir.UseVisualStyleBackColor = true;
            this.btnProdExcluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblProdNome
            // 
            this.lblProdNome.AutoSize = true;
            this.lblProdNome.Location = new System.Drawing.Point(130, 117);
            this.lblProdNome.Name = "lblProdNome";
            this.lblProdNome.Size = new System.Drawing.Size(0, 17);
            this.lblProdNome.TabIndex = 4;
            // 
            // txtProdNome
            // 
            this.txtProdNome.Location = new System.Drawing.Point(146, 78);
            this.txtProdNome.Name = "txtProdNome";
            this.txtProdNome.Size = new System.Drawing.Size(274, 22);
            this.txtProdNome.TabIndex = 5;
            // 
            // txtProdPreco
            // 
            this.txtProdPreco.Location = new System.Drawing.Point(146, 151);
            this.txtProdPreco.Name = "txtProdPreco";
            this.txtProdPreco.Size = new System.Drawing.Size(274, 22);
            this.txtProdPreco.TabIndex = 6;
            // 
            // lblProdPreco
            // 
            this.lblProdPreco.AutoSize = true;
            this.lblProdPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdPreco.Location = new System.Drawing.Point(20, 151);
            this.lblProdPreco.Name = "lblProdPreco";
            this.lblProdPreco.Size = new System.Drawing.Size(110, 20);
            this.lblProdPreco.TabIndex = 7;
            this.lblProdPreco.Text = "Preço Venda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome Produto:";
            // 
            // cmbProUni
            // 
            this.cmbProUni.FormattingEnabled = true;
            this.cmbProUni.Location = new System.Drawing.Point(146, 114);
            this.cmbProUni.Name = "cmbProUni";
            this.cmbProUni.Size = new System.Drawing.Size(121, 24);
            this.cmbProUni.TabIndex = 9;
            // 
            // lblProUni
            // 
            this.lblProUni.AutoSize = true;
            this.lblProUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProUni.Location = new System.Drawing.Point(49, 117);
            this.lblProUni.Name = "lblProUni";
            this.lblProUni.Size = new System.Drawing.Size(75, 20);
            this.lblProUni.TabIndex = 10;
            this.lblProUni.Text = "Unidade:";
            // 
            // cmbProCategoria
            // 
            this.cmbProCategoria.FormattingEnabled = true;
            this.cmbProCategoria.Location = new System.Drawing.Point(146, 184);
            this.cmbProCategoria.Name = "cmbProCategoria";
            this.cmbProCategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbProCategoria.TabIndex = 11;
            // 
            // lblProCategoria
            // 
            this.lblProCategoria.AutoSize = true;
            this.lblProCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProCategoria.Location = new System.Drawing.Point(38, 190);
            this.lblProCategoria.Name = "lblProCategoria";
            this.lblProCategoria.Size = new System.Drawing.Size(86, 20);
            this.lblProCategoria.TabIndex = 12;
            this.lblProCategoria.Text = "Categoria:";
            this.lblProCategoria.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(572, 209);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 480);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblProCategoria);
            this.Controls.Add(this.cmbProCategoria);
            this.Controls.Add(this.lblProUni);
            this.Controls.Add(this.cmbProUni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProdPreco);
            this.Controls.Add(this.txtProdPreco);
            this.Controls.Add(this.txtProdNome);
            this.Controls.Add(this.lblProdNome);
            this.Controls.Add(this.btnProdExcluir);
            this.Controls.Add(this.btnProdAlterar);
            this.Controls.Add(this.btnProdSalvar);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button btnProdSalvar;
        private System.Windows.Forms.Button btnProdAlterar;
        private System.Windows.Forms.Button btnProdExcluir;
        private System.Windows.Forms.Label lblProdNome;
        private System.Windows.Forms.TextBox txtProdNome;
        private System.Windows.Forms.TextBox txtProdPreco;
        private System.Windows.Forms.Label lblProdPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProUni;
        private System.Windows.Forms.Label lblProUni;
        private System.Windows.Forms.ComboBox cmbProCategoria;
        private System.Windows.Forms.Label lblProCategoria;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

