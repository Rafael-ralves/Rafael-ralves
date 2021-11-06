
namespace ProjetoLogin
{
    partial class Form2
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
            this.Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnamecadin = new System.Windows.Forms.TextBox();
            this.txtemailcadin = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtconfirmarsenha = new System.Windows.Forms.TextBox();
            this.BtnCadastrarcadin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(86, 32);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Usuario";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(86, 69);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(31, 13);
            this.email.TabIndex = 1;
            this.email.Text = "email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Confirmar Senha";
            // 
            // txtnamecadin
            // 
            this.txtnamecadin.Location = new System.Drawing.Point(158, 29);
            this.txtnamecadin.Name = "txtnamecadin";
            this.txtnamecadin.Size = new System.Drawing.Size(170, 20);
            this.txtnamecadin.TabIndex = 2;
            // 
            // txtemailcadin
            // 
            this.txtemailcadin.Location = new System.Drawing.Point(158, 69);
            this.txtemailcadin.Name = "txtemailcadin";
            this.txtemailcadin.Size = new System.Drawing.Size(170, 20);
            this.txtemailcadin.TabIndex = 2;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(158, 111);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(170, 20);
            this.txtusuario.TabIndex = 2;
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(158, 159);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(170, 20);
            this.txtsenha.TabIndex = 2;
            // 
            // txtconfirmarsenha
            // 
            this.txtconfirmarsenha.Location = new System.Drawing.Point(158, 209);
            this.txtconfirmarsenha.Name = "txtconfirmarsenha";
            this.txtconfirmarsenha.Size = new System.Drawing.Size(170, 20);
            this.txtconfirmarsenha.TabIndex = 2;
            // 
            // BtnCadastrarcadin
            // 
            this.BtnCadastrarcadin.Location = new System.Drawing.Point(187, 288);
            this.BtnCadastrarcadin.Name = "BtnCadastrarcadin";
            this.BtnCadastrarcadin.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrarcadin.TabIndex = 3;
            this.BtnCadastrarcadin.Text = "Cadastrar";
            this.BtnCadastrarcadin.UseVisualStyleBackColor = true;
            this.BtnCadastrarcadin.Click += new System.EventHandler(this.BtnCadastrarcadin_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.BtnCadastrarcadin);
            this.Controls.Add(this.txtconfirmarsenha);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtemailcadin);
            this.Controls.Add(this.txtnamecadin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Name = "Form2";
            this.Text = "Cadastre-se";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnamecadin;
        private System.Windows.Forms.TextBox txtemailcadin;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtconfirmarsenha;
        private System.Windows.Forms.Button BtnCadastrarcadin;
    }
}