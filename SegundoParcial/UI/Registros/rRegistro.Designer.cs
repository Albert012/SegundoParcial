namespace SegundoParcial.UI.Registros
{
    partial class rRegistro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.Guardar_button = new System.Windows.Forms.Button();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.Buscar_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Eliminar_button);
            this.groupBox1.Controls.Add(this.Guardar_button);
            this.groupBox1.Controls.Add(this.Nuevo_button);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(165, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Image = global::SegundoParcial.Properties.Resources.new2;
            this.Nuevo_button.Location = new System.Drawing.Point(28, 23);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(42, 40);
            this.Nuevo_button.TabIndex = 0;
            this.Nuevo_button.UseVisualStyleBackColor = true;
            // 
            // Guardar_button
            // 
            this.Guardar_button.Image = global::SegundoParcial.Properties.Resources.Save;
            this.Guardar_button.Location = new System.Drawing.Point(76, 23);
            this.Guardar_button.Name = "Guardar_button";
            this.Guardar_button.Size = new System.Drawing.Size(42, 40);
            this.Guardar_button.TabIndex = 1;
            this.Guardar_button.UseVisualStyleBackColor = true;
            // 
            // Eliminar_button
            // 
            this.Eliminar_button.Image = global::SegundoParcial.Properties.Resources.Delete;
            this.Eliminar_button.Location = new System.Drawing.Point(124, 23);
            this.Eliminar_button.Name = "Eliminar_button";
            this.Eliminar_button.Size = new System.Drawing.Size(42, 40);
            this.Eliminar_button.TabIndex = 2;
            this.Eliminar_button.UseVisualStyleBackColor = true;
            // 
            // Buscar_button
            // 
            this.Buscar_button.Image = global::SegundoParcial.Properties.Resources.find;
            this.Buscar_button.Location = new System.Drawing.Point(295, 25);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(35, 35);
            this.Buscar_button.TabIndex = 1;
            this.Buscar_button.UseVisualStyleBackColor = true;
            // 
            // rRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 412);
            this.Controls.Add(this.Buscar_button);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "rRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Eliminar_button;
        private System.Windows.Forms.Button Guardar_button;
        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.Button Buscar_button;
    }
}