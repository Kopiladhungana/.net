namespace calculator
{
    partial class Form1
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
            this.label5 = new System.Windows.Forms.Label();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxoperand2 = new System.Windows.Forms.TextBox();
            this.textBoxoperand1 = new System.Windows.Forms.TextBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btndel = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnequals = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.radioButtonfloor = new System.Windows.Forms.RadioButton();
            this.radioButtonceiling = new System.Windows.Forms.RadioButton();
            this.btncos = new System.Windows.Forms.Button();
            this.btnsqrt = new System.Windows.Forms.Button();
            this.btnsine = new System.Windows.Forms.Button();
            this.btnlog = new System.Windows.Forms.Button();
            this.btntan = new System.Windows.Forms.Button();
            this.radioBtndegrees = new System.Windows.Forms.RadioButton();
            this.radioBtnradian = new System.Windows.Forms.RadioButton();
            this.btnpi = new System.Windows.Forms.Button();
            this.btnoff = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btnplusminus = new System.Windows.Forms.Button();
            this.btnx = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncosinverse = new System.Windows.Forms.Button();
            this.btntaninverse = new System.Windows.Forms.Button();
            this.btnsininverse = new System.Windows.Forms.Button();
            this.lblcalculator = new System.Windows.Forms.Label();
            this.btnsquare = new System.Windows.Forms.Button();
            this.btncube = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Choose Option";
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(152, 281);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 36);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click_1);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(19, 281);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(61, 35);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click_1);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(86, 281);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 36);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Add",
            "Subtract",
            "Multiply",
            "Divide"});
            this.comboBox1.Location = new System.Drawing.Point(152, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(117, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // textBoxoperand2
            // 
            this.textBoxoperand2.Location = new System.Drawing.Point(286, 60);
            this.textBoxoperand2.Multiline = true;
            this.textBoxoperand2.Name = "textBoxoperand2";
            this.textBoxoperand2.Size = new System.Drawing.Size(128, 20);
            this.textBoxoperand2.TabIndex = 20;
            this.textBoxoperand2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxoperand2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxoperand2_KeyPress);
            // 
            // textBoxoperand1
            // 
            this.textBoxoperand1.Location = new System.Drawing.Point(24, 63);
            this.textBoxoperand1.Multiline = true;
            this.textBoxoperand1.Name = "textBoxoperand1";
            this.textBoxoperand1.Size = new System.Drawing.Size(106, 20);
            this.textBoxoperand1.TabIndex = 19;
            this.textBoxoperand1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxoperand1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtoperand1keypress);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(19, 176);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(193, 20);
            this.txtDisplay.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "RESULT";
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(153, 323);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(59, 30);
            this.btndel.TabIndex = 17;
            this.btndel.Text = "DEL";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click_1);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(219, 133);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(59, 31);
            this.btnclear.TabIndex = 18;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click_1);
            // 
            // btnequals
            // 
            this.btnequals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnequals.Location = new System.Drawing.Point(417, 133);
            this.btnequals.Name = "btnequals";
            this.btnequals.Size = new System.Drawing.Size(54, 223);
            this.btnequals.TabIndex = 2;
            this.btnequals.Text = "=";
            this.btnequals.UseVisualStyleBackColor = true;
            this.btnequals.Click += new System.EventHandler(this.btnequals_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(152, 208);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 31);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click_1);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(153, 245);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(59, 31);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click_1);
            // 
            // btn10
            // 
            this.btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.Location = new System.Drawing.Point(88, 323);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(58, 31);
            this.btn10.TabIndex = 1;
            this.btn10.Text = ".";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click_1);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(20, 322);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 31);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click_1);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(86, 208);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 33);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click_1);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(86, 245);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 33);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click_1);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(20, 208);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 31);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click_1);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(19, 245);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(61, 31);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click_1);
            // 
            // radioButtonfloor
            // 
            this.radioButtonfloor.AutoSize = true;
            this.radioButtonfloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonfloor.Location = new System.Drawing.Point(104, 369);
            this.radioButtonfloor.Name = "radioButtonfloor";
            this.radioButtonfloor.Size = new System.Drawing.Size(83, 20);
            this.radioButtonfloor.TabIndex = 15;
            this.radioButtonfloor.TabStop = true;
            this.radioButtonfloor.Text = "Flooring";
            this.radioButtonfloor.UseVisualStyleBackColor = true;
            this.radioButtonfloor.CheckedChanged += new System.EventHandler(this.radioButtonfloor_CheckedChanged);
            // 
            // radioButtonceiling
            // 
            this.radioButtonceiling.AutoSize = true;
            this.radioButtonceiling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonceiling.Location = new System.Drawing.Point(24, 369);
            this.radioButtonceiling.Name = "radioButtonceiling";
            this.radioButtonceiling.Size = new System.Drawing.Size(74, 20);
            this.radioButtonceiling.TabIndex = 14;
            this.radioButtonceiling.TabStop = true;
            this.radioButtonceiling.Text = "Ceiling";
            this.radioButtonceiling.UseVisualStyleBackColor = true;
            this.radioButtonceiling.CheckedChanged += new System.EventHandler(this.radioButtonceiling_CheckedChanged);
            // 
            // btncos
            // 
            this.btncos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncos.Location = new System.Drawing.Point(219, 281);
            this.btncos.Name = "btncos";
            this.btncos.Size = new System.Drawing.Size(61, 35);
            this.btncos.TabIndex = 27;
            this.btncos.Text = "Cos";
            this.btncos.UseVisualStyleBackColor = true;
            this.btncos.Click += new System.EventHandler(this.btncos_Click);
            // 
            // btnsqrt
            // 
            this.btnsqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsqrt.Location = new System.Drawing.Point(286, 322);
            this.btnsqrt.Name = "btnsqrt";
            this.btnsqrt.Size = new System.Drawing.Size(52, 31);
            this.btnsqrt.TabIndex = 26;
            this.btnsqrt.Text = "Sqrt";
            this.btnsqrt.UseVisualStyleBackColor = true;
            this.btnsqrt.Click += new System.EventHandler(this.btnsqrt_Click);
            // 
            // btnsine
            // 
            this.btnsine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsine.Location = new System.Drawing.Point(220, 322);
            this.btnsine.Name = "btnsine";
            this.btnsine.Size = new System.Drawing.Size(60, 31);
            this.btnsine.TabIndex = 25;
            this.btnsine.Text = "Sine";
            this.btnsine.UseVisualStyleBackColor = true;
            this.btnsine.Click += new System.EventHandler(this.btnsine_Click);
            // 
            // btnlog
            // 
            this.btnlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlog.Location = new System.Drawing.Point(220, 208);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(60, 31);
            this.btnlog.TabIndex = 33;
            this.btnlog.Text = "log";
            this.btnlog.UseVisualStyleBackColor = true;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // btntan
            // 
            this.btntan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntan.Location = new System.Drawing.Point(219, 245);
            this.btntan.Name = "btntan";
            this.btntan.Size = new System.Drawing.Size(61, 31);
            this.btntan.TabIndex = 30;
            this.btntan.Text = "tan";
            this.btntan.UseVisualStyleBackColor = true;
            this.btntan.Click += new System.EventHandler(this.btntan_Click);
            // 
            // radioBtndegrees
            // 
            this.radioBtndegrees.AutoSize = true;
            this.radioBtndegrees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtndegrees.Location = new System.Drawing.Point(204, 369);
            this.radioBtndegrees.Name = "radioBtndegrees";
            this.radioBtndegrees.Size = new System.Drawing.Size(86, 20);
            this.radioBtndegrees.TabIndex = 16;
            this.radioBtndegrees.TabStop = true;
            this.radioBtndegrees.Text = "Degrees";
            this.radioBtndegrees.UseVisualStyleBackColor = true;
            // 
            // radioBtnradian
            // 
            this.radioBtnradian.AutoSize = true;
            this.radioBtnradian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnradian.Location = new System.Drawing.Point(296, 369);
            this.radioBtnradian.Name = "radioBtnradian";
            this.radioBtnradian.Size = new System.Drawing.Size(84, 20);
            this.radioBtnradian.TabIndex = 17;
            this.radioBtnradian.TabStop = true;
            this.radioBtnradian.Text = "Radians";
            this.radioBtnradian.UseVisualStyleBackColor = true;
            // 
            // btnpi
            // 
            this.btnpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpi.Location = new System.Drawing.Point(286, 281);
            this.btnpi.Name = "btnpi";
            this.btnpi.Size = new System.Drawing.Size(52, 33);
            this.btnpi.TabIndex = 37;
            this.btnpi.Text = "PI";
            this.btnpi.UseVisualStyleBackColor = true;
            this.btnpi.Click += new System.EventHandler(this.btnpi_Click);
            // 
            // btnoff
            // 
            this.btnoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoff.Location = new System.Drawing.Point(351, 133);
            this.btnoff.Name = "btnoff";
            this.btnoff.Size = new System.Drawing.Size(60, 68);
            this.btnoff.TabIndex = 38;
            this.btnoff.Text = "OFF";
            this.btnoff.UseVisualStyleBackColor = true;
            this.btnoff.Click += new System.EventHandler(this.btnoff_Click);
            // 
            // btnAC
            // 
            this.btnAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAC.Location = new System.Drawing.Point(283, 133);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(62, 31);
            this.btnAC.TabIndex = 39;
            this.btnAC.Text = "AC";
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // btn20
            // 
            this.btn20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20.Location = new System.Drawing.Point(218, 170);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(59, 31);
            this.btn20.TabIndex = 40;
            this.btn20.Text = "1/x";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click_1);
            // 
            // btnplusminus
            // 
            this.btnplusminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplusminus.Location = new System.Drawing.Point(286, 169);
            this.btnplusminus.Name = "btnplusminus";
            this.btnplusminus.Size = new System.Drawing.Size(52, 31);
            this.btnplusminus.TabIndex = 41;
            this.btnplusminus.Text = "+/-";
            this.btnplusminus.UseVisualStyleBackColor = true;
            this.btnplusminus.Click += new System.EventHandler(this.btnplusminus_Click);
            // 
            // btnx
            // 
            this.btnx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnx.Location = new System.Drawing.Point(286, 206);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(52, 31);
            this.btnx.TabIndex = 42;
            this.btnx.Text = "x!";
            this.btnx.UseVisualStyleBackColor = true;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btncube);
            this.panel1.Controls.Add(this.btncosinverse);
            this.panel1.Controls.Add(this.btntaninverse);
            this.panel1.Controls.Add(this.btnsininverse);
            this.panel1.Controls.Add(this.lblcalculator);
            this.panel1.Controls.Add(this.btnsquare);
            this.panel1.Controls.Add(this.btnx);
            this.panel1.Controls.Add(this.btnplusminus);
            this.panel1.Controls.Add(this.btn20);
            this.panel1.Controls.Add(this.btnAC);
            this.panel1.Controls.Add(this.btnoff);
            this.panel1.Controls.Add(this.btnpi);
            this.panel1.Controls.Add(this.radioBtnradian);
            this.panel1.Controls.Add(this.radioBtndegrees);
            this.panel1.Controls.Add(this.btncos);
            this.panel1.Controls.Add(this.btnsqrt);
            this.panel1.Controls.Add(this.btnsine);
            this.panel1.Controls.Add(this.btnlog);
            this.panel1.Controls.Add(this.btntan);
            this.panel1.Controls.Add(this.radioButtonfloor);
            this.panel1.Controls.Add(this.radioButtonceiling);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btnequals);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btndel);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn10);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.textBoxoperand1);
            this.panel1.Controls.Add(this.txtDisplay);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxoperand2);
            this.panel1.Location = new System.Drawing.Point(62, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 406);
            this.panel1.TabIndex = 43;
            // 
            // btncosinverse
            // 
            this.btncosinverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncosinverse.Location = new System.Drawing.Point(351, 281);
            this.btncosinverse.Name = "btncosinverse";
            this.btncosinverse.Size = new System.Drawing.Size(60, 33);
            this.btncosinverse.TabIndex = 47;
            this.btncosinverse.Text = "cos-1";
            this.btncosinverse.UseVisualStyleBackColor = true;
            this.btncosinverse.Click += new System.EventHandler(this.btncosinverse_Click);
            // 
            // btntaninverse
            // 
            this.btntaninverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntaninverse.Location = new System.Drawing.Point(351, 322);
            this.btntaninverse.Name = "btntaninverse";
            this.btntaninverse.Size = new System.Drawing.Size(60, 31);
            this.btntaninverse.TabIndex = 46;
            this.btntaninverse.Text = "tan-1";
            this.btntaninverse.UseVisualStyleBackColor = true;
            this.btntaninverse.Click += new System.EventHandler(this.btntaninverse_Click);
            // 
            // btnsininverse
            // 
            this.btnsininverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsininverse.Location = new System.Drawing.Point(351, 243);
            this.btnsininverse.Name = "btnsininverse";
            this.btnsininverse.Size = new System.Drawing.Size(60, 32);
            this.btnsininverse.TabIndex = 45;
            this.btnsininverse.Text = "sin-1";
            this.btnsininverse.UseVisualStyleBackColor = true;
            this.btnsininverse.Click += new System.EventHandler(this.btnsininverse_Click);
            // 
            // lblcalculator
            // 
            this.lblcalculator.AutoSize = true;
            this.lblcalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalculator.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblcalculator.Location = new System.Drawing.Point(70, 0);
            this.lblcalculator.Name = "lblcalculator";
            this.lblcalculator.Size = new System.Drawing.Size(220, 33);
            this.lblcalculator.TabIndex = 44;
            this.lblcalculator.Text = "CALCULATOR";
            // 
            // btnsquare
            // 
            this.btnsquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsquare.Location = new System.Drawing.Point(286, 243);
            this.btnsquare.Name = "btnsquare";
            this.btnsquare.Size = new System.Drawing.Size(52, 33);
            this.btnsquare.TabIndex = 43;
            this.btnsquare.Text = "x^2";
            this.btnsquare.UseVisualStyleBackColor = true;
            this.btnsquare.Click += new System.EventHandler(this.btnsquare_Click);
            // 
            // btncube
            // 
            this.btncube.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncube.Location = new System.Drawing.Point(351, 208);
            this.btncube.Name = "btncube";
            this.btncube.Size = new System.Drawing.Size(60, 31);
            this.btncube.TabIndex = 48;
            this.btncube.Text = "x^3";
            this.btncube.UseVisualStyleBackColor = true;
            this.btncube.Click += new System.EventHandler(this.btncube_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 485);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxoperand2;
        private System.Windows.Forms.TextBox textBoxoperand1;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnequals;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.RadioButton radioButtonfloor;
        private System.Windows.Forms.RadioButton radioButtonceiling;
        private System.Windows.Forms.Button btncos;
        private System.Windows.Forms.Button btnsqrt;
        private System.Windows.Forms.Button btnsine;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Button btntan;
        private System.Windows.Forms.RadioButton radioBtndegrees;
        private System.Windows.Forms.RadioButton radioBtnradian;
        private System.Windows.Forms.Button btnpi;
        private System.Windows.Forms.Button btnoff;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btnplusminus;
        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsquare;
        private System.Windows.Forms.Label lblcalculator;
        private System.Windows.Forms.Button btnsininverse;
        private System.Windows.Forms.Button btncosinverse;
        private System.Windows.Forms.Button btntaninverse;
        private System.Windows.Forms.Button btncube;


    }
}

