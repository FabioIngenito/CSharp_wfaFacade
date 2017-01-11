using System;

namespace clsSubSystemD
{
    /// <summary>
    /// To control all doors functions - Para controlar todas as funções das portas
    /// </summary>
    public class Doors
    {
        /// <summary>
        /// Only to lock the doors - Somente para travar as portas
        /// </summary>
        /// <returns>String</returns>
        public static String LockDoors()
        {
            return "Lock the doors - Travando as portas";
        }
        
        /// <summary>
        /// Only to unlock the doors - Somente para destravar as portas
        /// </summary>
        /// <returns>String</returns>
        public static String UnlockDoors()
        {
            return "Unlock the doors - Destravando as portas";
        }
    }
}
