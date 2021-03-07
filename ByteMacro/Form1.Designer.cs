
namespace ByteMacro
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAutoclicker = new System.Windows.Forms.TabPage();
            this.autoclickToggle = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.autoclickDelay = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.autoclickKey = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numericY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.trigKey = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxToggle = new System.Windows.Forms.CheckBox();
            this.checkBoxEnter = new System.Windows.Forms.CheckBox();
            this.checkBoxSpace = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.macroOutput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.macroDelay = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.macroKey = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.aimToggle = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.coords1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.coords2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.targetCol = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.aimKey = new System.Windows.Forms.TextBox();
            this.btnCursorDetails = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabAutoclicker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoclickDelay)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.macroDelay)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAutoclicker);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(14, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(495, 190);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAutoclicker
            // 
            this.tabAutoclicker.Controls.Add(this.autoclickToggle);
            this.tabAutoclicker.Controls.Add(this.label13);
            this.tabAutoclicker.Controls.Add(this.autoclickDelay);
            this.tabAutoclicker.Controls.Add(this.label14);
            this.tabAutoclicker.Controls.Add(this.autoclickKey);
            this.tabAutoclicker.Location = new System.Drawing.Point(4, 24);
            this.tabAutoclicker.Name = "tabAutoclicker";
            this.tabAutoclicker.Padding = new System.Windows.Forms.Padding(3);
            this.tabAutoclicker.Size = new System.Drawing.Size(487, 162);
            this.tabAutoclicker.TabIndex = 3;
            this.tabAutoclicker.Text = "Autoclicker";
            this.tabAutoclicker.UseVisualStyleBackColor = true;
            // 
            // autoclickToggle
            // 
            this.autoclickToggle.AutoSize = true;
            this.autoclickToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoclickToggle.Location = new System.Drawing.Point(344, 30);
            this.autoclickToggle.Name = "autoclickToggle";
            this.autoclickToggle.Size = new System.Drawing.Size(114, 19);
            this.autoclickToggle.TabIndex = 14;
            this.autoclickToggle.Text = "Toggle(On)/(Off)";
            this.autoclickToggle.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(8, 84);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "Delay(ms)";
            // 
            // autoclickDelay
            // 
            this.autoclickDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoclickDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.autoclickDelay.Location = new System.Drawing.Point(13, 111);
            this.autoclickDelay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.autoclickDelay.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.autoclickDelay.Name = "autoclickDelay";
            this.autoclickDelay.Size = new System.Drawing.Size(148, 26);
            this.autoclickDelay.TabIndex = 8;
            this.autoclickDelay.UseWaitCursor = true;
            this.autoclickDelay.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(13, 7);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "Key";
            // 
            // autoclickKey
            // 
            this.autoclickKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoclickKey.Location = new System.Drawing.Point(13, 30);
            this.autoclickKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.autoclickKey.Name = "autoclickKey";
            this.autoclickKey.Size = new System.Drawing.Size(139, 26);
            this.autoclickKey.TabIndex = 6;
            this.autoclickKey.Text = "t";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numericY);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numericX);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.trigKey);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(487, 162);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Triggerbot";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // numericY
            // 
            this.numericY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericY.Location = new System.Drawing.Point(188, 110);
            this.numericY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericY.Name = "numericY";
            this.numericY.Size = new System.Drawing.Size(148, 26);
            this.numericY.TabIndex = 5;
            this.numericY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(183, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "OffsetY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "OffsetX";
            // 
            // numericX
            // 
            this.numericX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericX.Location = new System.Drawing.Point(12, 110);
            this.numericX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericX.Name = "numericX";
            this.numericX.Size = new System.Drawing.Size(148, 26);
            this.numericX.TabIndex = 2;
            this.numericX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key";
            // 
            // trigKey
            // 
            this.trigKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trigKey.Location = new System.Drawing.Point(12, 35);
            this.trigKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trigKey.Name = "trigKey";
            this.trigKey.Size = new System.Drawing.Size(139, 26);
            this.trigKey.TabIndex = 0;
            this.trigKey.Text = "t";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxToggle);
            this.tabPage2.Controls.Add(this.checkBoxEnter);
            this.tabPage2.Controls.Add(this.checkBoxSpace);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.macroOutput);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.macroDelay);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.macroKey);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(487, 162);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Macro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxToggle
            // 
            this.checkBoxToggle.AutoSize = true;
            this.checkBoxToggle.Checked = true;
            this.checkBoxToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxToggle.Location = new System.Drawing.Point(329, 20);
            this.checkBoxToggle.Name = "checkBoxToggle";
            this.checkBoxToggle.Size = new System.Drawing.Size(123, 19);
            this.checkBoxToggle.TabIndex = 13;
            this.checkBoxToggle.Text = "Toggle(F)/Hold(T)";
            this.checkBoxToggle.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnter
            // 
            this.checkBoxEnter.AutoSize = true;
            this.checkBoxEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxEnter.Location = new System.Drawing.Point(329, 71);
            this.checkBoxEnter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxEnter.Name = "checkBoxEnter";
            this.checkBoxEnter.Size = new System.Drawing.Size(95, 20);
            this.checkBoxEnter.TabIndex = 12;
            this.checkBoxEnter.Text = "Press Enter";
            this.checkBoxEnter.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpace
            // 
            this.checkBoxSpace.AutoSize = true;
            this.checkBoxSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxSpace.Location = new System.Drawing.Point(329, 45);
            this.checkBoxSpace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxSpace.Name = "checkBoxSpace";
            this.checkBoxSpace.Size = new System.Drawing.Size(107, 20);
            this.checkBoxSpace.TabIndex = 11;
            this.checkBoxSpace.Text = "Space Macro";
            this.checkBoxSpace.UseVisualStyleBackColor = true;
            this.checkBoxSpace.CheckedChanged += new System.EventHandler(this.checkBoxSpace_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(162, 85);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Macro Output";
            // 
            // macroOutput
            // 
            this.macroOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.macroOutput.Location = new System.Drawing.Point(162, 112);
            this.macroOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.macroOutput.Name = "macroOutput";
            this.macroOutput.Size = new System.Drawing.Size(316, 26);
            this.macroOutput.TabIndex = 6;
            this.macroOutput.Text = "aaa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(2, 85);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Delay(ms)";
            // 
            // macroDelay
            // 
            this.macroDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.macroDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.macroDelay.Location = new System.Drawing.Point(7, 112);
            this.macroDelay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.macroDelay.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.macroDelay.Name = "macroDelay";
            this.macroDelay.Size = new System.Drawing.Size(148, 26);
            this.macroDelay.TabIndex = 4;
            this.macroDelay.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(2, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Key";
            // 
            // macroKey
            // 
            this.macroKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.macroKey.Location = new System.Drawing.Point(7, 35);
            this.macroKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.macroKey.Name = "macroKey";
            this.macroKey.Size = new System.Drawing.Size(139, 26);
            this.macroKey.TabIndex = 2;
            this.macroKey.Text = "space";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.aimToggle);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.coords1);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.coords2);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.targetCol);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.aimKey);
            this.tabPage3.Controls.Add(this.btnCursorDetails);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Size = new System.Drawing.Size(487, 162);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Color Aimbot";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(214, 30);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "BROKEN!!!";
            // 
            // aimToggle
            // 
            this.aimToggle.AutoSize = true;
            this.aimToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aimToggle.Location = new System.Drawing.Point(163, 129);
            this.aimToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aimToggle.Name = "aimToggle";
            this.aimToggle.Size = new System.Drawing.Size(115, 20);
            this.aimToggle.TabIndex = 10;
            this.aimToggle.Text = "Toggle Aimbot";
            this.aimToggle.UseVisualStyleBackColor = true;
            this.aimToggle.CheckedChanged += new System.EventHandler(this.aimToggle_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(7, 61);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "X1,Y1";
            // 
            // coords1
            // 
            this.coords1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coords1.Location = new System.Drawing.Point(12, 88);
            this.coords1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.coords1.Name = "coords1";
            this.coords1.Size = new System.Drawing.Size(139, 26);
            this.coords1.TabIndex = 8;
            this.coords1.Text = "0,0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(154, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "X2,Y2";
            // 
            // coords2
            // 
            this.coords2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coords2.Location = new System.Drawing.Point(159, 88);
            this.coords2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.coords2.Name = "coords2";
            this.coords2.Size = new System.Drawing.Size(139, 26);
            this.coords2.TabIndex = 6;
            this.coords2.Text = "0,0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(301, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Target Color(R,G,B)";
            // 
            // targetCol
            // 
            this.targetCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.targetCol.Location = new System.Drawing.Point(306, 88);
            this.targetCol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.targetCol.Name = "targetCol";
            this.targetCol.Size = new System.Drawing.Size(139, 26);
            this.targetCol.TabIndex = 4;
            this.targetCol.Text = "255,255,255";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(7, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Key";
            // 
            // aimKey
            // 
            this.aimKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aimKey.Location = new System.Drawing.Point(12, 30);
            this.aimKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aimKey.Name = "aimKey";
            this.aimKey.Size = new System.Drawing.Size(139, 26);
            this.aimKey.TabIndex = 2;
            this.aimKey.Text = "e";
            // 
            // btnCursorDetails
            // 
            this.btnCursorDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCursorDetails.Location = new System.Drawing.Point(12, 125);
            this.btnCursorDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCursorDetails.Name = "btnCursorDetails";
            this.btnCursorDetails.Size = new System.Drawing.Size(140, 29);
            this.btnCursorDetails.TabIndex = 0;
            this.btnCursorDetails.Text = "Cursor Details";
            this.btnCursorDetails.UseVisualStyleBackColor = true;
            this.btnCursorDetails.Click += new System.EventHandler(this.btnCursorDetails_Click);
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.output.Location = new System.Drawing.Point(14, 230);
            this.output.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(494, 72);
            this.output.TabIndex = 1;
            this.output.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 313);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.output);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Multi Usage Macro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabAutoclicker.ResumeLayout(false);
            this.tabAutoclicker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoclickDelay)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.macroDelay)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox trigKey;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.NumericUpDown numericY;
        public System.Windows.Forms.NumericUpDown numericX;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox macroKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCursorDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox targetCol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox aimKey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox coords1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox coords2;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.NumericUpDown macroDelay;
        private System.Windows.Forms.CheckBox aimToggle;
        private System.Windows.Forms.CheckBox checkBoxEnter;
        private System.Windows.Forms.CheckBox checkBoxSpace;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox macroOutput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBoxToggle;
        private System.Windows.Forms.TabPage tabAutoclicker;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.NumericUpDown autoclickDelay;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox autoclickKey;
        private System.Windows.Forms.CheckBox autoclickToggle;
    }
}

