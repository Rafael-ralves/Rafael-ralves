
namespace ProjetoLogin
{
    partial class TelaAjuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAjuda));
            this.BtnSairtelaajuda = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnSairtelaajuda
            // 
            this.BtnSairtelaajuda.Location = new System.Drawing.Point(231, 312);
            this.BtnSairtelaajuda.Name = "BtnSairtelaajuda";
            this.BtnSairtelaajuda.Size = new System.Drawing.Size(75, 23);
            this.BtnSairtelaajuda.TabIndex = 0;
            this.BtnSairtelaajuda.Text = "SAIR";
            this.BtnSairtelaajuda.UseVisualStyleBackColor = true;
            this.BtnSairtelaajuda.Click += new System.EventHandler(this.BtnSairtelaajuda_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 90);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(531, 170);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // TelaAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnSairtelaajuda);
            this.Name = "TelaAjuda";
            this.Text = "TelaAjuda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSairtelaajuda;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}