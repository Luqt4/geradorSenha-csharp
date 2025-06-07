namespace GeradorSenha
{
    partial class Form1
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
            labell = new System.Windows.Forms.Label();
            chkMaiusculas = new System.Windows.Forms.CheckBox();
            chkNumeros = new System.Windows.Forms.CheckBox();
            chkEspeciais = new System.Windows.Forms.CheckBox();
            btnGerar = new System.Windows.Forms.Button();
            btnCopiarSelecionada = new System.Windows.Forms.Button();
            lstSenhas = new System.Windows.Forms.ListBox();
            txtComprimento = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // labell
            // 
            labell.AutoSize = true;
            labell.Location = new System.Drawing.Point(256, 24);
            labell.Name = "labell";
            labell.Size = new System.Drawing.Size(135, 15);
            labell.TabIndex = 0;
            labell.Text = "Comprimento da senha:";
            // 
            // chkMaiusculas
            // 
            chkMaiusculas.AutoSize = true;
            chkMaiusculas.Location = new System.Drawing.Point(256, 107);
            chkMaiusculas.Name = "chkMaiusculas";
            chkMaiusculas.Size = new System.Drawing.Size(152, 19);
            chkMaiusculas.TabIndex = 2;
            chkMaiusculas.Text = "Incluir letras maiúsculas";
            chkMaiusculas.UseVisualStyleBackColor = true;
            // 
            // chkNumeros
            // 
            chkNumeros.AutoSize = true;
            chkNumeros.Location = new System.Drawing.Point(256, 150);
            chkNumeros.Name = "chkNumeros";
            chkNumeros.Size = new System.Drawing.Size(109, 19);
            chkNumeros.TabIndex = 3;
            chkNumeros.Text = "\tIncluir números";
            chkNumeros.UseVisualStyleBackColor = true;
            // 
            // chkEspeciais
            // 
            chkEspeciais.AutoSize = true;
            chkEspeciais.Location = new System.Drawing.Point(256, 198);
            chkEspeciais.Name = "chkEspeciais";
            chkEspeciais.Size = new System.Drawing.Size(165, 19);
            chkEspeciais.TabIndex = 4;
            chkEspeciais.Text = "Incluir caracteres especiais";
            chkEspeciais.UseVisualStyleBackColor = true;
            // 
            // btnGerar
            // 
            btnGerar.Location = new System.Drawing.Point(256, 235);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new System.Drawing.Size(75, 23);
            btnGerar.TabIndex = 5;
            btnGerar.Text = "Gerar Senha";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // btnCopiarSelecionada
            // 
            btnCopiarSelecionada.Location = new System.Drawing.Point(515, 235);
            btnCopiarSelecionada.Name = "btnCopiarSelecionada";
            btnCopiarSelecionada.Size = new System.Drawing.Size(75, 23);
            btnCopiarSelecionada.TabIndex = 7;
            btnCopiarSelecionada.Text = "Copiar senha selecionada";
            btnCopiarSelecionada.UseVisualStyleBackColor = true;
            // 
            // lstSenhas
            // 
            lstSenhas.FormattingEnabled = true;
            lstSenhas.ItemHeight = 15;
            lstSenhas.Location = new System.Drawing.Point(46, 32);
            lstSenhas.Name = "lstSenhas";
            lstSenhas.Size = new System.Drawing.Size(120, 94);
            lstSenhas.TabIndex = 8;
            // 
            // txtComprimento
            // 
            txtComprimento.Location = new System.Drawing.Point(256, 55);
            txtComprimento.Name = "txtComprimento";
            txtComprimento.Size = new System.Drawing.Size(100, 23);
            txtComprimento.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(txtComprimento);
            Controls.Add(lstSenhas);
            Controls.Add(btnCopiarSelecionada);
            Controls.Add(btnGerar);
            Controls.Add(chkEspeciais);
            Controls.Add(chkNumeros);
            Controls.Add(chkMaiusculas);
            Controls.Add(labell);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labell;
        private System.Windows.Forms.CheckBox chkMaiusculas;
        private System.Windows.Forms.CheckBox chkNumeros;
        private System.Windows.Forms.CheckBox chkEspeciais;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnCopiarSelecionada;
        private System.Windows.Forms.ListBox lstSenhas;
        private System.Windows.Forms.TextBox txtComprimento;
    }
}