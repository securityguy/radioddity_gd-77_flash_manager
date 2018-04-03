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
			this.txtVHFOscRef = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabUHF = new System.Windows.Forms.TabPage();
			this.txtUHFOscRef = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabVHF.SuspendLayout();
			this.tabUHF.SuspendLayout();
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
			this.tabVHF.Controls.Add(this.txtVHFOscRef);
			this.tabVHF.Controls.Add(this.label1);
			this.tabVHF.Location = new System.Drawing.Point(4, 22);
			this.tabVHF.Name = "tabVHF";
			this.tabVHF.Padding = new System.Windows.Forms.Padding(3);
			this.tabVHF.Size = new System.Drawing.Size(523, 382);
			this.tabVHF.TabIndex = 0;
			this.tabVHF.Text = "VHF";
			this.tabVHF.UseVisualStyleBackColor = true;
			// 
			// txtVHFOscRef
			// 
			this.txtVHFOscRef.Location = new System.Drawing.Point(152, 6);
			this.txtVHFOscRef.Name = "txtVHFOscRef";
			this.txtVHFOscRef.Size = new System.Drawing.Size(100, 20);
			this.txtVHFOscRef.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Reference osciallator tuning\t";
			// 
			// tabUHF
			// 
			this.tabUHF.Controls.Add(this.txtUHFOscRef);
			this.tabUHF.Controls.Add(this.label2);
			this.tabUHF.Location = new System.Drawing.Point(4, 22);
			this.tabUHF.Name = "tabUHF";
			this.tabUHF.Padding = new System.Windows.Forms.Padding(3);
			this.tabUHF.Size = new System.Drawing.Size(523, 382);
			this.tabUHF.TabIndex = 1;
			this.tabUHF.Text = "UHF";
			this.tabUHF.UseVisualStyleBackColor = true;
			// 
			// txtUHFOscRef
			// 
			this.txtUHFOscRef.Location = new System.Drawing.Point(152, 15);
			this.txtUHFOscRef.Name = "txtUHFOscRef";
			this.txtUHFOscRef.Size = new System.Drawing.Size(100, 20);
			this.txtUHFOscRef.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Reference osciallator tuning\t";
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
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabVHF;
		private System.Windows.Forms.TabPage tabUHF;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtVHFOscRef;
		private System.Windows.Forms.TextBox txtUHFOscRef;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
	}
}