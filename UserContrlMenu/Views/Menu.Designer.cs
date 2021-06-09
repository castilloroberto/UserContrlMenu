
namespace UserContrlMenu
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_colaboradores = new System.Windows.Forms.Button();
            this.btn_inventario = new System.Windows.Forms.Button();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_colaboradores);
            this.panel1.Controls.Add(this.btn_inventario);
            this.panel1.Controls.Add(this.btn_ventas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 125);
            this.panel1.TabIndex = 0;
            // 
            // btn_colaboradores
            // 
            this.btn_colaboradores.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_colaboradores.FlatAppearance.BorderSize = 0;
            this.btn_colaboradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_colaboradores.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_colaboradores.Location = new System.Drawing.Point(750, 55);
            this.btn_colaboradores.Name = "btn_colaboradores";
            this.btn_colaboradores.Size = new System.Drawing.Size(195, 45);
            this.btn_colaboradores.TabIndex = 2;
            this.btn_colaboradores.Text = "Colaboradores";
            this.btn_colaboradores.UseVisualStyleBackColor = false;
            this.btn_colaboradores.Click += new System.EventHandler(this.btn_colaboradores_Click);
            // 
            // btn_inventario
            // 
            this.btn_inventario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_inventario.FlatAppearance.BorderSize = 0;
            this.btn_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventario.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_inventario.Location = new System.Drawing.Point(549, 55);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(195, 45);
            this.btn_inventario.TabIndex = 1;
            this.btn_inventario.Text = "Inventario";
            this.btn_inventario.UseVisualStyleBackColor = false;
            this.btn_inventario.Click += new System.EventHandler(this.btn_inventario_Click);
            // 
            // btn_ventas
            // 
            this.btn_ventas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ventas.FlatAppearance.BorderSize = 0;
            this.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventas.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ventas.Location = new System.Drawing.Point(346, 54);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(195, 45);
            this.btn_ventas.TabIndex = 0;
            this.btn_ventas.Text = "Ventas";
            this.btn_ventas.UseVisualStyleBackColor = false;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 786);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_colaboradores;
        private System.Windows.Forms.Button btn_inventario;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.Label label1;
    }
}

