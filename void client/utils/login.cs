using System.Windows.Forms;

namespace void_client.utils
{
    class login
    {
        public static bool sign_in(string username, string password, string hwid)
        {
            // verify if username or password is empty
            if (string.IsNullOrEmpty(username))
            {
                warning.warn("Your username is empty", 3, 2000);
                return false;
            }
            if (string.IsNullOrEmpty(password))
            {
                warning.warn("Your password is empty", 3, 2000);
                return false;
            }
            // auth
            {
                // autenticar - depois
            }
            warning.warn("Autenticado, redirecionando...", 2, 2000);
            util.wait_non_async(2200);
            new frm_clicker(username).Show();
            return true;
        }
    }
}
