using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndroidButtonGenerator
{
 public class AndroidButton
  {
	public string ButtonName { get; set; }
	public string FileName { get; set; }
	public string Shape { get; set; }
	public string Solid { get; set; }
	public Gradient Gradient { get; set; }
	public string CornerRadius { get; set; }


	public override string ToString()
	{
	  StringBuilder sb = new StringBuilder();
	  sb.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
	  sb.AppendLine("<shape xmlns:android=\"http://schemas.android.com/apk/res/android\" android:shape=\"" + Shape.ToLower() + "\">");

	  if (!string.IsNullOrEmpty(Solid))
	  {
		sb.AppendLine("<solid android:color=\"#" + Solid.Replace("#", "") + "\"/>");
	  }

	  if (!string.IsNullOrEmpty(CornerRadius))
	  {		 
		sb.AppendLine("<corners android:radius=\"" + CornerRadius + "dp\"/>");
	  }

	  if (Gradient != null)
	  {
		sb.AppendLine(string.Format("<gradient android:angle=\"{0}\" android:endColor=\"#{1}\" android:centerColor=\"#{2}\"  android:startColor=\"#{3}\" android:type=\"{4}\"/>", Gradient.Angle, Gradient.EndColor.Replace("#", ""), Gradient.CenterColor.Replace("#", ""), Gradient.StartColor.Replace("#", ""), Gradient.Type));
	  }

	  sb.AppendLine("</shape>");


	  return sb.ToString();
	}

  }

 public class Gradient
  {
	public string StartColor { get; set; }
	public string CenterColor { get; set; }
	public string EndColor { get; set; }
	public string Angle { get; set; }
	public string Type { get; set; }
  }

}
