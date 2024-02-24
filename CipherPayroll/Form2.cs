using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherPayroll
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            RoundCorners(20);
        }

        private void RoundCorners(int radius)
        {
            // Create a GraphicsPath object
            GraphicsPath path = new GraphicsPath();
            // Create a rectangle representing the form's client area
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            // Create a rounded rectangle using the specified radius
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Top left corner
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90); // Top right corner
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90); // Bottom right corner
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90); // Bottom left corner
            path.CloseFigure();
            // Set the form's region to the created GraphicsPath
            this.Region = new Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
