namespace SisDelivery
{
    partial class FrmEstoque
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
            this.lblEstQtdMinima = new System.Windows.Forms.Label();
            this.lblQtdMaximo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdViewEstoque = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEstoqMax = new System.Windows.Forms.TextBox();
            this.txtEstoqMin = new System.Windows.Forms.TextBox();
            this.txtEstoq = new System.Windows.Forms.TextBox();
            this.btnEstExcluir = new System.Windows.Forms.Button();
            this.btnEstAlterar = new System.Windows.Forms.Button();
            this.btnEstSalvar = new System.Windows.Forms.Button();
            this.cmbEstoqProduto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstQtdMinima
            // 
            this.lblEstQtdMinima.AutoSize = true;
            this.lblEstQtdMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstQtdMinima.Location = new System.Drawing.Point(52, 38);
            this.lblEstQtdMinima.Name = "lblEstQtdMinima";
            this.lblEstQtdMinima.Size = new System.Drawing.Size(179, 24);
            this.lblEstQtdMinima.TabIndex = 0;
            this.lblEstQtdMinima.Text = "Quantidade Mínima:";
            // 
            // lblQtdMaximo
            // 
            this.lblQtdMaximo.AutoSize = true;
            this.lblQtdMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdMaximo.Location = new System.Drawing.Point(52, 92);
            this.lblQtdMaximo.Name = "lblQtdMaximo";
            this.lblQtdMaximo.Size = new System.Drawing.Size(184, 24);
            this.lblQtdMaximo.TabIndex = 1;
            this.lblQtdMaximo.Text = "Quantidade Máxima:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estoque Atual:";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(856, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(39, 510);
            this.panel1.TabIndex = 3;
            // 
            // grdViewEstoque
            // 
            this.grdViewEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewEstoque.Location = new System.Drawing.Point(50, 219);
            this.grdViewEstoque.Name = "grdViewEstoque";
            this.grdViewEstoque.RowTemplate.Height = 24;
            this.grdViewEstoque.Size = new System.Drawing.Size(800, 200);
            this.grdViewEstoque.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 425);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 85);
            this.panel2.TabIndex = 6;
            // 
            // txtEstoqMax
            // 
            this.txtEstoqMax.Location = new System.Drawing.Point(243, 93);
            this.txtEstoqMax.Name = "txtEstoqMax";
            this.txtEstoqMax.Size = new System.Drawing.Size(100, 22);
            this.txtEstoqMax.TabIndex = 7;
            // 
            // txtEstoqMin
            // 
            this.txtEstoqMin.Location = new System.Drawing.Point(243, 38);
            this.txtEstoqMin.Name = "txtEstoqMin";
            this.txtEstoqMin.Size = new System.Drawing.Size(100, 22);
            this.txtEstoqMin.TabIndex = 8;
            // 
            // txtEstoq
            // 
            this.txtEstoq.Location = new System.Drawing.Point(243, 149);
            this.txtEstoq.Name = "txtEstoq";
            this.txtEstoq.Size = new System.Drawing.Size(100, 22);
            this.txtEstoq.TabIndex = 9;
            // 
            // btnEstExcluir
            // 
            this.btnEstExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstExcluir.Location = new System.Drawing.Point(691, 130);
            this.btnEstExcluir.Name = "btnEstExcluir";
            this.btnEstExcluir.Size = new System.Drawing.Size(128, 40);
            this.btnEstExcluir.TabIndex = 12;
            this.btnEstExcluir.Text = "Excluir";
            this.btnEstExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEstAlterar
            // 
            this.btnEstAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstAlterar.Location = new System.Drawing.Point(691, 84);
            this.btnEstAlterar.Name = "btnEstAlterar";
            this.btnEstAlterar.Size = new System.Drawing.Size(128, 40);
            this.btnEstAlterar.TabIndex = 11;
            this.btnEstAlterar.Text = "Alterar";
            this.btnEstAlterar.UseVisualStyleBackColor = true;
            // 
            // btnEstSalvar
            // 
            this.btnEstSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstSalvar.Location = new System.Drawing.Point(691, 38);
            this.btnEstSalvar.Name = "btnEstSalvar";
            this.btnEstSalvar.Size = new System.Drawing.Size(128, 40);
            this.btnEstSalvar.TabIndex = 10;
            this.btnEstSalvar.Text = "Salvar";
            this.btnEstSalvar.UseVisualStyleBackColor = true;
            this.btnEstSalvar.Click += new System.EventHandler(this.BtnEstSalvar_Click);
            // 
            // cmbEstoqProduto
            // 
            this.cmbEstoqProduto.FormattingEnabled = true;
            this.cmbEstoqProduto.Items.AddRange(new object[] {
            "Selecione"});
            this.cmbEstoqProduto.Location = new System.Drawing.Point(427, 36);
            this.cmbEstoqProduto.Name = "cmbEstoqProduto";
            this.cmbEstoqProduto.Size = new System.Drawing.Size(121, 24);
            this.cmbEstoqProduto.TabIndex = 13;
            // 
            // FrmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 510);
            this.Controls.Add(this.cmbEstoqProduto);
            this.Controls.Add(this.btnEstExcluir);
            this.Controls.Add(this.btnEstAlterar);
            this.Controls.Add(this.btnEstSalvar);
            this.Controls.Add(this.txtEstoq);
            this.Controls.Add(this.txtEstoqMin);
            this.Controls.Add(this.txtEstoqMax);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grdViewEstoque);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQtdMaximo);
            this.Controls.Add(this.lblEstQtdMinima);
            this.Name = "FrmEstoque";
            this.Text = "FrmEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.grdViewEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstQtdMinima;
        private System.Windows.Forms.Label lblQtdMaximo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grdViewEstoque;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEstoqMax;
        private System.Windows.Forms.TextBox txtEstoqMin;
        private System.Windows.Forms.TextBox txtEstoq;
        private System.Windows.Forms.Button btnEstExcluir;
        private System.Windows.Forms.Button btnEstAlterar;
        private System.Windows.Forms.Button btnEstSalvar;
        private System.Windows.Forms.ComboBox cmbEstoqProduto;
    }
}