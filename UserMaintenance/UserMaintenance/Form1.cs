using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_LastName.Text = Localization.LastName;
            lbl_FirstName.Text = Localization.FirstName;
            btn_Add.Text = Localization.Add;
        }
    }
}
