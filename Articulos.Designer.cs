namespace splash
{
    partial class fArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fArticulos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbCosto = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbTasaIVA = new System.Windows.Forms.TextBox();
            this.tbIEPS = new System.Windows.Forms.TextBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bELiminar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.pDatos = new System.Windows.Forms.Panel();
            this.pAction = new System.Windows.Forms.Panel();
            this.pCodigo = new System.Windows.Forms.Panel();
            this.pDatos.SuspendLayout();
            this.pAction.SuspendLayout();
            this.pCodigo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tasa IVA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(213, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tasa IEPS";
            // 
            // tbCodigo
            // 
            this.tbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCodigo.Location = new System.Drawing.Point(71, 21);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(111, 13);
            this.tbCodigo.TabIndex = 6;
            this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescripcion.Location = new System.Drawing.Point(123, 15);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(297, 13);
            this.tbDescripcion.TabIndex = 7;
            // 
            // tbCosto
            // 
            this.tbCosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCosto.Location = new System.Drawing.Point(69, 57);
            this.tbCosto.Name = "tbCosto";
            this.tbCosto.Size = new System.Drawing.Size(138, 13);
            this.tbCosto.TabIndex = 8;
            // 
            // tbPrecio
            // 
            this.tbPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrecio.Location = new System.Drawing.Point(278, 57);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(146, 13);
            this.tbPrecio.TabIndex = 9;
            // 
            // tbTasaIVA
            // 
            this.tbTasaIVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTasaIVA.Location = new System.Drawing.Point(96, 109);
            this.tbTasaIVA.Name = "tbTasaIVA";
            this.tbTasaIVA.Size = new System.Drawing.Size(111, 13);
            this.tbTasaIVA.TabIndex = 10;
            // 
            // tbIEPS
            // 
            this.tbIEPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIEPS.Location = new System.Drawing.Point(313, 107);
            this.tbIEPS.Name = "tbIEPS";
            this.tbIEPS.Size = new System.Drawing.Size(111, 13);
            this.tbIEPS.TabIndex = 11;
            // 
            // bGuardar
            // 
            this.bGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bGuardar.Image = ((System.Drawing.Image)(resources.GetObject("bGuardar.Image")));
            this.bGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bGuardar.Location = new System.Drawing.Point(3, 3);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(57, 45);
            this.bGuardar.TabIndex = 12;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(234, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 36);
            this.button2.TabIndex = 13;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bELiminar
            // 
            this.bELiminar.Image = ((System.Drawing.Image)(resources.GetObject("bELiminar.Image")));
            this.bELiminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bELiminar.Location = new System.Drawing.Point(66, 3);
            this.bELiminar.Name = "bELiminar";
            this.bELiminar.Size = new System.Drawing.Size(91, 43);
            this.bELiminar.TabIndex = 14;
            this.bELiminar.Text = "Eliminar";
            this.bELiminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bELiminar.UseVisualStyleBackColor = true;
            this.bELiminar.Click += new System.EventHandler(this.bELiminar_Click_1);
            // 
            // bCancelar
            // 
            this.bCancelar.Image = ((System.Drawing.Image)(resources.GetObject("bCancelar.Image")));
            this.bCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bCancelar.Location = new System.Drawing.Point(163, 3);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 43);
            this.bCancelar.TabIndex = 15;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click_1);
            // 
            // bBuscar
            // 
            this.bBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bBuscar.Image")));
            this.bBuscar.Location = new System.Drawing.Point(188, 18);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(40, 23);
            this.bBuscar.TabIndex = 16;
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.button5_Click);
            // 
            // pDatos
            // 
            this.pDatos.Controls.Add(this.label6);
            this.pDatos.Controls.Add(this.label2);
            this.pDatos.Controls.Add(this.label3);
            this.pDatos.Controls.Add(this.label4);
            this.pDatos.Controls.Add(this.label5);
            this.pDatos.Controls.Add(this.tbDescripcion);
            this.pDatos.Controls.Add(this.tbIEPS);
            this.pDatos.Controls.Add(this.tbCosto);
            this.pDatos.Controls.Add(this.tbTasaIVA);
            this.pDatos.Controls.Add(this.tbPrecio);
            this.pDatos.Location = new System.Drawing.Point(33, 78);
            this.pDatos.Name = "pDatos";
            this.pDatos.Size = new System.Drawing.Size(441, 147);
            this.pDatos.TabIndex = 17;
            // 
            // pAction
            // 
            this.pAction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pAction.Controls.Add(this.bGuardar);
            this.pAction.Controls.Add(this.bELiminar);
            this.pAction.Controls.Add(this.bCancelar);
            this.pAction.Location = new System.Drawing.Point(33, 231);
            this.pAction.Name = "pAction";
            this.pAction.Size = new System.Drawing.Size(245, 51);
            this.pAction.TabIndex = 18;
            // 
            // pCodigo
            // 
            this.pCodigo.Controls.Add(this.label1);
            this.pCodigo.Controls.Add(this.tbCodigo);
            this.pCodigo.Controls.Add(this.button2);
            this.pCodigo.Controls.Add(this.bBuscar);
            this.pCodigo.Location = new System.Drawing.Point(33, 12);
            this.pCodigo.Name = "pCodigo";
            this.pCodigo.Size = new System.Drawing.Size(277, 53);
            this.pCodigo.TabIndex = 19;
            // 
            // fArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 291);
            this.Controls.Add(this.pCodigo);
            this.Controls.Add(this.pAction);
            this.Controls.Add(this.pDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fArticulos";
            this.Text = "Farticulos";
            this.Load += new System.EventHandler(this.fArticulos_Load);
            this.pDatos.ResumeLayout(false);
            this.pDatos.PerformLayout();
            this.pAction.ResumeLayout(false);
            this.pCodigo.ResumeLayout(false);
            this.pCodigo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbCosto;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbTasaIVA;
        private System.Windows.Forms.TextBox tbIEPS;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bELiminar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Panel pDatos;
        private System.Windows.Forms.Panel pAction;
        private System.Windows.Forms.Panel pCodigo;

    }
}