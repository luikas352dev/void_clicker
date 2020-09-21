namespace void_client.utils
{
    class warning
    {
        public static void warn(string warn_string, int type, int time)
        {
            switch (type)
            {
                case 0:
                    Bunifu.Snackbar.Show(frm_login.ActiveForm, warn_string, time, Snackbar.Views.SnackbarDesigner.MessageTypes.Error, "",
                        Snackbar.Views.SnackbarDesigner.ScopeLevels.FormOwner, Snackbar.Views.SnackbarDesigner.PlacementAreas.TopCenter, 0, false, true);
                    break;
                case 1:
                    Bunifu.Snackbar.Show(frm_login.ActiveForm, warn_string, time, Snackbar.Views.SnackbarDesigner.MessageTypes.Information, "",
                        Snackbar.Views.SnackbarDesigner.ScopeLevels.FormOwner, Snackbar.Views.SnackbarDesigner.PlacementAreas.TopCenter, 0, false, true);
                    break;
                case 2:
                    Bunifu.Snackbar.Show(frm_login.ActiveForm, warn_string, time, Snackbar.Views.SnackbarDesigner.MessageTypes.Success, "",
                        Snackbar.Views.SnackbarDesigner.ScopeLevels.FormOwner, Snackbar.Views.SnackbarDesigner.PlacementAreas.TopCenter, 0, false, true);
                    break;
                case 3:
                    Bunifu.Snackbar.Show(frm_login.ActiveForm, warn_string, time, Snackbar.Views.SnackbarDesigner.MessageTypes.Warning, "",
                        Snackbar.Views.SnackbarDesigner.ScopeLevels.FormOwner, Snackbar.Views.SnackbarDesigner.PlacementAreas.TopCenter, 0, false, true);
                    break;
                default:
                    Bunifu.Snackbar.Show(frm_login.ActiveForm, "Unknown error - " + type, time, Snackbar.Views.SnackbarDesigner.MessageTypes.Warning, "",
                        Snackbar.Views.SnackbarDesigner.ScopeLevels.FormOwner, Snackbar.Views.SnackbarDesigner.PlacementAreas.TopCenter, 0, false, true);
                    break;
            }
        }
    }
}
