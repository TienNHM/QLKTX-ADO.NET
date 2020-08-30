using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTX.UI
{
    public partial class FrmHuongDan : Form
    {
        public FrmHuongDan()
        {
            InitializeComponent();
            
            rtb.SelectAll();
            rtb.SelectedRtf = Properties.Resources.HuongDan;
            rtb.SelectionStart = 0;
        }
    }
}
