using robot_arm_automation.Controller.CustomControl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

class SubMethods
{
    public static Point startPoint;
    public static Point endPoint;

    public static List<Point> trailPoints = new List<Point>();
    public static Point dotPoint;
    public static int squareSize = 20;
    public static int trailLength = 120;

    public static void DrawSetPointRectangle(int x1, int y1, int x2, int y2, PictureBox pictureBox)
    {
        startPoint = new Point(x1, y1);
        endPoint = new Point(x2, y2);
        pictureBox.Invalidate(); // Redraw the PictureBox
    }

    public static void DrawDotAndSquare(int x, int y, PictureBox pictureBox)
    {
        // Add new point to the trail
        trailPoints.Add(new Point(x, y));

        // Limit the trail length
        if (trailPoints.Count > trailLength)
            trailPoints.RemoveAt(0);
        dotPoint = new Point(x, y);
        pictureBox.Invalidate(); // Redraw the PictureBox
    }
    public static int String2Axis(string inputString)
    {
        double result;
        if(double.TryParse(inputString, out result))
        {
            return (int)Math.Round(result * 0.4);
        }
        else
        {
            CTMessageBox.Show("The input value to convert is not in the right format, please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return 0;
        }
    }
}