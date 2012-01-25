namespace AndroidButtonGenerator
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
	  this.groupBox1 = new System.Windows.Forms.GroupBox();
	  this.lstFileNames = new System.Windows.Forms.ListBox();
	  this.groupBox2 = new System.Windows.Forms.GroupBox();
	  this.txtGradientEndColor = new System.Windows.Forms.TextBox();
	  this.label9 = new System.Windows.Forms.Label();
	  this.cmbGradientType = new System.Windows.Forms.ComboBox();
	  this.cmbShape = new System.Windows.Forms.ComboBox();
	  this.label8 = new System.Windows.Forms.Label();
	  this.txtGradientAngle = new System.Windows.Forms.TextBox();
	  this.label7 = new System.Windows.Forms.Label();
	  this.label6 = new System.Windows.Forms.Label();
	  this.txtCornerRadius = new System.Windows.Forms.TextBox();
	  this.label5 = new System.Windows.Forms.Label();
	  this.txtGradientCenterColor = new System.Windows.Forms.TextBox();
	  this.label4 = new System.Windows.Forms.Label();
	  this.txtGradientStartColor = new System.Windows.Forms.TextBox();
	  this.label3 = new System.Windows.Forms.Label();
	  this.txtSolidColor = new System.Windows.Forms.TextBox();
	  this.label2 = new System.Windows.Forms.Label();
	  this.cbCornerRadius = new System.Windows.Forms.CheckBox();
	  this.txtButtonName = new System.Windows.Forms.TextBox();
	  this.label1 = new System.Windows.Forms.Label();
	  this.button1 = new System.Windows.Forms.Button();
	  this.label10 = new System.Windows.Forms.Label();
	  this.rbSolid = new System.Windows.Forms.RadioButton();
	  this.rbGradient = new System.Windows.Forms.RadioButton();
	  this.groupBox1.SuspendLayout();
	  this.groupBox2.SuspendLayout();
	  this.SuspendLayout();
	  // 
	  // groupBox1
	  // 
	  this.groupBox1.Controls.Add(this.lstFileNames);
	  this.groupBox1.Location = new System.Drawing.Point(25, 21);
	  this.groupBox1.Name = "groupBox1";
	  this.groupBox1.Size = new System.Drawing.Size(207, 165);
	  this.groupBox1.TabIndex = 0;
	  this.groupBox1.TabStop = false;
	  this.groupBox1.Text = "File Types";
	  // 
	  // lstFileNames
	  // 
	  this.lstFileNames.FormattingEnabled = true;
	  this.lstFileNames.Items.AddRange(new object[] {
            "Normal",
            "Pressed",
            "Selected"});
	  this.lstFileNames.Location = new System.Drawing.Point(23, 32);
	  this.lstFileNames.Name = "lstFileNames";
	  this.lstFileNames.Size = new System.Drawing.Size(120, 95);
	  this.lstFileNames.TabIndex = 0;
	  this.lstFileNames.SelectedIndexChanged += new System.EventHandler(this.lstFileNames_SelectedIndexChanged);
	  // 
	  // groupBox2
	  // 
	  this.groupBox2.Controls.Add(this.rbGradient);
	  this.groupBox2.Controls.Add(this.rbSolid);
	  this.groupBox2.Controls.Add(this.label10);
	  this.groupBox2.Controls.Add(this.txtGradientEndColor);
	  this.groupBox2.Controls.Add(this.label9);
	  this.groupBox2.Controls.Add(this.cmbGradientType);
	  this.groupBox2.Controls.Add(this.cmbShape);
	  this.groupBox2.Controls.Add(this.label8);
	  this.groupBox2.Controls.Add(this.txtGradientAngle);
	  this.groupBox2.Controls.Add(this.label7);
	  this.groupBox2.Controls.Add(this.label6);
	  this.groupBox2.Controls.Add(this.txtCornerRadius);
	  this.groupBox2.Controls.Add(this.label5);
	  this.groupBox2.Controls.Add(this.txtGradientCenterColor);
	  this.groupBox2.Controls.Add(this.label4);
	  this.groupBox2.Controls.Add(this.txtGradientStartColor);
	  this.groupBox2.Controls.Add(this.label3);
	  this.groupBox2.Controls.Add(this.txtSolidColor);
	  this.groupBox2.Controls.Add(this.label2);
	  this.groupBox2.Controls.Add(this.cbCornerRadius);
	  this.groupBox2.Location = new System.Drawing.Point(278, 21);
	  this.groupBox2.Name = "groupBox2";
	  this.groupBox2.Size = new System.Drawing.Size(613, 271);
	  this.groupBox2.TabIndex = 1;
	  this.groupBox2.TabStop = false;
	  this.groupBox2.Text = "File Properties";
	  // 
	  // txtGradientEndColor
	  // 
	  this.txtGradientEndColor.Location = new System.Drawing.Point(277, 138);
	  this.txtGradientEndColor.Name = "txtGradientEndColor";
	  this.txtGradientEndColor.Size = new System.Drawing.Size(88, 20);
	  this.txtGradientEndColor.TabIndex = 7;
	  this.txtGradientEndColor.TextChanged += new System.EventHandler(this.txtSolidColor_TextChanged);
	  // 
	  // label9
	  // 
	  this.label9.AutoSize = true;
	  this.label9.Location = new System.Drawing.Point(275, 119);
	  this.label9.Name = "label9";
	  this.label9.Size = new System.Drawing.Size(51, 13);
	  this.label9.TabIndex = 19;
	  this.label9.Text = "end color";
	  // 
	  // cmbGradientType
	  // 
	  this.cmbGradientType.FormattingEnabled = true;
	  this.cmbGradientType.Items.AddRange(new object[] {
            "linear",
            "radial",
            "sweep"});
	  this.cmbGradientType.Location = new System.Drawing.Point(278, 231);
	  this.cmbGradientType.Name = "cmbGradientType";
	  this.cmbGradientType.Size = new System.Drawing.Size(91, 21);
	  this.cmbGradientType.TabIndex = 9;
	  this.cmbGradientType.SelectedIndexChanged += new System.EventHandler(this.cmbShape_SelectedIndexChanged);
	  // 
	  // cmbShape
	  // 
	  this.cmbShape.FormattingEnabled = true;
	  this.cmbShape.Items.AddRange(new object[] {
            "rectangle",
            "oval",
            "line",
            "ring"});
	  this.cmbShape.Location = new System.Drawing.Point(6, 57);
	  this.cmbShape.Name = "cmbShape";
	  this.cmbShape.Size = new System.Drawing.Size(121, 21);
	  this.cmbShape.TabIndex = 2;
	  this.cmbShape.SelectedIndexChanged += new System.EventHandler(this.cmbShape_SelectedIndexChanged);
	  // 
	  // label8
	  // 
	  this.label8.AutoSize = true;
	  this.label8.Location = new System.Drawing.Point(280, 209);
	  this.label8.Name = "label8";
	  this.label8.Size = new System.Drawing.Size(27, 13);
	  this.label8.TabIndex = 16;
	  this.label8.Text = "type";
	  // 
	  // txtGradientAngle
	  // 
	  this.txtGradientAngle.Location = new System.Drawing.Point(278, 182);
	  this.txtGradientAngle.Name = "txtGradientAngle";
	  this.txtGradientAngle.Size = new System.Drawing.Size(85, 20);
	  this.txtGradientAngle.TabIndex = 8;
	  this.txtGradientAngle.TextChanged += new System.EventHandler(this.txtSolidColor_TextChanged);
	  // 
	  // label7
	  // 
	  this.label7.AutoSize = true;
	  this.label7.Location = new System.Drawing.Point(277, 166);
	  this.label7.Name = "label7";
	  this.label7.Size = new System.Drawing.Size(33, 13);
	  this.label7.TabIndex = 14;
	  this.label7.Text = "angle";
	  // 
	  // label6
	  // 
	  this.label6.AutoSize = true;
	  this.label6.Location = new System.Drawing.Point(455, 62);
	  this.label6.Name = "label6";
	  this.label6.Size = new System.Drawing.Size(19, 13);
	  this.label6.TabIndex = 13;
	  this.label6.Text = "dp";
	  // 
	  // txtCornerRadius
	  // 
	  this.txtCornerRadius.Location = new System.Drawing.Point(397, 60);
	  this.txtCornerRadius.Name = "txtCornerRadius";
	  this.txtCornerRadius.Size = new System.Drawing.Size(53, 20);
	  this.txtCornerRadius.TabIndex = 11;
	  this.txtCornerRadius.TextChanged += new System.EventHandler(this.txtSolidColor_TextChanged);
	  // 
	  // label5
	  // 
	  this.label5.AutoSize = true;
	  this.label5.Location = new System.Drawing.Point(397, 43);
	  this.label5.Name = "label5";
	  this.label5.Size = new System.Drawing.Size(35, 13);
	  this.label5.TabIndex = 11;
	  this.label5.Text = "radius";
	  // 
	  // txtGradientCenterColor
	  // 
	  this.txtGradientCenterColor.Location = new System.Drawing.Point(275, 97);
	  this.txtGradientCenterColor.Name = "txtGradientCenterColor";
	  this.txtGradientCenterColor.Size = new System.Drawing.Size(88, 20);
	  this.txtGradientCenterColor.TabIndex = 6;
	  this.txtGradientCenterColor.TextChanged += new System.EventHandler(this.txtSolidColor_TextChanged);
	  // 
	  // label4
	  // 
	  this.label4.AutoSize = true;
	  this.label4.Location = new System.Drawing.Point(275, 80);
	  this.label4.Name = "label4";
	  this.label4.Size = new System.Drawing.Size(63, 13);
	  this.label4.TabIndex = 9;
	  this.label4.Text = "center color";
	  // 
	  // txtGradientStartColor
	  // 
	  this.txtGradientStartColor.Location = new System.Drawing.Point(275, 60);
	  this.txtGradientStartColor.Name = "txtGradientStartColor";
	  this.txtGradientStartColor.Size = new System.Drawing.Size(88, 20);
	  this.txtGradientStartColor.TabIndex = 5;
	  this.txtGradientStartColor.TextChanged += new System.EventHandler(this.txtSolidColor_TextChanged);
	  // 
	  // label3
	  // 
	  this.label3.AutoSize = true;
	  this.label3.Location = new System.Drawing.Point(275, 43);
	  this.label3.Name = "label3";
	  this.label3.Size = new System.Drawing.Size(53, 13);
	  this.label3.TabIndex = 7;
	  this.label3.Text = "start color";
	  // 
	  // txtSolidColor
	  // 
	  this.txtSolidColor.Location = new System.Drawing.Point(159, 60);
	  this.txtSolidColor.Name = "txtSolidColor";
	  this.txtSolidColor.Size = new System.Drawing.Size(88, 20);
	  this.txtSolidColor.TabIndex = 4;
	  this.txtSolidColor.TextChanged += new System.EventHandler(this.txtSolidColor_TextChanged);
	  // 
	  // label2
	  // 
	  this.label2.AutoSize = true;
	  this.label2.Location = new System.Drawing.Point(159, 43);
	  this.label2.Name = "label2";
	  this.label2.Size = new System.Drawing.Size(30, 13);
	  this.label2.TabIndex = 13;
	  this.label2.Text = "color";
	  // 
	  // cbCornerRadius
	  // 
	  this.cbCornerRadius.AutoSize = true;
	  this.cbCornerRadius.Location = new System.Drawing.Point(392, 19);
	  this.cbCornerRadius.Name = "cbCornerRadius";
	  this.cbCornerRadius.Size = new System.Drawing.Size(93, 17);
	  this.cbCornerRadius.TabIndex = 10;
	  this.cbCornerRadius.Text = "Corner Radius";
	  this.cbCornerRadius.UseVisualStyleBackColor = true;
	  this.cbCornerRadius.CheckedChanged += new System.EventHandler(this.cbShape_CheckedChanged);
	  // 
	  // txtButtonName
	  // 
	  this.txtButtonName.Location = new System.Drawing.Point(36, 314);
	  this.txtButtonName.Name = "txtButtonName";
	  this.txtButtonName.Size = new System.Drawing.Size(196, 20);
	  this.txtButtonName.TabIndex = 12;
	  this.txtButtonName.Text = "share_button";
	  // 
	  // label1
	  // 
	  this.label1.AutoSize = true;
	  this.label1.Location = new System.Drawing.Point(33, 289);
	  this.label1.Name = "label1";
	  this.label1.Size = new System.Drawing.Size(69, 13);
	  this.label1.TabIndex = 3;
	  this.label1.Text = "Button Name";
	  // 
	  // button1
	  // 
	  this.button1.Location = new System.Drawing.Point(36, 349);
	  this.button1.Name = "button1";
	  this.button1.Size = new System.Drawing.Size(75, 23);
	  this.button1.TabIndex = 13;
	  this.button1.Text = "Generate";
	  this.button1.UseVisualStyleBackColor = true;
	  this.button1.Click += new System.EventHandler(this.button1_Click);
	  // 
	  // label10
	  // 
	  this.label10.AutoSize = true;
	  this.label10.Location = new System.Drawing.Point(9, 22);
	  this.label10.Name = "label10";
	  this.label10.Size = new System.Drawing.Size(38, 13);
	  this.label10.TabIndex = 20;
	  this.label10.Text = "Shape";
	  // 
	  // rbSolid
	  // 
	  this.rbSolid.AutoSize = true;
	  this.rbSolid.Location = new System.Drawing.Point(162, 18);
	  this.rbSolid.Name = "rbSolid";
	  this.rbSolid.Size = new System.Drawing.Size(48, 17);
	  this.rbSolid.TabIndex = 21;
	  this.rbSolid.TabStop = true;
	  this.rbSolid.Text = "Solid";
	  this.rbSolid.UseVisualStyleBackColor = true;
	  this.rbSolid.CheckedChanged += new System.EventHandler(this.cbShape_CheckedChanged);
	  // 
	  // rbGradient
	  // 
	  this.rbGradient.AutoSize = true;
	  this.rbGradient.Location = new System.Drawing.Point(275, 18);
	  this.rbGradient.Name = "rbGradient";
	  this.rbGradient.Size = new System.Drawing.Size(65, 17);
	  this.rbGradient.TabIndex = 23;
	  this.rbGradient.TabStop = true;
	  this.rbGradient.Text = "Gradient";
	  this.rbGradient.UseVisualStyleBackColor = true;
	  this.rbGradient.CheckedChanged += new System.EventHandler(this.cbShape_CheckedChanged);
	  // 
	  // Form1
	  // 
	  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	  this.ClientSize = new System.Drawing.Size(915, 396);
	  this.Controls.Add(this.button1);
	  this.Controls.Add(this.label1);
	  this.Controls.Add(this.txtButtonName);
	  this.Controls.Add(this.groupBox2);
	  this.Controls.Add(this.groupBox1);
	  this.Name = "Form1";
	  this.Text = "Android Button Generator V1 by i-Developer";
	  this.groupBox1.ResumeLayout(false);
	  this.groupBox2.ResumeLayout(false);
	  this.groupBox2.PerformLayout();
	  this.ResumeLayout(false);
	  this.PerformLayout();

	}

	#endregion

	private System.Windows.Forms.GroupBox groupBox1;
	private System.Windows.Forms.ListBox lstFileNames;
	private System.Windows.Forms.GroupBox groupBox2;
	private System.Windows.Forms.CheckBox cbCornerRadius;
	private System.Windows.Forms.TextBox txtButtonName;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.Button button1;
	private System.Windows.Forms.Label label6;
	private System.Windows.Forms.TextBox txtCornerRadius;
	private System.Windows.Forms.Label label5;
	private System.Windows.Forms.TextBox txtGradientCenterColor;
	private System.Windows.Forms.Label label4;
	private System.Windows.Forms.TextBox txtGradientStartColor;
	private System.Windows.Forms.Label label3;
	private System.Windows.Forms.TextBox txtSolidColor;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.ComboBox cmbShape;
	private System.Windows.Forms.Label label8;
	private System.Windows.Forms.TextBox txtGradientAngle;
	private System.Windows.Forms.Label label7;
	private System.Windows.Forms.TextBox txtGradientEndColor;
	private System.Windows.Forms.Label label9;
	private System.Windows.Forms.ComboBox cmbGradientType;
	private System.Windows.Forms.RadioButton rbGradient;
	private System.Windows.Forms.RadioButton rbSolid;
	private System.Windows.Forms.Label label10;
  }
}

