using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика_3
{
    public partial class Form1 : Form
    {
        Hill[] body = new Hill[3];
        public Form1()
        {
            InitializeComponent();
            body[0] = new Circle(ClientSize.Width / 2, ClientSize.Height / 2, 25);
            body[1] = new Square(ClientSize.Width / 2, ClientSize.Height / 2, 25);
            body[2] = new Triangle(ClientSize.Width / 2, ClientSize.Height / 2, 25);
            Invalidate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Окружность", "Квадрат","Треугольник" });
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                body[0].DrawFigure(e.Graphics);
            if (comboBox1.SelectedIndex == 1)
                body[1].DrawFigure(e.Graphics);
            if (comboBox1.SelectedIndex == 2)
                body[2].DrawFigure(e.Graphics);
        }

    }
}
