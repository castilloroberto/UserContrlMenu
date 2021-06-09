
namespace UserContrlMenu.Views
{
    partial class ColaboradoresView
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_colaboradores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(268, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Colaboradores";
            // 
            // btn_colaboradores
            // 
            this.btn_colaboradores.Location = new System.Drawing.Point(378, 264);
            this.btn_colaboradores.Name = "btn_colaboradores";
            this.btn_colaboradores.Size = new System.Drawing.Size(94, 29);
            this.btn_colaboradores.TabIndex = 1;
            this.btn_colaboradores.Text = "Show Msg";
            this.btn_colaboradores.UseVisualStyleBackColor = true;
            this.btn_colaboradores.Click += new System.EventHandler(this.btn_colaboradores_Click);
            // 
            // ColaboradoresView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_colaboradores);
            this.Controls.Add(this.label1);
            this.Name = "ColaboradoresView";
            this.Size = new System.Drawing.Size(935, 605);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_colaboradores;
    }
}
