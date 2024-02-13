namespace FormasGeometricas
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
            BtnCalcular = new Button();
            pictureBoxQuadrado = new PictureBox();
            label1 = new Label();
            txtLadoQuadrado = new TextBox();
            lblAreaQuadrado = new TextBox();
            lblPerimetroQuadrado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQuadrado).BeginInit();
            SuspendLayout();
            // 
            // BtnCalcular
            // 
            BtnCalcular.Location = new Point(12, 300);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(100, 23);
            BtnCalcular.TabIndex = 0;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.UseVisualStyleBackColor = true;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // pictureBoxQuadrado
            // 
            pictureBoxQuadrado.Location = new Point(527, 185);
            pictureBoxQuadrado.Name = "pictureBoxQuadrado";
            pictureBoxQuadrado.Size = new Size(163, 138);
            pictureBoxQuadrado.TabIndex = 1;
            pictureBoxQuadrado.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 102);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 2;
            label1.Text = "Lado do quadrado:";
            // 
            // txtLadoQuadrado
            // 
            txtLadoQuadrado.Location = new Point(162, 100);
            txtLadoQuadrado.Name = "txtLadoQuadrado";
            txtLadoQuadrado.Size = new Size(100, 23);
            txtLadoQuadrado.TabIndex = 3;
            // 
            // lblAreaQuadrado
            // 
            lblAreaQuadrado.Location = new Point(162, 147);
            lblAreaQuadrado.Name = "lblAreaQuadrado";
            lblAreaQuadrado.Size = new Size(100, 23);
            lblAreaQuadrado.TabIndex = 4;
            // 
            // lblPerimetroQuadrado
            // 
            lblPerimetroQuadrado.Location = new Point(162, 194);
            lblPerimetroQuadrado.Name = "lblPerimetroQuadrado";
            lblPerimetroQuadrado.Size = new Size(100, 23);
            lblPerimetroQuadrado.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPerimetroQuadrado);
            Controls.Add(lblAreaQuadrado);
            Controls.Add(txtLadoQuadrado);
            Controls.Add(label1);
            Controls.Add(pictureBoxQuadrado);
            Controls.Add(BtnCalcular);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxQuadrado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCalcular;
        private PictureBox pictureBoxQuadrado;
        private Label label1;
        private TextBox txtLadoQuadrado;
        private TextBox lblAreaQuadrado;
        private TextBox lblPerimetroQuadrado;
    }
}