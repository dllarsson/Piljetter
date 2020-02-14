using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piljetter
{
    public partial class Login : Form
    {
        MainForm mf = null;
        public Login(Form callingForm)
        {
            mf = callingForm as MainForm;
            InitializeComponent();
        }


    }
}
