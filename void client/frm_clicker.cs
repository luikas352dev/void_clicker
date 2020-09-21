using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace void_client
{
    public partial class frm_clicker : Form
    {
        string username;
        public frm_clicker(string username)
        {
            this.username = username;
            InitializeComponent();
        }
    }
}
