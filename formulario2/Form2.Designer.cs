namespace Notas.formulario2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Añadir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.Eliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.Actualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.Mostrar = new System.Windows.Forms.ToolStripButton();
            this.Estudiantes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEspa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBio = new System.Windows.Forms.TextBox();
            this.dgvSalida = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.Añadir,
            this.toolStripLabel2,
            this.Eliminar,
            this.toolStripLabel3,
            this.Actualizar,
            this.toolStripLabel4,
            this.Mostrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Añadir";
            // 
            // Añadir
            // 
            this.Añadir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Añadir.Image = ((System.Drawing.Image)(resources.GetObject("Añadir.Image")));
            this.Añadir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Añadir.Name = "Añadir";
            this.Añadir.Size = new System.Drawing.Size(23, 22);
            this.Añadir.Text = "Añadir";
            this.Añadir.Click += new System.EventHandler(this.Añadir_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel2.Text = "Eliminar";
            // 
            // Eliminar
            // 
            this.Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(23, 22);
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel3.Text = "Actualizar";
            // 
            // Actualizar
            // 
            this.Actualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Actualizar.Image = ((System.Drawing.Image)(resources.GetObject("Actualizar.Image")));
            this.Actualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(23, 22);
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabel4.Text = "Mostrar";
            // 
            // Mostrar
            // 
            this.Mostrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Mostrar.Image = ((System.Drawing.Image)(resources.GetObject("Mostrar.Image")));
            this.Mostrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(23, 22);
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // Estudiantes
            // 
            this.Estudiantes.AutoSize = true;
            this.Estudiantes.Location = new System.Drawing.Point(376, 38);
            this.Estudiantes.Name = "Estudiantes";
            this.Estudiantes.Size = new System.Drawing.Size(62, 13);
            this.Estudiantes.TabIndex = 1;
            this.Estudiantes.Text = "Estudiantes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(143, 89);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(208, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nota de Matematicas";
            // 
            // tbMate
            // 
            this.tbMate.Location = new System.Drawing.Point(143, 136);
            this.tbMate.Name = "tbMate";
            this.tbMate.Size = new System.Drawing.Size(208, 20);
            this.tbMate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nota de Español";
            // 
            // tbEspa
            // 
            this.tbEspa.Location = new System.Drawing.Point(143, 189);
            this.tbEspa.Name = "tbEspa";
            this.tbEspa.Size = new System.Drawing.Size(208, 20);
            this.tbEspa.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nota de Biología";
            // 
            // tbBio
            // 
            this.tbBio.Location = new System.Drawing.Point(143, 236);
            this.tbBio.Name = "tbBio";
            this.tbBio.Size = new System.Drawing.Size(208, 20);
            this.tbBio.TabIndex = 9;
            // 
            // dgvSalida
            // 
            this.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalida.Location = new System.Drawing.Point(421, 76);
            this.dgvSalida.Name = "dgvSalida";
            this.dgvSalida.Size = new System.Drawing.Size(350, 194);
            this.dgvSalida.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSalida);
            this.Controls.Add(this.tbBio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEspa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Estudiantes);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton Añadir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton Eliminar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton Actualizar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton Mostrar;
        private System.Windows.Forms.Label Estudiantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEspa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBio;
        private System.Windows.Forms.DataGridView dgvSalida;
    }
}