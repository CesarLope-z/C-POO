namespace ejem1Guia8
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
            label1 = new Label();
            txtMonto = new TextBox();
            groupBox1 = new GroupBox();
            rbEfectivo = new RadioButton();
            rbBitcoin = new RadioButton();
            rbTarjeta = new RadioButton();
            btnPagar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 24);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Monto a pagar";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(21, 56);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbEfectivo);
            groupBox1.Controls.Add(rbBitcoin);
            groupBox1.Controls.Add(rbTarjeta);
            groupBox1.Location = new Point(21, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 182);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Metodo de pago";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(27, 127);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(67, 19);
            rbEfectivo.TabIndex = 2;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbBitcoin
            // 
            rbBitcoin.AutoSize = true;
            rbBitcoin.Location = new Point(32, 72);
            rbBitcoin.Name = "rbBitcoin";
            rbBitcoin.Size = new Size(60, 19);
            rbBitcoin.TabIndex = 1;
            rbBitcoin.TabStop = true;
            rbBitcoin.Text = "PayPal";
            rbBitcoin.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(35, 37);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(59, 19);
            rbTarjeta.TabIndex = 0;
            rbTarjeta.TabStop = true;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(282, 257);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(78, 33);
            btnPagar.TabIndex = 3;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 349);
            Controls.Add(btnPagar);
            Controls.Add(groupBox1);
            Controls.Add(txtMonto);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMonto;
        private GroupBox groupBox1;
        private RadioButton rbEfectivo;
        private RadioButton rbBitcoin;
        private RadioButton rbTarjeta;
        private Button btnPagar;
    }
}
