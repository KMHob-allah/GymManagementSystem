using GymManagementSystem.BLL;
using GymManagementSystem.UI;
using GymManagementSystem.UI.Authentication;
using System;
using System.Windows.Forms;

namespace GymManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                using (var frmLogin = new frmLogin())
                {
                    if (frmLogin.ShowDialog() != DialogResult.OK)
                        break;
                }

                using (var frmMain = new Main())
                {
                    Application.Run(frmMain);
                }

                GlobalSettings.CurrentUser = null;
            }
        }
    }
}