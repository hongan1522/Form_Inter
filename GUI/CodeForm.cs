using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CodeForm : Form
    {
        private uc_NhanVien uc_NV = new uc_NhanVien();
        private TableLayoutPanel tlpForm = new TableLayoutPanel();
        public CodeForm()
        {
            InitializeComponent();
            Size = new Size(1522, 950);

            this.Controls.Add(tlpForm);
            tlpForm.Controls.Add(uc_NV, 0, 0);
            tlpForm.Name = "tlpForm";
            tlpForm.Dock = DockStyle.Fill;
            tlpForm.ColumnCount = 1;
            tlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpForm.RowCount = 1;
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpForm.TabIndex = 0;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            uc_NV.Dock = DockStyle.Fill;

            MaximizeBox = false;
            MinimizeBox = false;
        }
    }
}
