namespace WinFormsApp1
{
    partial class Form1
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
            button1 = new Button();
            label1 = new Label();
            txtconsumos = new TextBox();
            lbldesc = new Label();
            lblimpuesto = new Label();
            lblsubtotal = new Label();
            lblimporte = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(298, 258);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Ejecutar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 15);
            label1.TabIndex = 1;
            label1.Text = "¿Cuánto es el costo de sus consumos?";
            // 
            // txtconsumos
            // 
            txtconsumos.Location = new Point(148, 27);
            txtconsumos.Name = "txtconsumos";
            txtconsumos.Size = new Size(100, 23);
            txtconsumos.TabIndex = 2;
            // 
            // lbldesc
            // 
            lbldesc.AutoSize = true;
            lbldesc.Location = new Point(96, 79);
            lbldesc.Name = "lbldesc";
            lbldesc.Size = new Size(63, 15);
            lbldesc.TabIndex = 3;
            lbldesc.Text = "Descuento";
            // 
            // lblimpuesto
            // 
            lblimpuesto.AutoSize = true;
            lblimpuesto.Location = new Point(96, 122);
            lblimpuesto.Name = "lblimpuesto";
            lblimpuesto.Size = new Size(57, 15);
            lblimpuesto.TabIndex = 5;
            lblimpuesto.Text = "Impuesto";
            lblimpuesto.Click += label3_Click;
            // 
            // lblsubtotal
            // 
            lblsubtotal.AutoSize = true;
            lblsubtotal.Location = new Point(96, 162);
            lblsubtotal.Name = "lblsubtotal";
            lblsubtotal.Size = new Size(54, 15);
            lblsubtotal.TabIndex = 6;
            lblsubtotal.Text = "Sub total";
            // 
            // lblimporte
            // 
            lblimporte.AutoSize = true;
            lblimporte.Location = new Point(96, 199);
            lblimporte.Name = "lblimporte";
            lblimporte.Size = new Size(91, 15);
            lblimporte.TabIndex = 7;
            lblimporte.Text = "Importe a pagar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblimporte);
            Controls.Add(lblsubtotal);
            Controls.Add(lblimpuesto);
            Controls.Add(lbldesc);
            Controls.Add(txtconsumos);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txtconsumos;
        private Label lbldesc;
        private Label lblimpuesto;
        private Label lblsubtotal;
        private Label lblimporte;
    }
}