using System;
using System.Windows.Forms;
using void_client.utils;
using Snackbar;

namespace void_client
{
    public partial class frm_login : Form
    {
        string our_hwid = methods.get_hwid.ToUpper();

        public frm_login()
        {
            InitializeComponent();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (login.sign_in(txt_user.Text, txt_pass.Text, our_hwid))
            {
                // dispose elements

                lb_logo.Text = null;
                lb_pass.Text = null;
                lb_username.Text = null;
                txt_user.Text = null;
                txt_pass.Text = null;
                btn_login.Text = null;

                lb_logo.Dispose();
                lb_pass.Dispose();
                lb_username.Dispose();
                txt_user.Dispose();
                txt_pass.Dispose();
                btn_login.Dispose();
                pn_bottom.Dispose();
                this.Hide();
            }
        }
    }
}
