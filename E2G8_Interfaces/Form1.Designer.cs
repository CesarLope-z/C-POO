namespace E2G8_Interfaces
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
            btnMostrar = new Button();
            lblResultado = new Label();
            cmbVehiculos = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(91, 96);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Mostrar Info";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(23, 187);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 1;
            // 
            // cmbVehiculos
            // 
            cmbVehiculos.FormattingEnabled = true;
            cmbVehiculos.Items.AddRange(new object[] { "Carro", "Moto", "Bus" });
            cmbVehiculos.Location = new Point(67, 67);
            cmbVehiculos.Name = "cmbVehiculos";
            cmbVehiculos.Size = new Size(121, 23);
            cmbVehiculos.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 33);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 3;
            label2.Text = "Elije el tipo de vehiculo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 249);
            Controls.Add(label2);
            Controls.Add(cmbVehiculos);
            Controls.Add(lblResultado);
            Controls.Add(btnMostrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrar;
        private Label lblResultado;
        private ComboBox cmbVehiculos;
        private Label label2;
    }
}
