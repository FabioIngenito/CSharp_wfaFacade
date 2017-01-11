using System;

namespace clsSubSystemC
{
    /// <summary>
    /// To control all headlights functions - Para controlar todas as funções dos faróis
    /// </summary>
    public class Headlights
    {
        /// <summary>
        /// Just to turn on the headlights - Somente para ligar o faról
        /// </summary>
        /// <returns>String</returns>
        public static String TurnOnHeadlights()
        {
            return "Turn on the headlights - Ascendendo o farol";
        }

        /// <summary>
        /// Just to turn off the headlights - Somente para desligar o faról
        /// </summary>
        /// <returns>String</returns>
        public static String TurnOffHeadlights()
        {
            return "Turn off the headlights - Apagando o farol";
        }
    }
}