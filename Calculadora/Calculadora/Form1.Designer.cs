namespace Calculadora
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
            this.textpantalla = new System.Windows.Forms.TextBox();
            this.buttonmas = new System.Windows.Forms.Button();
            this.buttonmenos = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonCe = new System.Windows.Forms.Button();
            this.buttonsuma = new System.Windows.Forms.Button();
            this.buttonresta = new System.Windows.Forms.Button();
            this.buttondivision = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonmod = new System.Windows.Forms.Button();
            this.buttonpotencia = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonraiz = new System.Windows.Forms.Button();
            this.buttonpi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonANS = new System.Windows.Forms.Button();
            this.buttondoble0 = new System.Windows.Forms.Button();
            this.buttonpunto = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonlog = new System.Windows.Forms.Button();
            this.buttonigual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textpantalla
            // 
            this.textpantalla.BackColor = System.Drawing.Color.Silver;
            this.textpantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpantalla.Location = new System.Drawing.Point(20, 49);
            this.textpantalla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textpantalla.MaxLength = 20;
            this.textpantalla.Multiline = true;
            this.textpantalla.Name = "textpantalla";
            this.textpantalla.ReadOnly = true;
            this.textpantalla.Size = new System.Drawing.Size(372, 79);
            this.textpantalla.TabIndex = 0;
            this.textpantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonmas
            // 
            this.buttonmas.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonmas.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmas.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonmas.Location = new System.Drawing.Point(18, 154);
            this.buttonmas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonmas.Name = "buttonmas";
            this.buttonmas.Size = new System.Drawing.Size(68, 69);
            this.buttonmas.TabIndex = 1;
            this.buttonmas.Text = "M+";
            this.buttonmas.UseVisualStyleBackColor = false;
            this.buttonmas.Click += new System.EventHandler(this.buttonmas_Click);
            // 
            // buttonmenos
            // 
            this.buttonmenos.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonmenos.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmenos.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonmenos.Location = new System.Drawing.Point(94, 154);
            this.buttonmenos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonmenos.Name = "buttonmenos";
            this.buttonmenos.Size = new System.Drawing.Size(68, 69);
            this.buttonmenos.TabIndex = 2;
            this.buttonmenos.Text = "M-";
            this.buttonmenos.UseVisualStyleBackColor = false;
            this.buttonmenos.Click += new System.EventHandler(this.buttonmenos_Click);
            // 
            // buttonMR
            // 
            this.buttonMR.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonMR.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMR.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonMR.Location = new System.Drawing.Point(171, 154);
            this.buttonMR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(68, 69);
            this.buttonMR.TabIndex = 3;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = false;
            this.buttonMR.Click += new System.EventHandler(this.buttonMR_Click);
            // 
            // buttonMC
            // 
            this.buttonMC.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonMC.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMC.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonMC.Location = new System.Drawing.Point(248, 154);
            this.buttonMC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(68, 69);
            this.buttonMC.TabIndex = 4;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = false;
            this.buttonMC.Click += new System.EventHandler(this.buttonMC_Click);
            // 
            // buttonCe
            // 
            this.buttonCe.BackColor = System.Drawing.Color.DarkRed;
            this.buttonCe.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCe.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonCe.Location = new System.Drawing.Point(324, 154);
            this.buttonCe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCe.Name = "buttonCe";
            this.buttonCe.Size = new System.Drawing.Size(68, 69);
            this.buttonCe.TabIndex = 5;
            this.buttonCe.Text = "CE";
            this.buttonCe.UseVisualStyleBackColor = false;
            this.buttonCe.Click += new System.EventHandler(this.buttonCe_Click);
            // 
            // buttonsuma
            // 
            this.buttonsuma.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonsuma.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsuma.Location = new System.Drawing.Point(18, 232);
            this.buttonsuma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonsuma.Name = "buttonsuma";
            this.buttonsuma.Size = new System.Drawing.Size(68, 69);
            this.buttonsuma.TabIndex = 6;
            this.buttonsuma.Text = "+";
            this.buttonsuma.UseVisualStyleBackColor = false;
            this.buttonsuma.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // buttonresta
            // 
            this.buttonresta.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonresta.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonresta.Location = new System.Drawing.Point(94, 232);
            this.buttonresta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonresta.Name = "buttonresta";
            this.buttonresta.Size = new System.Drawing.Size(68, 69);
            this.buttonresta.TabIndex = 7;
            this.buttonresta.Text = "-";
            this.buttonresta.UseVisualStyleBackColor = false;
            this.buttonresta.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // buttondivision
            // 
            this.buttondivision.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttondivision.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondivision.Location = new System.Drawing.Point(171, 232);
            this.buttondivision.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttondivision.Name = "buttondivision";
            this.buttondivision.Size = new System.Drawing.Size(68, 69);
            this.buttondivision.TabIndex = 8;
            this.buttondivision.Text = "/";
            this.buttondivision.UseVisualStyleBackColor = false;
            this.buttondivision.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonMul.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMul.Location = new System.Drawing.Point(248, 232);
            this.buttonMul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(68, 69);
            this.buttonMul.TabIndex = 9;
            this.buttonMul.Text = "x";
            this.buttonMul.UseVisualStyleBackColor = false;
            this.buttonMul.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttoneliminar.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneliminar.Location = new System.Drawing.Point(18, 546);
            this.buttoneliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(68, 69);
            this.buttoneliminar.TabIndex = 10;
            this.buttoneliminar.Text = "<-";
            this.buttoneliminar.UseVisualStyleBackColor = false;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.GrayText;
            this.button7.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Cornsilk;
            this.button7.Location = new System.Drawing.Point(95, 311);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 69);
            this.button7.TabIndex = 11;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.GrayText;
            this.button8.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Cornsilk;
            this.button8.Location = new System.Drawing.Point(171, 310);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(68, 69);
            this.button8.TabIndex = 12;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.GrayText;
            this.button9.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Cornsilk;
            this.button9.Location = new System.Drawing.Point(250, 311);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(68, 69);
            this.button9.TabIndex = 13;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // buttonmod
            // 
            this.buttonmod.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonmod.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmod.Location = new System.Drawing.Point(18, 388);
            this.buttonmod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonmod.Name = "buttonmod";
            this.buttonmod.Size = new System.Drawing.Size(68, 69);
            this.buttonmod.TabIndex = 14;
            this.buttonmod.Text = "%";
            this.buttonmod.UseVisualStyleBackColor = false;
            this.buttonmod.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // buttonpotencia
            // 
            this.buttonpotencia.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonpotencia.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpotencia.Location = new System.Drawing.Point(19, 310);
            this.buttonpotencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonpotencia.Name = "buttonpotencia";
            this.buttonpotencia.Size = new System.Drawing.Size(68, 69);
            this.buttonpotencia.TabIndex = 15;
            this.buttonpotencia.Text = "^";
            this.buttonpotencia.UseVisualStyleBackColor = false;
            this.buttonpotencia.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GrayText;
            this.button4.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Cornsilk;
            this.button4.Location = new System.Drawing.Point(95, 390);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 69);
            this.button4.TabIndex = 16;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GrayText;
            this.button5.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Cornsilk;
            this.button5.Location = new System.Drawing.Point(171, 388);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 69);
            this.button5.TabIndex = 17;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GrayText;
            this.button6.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Cornsilk;
            this.button6.Location = new System.Drawing.Point(250, 388);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 69);
            this.button6.TabIndex = 18;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // buttonraiz
            // 
            this.buttonraiz.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonraiz.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonraiz.Location = new System.Drawing.Point(18, 467);
            this.buttonraiz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonraiz.Name = "buttonraiz";
            this.buttonraiz.Size = new System.Drawing.Size(68, 69);
            this.buttonraiz.TabIndex = 19;
            this.buttonraiz.Text = "√";
            this.buttonraiz.UseVisualStyleBackColor = false;
            this.buttonraiz.Click += new System.EventHandler(this.buttonraiz_Click);
            // 
            // buttonpi
            // 
            this.buttonpi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonpi.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpi.Location = new System.Drawing.Point(326, 388);
            this.buttonpi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonpi.Name = "buttonpi";
            this.buttonpi.Size = new System.Drawing.Size(68, 69);
            this.buttonpi.TabIndex = 20;
            this.buttonpi.Text = "π";
            this.buttonpi.UseVisualStyleBackColor = false;
            this.buttonpi.Click += new System.EventHandler(this.buttonpi_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(98, 469);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 69);
            this.button1.TabIndex = 21;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(174, 467);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 69);
            this.button2.TabIndex = 22;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GrayText;
            this.button3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Cornsilk;
            this.button3.Location = new System.Drawing.Point(250, 467);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 69);
            this.button3.TabIndex = 23;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // buttonANS
            // 
            this.buttonANS.BackColor = System.Drawing.Color.DarkRed;
            this.buttonANS.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonANS.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonANS.Location = new System.Drawing.Point(326, 311);
            this.buttonANS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonANS.Name = "buttonANS";
            this.buttonANS.Size = new System.Drawing.Size(66, 69);
            this.buttonANS.TabIndex = 24;
            this.buttonANS.Text = "ANS";
            this.buttonANS.UseVisualStyleBackColor = false;
            this.buttonANS.Click += new System.EventHandler(this.buttonANS_Click);
            // 
            // buttondoble0
            // 
            this.buttondoble0.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttondoble0.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondoble0.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttondoble0.Location = new System.Drawing.Point(324, 467);
            this.buttondoble0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttondoble0.Name = "buttondoble0";
            this.buttondoble0.Size = new System.Drawing.Size(68, 69);
            this.buttondoble0.TabIndex = 25;
            this.buttondoble0.Text = "00";
            this.buttondoble0.UseVisualStyleBackColor = false;
            this.buttondoble0.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // buttonpunto
            // 
            this.buttonpunto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonpunto.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpunto.Location = new System.Drawing.Point(98, 546);
            this.buttonpunto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonpunto.Name = "buttonpunto";
            this.buttonpunto.Size = new System.Drawing.Size(68, 69);
            this.buttonpunto.TabIndex = 26;
            this.buttonpunto.Text = ".";
            this.buttonpunto.UseVisualStyleBackColor = false;
            this.buttonpunto.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.GrayText;
            this.button0.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.ForeColor = System.Drawing.Color.Cornsilk;
            this.button0.Location = new System.Drawing.Point(174, 546);
            this.button0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(68, 69);
            this.button0.TabIndex = 27;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // buttonlog
            // 
            this.buttonlog.BackColor = System.Drawing.Color.DarkRed;
            this.buttonlog.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlog.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonlog.Location = new System.Drawing.Point(324, 232);
            this.buttonlog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonlog.Name = "buttonlog";
            this.buttonlog.Size = new System.Drawing.Size(68, 69);
            this.buttonlog.TabIndex = 28;
            this.buttonlog.Text = "log";
            this.buttonlog.UseVisualStyleBackColor = false;
            this.buttonlog.Click += new System.EventHandler(this.buttonlog_Click);
            // 
            // buttonigual
            // 
            this.buttonigual.BackColor = System.Drawing.Color.DarkRed;
            this.buttonigual.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonigual.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonigual.Location = new System.Drawing.Point(248, 546);
            this.buttonigual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonigual.Name = "buttonigual";
            this.buttonigual.Size = new System.Drawing.Size(144, 69);
            this.buttonigual.TabIndex = 29;
            this.buttonigual.Text = "=";
            this.buttonigual.UseVisualStyleBackColor = false;
            this.buttonigual.Click += new System.EventHandler(this.buttonigual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(410, 624);
            this.Controls.Add(this.buttonigual);
            this.Controls.Add(this.buttonlog);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonpunto);
            this.Controls.Add(this.buttondoble0);
            this.Controls.Add(this.buttonANS);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonpi);
            this.Controls.Add(this.buttonraiz);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonpotencia);
            this.Controls.Add(this.buttonmod);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttondivision);
            this.Controls.Add(this.buttonresta);
            this.Controls.Add(this.buttonsuma);
            this.Controls.Add(this.buttonCe);
            this.Controls.Add(this.buttonMC);
            this.Controls.Add(this.buttonMR);
            this.Controls.Add(this.buttonmenos);
            this.Controls.Add(this.buttonmas);
            this.Controls.Add(this.textpantalla);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textpantalla;
        private System.Windows.Forms.Button buttonmas;
        private System.Windows.Forms.Button buttonmenos;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonCe;
        private System.Windows.Forms.Button buttonsuma;
        private System.Windows.Forms.Button buttonresta;
        private System.Windows.Forms.Button buttondivision;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonmod;
        private System.Windows.Forms.Button buttonpotencia;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonraiz;
        private System.Windows.Forms.Button buttonpi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonANS;
        private System.Windows.Forms.Button buttondoble0;
        private System.Windows.Forms.Button buttonpunto;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonlog;
        private System.Windows.Forms.Button buttonigual;
    }
}

