namespace Vistas
{
    partial class ListaProducto
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
            this.txtBuscarProd = new System.Windows.Forms.TextBox();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.dgwProd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalirP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarProd
            // 
            this.txtBuscarProd.Location = new System.Drawing.Point(92, 44);
            this.txtBuscarProd.Name = "txtBuscarProd";
            this.txtBuscarProd.Size = new System.Drawing.Size(420, 20);
            this.txtBuscarProd.TabIndex = 0;
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.Location = new System.Drawing.Point(526, 42);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(97, 23);
            this.btnBuscarP.TabIndex = 1;
            this.btnBuscarP.Text = "BUSCAR";
            this.btnBuscarP.UseVisualStyleBackColor = true;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // dgwProd
            // 
            this.dgwProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProd.Location = new System.Drawing.Point(69, 88);
            this.dgwProd.Name = "dgwProd";
            this.dgwProd.Size = new System.Drawing.Size(554, 267);
            this.dgwProd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "INGRESE CODIGO DEL PRODUCTO";
            // 
            // btnSalirP
            // 
            this.btnSalirP.Location = new System.Drawing.Point(257, 387);
            this.btnSalirP.Name = "btnSalirP";
            this.btnSalirP.Size = new System.Drawing.Size(99, 40);
            this.btnSalirP.TabIndex = 4;
            this.btnSalirP.Text = "SALIR";
            this.btnSalirP.UseVisualStyleBackColor = true;
            this.btnSalirP.Click += new System.EventHandler(this.btnSalirP_Click);
            // 
            // ListaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 480);
            this.Controls.Add(this.btnSalirP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwProd);
            this.Controls.Add(this.btnBuscarP);
            this.Controls.Add(this.txtBuscarProd);
            this.Name = "ListaProducto";
            this.Text = "ListaProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgwProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarProd;
        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.DataGridView dgwProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalirP;
    }
}