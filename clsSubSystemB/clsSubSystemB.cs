using System;

namespace clsSubSystemB
{
    /// <summary>
    /// To control all seat belt functions - Para controlar todas as funções do cinto de segurança
    /// </summary>
    public class SeatBelt
    {
        /// <summary>
        /// Only for lock the seat belt - Somente para travar o cinto de segurança
        /// </summary>
        /// <returns>String</returns>
        public static String LockSeatBelt()
        {
            return "Locking the seat belt - Travando o cinto de segurança";
        }
        /// <summary>
        /// Only for unlock the seat belt - Somente para destravar o cinto de segurança
        /// </summary>
        /// <returns>String</returns>
        public static String UnlockSeatBelt()
        {
            return "Unlocking the seat belt - Destravando o cinto de segurança";
        }
    }
}