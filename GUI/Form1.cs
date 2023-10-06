using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using OfficeOpenXml;
using System.IO;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1322, 885);

        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            int dgvWidth = this.ClientSize.Width - qlnv1.DgvNVText.Location.X - 20; // 20 là một số margin để tránh việc đụng lề
            int dgvHeight = this.ClientSize.Height - qlnv1.DgvNVText.Location.Y - 20; // 20 là một số margin để tránh việc đụng lề

            qlnv1.DgvNVText.Size = new Size(dgvWidth, dgvHeight);
        }

    }
}
