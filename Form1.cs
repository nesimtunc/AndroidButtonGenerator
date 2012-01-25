using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AndroidButtonGenerator
{
  public partial class Form1 : Form
  {

	List<AndroidButton> buttons = new List<AndroidButton>();

	public AndroidButton SelectedButton
	{
	  get
	  {
		return buttons[lstFileNames.SelectedIndex];
	  }
	  set
	  {
		buttons[lstFileNames.SelectedIndex] = value;
	  }
	}

	public Form1()
	{
	  InitializeComponent();

	  buttons.Add(new AndroidButton { FileName = "Normal" });
	  buttons.Add(new AndroidButton { FileName = "Pressed" });
	  buttons.Add(new AndroidButton { FileName = "Selected" });

	  lstFileNames.SelectedIndex = 0;

	}

	private void lstFileNames_SelectedIndexChanged(object sender, EventArgs e)
	{
	  if (lstFileNames.SelectedIndex > -1)
	  {
		PutValues();
	  }
	}

	private void PutValues()
	{
	  AndroidButton selectedButton = SelectedButton;

	  if (!string.IsNullOrEmpty(selectedButton.Shape))
	  {
		cmbShape.SelectedItem = selectedButton.Shape;
	  }

	  if (!string.IsNullOrEmpty(selectedButton.Solid))
	  {
		rbSolid.Checked = true;
		txtSolidColor.Text = selectedButton.Solid;
	  }

	  if (selectedButton.Gradient != null)
	  {

		rbGradient.Checked = true;

		Gradient gradient = selectedButton.Gradient;
		if (!string.IsNullOrEmpty(gradient.Angle))
		{
		  txtGradientAngle.Text = gradient.Angle;
		}
		if (!string.IsNullOrEmpty(gradient.CenterColor))
		{
		  txtGradientCenterColor.Text = gradient.CenterColor;
		}
		if (!string.IsNullOrEmpty(gradient.StartColor))
		{
		  txtGradientStartColor.Text = gradient.StartColor;
		}
		if (!string.IsNullOrEmpty(gradient.EndColor))
		{
		  txtGradientEndColor.Text = gradient.EndColor;
		}
		if (!string.IsNullOrEmpty(gradient.Type))
		{
		  cmbGradientType.SelectedItem = gradient.Type;
		}

	  }

	  if (!string.IsNullOrEmpty(selectedButton.CornerRadius))
	  {
		cbCornerRadius.Checked = true;
		txtCornerRadius.Text = selectedButton.CornerRadius;
	  }

	}


	private AndroidButton GetValues()
	{
	  AndroidButton selectedButton = SelectedButton;

	  if (cmbShape.SelectedItem != null && !string.IsNullOrEmpty(cmbShape.SelectedItem.ToString()))
	  {
		selectedButton.Shape = cmbShape.SelectedItem.ToString();
	  }

	  if (rbSolid.Checked)
	  {
		selectedButton.Solid = txtSolidColor.Text;
	  }

	  if (rbGradient.Checked)
	  {
		selectedButton.Gradient = new Gradient
		{
		  Angle = txtGradientAngle.Text,
		  CenterColor = txtGradientCenterColor.Text,
		  StartColor = txtGradientStartColor.Text,
		  EndColor = txtGradientEndColor.Text,
		  Type = cmbGradientType.SelectedItem != null ? cmbGradientType.SelectedItem.ToString() : string.Empty,
		};
	  }

	  if (cbCornerRadius.Checked)
	  {
		selectedButton.CornerRadius = txtCornerRadius.Text;
	  }

	  return selectedButton;

	}

	private void cbShape_CheckedChanged(object sender, EventArgs e)
	{
	  SelectedButton = GetValues();
	}

	private void txtSolidColor_TextChanged(object sender, EventArgs e)
	{
	  SelectedButton = GetValues();
	}

	private void cmbShape_SelectedIndexChanged(object sender, EventArgs e)
	{
	  SelectedButton = GetValues();
	}

	private void button1_Click(object sender, EventArgs e)
	{
	  StringBuilder selector = new StringBuilder();

	  string buttonName = txtButtonName.Text.ToLower();

	  foreach (AndroidButton androidButton in buttons)
	  {
		string xml = androidButton.ToString();
		File.WriteAllText(string.Format("{0}_{1}.xml", buttonName, androidButton.FileName.ToLower()), xml);
	  }

	  selector.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
	  selector.AppendLine("<selector xmlns:android=\"http://schemas.android.com/apk/res/android\">");
	  selector.AppendLine("<item android:drawable=\"@drawable/" + buttonName + "_" + "normal\"  android:state_pressed=\"true\"/>");
	  selector.AppendLine("<item android:drawable=\"@drawable/" + buttonName + "_" + "focused\" android:state_focused=\"true\"/>");
	  selector.AppendLine("<item android:drawable=\"@drawable/" + buttonName + "_" + "selected\" android:state_selected=\"true\"/>");
	  selector.AppendLine("</selector>");

	  string selectorFile = selector.ToString();

	  File.WriteAllText(buttonName + ".xml", selectorFile);

	}

  }
}
