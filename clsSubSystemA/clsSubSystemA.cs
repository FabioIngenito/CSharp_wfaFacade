using System;

namespace clsSubSystemA
{
    /// <summary>
    /// To control all engine functions - Para controlar todas as funções do motor
    /// </summary>
    public class Engine
    {
        /// <summary>
        /// Only for Start the engine - Somente para ligar o motor
        /// </summary>
        /// <returns>String</returns>
        public static String TurnOnEngine()
        {
            return "Starting the engine - Ligando o motor";
        }

        /// <summary>
        /// Only to switch off the engine - Somente para desligar o motor
        /// </summary>
        /// <returns>String</returns>
        public static String TurnOffEngine()
        {
            return "Shutting down the engine - Desligando o motor";
        }
    }
}