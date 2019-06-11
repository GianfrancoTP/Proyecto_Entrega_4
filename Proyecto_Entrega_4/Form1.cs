using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Entrega_4
{
    public partial class Form1 : Form
    {
        int OriginalWidth1;
        int OriginalWidth2;
        int OriginalWidthForm;
        public Form1()
        {
            InitializeComponent();
            OriginalWidth1 = MenuPanel1.Width;
            OriginalWidth2 = MenuPanel2.Width;
            OriginalWidthForm = this.Width;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            MaximizeButton.Visible = false;
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            MaximizeButton.Visible = true;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (MenuPanel2.Width == OriginalWidth2)
            {
                MenuPanel2.Visible = false;
                MenuPanel2.Width = OriginalWidth2 - 157;
                MenuPanel1.Width = OriginalWidth1 - 153;
                CloseAnimation.Show(MenuPanel2);
                this.Width = OriginalWidthForm - 153;
            }
            else
            {
                MenuPanel2.Visible = false;
                MenuPanel2.Width = OriginalWidth2;
                MenuPanel1.Width = OriginalWidth1;
                OpenAnimation.Show(MenuPanel2);
                this.Width = OriginalWidthForm;
            }
        }
    }
}
