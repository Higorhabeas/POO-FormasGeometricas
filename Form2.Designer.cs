namespace FormasGeometricas
{
    partial class Form2
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
            label1 = new Label();
            LadoTrianguloTxt = new TextBox();
            AreaTrianguloTxt = new TextBox();
            PerimetroTrianguloTxt = new TextBox();
            BtnCalcularTriangulo = new Button();
            pictureBoxTriangulo = new PictureBox();
            label2 = new Label();
            AlturaTrianguloTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTriangulo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 87);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Lado do triangulo:";
            // 
            // LadoTrianguloTxt
            // 
            LadoTrianguloTxt.Location = new Point(188, 87);
            LadoTrianguloTxt.Name = "LadoTrianguloTxt";
            LadoTrianguloTxt.Size = new Size(100, 23);
            LadoTrianguloTxt.TabIndex = 1;
            // 
            // AreaTrianguloTxt
            // 
            AreaTrianguloTxt.Location = new Point(188, 237);
            AreaTrianguloTxt.Name = "AreaTrianguloTxt";
            AreaTrianguloTxt.Size = new Size(100, 23);
            AreaTrianguloTxt.TabIndex = 2;
            // 
            // PerimetroTrianguloTxt
            // 
            PerimetroTrianguloTxt.Location = new Point(188, 284);
            PerimetroTrianguloTxt.Name = "PerimetroTrianguloTxt";
            PerimetroTrianguloTxt.Size = new Size(100, 23);
            PerimetroTrianguloTxt.TabIndex = 3;
            // 
            // BtnCalcularTriangulo
            // 
            BtnCalcularTriangulo.Location = new Point(63, 301);
            BtnCalcularTriangulo.Name = "BtnCalcularTriangulo";
            BtnCalcularTriangulo.Size = new Size(75, 23);
            BtnCalcularTriangulo.TabIndex = 4;
            BtnCalcularTriangulo.Text = "&Calcular";
            BtnCalcularTriangulo.UseVisualStyleBackColor = true;
            BtnCalcularTriangulo.Click += BtnCalcularTriangulo_Click;
            // 
            // pictureBoxTriangulo
            // 
            pictureBoxTriangulo.Location = new Point(518, 237);
            pictureBoxTriangulo.Name = "pictureBoxTriangulo";
            pictureBoxTriangulo.Size = new Size(163, 138);
            pictureBoxTriangulo.TabIndex = 5;
            pictureBoxTriangulo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 134);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 6;
            label2.Text = "Altura do triangulo:";
            // 
            // AlturaTrianguloTxt
            // 
            AlturaTrianguloTxt.Location = new Point(188, 126);
            AlturaTrianguloTxt.Name = "AlturaTrianguloTxt";
            AlturaTrianguloTxt.Size = new Size(100, 23);
            AlturaTrianguloTxt.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AlturaTrianguloTxt);
            Controls.Add(label2);
            Controls.Add(pictureBoxTriangulo);
            Controls.Add(BtnCalcularTriangulo);
            Controls.Add(PerimetroTrianguloTxt);
            Controls.Add(AreaTrianguloTxt);
            Controls.Add(LadoTrianguloTxt);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBoxTriangulo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox LadoTrianguloTxt;
        private TextBox AreaTrianguloTxt;
        private TextBox PerimetroTrianguloTxt;
        private Button BtnCalcularTriangulo;
        private PictureBox pictureBoxTriangulo;
        private Label label2;
        private TextBox AlturaTrianguloTxt;
    }
}