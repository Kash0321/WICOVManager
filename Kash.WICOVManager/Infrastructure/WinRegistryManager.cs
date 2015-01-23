using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kash.WICOVManager.Infrastructure
{
    /// <summary>
    /// Gestor de operaciones sobre el registro del sistema
    /// </summary>
    public class WinRegistryManager : IWinRegistryManager
    {
        /// <contentfrom />
        public IEnumerable<string> ReturnOverlayIconsRKs()
        {
            IEnumerable<string> retVal = new List<string>();

            RegistryKey key = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\ShellIconOverlayIdentifiers");

            retVal = key.GetSubKeyNames();

            return retVal;
        }
    }
}
