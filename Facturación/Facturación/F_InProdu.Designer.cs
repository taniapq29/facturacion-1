﻿namespace Facturación
{
    partial class Form10
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxBCodigo = new System.Windows.Forms.TextBox();
            this.TxBCantidad = new System.Windows.Forms.TextBox();
            this.TxBPrecio = new System.Windows.Forms.TextBox();
            this.TxBDescripcion = new System.Windows.Forms.TextBox();
            this.TxBNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Atrás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(551, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descripción: ";
            // 
            // TxBCodigo
            // 
            this.TxBCodigo.Location = new System.Drawing.Point(305, 44);
            this.TxBCodigo.Name = "TxBCodigo";
            this.TxBCodigo.Size = new System.Drawing.Size(134, 20);
            this.TxBCodigo.TabIndex = 6;
            // 
            // TxBCantidad
            // 
            this.TxBCantidad.Location = new System.Drawing.Point(305, 107);
            this.TxBCantidad.Name = "TxBCantidad";
            this.TxBCantidad.Size = new System.Drawing.Size(134, 20);
            this.TxBCantidad.TabIndex = 7;
            // 
            // TxBPrecio
            // 
            this.TxBPrecio.Location = new System.Drawing.Point(305, 161);
            this.TxBPrecio.Name = "TxBPrecio";
            this.TxBPrecio.Size = new System.Drawing.Size(134, 20);
            this.TxBPrecio.TabIndex = 8;
            // 
            // TxBDescripcion
            // 
            this.TxBDescripcion.Location = new System.Drawing.Point(305, 221);
            this.TxBDescripcion.Name = "TxBDescripcion";
            this.TxBDescripcion.Size = new System.Drawing.Size(134, 20);
            this.TxBDescripcion.TabIndex = 9;
            // 
            // TxBNombre
            // 
            this.TxBNombre.Location = new System.Drawing.Point(305, 284);
            this.TxBNombre.Name = "TxBNombre";
            this.TxBNombre.Size = new System.Drawing.Size(134, 20);
            this.TxBNombre.TabIndex = 10;
            this.TxBNombre.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre:";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 411);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxBNombre);
            this.Controls.Add(this.TxBDescripcion);
            this.Controls.Add(this.TxBPrecio);
            this.Controls.Add(this.TxBCantidad);
            this.Controls.Add(this.TxBCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form10";
            this.Text = "Registro  Producto";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxBCodigo;
        private System.Windows.Forms.TextBox TxBCantidad;
        private System.Windows.Forms.TextBox TxBPrecio;
        private System.Windows.Forms.TextBox TxBDescripcion;
        private System.Windows.Forms.TextBox TxBNombre;
        private System.Windows.Forms.Label label5;
    }
}