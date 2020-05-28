namespace SisDelivery
{
    partial class FrmCategoria
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
            this.lblCatNome = new System.Windows.Forms.Label();
            this.txtCatNome = new System.Windows.Forms.TextBox();
            this.lblCatDescricao = new System.Windows.Forms.Label();
            this.txtCatDescricao = new System.Windows.Forms.TextBox();
            this.btnCatSalvar = new System.Windows.Forms.Button();
            this.btnCatAlterar = new System.Windows.Forms.Button();
            this.btnCatExcluir = new System.Windows.Forms.Button();
            this.gridViewCategoria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCatNome
            // 
            this.lblCatNome.AutoSize = true;
            this.lblCatNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatNome.Location = new System.Drawing.Point(9, 21);
            this.lblCatNome.Name = "lblCatNome";
            this.lblCatNome.Size = new System.Drawing.Size(135, 20);
            this.lblCatNome.TabIndex = 0;
            this.lblCatNome.Text = "Categoria Nome:";
            // 
            // txtCatNome
            // 
            this.txtCatNome.Location = new System.Drawing.Point(150, 21);
            this.txtCatNome.Name = "txtCatNome";
            this.txtCatNome.Size = new System.Drawing.Size(292, 22);
            this.txtCatNome.TabIndex = 1;
            // 
            // lblCatDescricao
            // 
            this.lblCatDescricao.AutoSize = true;
            this.lblCatDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatDescricao.Location = new System.Drawing.Point(43, 68);
            this.lblCatDescricao.Name = "lblCatDescricao";
            this.lblCatDescricao.Size = new System.Drawing.Size(91, 20);
            this.lblCatDescricao.TabIndex = 2;
            this.lblCatDescricao.Text = "Descrição:";
            // 
            // txtCatDescricao
            // 
            this.txtCatDescricao.Location = new System.Drawing.Point(150, 68);
            this.txtCatDescricao.Name = "txtCatDescricao";
            this.txtCatDescricao.Size = new System.Drawing.Size(292, 22);
            this.txtCatDescricao.TabIndex = 3;
            // 
            // btnCatSalvar
            // 
            this.btnCatSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatSalvar.Location = new System.Drawing.Point(559, 21);
            this.btnCatSalvar.Name = "btnCatSalvar";
            this.btnCatSalvar.Size = new System.Drawing.Size(137, 42);
            this.btnCatSalvar.TabIndex = 4;
            this.btnCatSalvar.Text = "Salvar";
            this.btnCatSalvar.UseVisualStyleBackColor = true;
            this.btnCatSalvar.Click += new System.EventHandler(this.btnCatSalvar_Click);
            // 
            // btnCatAlterar
            // 
            this.btnCatAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatAlterar.Location = new System.Drawing.Point(559, 73);
            this.btnCatAlterar.Name = "btnCatAlterar";
            this.btnCatAlterar.Size = new System.Drawing.Size(137, 45);
            this.btnCatAlterar.TabIndex = 5;
            this.btnCatAlterar.Text = "Alterar";
            this.btnCatAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCatExcluir
            // 
            this.btnCatExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatExcluir.Location = new System.Drawing.Point(559, 133);
            this.btnCatExcluir.Name = "btnCatExcluir";
            this.btnCatExcluir.Size = new System.Drawing.Size(137, 46);
            this.btnCatExcluir.TabIndex = 6;
            this.btnCatExcluir.Text = "Excluir";
            this.btnCatExcluir.UseVisualStyleBackColor = true;
            // 
            // gridViewCategoria
            // 
            this.gridViewCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCategoria.Location = new System.Drawing.Point(13, 196);
            this.gridViewCategoria.Name = "gridViewCategoria";
            this.gridViewCategoria.RowTemplate.Height = 24;
            this.gridViewCategoria.Size = new System.Drawing.Size(683, 229);
            this.gridViewCategoria.TabIndex = 7;
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 439);
            this.Controls.Add(this.gridViewCategoria);
            this.Controls.Add(this.btnCatExcluir);
            this.Controls.Add(this.btnCatAlterar);
            this.Controls.Add(this.btnCatSalvar);
            this.Controls.Add(this.txtCatDescricao);
            this.Controls.Add(this.lblCatDescricao);
            this.Controls.Add(this.txtCatNome);
            this.Controls.Add(this.lblCatNome);
            this.Name = "FrmCategoria";
            this.Text = "FrmCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCatNome;
        private System.Windows.Forms.TextBox txtCatNome;
        private System.Windows.Forms.Label lblCatDescricao;
        private System.Windows.Forms.TextBox txtCatDescricao;
        private System.Windows.Forms.Button btnCatSalvar;
        private System.Windows.Forms.Button btnCatAlterar;
        private System.Windows.Forms.Button btnCatExcluir;
        private System.Windows.Forms.DataGridView gridViewCategoria;
    }
}