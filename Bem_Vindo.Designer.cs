
namespace ProjetoLogin
{
    partial class Bem_Vindo
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
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtcadlogin = new System.Windows.Forms.ToolStripTextBox();
            this.txtajuda = new System.Windows.Forms.ToolStripTextBox();
            this.btn_retornolog = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BEM VINDO AO SISTEMA!";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtcadlogin,
            this.txtajuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtcadlogin
            // 
            this.txtcadlogin.Name = "txtcadlogin";
            this.txtcadlogin.Size = new System.Drawing.Size(100, 25);
            this.txtcadlogin.Text = "Cadastro Login";
            this.txtcadlogin.Click += new System.EventHandler(this.txtcadlogin_Click);
            // 
            // txtajuda
            // 
            this.txtajuda.Name = "txtajuda";
            this.txtajuda.Size = new System.Drawing.Size(100, 25);
            this.txtajuda.Text = "Precisa de ajuda";
            this.txtajuda.Click += new System.EventHandler(this.txtajuda_Click);
            // 
            // btn_retornolog
            // 
            this.btn_retornolog.Location = new System.Drawing.Point(315, 334);
            this.btn_retornolog.Name = "btn_retornolog";
            this.btn_retornolog.Size = new System.Drawing.Size(138, 23);
            this.btn_retornolog.TabIndex = 2;
            this.btn_retornolog.Text = "Retornar a Tela de Login";
            this.btn_retornolog.UseVisualStyleBackColor = true;
            this.btn_retornolog.Click += new System.EventHandler(this.btn_retornolog_Click);
            // 
            // Bem_Vindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_retornolog);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Name = "Bem_Vindo";
            this.Text = "Bem_Vindo";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txtcadlogin;
        private System.Windows.Forms.ToolStripTextBox txtajuda;
        private System.Windows.Forms.Button btn_retornolog;
    }
}