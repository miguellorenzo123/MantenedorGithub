
namespace MantenedorGithub
{
    partial class FormMantenedores
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnDiseno = new System.Windows.Forms.Button();
            this.btnDistribuidor = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnJefe = new System.Windows.Forms.Button();
            this.btnHerramientas = new System.Windows.Forms.Button();
            this.btnPlano = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Location = new System.Drawing.Point(73, 56);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(156, 23);
            this.btnEmpleado.TabIndex = 0;
            this.btnEmpleado.Text = "Mantenedor Empleado";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnDiseno
            // 
            this.btnDiseno.Location = new System.Drawing.Point(73, 96);
            this.btnDiseno.Name = "btnDiseno";
            this.btnDiseno.Size = new System.Drawing.Size(156, 23);
            this.btnDiseno.TabIndex = 1;
            this.btnDiseno.Text = "Mantenedor Diseñador";
            this.btnDiseno.UseVisualStyleBackColor = true;
            this.btnDiseno.Click += new System.EventHandler(this.btnDiseno_Click);
            // 
            // btnDistribuidor
            // 
            this.btnDistribuidor.Location = new System.Drawing.Point(73, 179);
            this.btnDistribuidor.Name = "btnDistribuidor";
            this.btnDistribuidor.Size = new System.Drawing.Size(156, 23);
            this.btnDistribuidor.TabIndex = 2;
            this.btnDistribuidor.Text = "Mantenedor Distribuidor";
            this.btnDistribuidor.UseVisualStyleBackColor = true;
            this.btnDistribuidor.Click += new System.EventHandler(this.btnDistribuidor_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.Location = new System.Drawing.Point(73, 138);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(156, 23);
            this.btnMaterial.TabIndex = 3;
            this.btnMaterial.Text = "Mantenedor Material";
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // btnJefe
            // 
            this.btnJefe.Location = new System.Drawing.Point(73, 219);
            this.btnJefe.Name = "btnJefe";
            this.btnJefe.Size = new System.Drawing.Size(156, 23);
            this.btnJefe.TabIndex = 4;
            this.btnJefe.Text = "Mantenedor Jefe de Area";
            this.btnJefe.UseVisualStyleBackColor = true;
            this.btnJefe.Click += new System.EventHandler(this.btnJefe_Click);
            // 
            // btnHerramientas
            // 
            this.btnHerramientas.Location = new System.Drawing.Point(73, 260);
            this.btnHerramientas.Name = "btnHerramientas";
            this.btnHerramientas.Size = new System.Drawing.Size(156, 23);
            this.btnHerramientas.TabIndex = 5;
            this.btnHerramientas.Text = "Mantenedor Herramientas";
            this.btnHerramientas.UseVisualStyleBackColor = true;
            this.btnHerramientas.Click += new System.EventHandler(this.btnHerramientas_Click);
            // 
            // btnPlano
            // 
            this.btnPlano.Location = new System.Drawing.Point(73, 302);
            this.btnPlano.Name = "btnPlano";
            this.btnPlano.Size = new System.Drawing.Size(156, 23);
            this.btnPlano.TabIndex = 6;
            this.btnPlano.Text = "Mantenedor Plano de Mueble";
            this.btnPlano.UseVisualStyleBackColor = true;
            this.btnPlano.Click += new System.EventHandler(this.btnPlano_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 342);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormMantenedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 377);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPlano);
            this.Controls.Add(this.btnHerramientas);
            this.Controls.Add(this.btnJefe);
            this.Controls.Add(this.btnMaterial);
            this.Controls.Add(this.btnDistribuidor);
            this.Controls.Add(this.btnDiseno);
            this.Controls.Add(this.btnEmpleado);
            this.Name = "FormMantenedores";
            this.Text = "Mantenedores";
            this.Load += new System.EventHandler(this.FormMantenedores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnDiseno;
        private System.Windows.Forms.Button btnDistribuidor;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnJefe;
        private System.Windows.Forms.Button btnHerramientas;
        private System.Windows.Forms.Button btnPlano;
        private System.Windows.Forms.Button btnSalir;
    }
}

