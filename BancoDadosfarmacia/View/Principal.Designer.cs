namespace View
{
    partial class Principal
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
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnCadastroComestiveis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(33, 24);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(272, 169);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "Cadastro De Produtos Higienicos";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnCadastroComestiveis
            // 
            this.btnCadastroComestiveis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastroComestiveis.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroComestiveis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastroComestiveis.Location = new System.Drawing.Point(425, 24);
            this.btnCadastroComestiveis.Name = "btnCadastroComestiveis";
            this.btnCadastroComestiveis.Size = new System.Drawing.Size(249, 169);
            this.btnCadastroComestiveis.TabIndex = 1;
            this.btnCadastroComestiveis.Text = "Cadastro De Comestiveis";
            this.btnCadastroComestiveis.UseVisualStyleBackColor = false;
            this.btnCadastroComestiveis.Click += new System.EventHandler(this.btnCadastroComestiveis_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastroComestiveis);
            this.Controls.Add(this.btnCadastro);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnCadastroComestiveis;
    }
}

