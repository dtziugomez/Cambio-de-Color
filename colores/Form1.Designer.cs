﻿namespace colores
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboColores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboColores
            // 
            this.cboColores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColores.FormattingEnabled = true;
            this.cboColores.ItemHeight = 13;
            this.cboColores.Items.AddRange(new object[] {
            "violet",
            "indigo",
            "red",
            "blue",
            "green",
            "yellow"});
            this.cboColores.Location = new System.Drawing.Point(128, 53);
            this.cboColores.Name = "cboColores";
            this.cboColores.Size = new System.Drawing.Size(121, 21);
            this.cboColores.TabIndex = 0;
            this.cboColores.SelectedIndexChanged += new System.EventHandler(this.cboColores_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "seleccione el color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboColores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboColores;
        private System.Windows.Forms.Label label1;
    }
}

