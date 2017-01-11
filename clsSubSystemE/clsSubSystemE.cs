using System;
using System.Text;

namespace clsSubSystemE
{
    /// <summary>
    /// To control all radio functions - Para controlar todas as funções do rádio
    /// </summary>
    public class Radio
    {
        /// <summary>
        /// Just to turn on the radio - Somente para ligar o rádio
        /// </summary>
        /// <returns>String</returns>
        public static String TurnOnRadio()
        {
            return "Turn on the radio - Ligando o rádio";
        }

        /// <summary>
        /// Just to tune the radio - Somente para sintonizar o rádio
        /// </summary>
        /// <param name="frequency"></param>
        /// <returns>String</returns>
        public static String TuneRadio(String frequency)
        {
            StringBuilder stbTuneRadio = new StringBuilder();

            stbTuneRadio.AppendFormat("Tuning the radio to the frequency {0} - Sintonizando o rádio na frequência {0}", frequency);

            return stbTuneRadio.ToString();
        }

        /// <summary>
        /// Just to turn off the radio - Somente para desligar o rádio
        /// </summary>
        /// <returns>String</returns>
        public static String TurnOffRadio()
        {
            return "Turn off the radio - Desligando o rádio";
        }
    }
}