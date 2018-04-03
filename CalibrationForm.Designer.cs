using System;
using System.Windows.Forms;

namespace GD77_FlashManager
{
	partial class CalibrationForm
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
			this.tabVHF = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.tabUHF = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.nudVhfOscRef = new System.Windows.Forms.NumericUpDown();
			this.nudUhfOscRef = new System.Windows.Forms.NumericUpDown();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.nudUhfSquelchNarrowNormClose = new System.Windows.Forms.NumericUpDown();
			this.nudUhfSquelchWideNormClose = new System.Windows.Forms.NumericUpDown();
			this.nudUhfSquelchNarrowNormOpen = new System.Windows.Forms.NumericUpDown();
			this.nudUhfSquelchWideNormOpen = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.nudUhfSquelchNarrowTightClose = new System.Windows.Forms.NumericUpDown();
			this.nudUhfSquelchWideTightClose = new System.Windows.Forms.NumericUpDown();
			this.nudUhfSquelchNarrowTightOpen = new System.Windows.Forms.NumericUpDown();
			this.nudUhfSquelchWideTightOpen = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.nudVhfSquelchNarrowTightClose = new System.Windows.Forms.NumericUpDown();
			this.nudVhfSquelchWideTightClose = new System.Windows.Forms.NumericUpDown();
			this.nudVhfSquelchNarrowTightOpen = new System.Windows.Forms.NumericUpDown();
			this.nudVhfSquelchWideTightOpen = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.nudVhfSquelchNarrowNormClose = new System.Windows.Forms.NumericUpDown();
			this.nudVhfSquelchWideNormClose = new System.Windows.Forms.NumericUpDown();
			this.nudVhfSquelchNarrowNormOpen = new System.Windows.Forms.NumericUpDown();
			this.nudVhfSquelchWideNormOpen = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabVHF.SuspendLayout();
			this.tabUHF.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudVhfOscRef)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudUhfOscRef)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudUhfSquelchNarrowNormClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudUhfSquelchWideNormClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudUhfSquelchNarrowNormOpen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudUhfSquelchWideNormOpen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudUhfSquelchNarrowTightClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudUhfSquelchWideTightClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudUhfSquelchNarrowTightOpen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudUhfSquelchWideTightOpen)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudVhfSquelchNarrowTightClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudVhfSquelchWideTightClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudVhfSquelchNarrowTightOpen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudVhfSquelchWideTightOpen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudVhfSquelchNarrowNormClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudVhfSquelchWideNormClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudVhfSquelchNarrowNormOpen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudVhfSquelchWideNormOpen)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabVHF);
			this.tabControl1.Controls.Add(this.tabUHF);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(531, 408);
			this.tabControl1.TabIndex = 0;
			// 
			// tabVHF
			// 
			this.tabVHF.Controls.Add(this.groupBox1);
			this.tabVHF.Controls.Add(this.nudVhfOscRef);
			this.tabVHF.Controls.Add(this.label1);
			this.tabVHF.Location = new System.Drawing.Point(4, 22);
			this.tabVHF.Name = "tabVHF";
			this.tabVHF.Padding = new System.Windows.Forms.Padding(3);
			this.tabVHF.Size = new System.Drawing.Size(523, 382);
			this.tabVHF.TabIndex = 0;
			this.tabVHF.Text = "VHF";
			this.tabVHF.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Reference oscillator tuning\t";
			// 
			// tabUHF
			// 
			this.tabUHF.Controls.Add(this.groupBox2);
			this.tabUHF.Controls.Add(this.nudUhfOscRef);
			this.tabUHF.Controls.Add(this.label2);
			this.tabUHF.Location = new System.Drawing.Point(4, 22);
			this.tabUHF.Name = "tabUHF";
			this.tabUHF.Padding = new System.Windows.Forms.Padding(3);
			this.tabUHF.Size = new System.Drawing.Size(523, 382);
			this.tabUHF.TabIndex = 1;
			this.tabUHF.Text = "UHF";
			this.tabUHF.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Reference oscillator tuning\t";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(370, 436);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(464, 436);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// nudVhfOscRef
			// 
			this.nudVhfOscRef.Location = new System.Drawing.Point(145, 13);
			this.nudVhfOscRef.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nudVhfOscRef.Name = "nudVhfOscRef";
			this.nudVhfOscRef.Size = new System.Drawing.Size(63, 20);
			this.nudVhfOscRef.TabIndex = 2;
			// 
			// nudUhfOscRef
			// 
			this.nudUhfOscRef.Location = new System.Drawing.Point(145, 15);
			this.nudUhfOscRef.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nudUhfOscRef.Name = "nudUhfOscRef";
			this.nudUhfOscRef.Size = new System.Drawing.Size(61, 20);
			this.nudUhfOscRef.TabIndex = 3;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.nudUhfSquelchNarrowTightClose);
			this.groupBox2.Controls.Add(this.nudUhfSquelchWideTightClose);
			this.groupBox2.Controls.Add(this.nudUhfSquelchNarrowTightOpen);
			this.groupBox2.Controls.Add(this.nudUhfSquelchWideTightOpen);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.nudUhfSquelchNarrowNormClose);
			this.groupBox2.Controls.Add(this.nudUhfSquelchWideNormClose);
			this.groupBox2.Controls.Add(this.nudUhfSquelchNarrowNormOpen);
			this.groupBox2.Controls.Add(this.nudUhfSquelchWideNormOpen);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Location = new System.Drawing.Point(9, 51);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(197, 144);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Squelch";
			// 
			// nudUhfSquelchNarrowNormClose
			// 
			this.nudUhfSquelchNarrowNormClose.Location = new System.Drawing.Point(136, 58);
			this.nudUhfSquelchNarrowNormClose.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudUhfSquelchNarrowNormClose.Name = "nudUhfSquelchNarrowNormClose";
			this.nudUhfSquelchNarrowNormClose.Size = new System.Drawing.Size(41, 20);
			this.nudUhfSquelchNarrowNormClose.TabIndex = 8;
			// 
			// nudUhfSquelchWideNormClose
			// 
			this.nudUhfSquelchWideNormClose.Location = new System.Drawing.Point(76, 58);
			this.nudUhfSquelchWideNormClose.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudUhfSquelchWideNormClose.Name = "nudUhfSquelchWideNormClose";
			this.nudUhfSquelchWideNormClose.Size = new System.Drawing.Size(41, 20);
			this.nudUhfSquelchWideNormClose.TabIndex = 7;
			// 
			// nudUhfSquelchNarrowNormOpen
			// 
			this.nudUhfSquelchNarrowNormOpen.Location = new System.Drawing.Point(136, 32);
			this.nudUhfSquelchNarrowNormOpen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudUhfSquelchNarrowNormOpen.Name = "nudUhfSquelchNarrowNormOpen";
			this.nudUhfSquelchNarrowNormOpen.Size = new System.Drawing.Size(41, 20);
			this.nudUhfSquelchNarrowNormOpen.TabIndex = 6;
			// 
			// nudUhfSquelchWideNormOpen
			// 
			this.nudUhfSquelchWideNormOpen.Location = new System.Drawing.Point(76, 32);
			this.nudUhfSquelchWideNormOpen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudUhfSquelchWideNormOpen.Name = "nudUhfSquelchWideNormOpen";
			this.nudUhfSquelchWideNormOpen.Size = new System.Drawing.Size(41, 20);
			this.nudUhfSquelchWideNormOpen.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(133, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "Narrow";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(73, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 13);
			this.label8.TabIndex = 3;
			this.label8.Text = "Wide";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 60);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(69, 13);
			this.label9.TabIndex = 2;
			this.label9.Text = "Close Normal";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 34);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(69, 13);
			this.label10.TabIndex = 1;
			this.label10.Text = "Open Normal";
			this.label10.Click += new System.EventHandler(this.label10_Click);
			// 
			// nudUhfSquelchNarrowTightClose
			// 
			this.nudUhfSquelchNarrowTightClose.Location = new System.Drawing.Point(136, 112);
			this.nudUhfSquelchNarrowTightClose.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudUhfSquelchNarrowTightClose.Name = "nudUhfSquelchNarrowTightClose";
			this.nudUhfSquelchNarrowTightClose.Size = new System.Drawing.Size(41, 20);
			this.nudUhfSquelchNarrowTightClose.TabIndex = 14;
			// 
			// nudUhfSquelchWideTightClose
			// 
			this.nudUhfSquelchWideTightClose.Location = new System.Drawing.Point(76, 112);
			this.nudUhfSquelchWideTightClose.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudUhfSquelchWideTightClose.Name = "nudUhfSquelchWideTightClose";
			this.nudUhfSquelchWideTightClose.Size = new System.Drawing.Size(41, 20);
			this.nudUhfSquelchWideTightClose.TabIndex = 13;
			// 
			// nudUhfSquelchNarrowTightOpen
			// 
			this.nudUhfSquelchNarrowTightOpen.Location = new System.Drawing.Point(136, 86);
			this.nudUhfSquelchNarrowTightOpen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudUhfSquelchNarrowTightOpen.Name = "nudUhfSquelchNarrowTightOpen";
			this.nudUhfSquelchNarrowTightOpen.Size = new System.Drawing.Size(41, 20);
			this.nudUhfSquelchNarrowTightOpen.TabIndex = 12;
			// 
			// nudUhfSquelchWideTightOpen
			// 
			this.nudUhfSquelchWideTightOpen.Location = new System.Drawing.Point(76, 86);
			this.nudUhfSquelchWideTightOpen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudUhfSquelchWideTightOpen.Name = "nudUhfSquelchWideTightOpen";
			this.nudUhfSquelchWideTightOpen.Size = new System.Drawing.Size(41, 20);
			this.nudUhfSquelchWideTightOpen.TabIndex = 11;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 114);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(60, 13);
			this.label11.TabIndex = 10;
			this.label11.Text = "Close Tight";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 88);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(60, 13);
			this.label12.TabIndex = 9;
			this.label12.Text = "Open Tight";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.nudVhfSquelchNarrowTightClose);
			this.groupBox1.Controls.Add(this.nudVhfSquelchWideTightClose);
			this.groupBox1.Controls.Add(this.nudVhfSquelchNarrowTightOpen);
			this.groupBox1.Controls.Add(this.nudVhfSquelchWideTightOpen);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.nudVhfSquelchNarrowNormClose);
			this.groupBox1.Controls.Add(this.nudVhfSquelchWideNormClose);
			this.groupBox1.Controls.Add(this.nudVhfSquelchNarrowNormOpen);
			this.groupBox1.Controls.Add(this.nudVhfSquelchWideNormOpen);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Location = new System.Drawing.Point(9, 49);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(197, 144);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Squelch";
			// 
			// nudVhfSquelchNarrowTightClose
			// 
			this.nudVhfSquelchNarrowTightClose.Location = new System.Drawing.Point(136, 112);
			this.nudVhfSquelchNarrowTightClose.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudVhfSquelchNarrowTightClose.Name = "nudVhfSquelchNarrowTightClose";
			this.nudVhfSquelchNarrowTightClose.Size = new System.Drawing.Size(41, 20);
			this.nudVhfSquelchNarrowTightClose.TabIndex = 14;
			// 
			// nudVhfSquelchWideTightClose
			// 
			this.nudVhfSquelchWideTightClose.Location = new System.Drawing.Point(76, 112);
			this.nudVhfSquelchWideTightClose.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudVhfSquelchWideTightClose.Name = "nudVhfSquelchWideTightClose";
			this.nudVhfSquelchWideTightClose.Size = new System.Drawing.Size(41, 20);
			this.nudVhfSquelchWideTightClose.TabIndex = 13;
			// 
			// nudVhfSquelchNarrowTightOpen
			// 
			this.nudVhfSquelchNarrowTightOpen.Location = new System.Drawing.Point(136, 86);
			this.nudVhfSquelchNarrowTightOpen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudVhfSquelchNarrowTightOpen.Name = "nudVhfSquelchNarrowTightOpen";
			this.nudVhfSquelchNarrowTightOpen.Size = new System.Drawing.Size(41, 20);
			this.nudVhfSquelchNarrowTightOpen.TabIndex = 12;
			// 
			// nudVhfSquelchWideTightOpen
			// 
			this.nudVhfSquelchWideTightOpen.Location = new System.Drawing.Point(76, 86);
			this.nudVhfSquelchWideTightOpen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudVhfSquelchWideTightOpen.Name = "nudVhfSquelchWideTightOpen";
			this.nudVhfSquelchWideTightOpen.Size = new System.Drawing.Size(41, 20);
			this.nudVhfSquelchWideTightOpen.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Close Tight";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Open Tight";
			// 
			// nudVhfSquelchNarrowNormClose
			// 
			this.nudVhfSquelchNarrowNormClose.Location = new System.Drawing.Point(136, 58);
			this.nudVhfSquelchNarrowNormClose.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudVhfSquelchNarrowNormClose.Name = "nudVhfSquelchNarrowNormClose";
			this.nudVhfSquelchNarrowNormClose.Size = new System.Drawing.Size(41, 20);
			this.nudVhfSquelchNarrowNormClose.TabIndex = 8;
			// 
			// nudVhfSquelchWideNormClose
			// 
			this.nudVhfSquelchWideNormClose.Location = new System.Drawing.Point(76, 58);
			this.nudVhfSquelchWideNormClose.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudVhfSquelchWideNormClose.Name = "nudVhfSquelchWideNormClose";
			this.nudVhfSquelchWideNormClose.Size = new System.Drawing.Size(41, 20);
			this.nudVhfSquelchWideNormClose.TabIndex = 7;
			// 
			// nudVhfSquelchNarrowNormOpen
			// 
			this.nudVhfSquelchNarrowNormOpen.Location = new System.Drawing.Point(136, 32);
			this.nudVhfSquelchNarrowNormOpen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudVhfSquelchNarrowNormOpen.Name = "nudVhfSquelchNarrowNormOpen";
			this.nudVhfSquelchNarrowNormOpen.Size = new System.Drawing.Size(41, 20);
			this.nudVhfSquelchNarrowNormOpen.TabIndex = 6;
			// 
			// nudVhfSquelchWideNormOpen
			// 
			this.nudVhfSquelchWideNormOpen.Location = new System.Drawing.Point(76, 32);
			this.nudVhfSquelchWideNormOpen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudVhfSquelchWideNormOpen.Name = "nudVhfSquelchWideNormOpen";
			this.nudVhfSquelchWideNormOpen.Size = new System.Drawing.Size(41, 20);
			this.nudVhfSquelchWideNormOpen.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(133, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Narrow";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(73, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "Wide";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(6, 60);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(69, 13);
			this.label13.TabIndex = 2;
			this.label13.Text = "Close Normal";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(6, 34);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(69, 13);
			this.label14.TabIndex = 1;
			this.label14.Text = "Open Normal";
			// 
			// CalibrationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 471);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.tabControl1);
			this.Name = "CalibrationForm";
			this.Text = "Calibration";
			this.Load += new System.EventHandler(this.onFormLoad);
			this.tabControl1.ResumeLayout(false);
			this.tabVHF.ResumeLayout(false);
			this.tabVHF.PerformLayout();
			this.tabUHF.ResumeLayout(false);
			this.tabUHF.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudVhfOscRef)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudUhfOscRef)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudUhfSquelchNarrowNormClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudUhfSquelchWideNormClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudUhfSquelchNarrowNormOpen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudUhfSquelchWideNormOpen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudUhfSquelchNarrowTightClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudUhfSquelchWideTightClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudUhfSquelchNarrowTightOpen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudUhfSquelchWideTightOpen)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudVhfSquelchNarrowTightClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudVhfSquelchWideTightClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudVhfSquelchNarrowTightOpen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudVhfSquelchWideTightOpen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudVhfSquelchNarrowNormClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudVhfSquelchWideNormClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudVhfSquelchNarrowNormOpen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudVhfSquelchWideNormOpen)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabVHF;
		private System.Windows.Forms.TabPage tabUHF;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private NumericUpDown nudVhfOscRef;
		private NumericUpDown nudUhfOscRef;
		private GroupBox groupBox2;
		private NumericUpDown nudUhfSquelchNarrowNormClose;
		private NumericUpDown nudUhfSquelchWideNormClose;
		private NumericUpDown nudUhfSquelchNarrowNormOpen;
		private NumericUpDown nudUhfSquelchWideNormOpen;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label10;
		private NumericUpDown nudUhfSquelchNarrowTightClose;
		private NumericUpDown nudUhfSquelchWideTightClose;
		private NumericUpDown nudUhfSquelchNarrowTightOpen;
		private NumericUpDown nudUhfSquelchWideTightOpen;
		private Label label11;
		private Label label12;
		private GroupBox groupBox1;
		private NumericUpDown nudVhfSquelchNarrowTightClose;
		private NumericUpDown nudVhfSquelchWideTightClose;
		private NumericUpDown nudVhfSquelchNarrowTightOpen;
		private NumericUpDown nudVhfSquelchWideTightOpen;
		private Label label3;
		private Label label4;
		private NumericUpDown nudVhfSquelchNarrowNormClose;
		private NumericUpDown nudVhfSquelchWideNormClose;
		private NumericUpDown nudVhfSquelchNarrowNormOpen;
		private NumericUpDown nudVhfSquelchWideNormOpen;
		private Label label5;
		private Label label6;
		private Label label13;
		private Label label14;
	}
}