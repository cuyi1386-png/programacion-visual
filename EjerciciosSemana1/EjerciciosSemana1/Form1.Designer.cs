namespace EjerciciosSemana1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            BtLogin = new Button();
            TbContraseña = new TextBox();
            label3 = new Label();
            TbUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            BtCalcular = new Button();
            TbPeso = new TextBox();
            label4 = new Label();
            TbAltura = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tabPage3 = new TabPage();
            CbConversion = new ComboBox();
            BtConvertir = new Button();
            TbTemperatura = new TextBox();
            label7 = new Label();
            label9 = new Label();
            tabPage4 = new TabPage();
            BtReset = new Button();
            BtClick = new Button();
            Display = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(2, 4);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(501, 440);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BtLogin);
            tabPage1.Controls.Add(TbContraseña);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(TbUsuario);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(493, 402);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Login";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtLogin
            // 
            BtLogin.BackColor = Color.Black;
            BtLogin.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtLogin.ForeColor = SystemColors.ButtonHighlight;
            BtLogin.Location = new Point(144, 306);
            BtLogin.Margin = new Padding(4);
            BtLogin.Name = "BtLogin";
            BtLogin.Size = new Size(199, 60);
            BtLogin.TabIndex = 5;
            BtLogin.Text = "Iniciar Sesion";
            BtLogin.UseVisualStyleBackColor = false;
            BtLogin.Click += BtLogin_Click;
            // 
            // TbContraseña
            // 
            TbContraseña.Location = new Point(80, 224);
            TbContraseña.Margin = new Padding(4);
            TbContraseña.Name = "TbContraseña";
            TbContraseña.PasswordChar = '*';
            TbContraseña.Size = new Size(322, 31);
            TbContraseña.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 194);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 22);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // TbUsuario
            // 
            TbUsuario.Location = new Point(80, 145);
            TbUsuario.Margin = new Padding(4);
            TbUsuario.Name = "TbUsuario";
            TbUsuario.Size = new Size(322, 31);
            TbUsuario.TabIndex = 2;
            TbUsuario.TextChanged += TbUsuario_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 116);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 22);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 15.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 39);
            label1.TabIndex = 0;
            label1.Text = "Login Simple";
            label1.Click += label1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BtCalcular);
            tabPage2.Controls.Add(TbPeso);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(TbAltura);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(493, 402);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "IMC";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtCalcular
            // 
            BtCalcular.BackColor = Color.Black;
            BtCalcular.ForeColor = SystemColors.ButtonHighlight;
            BtCalcular.Location = new Point(150, 309);
            BtCalcular.Margin = new Padding(4);
            BtCalcular.Name = "BtCalcular";
            BtCalcular.Size = new Size(199, 60);
            BtCalcular.TabIndex = 11;
            BtCalcular.Text = "Calcular";
            BtCalcular.UseVisualStyleBackColor = false;
            BtCalcular.Click += BtCalcular_Click;
            // 
            // TbPeso
            // 
            TbPeso.Location = new Point(86, 224);
            TbPeso.Margin = new Padding(4);
            TbPeso.Name = "TbPeso";
            TbPeso.Size = new Size(322, 31);
            TbPeso.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(82, 195);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(173, 22);
            label4.TabIndex = 9;
            label4.Text = "Ingrese su peso en kg";
            label4.Click += label4_Click;
            // 
            // TbAltura
            // 
            TbAltura.Location = new Point(86, 146);
            TbAltura.Margin = new Padding(4);
            TbAltura.Name = "TbAltura";
            TbAltura.Size = new Size(322, 31);
            TbAltura.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(82, 116);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(215, 22);
            label5.TabIndex = 7;
            label5.Text = "Ingrese su altura en metros";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Ink Free", 15.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(92, 29);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(299, 39);
            label6.TabIndex = 6;
            label6.Text = "Calculadora de IMC";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(CbConversion);
            tabPage3.Controls.Add(BtConvertir);
            tabPage3.Controls.Add(TbTemperatura);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label9);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(493, 402);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Conversor";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // CbConversion
            // 
            CbConversion.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbConversion.FormattingEnabled = true;
            CbConversion.Items.AddRange(new object[] { "Celcius a Farenheit", "Farenheit a Celcius" });
            CbConversion.Location = new Point(55, 92);
            CbConversion.Margin = new Padding(4);
            CbConversion.Name = "CbConversion";
            CbConversion.Size = new Size(378, 26);
            CbConversion.TabIndex = 18;
            CbConversion.Text = "Seleccione su tipo de conversion";
            // 
            // BtConvertir
            // 
            BtConvertir.BackColor = Color.Black;
            BtConvertir.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtConvertir.ForeColor = SystemColors.ButtonHighlight;
            BtConvertir.Location = new Point(138, 316);
            BtConvertir.Margin = new Padding(4);
            BtConvertir.Name = "BtConvertir";
            BtConvertir.Size = new Size(199, 60);
            BtConvertir.TabIndex = 17;
            BtConvertir.Text = "Convertir";
            BtConvertir.UseVisualStyleBackColor = false;
            BtConvertir.Click += button1_Click;
            // 
            // TbTemperatura
            // 
            TbTemperatura.Location = new Point(152, 226);
            TbTemperatura.Margin = new Padding(4);
            TbTemperatura.Name = "TbTemperatura";
            TbTemperatura.Size = new Size(165, 31);
            TbTemperatura.TabIndex = 16;
            TbTemperatura.TextChanged += TbTemperatura_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(152, 181);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(180, 22);
            label7.TabIndex = 15;
            label7.Text = "Ingrese la temperatura";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Ink Free", 15.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(54, 27);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(408, 39);
            label9.TabIndex = 12;
            label9.Text = "Conversor de Temperatura";
            label9.Click += label9_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(BtReset);
            tabPage4.Controls.Add(BtClick);
            tabPage4.Controls.Add(Display);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Margin = new Padding(4);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(493, 402);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Contador";
            tabPage4.UseVisualStyleBackColor = true;
            tabPage4.Click += tabPage4_Click;
            // 
            // BtReset
            // 
            BtReset.BackColor = Color.DarkGray;
            BtReset.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtReset.ForeColor = SystemColors.ButtonHighlight;
            BtReset.Location = new Point(280, 210);
            BtReset.Margin = new Padding(4);
            BtReset.Name = "BtReset";
            BtReset.Size = new Size(131, 50);
            BtReset.TabIndex = 2;
            BtReset.Text = "Reset";
            BtReset.UseVisualStyleBackColor = false;
            BtReset.Click += BtReset_Click;
            // 
            // BtClick
            // 
            BtClick.BackColor = Color.Black;
            BtClick.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtClick.ForeColor = SystemColors.ButtonHighlight;
            BtClick.Location = new Point(92, 210);
            BtClick.Margin = new Padding(4);
            BtClick.Name = "BtClick";
            BtClick.Size = new Size(131, 50);
            BtClick.TabIndex = 1;
            BtClick.Text = "Click";
            BtClick.UseVisualStyleBackColor = false;
            BtClick.Click += BtClick_Click;
            // 
            // Display
            // 
            Display.AutoSize = true;
            Display.Font = new Font("Ink Free", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Display.Location = new Point(236, 91);
            Display.Margin = new Padding(4, 0, 4, 0);
            Display.Name = "Display";
            Display.Size = new Size(36, 39);
            Display.TabIndex = 0;
            Display.Text = "0";
            Display.Click += Display_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 445);
            Controls.Add(tabControl1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Ejercicios Semana 1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox TbContraseña;
        private Label label3;
        private TextBox TbUsuario;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button BtLogin;
        private Button BtCalcular;
        private TextBox TbPeso;
        private Label label4;
        private TextBox TbAltura;
        private Label label5;
        private Label label6;
        private Button BtConvertir;
        private TextBox TbTemperatura;
        private Label label7;
        private Label label9;
        private ComboBox CbConversion;
        private Button BtReset;
        private Button BtClick;
        private Label Display;
    }
}
