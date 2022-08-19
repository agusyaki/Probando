namespace Probando
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
            this.btncambiar = new System.Windows.Forms.Button();
            this.txtcambiar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncambiar
            // 
            this.btncambiar.Location = new System.Drawing.Point(443, 211);
            this.btncambiar.Name = "btncambiar";
            this.btncambiar.Size = new System.Drawing.Size(55, 29);
            this.btncambiar.TabIndex = 5;
            this.btncambiar.Text = "cambiar";
            this.btncambiar.UseVisualStyleBackColor = true;
            this.btncambiar.Click += new System.EventHandler(this.Btncambiar_Click);
            // 
            // txtcambiar
            // 
            this.txtcambiar.Location = new System.Drawing.Point(303, 216);
            this.txtcambiar.Name = "txtcambiar";
            this.txtcambiar.Size = new System.Drawing.Size(121, 20);
            this.txtcambiar.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncambiar);
            this.Controls.Add(this.txtcambiar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncambiar;
        private System.Windows.Forms.TextBox txtcambiar;
    }
}