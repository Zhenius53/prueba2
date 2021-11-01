
namespace PruebasAlmacen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg_incidencias = new System.Windows.Forms.DataGridView();
            this.btn_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_incidencias)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_incidencias
            // 
            this.dg_incidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_incidencias.Location = new System.Drawing.Point(12, 46);
            this.dg_incidencias.Name = "dg_incidencias";
            this.dg_incidencias.RowTemplate.Height = 25;
            this.dg_incidencias.Size = new System.Drawing.Size(669, 266);
            this.dg_incidencias.TabIndex = 0;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(572, 344);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(109, 37);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.Text = "button1";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 431);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.dg_incidencias);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dg_incidencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_incidencias;
        private System.Windows.Forms.Button btn_guardar;
    }
}

