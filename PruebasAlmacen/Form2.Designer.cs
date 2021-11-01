
namespace PruebasAlmacen
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
            this.txt_comentario = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_comentario
            // 
            this.txt_comentario.Location = new System.Drawing.Point(12, 29);
            this.txt_comentario.Multiline = true;
            this.txt_comentario.Name = "txt_comentario";
            this.txt_comentario.Size = new System.Drawing.Size(463, 161);
            this.txt_comentario.TabIndex = 0;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(372, 216);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(103, 30);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "button1";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 288);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_comentario);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_comentario;
        private System.Windows.Forms.Button btn_agregar;
    }
}