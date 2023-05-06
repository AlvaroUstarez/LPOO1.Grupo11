namespace Vistas
{
    partial class ListaCliente
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
            this.btnClienteSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwCliente = new System.Windows.Forms.DataGridView();
            this.btnClienteBuscar = new System.Windows.Forms.Button();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClienteSalir
            // 
            this.btnClienteSalir.Location = new System.Drawing.Point(340, 427);
            this.btnClienteSalir.Name = "btnClienteSalir";
            this.btnClienteSalir.Size = new System.Drawing.Size(99, 40);
            this.btnClienteSalir.TabIndex = 9;
            this.btnClienteSalir.Text = "SALIR";
            this.btnClienteSalir.UseVisualStyleBackColor = true;
            this.btnClienteSalir.Click += new System.EventHandler(this.btnClienteSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "INGRESE DNI DEL CLIENTE";
            // 
            // dgwCliente
            // 
            this.dgwCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCliente.Location = new System.Drawing.Point(46, 124);
            this.dgwCliente.Name = "dgwCliente";
            this.dgwCliente.Size = new System.Drawing.Size(713, 267);
            this.dgwCliente.TabIndex = 7;
            // 
            // btnClienteBuscar
            // 
            this.btnClienteBuscar.Location = new System.Drawing.Point(609, 80);
            this.btnClienteBuscar.Name = "btnClienteBuscar";
            this.btnClienteBuscar.Size = new System.Drawing.Size(97, 23);
            this.btnClienteBuscar.TabIndex = 6;
            this.btnClienteBuscar.Text = "BUSCAR";
            this.btnClienteBuscar.UseVisualStyleBackColor = true;
            this.btnClienteBuscar.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(175, 84);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(420, 20);
            this.txtBuscarCliente.TabIndex = 5;
            // 
            // ListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 524);
            this.Controls.Add(this.btnClienteSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwCliente);
            this.Controls.Add(this.btnClienteBuscar);
            this.Controls.Add(this.txtBuscarCliente);
            this.Name = "ListaCliente";
            this.Text = "ListaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgwCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClienteSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwCliente;
        private System.Windows.Forms.Button btnClienteBuscar;
        private System.Windows.Forms.TextBox txtBuscarCliente;
    }
}