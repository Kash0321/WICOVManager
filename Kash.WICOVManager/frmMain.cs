using Kash.WICOVManager.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kash.WICOVManager
{
    public partial class frmMain : Form
    {
        IWinRegistryManager regMgr = null;

        public frmMain()
        {
            InitializeComponent();

            // Mostramos la versión de la aplicación en el formulario principal y el título y la versión en el caption de la ventana
            lblVersion.Text = ConfigManager.GetAppVersion();
            this.Text = string.Format(".: {0} - {1} :.", ConfigManager.GetAppName(), ConfigManager.GetAppVersion());

            regMgr = new WinRegistryManager();

            var res = regMgr.ReturnOverlayIconsRKs();

            foreach (var key in res)
            {
                outputPanel.Items.Add(key);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
