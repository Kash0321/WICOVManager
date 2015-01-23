using Kash.WICOVManager.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kash.WICOVManager.Infrastructure
{
    public static class ConfigManager
    {
        /// <summary>
        /// Versión de la aplicación
        /// </summary>
        static string _AppVersion = null;

        /// <summary>
        /// Devuelve la versión de la aplicación
        /// </summary>
        /// <returns></returns>
        public static string GetAppVersion()
        {
            if (string.IsNullOrWhiteSpace(_AppVersion))
            {
                var asm = Assembly.GetExecutingAssembly();
                _AppVersion = string.Format("v{0}", asm.GetName().Version.ToString());
            }
            return _AppVersion;
        }

        public static string GetAppName()
        {
            return Literals.AppName;
        }
    }
}
