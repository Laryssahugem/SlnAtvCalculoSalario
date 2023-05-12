namespace PJtAtvCalculoSalario
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
            bttCalcula = new Button();
            CkbVt = new CheckBox();
            CkbConvenio = new CheckBox();
            textBruto = new TextBox();
            textLiquido = new TextBox();
            lblBruto = new Label();
            lblLiquido = new Label();
            SuspendLayout();
            // 
            // bttCalcula
            // 
            bttCalcula.Location = new Point(300, 275);
            bttCalcula.Name = "bttCalcula";
            bttCalcula.Size = new Size(204, 35);
            bttCalcula.TabIndex = 0;
            bttCalcula.Text = "Calcular";
            bttCalcula.UseVisualStyleBackColor = true;
            bttCalcula.Click += button1_Click;
            // 
            // CkbVt
            // 
            CkbVt.AutoSize = true;
            CkbVt.Location = new Point(146, 196);
            CkbVt.Name = "CkbVt";
            CkbVt.Size = new Size(147, 19);
            CkbVt.TabIndex = 1;
            CkbVt.Text = "Recebo Vale Transporte";
            CkbVt.UseVisualStyleBackColor = true;
            // 
            // CkbConvenio
            // 
            CkbConvenio.AutoSize = true;
            CkbConvenio.Location = new Point(489, 196);
            CkbConvenio.Name = "CkbConvenio";
            CkbConvenio.Size = new Size(162, 19);
            CkbConvenio.TabIndex = 2;
            CkbConvenio.Text = "Recebo Convênio Médico";
            CkbConvenio.UseVisualStyleBackColor = true;
            // 
            // textBruto
            // 
            textBruto.Location = new Point(404, 63);
            textBruto.Name = "textBruto";
            textBruto.Size = new Size(194, 23);
            textBruto.TabIndex = 3;
            // 
            // textLiquido
            // 
            textLiquido.Location = new Point(401, 391);
            textLiquido.Name = "textLiquido";
            textLiquido.Size = new Size(197, 23);
            textLiquido.TabIndex = 4;
            // 
            // lblBruto
            // 
            lblBruto.AutoSize = true;
            lblBruto.Location = new Point(86, 71);
            lblBruto.Name = "lblBruto";
            lblBruto.Size = new Size(74, 15);
            lblBruto.TabIndex = 5;
            lblBruto.Text = "Salário Bruto";
            // 
            // lblLiquido
            // 
            lblLiquido.AutoSize = true;
            lblLiquido.Location = new Point(99, 399);
            lblLiquido.Name = "lblLiquido";
            lblLiquido.Size = new Size(85, 15);
            lblLiquido.TabIndex = 6;
            lblLiquido.Text = "Salário Liquído";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLiquido);
            Controls.Add(lblBruto);
            Controls.Add(textLiquido);
            Controls.Add(textBruto);
            Controls.Add(CkbConvenio);
            Controls.Add(CkbVt);
            Controls.Add(bttCalcula);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttCalcula;
        private CheckBox CkbVt;
        private CheckBox CkbConvenio;
        private TextBox textBruto;
        private TextBox textLiquido;
        private Label lblBruto;
        private Label lblLiquido;
    }
}