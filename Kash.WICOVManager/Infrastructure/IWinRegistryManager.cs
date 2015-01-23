using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kash.WICOVManager.Infrastructure
{
    public interface IWinRegistryManager
    {
        /// <summary>
        /// Devuelve una colección con todss las claves de registro correspondientes a los iconos superpuestos
        /// </summary>
        /// <returns>Colección con todss las claves de registro correspondientes a los iconos superpuestos</returns>
        IEnumerable<string> ReturnOverlayIconsRKs();
    }
}
