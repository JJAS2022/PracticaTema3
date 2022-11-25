namespace Aplicación___PrácticaTema3
{
    partial class Form1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.radioOrdinario = new System.Windows.Forms.RadioButton();
            this.radioUrgente = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(29, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(39, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Texto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Location = new System.Drawing.Point(77, 153);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 2;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(34, 156);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(37, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Coste:";
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(210, 142);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(98, 38);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Calcular";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelegrama.Location = new System.Drawing.Point(35, 29);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(273, 87);
            this.txtTelegrama.TabIndex = 5;
            // 
            // radioOrdinario
            // 
            this.radioOrdinario.AutoSize = true;
            this.radioOrdinario.Checked = true;
            this.radioOrdinario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioOrdinario.Location = new System.Drawing.Point(37, 122);
            this.radioOrdinario.Name = "radioOrdinario";
            this.radioOrdinario.Size = new System.Drawing.Size(66, 17);
            this.radioOrdinario.TabIndex = 6;
            this.radioOrdinario.TabStop = true;
            this.radioOrdinario.Text = "Ordinario";
            this.radioOrdinario.UseVisualStyleBackColor = true;
            // 
            // radioUrgente
            // 
            this.radioUrgente.AutoSize = true;
            this.radioUrgente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioUrgente.Location = new System.Drawing.Point(109, 122);
            this.radioUrgente.Name = "radioUrgente";
            this.radioUrgente.Size = new System.Drawing.Size(62, 17);
            this.radioUrgente.TabIndex = 7;
            this.radioUrgente.Text = "Urgente";
            this.radioUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 211);
            this.Controls.Add(this.radioUrgente);
            this.Controls.Add(this.radioOrdinario);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Aplicación - PrácticaTema3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.RadioButton radioOrdinario;
        private System.Windows.Forms.RadioButton radioUrgente;
    }
}

