namespace Arq_txt
{
    partial class Form1
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
            this.bCriarArquivo = new System.Windows.Forms.Button();
            this.bAppend = new System.Windows.Forms.Button();
            this.bLerArquivo = new System.Windows.Forms.Button();
            this.bAtualizarArquivo = new System.Windows.Forms.Button();
            this.bExcluirArquivo = new System.Windows.Forms.Button();
            this.tBAppend = new System.Windows.Forms.TextBox();
            this.tBArquivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bCriarArquivo
            // 
            this.bCriarArquivo.Location = new System.Drawing.Point(25, 21);
            this.bCriarArquivo.Name = "bCriarArquivo";
            this.bCriarArquivo.Size = new System.Drawing.Size(195, 41);
            this.bCriarArquivo.TabIndex = 0;
            this.bCriarArquivo.Text = "Criar Arquivo";
            this.bCriarArquivo.UseVisualStyleBackColor = true;
            this.bCriarArquivo.Click += new System.EventHandler(this.bCriarArquivo_Click);
            // 
            // bAppend
            // 
            this.bAppend.Location = new System.Drawing.Point(25, 68);
            this.bAppend.Name = "bAppend";
            this.bAppend.Size = new System.Drawing.Size(195, 41);
            this.bAppend.TabIndex = 1;
            this.bAppend.Text = "Append Arquivo";
            this.bAppend.UseVisualStyleBackColor = true;
            this.bAppend.Click += new System.EventHandler(this.bAppend_Click);
            // 
            // bLerArquivo
            // 
            this.bLerArquivo.Location = new System.Drawing.Point(25, 115);
            this.bLerArquivo.Name = "bLerArquivo";
            this.bLerArquivo.Size = new System.Drawing.Size(195, 41);
            this.bLerArquivo.TabIndex = 2;
            this.bLerArquivo.Text = "Ler Arquivo";
            this.bLerArquivo.UseVisualStyleBackColor = true;
            this.bLerArquivo.Click += new System.EventHandler(this.bLerArquivo_Click);
            // 
            // bAtualizarArquivo
            // 
            this.bAtualizarArquivo.Location = new System.Drawing.Point(25, 396);
            this.bAtualizarArquivo.Name = "bAtualizarArquivo";
            this.bAtualizarArquivo.Size = new System.Drawing.Size(195, 41);
            this.bAtualizarArquivo.TabIndex = 3;
            this.bAtualizarArquivo.Text = "Atualizar Arquivo";
            this.bAtualizarArquivo.UseVisualStyleBackColor = true;
            this.bAtualizarArquivo.Click += new System.EventHandler(this.bAtualizarArquivo_Click);
            // 
            // bExcluirArquivo
            // 
            this.bExcluirArquivo.Location = new System.Drawing.Point(25, 489);
            this.bExcluirArquivo.Name = "bExcluirArquivo";
            this.bExcluirArquivo.Size = new System.Drawing.Size(195, 41);
            this.bExcluirArquivo.TabIndex = 4;
            this.bExcluirArquivo.Text = "Excluir Arquivo";
            this.bExcluirArquivo.UseVisualStyleBackColor = true;
            this.bExcluirArquivo.Click += new System.EventHandler(this.bExcluirArquivo_Click);
            // 
            // tBAppend
            // 
            this.tBAppend.Location = new System.Drawing.Point(235, 75);
            this.tBAppend.Name = "tBAppend";
            this.tBAppend.Size = new System.Drawing.Size(806, 26);
            this.tBAppend.TabIndex = 5;
            // 
            // tBArquivo
            // 
            this.tBArquivo.Location = new System.Drawing.Point(235, 122);
            this.tBArquivo.Multiline = true;
            this.tBArquivo.Name = "tBArquivo";
            this.tBArquivo.Size = new System.Drawing.Size(806, 315);
            this.tBArquivo.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 542);
            this.Controls.Add(this.tBArquivo);
            this.Controls.Add(this.tBAppend);
            this.Controls.Add(this.bExcluirArquivo);
            this.Controls.Add(this.bAtualizarArquivo);
            this.Controls.Add(this.bLerArquivo);
            this.Controls.Add(this.bAppend);
            this.Controls.Add(this.bCriarArquivo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arquivo de Texto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCriarArquivo;
        private System.Windows.Forms.Button bAppend;
        private System.Windows.Forms.Button bLerArquivo;
        private System.Windows.Forms.Button bAtualizarArquivo;
        private System.Windows.Forms.Button bExcluirArquivo;
        private System.Windows.Forms.TextBox tBAppend;
        private System.Windows.Forms.TextBox tBArquivo;
    }
}

