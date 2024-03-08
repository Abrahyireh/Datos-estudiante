namespace ej1DatosEstudiantes
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
            btn_Implimir = new Button();
            btn_Limpiar = new Button();
            btn_Salir = new Button();
            txt_Matricula = new TextBox();
            txt_Nombre = new TextBox();
            txt_Apellidos = new TextBox();
            txt_Edad = new TextBox();
            txt_Carrera = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lbl_Matricula = new Label();
            lbl_Nombre = new Label();
            lbl_Apellidos = new Label();
            lbl_Edad = new Label();
            lbl_Carrera = new Label();
            SuspendLayout();
            // 
            // btn_Implimir
            // 
            btn_Implimir.BackColor = Color.Blue;
            btn_Implimir.ForeColor = SystemColors.ButtonFace;
            btn_Implimir.Location = new Point(40, 387);
            btn_Implimir.Name = "btn_Implimir";
            btn_Implimir.Size = new Size(75, 23);
            btn_Implimir.TabIndex = 0;
            btn_Implimir.Text = "Nuevo";
            btn_Implimir.UseVisualStyleBackColor = false;
            btn_Implimir.Click += btn_Implimir_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor = Color.Blue;
            btn_Limpiar.ForeColor = SystemColors.ButtonHighlight;
            btn_Limpiar.Location = new Point(152, 387);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(75, 23);
            btn_Limpiar.TabIndex = 1;
            btn_Limpiar.Text = "Clear";
            btn_Limpiar.UseVisualStyleBackColor = false;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.Red;
            btn_Salir.ForeColor = SystemColors.ButtonHighlight;
            btn_Salir.Location = new Point(258, 387);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(75, 23);
            btn_Salir.TabIndex = 2;
            btn_Salir.Text = "X";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // txt_Matricula
            // 
            txt_Matricula.Location = new Point(76, 75);
            txt_Matricula.Name = "txt_Matricula";
            txt_Matricula.Size = new Size(100, 23);
            txt_Matricula.TabIndex = 3;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(76, 115);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(100, 23);
            txt_Nombre.TabIndex = 4;
            // 
            // txt_Apellidos
            // 
            txt_Apellidos.Location = new Point(76, 164);
            txt_Apellidos.Name = "txt_Apellidos";
            txt_Apellidos.Size = new Size(100, 23);
            txt_Apellidos.TabIndex = 5;
            // 
            // txt_Edad
            // 
            txt_Edad.Location = new Point(76, 221);
            txt_Edad.Name = "txt_Edad";
            txt_Edad.Size = new Size(100, 23);
            txt_Edad.TabIndex = 6;
            // 
            // txt_Carrera
            // 
            txt_Carrera.Location = new Point(76, 287);
            txt_Carrera.Name = "txt_Carrera";
            txt_Carrera.Size = new Size(100, 23);
            txt_Carrera.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 8;
            label1.Text = "Matricula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 172);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 10;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 229);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 11;
            label4.Text = "Edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 295);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 12;
            label5.Text = "Carrera";
            // 
            // lbl_Matricula
            // 
            lbl_Matricula.AutoSize = true;
            lbl_Matricula.Location = new Point(295, 83);
            lbl_Matricula.Name = "lbl_Matricula";
            lbl_Matricula.Size = new Size(19, 15);
            lbl_Matricula.TabIndex = 13;
            lbl_Matricula.Text = "....";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(295, 123);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(19, 15);
            lbl_Nombre.TabIndex = 14;
            lbl_Nombre.Text = "....";
            // 
            // lbl_Apellidos
            // 
            lbl_Apellidos.AutoSize = true;
            lbl_Apellidos.Location = new Point(295, 164);
            lbl_Apellidos.Name = "lbl_Apellidos";
            lbl_Apellidos.Size = new Size(19, 15);
            lbl_Apellidos.TabIndex = 15;
            lbl_Apellidos.Text = "....";
            // 
            // lbl_Edad
            // 
            lbl_Edad.AutoSize = true;
            lbl_Edad.Location = new Point(295, 221);
            lbl_Edad.Name = "lbl_Edad";
            lbl_Edad.Size = new Size(19, 15);
            lbl_Edad.TabIndex = 16;
            lbl_Edad.Text = "....";
            // 
            // lbl_Carrera
            // 
            lbl_Carrera.AutoSize = true;
            lbl_Carrera.Location = new Point(295, 295);
            lbl_Carrera.Name = "lbl_Carrera";
            lbl_Carrera.Size = new Size(19, 15);
            lbl_Carrera.TabIndex = 17;
            lbl_Carrera.Text = "....";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 450);
            Controls.Add(lbl_Carrera);
            Controls.Add(lbl_Edad);
            Controls.Add(lbl_Apellidos);
            Controls.Add(lbl_Nombre);
            Controls.Add(lbl_Matricula);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Carrera);
            Controls.Add(txt_Edad);
            Controls.Add(txt_Apellidos);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_Matricula);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Implimir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Implimir;
        private Button btn_Limpiar;
        private Button btn_Salir;
        private TextBox txt_Matricula;
        private TextBox txt_Nombre;
        private TextBox txt_Apellidos;
        private TextBox txt_Edad;
        private TextBox txt_Carrera;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lbl_Matricula;
        private Label lbl_Nombre;
        private Label lbl_Apellidos;
        private Label lbl_Edad;
        private Label lbl_Carrera;
    }
}