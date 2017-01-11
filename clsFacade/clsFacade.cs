using System;
using System.Text;
using clsSubSystemA;
using clsSubSystemB;
using clsSubSystemC;
using clsSubSystemD;
using clsSubSystemE;

namespace clsFacade
{
    public class Car
    {
        public static String Drive(String frequency)
        {
            StringBuilder stbLine = new StringBuilder();

            //Portas.Destrancar();
            stbLine.AppendLine(Doors.UnlockDoors());

            //Portas.Trancar();
            stbLine.AppendLine(Doors.LockDoors());

            //CintoDeSeguranca.Travar();
            stbLine.AppendLine(SeatBelt.LockSeatBelt());

            //Motor.Ligar();
            stbLine.AppendLine(Engine.TurnOnEngine());

            //Farol.Ascender();
            stbLine.AppendLine(Headlights.TurnOnHeadlights());

            //Radio.Ligar();
            stbLine.AppendLine(Radio.TurnOnRadio());

            //Radio.Sintonizar(91.3);
            stbLine.AppendLine(Radio.TuneRadio(frequency));

            return stbLine.ToString();
        }

        public static String Park()
        {
            StringBuilder stbLine = new StringBuilder();

            ////Motor.Desligar();
            stbLine.AppendLine(Engine.TurnOffEngine());

            ////CintoDeSeguranca.Destravar();
            stbLine.AppendLine(SeatBelt.UnlockSeatBelt());

            ////Farol.Apagar();
            stbLine.AppendLine(Headlights.TurnOffHeadlights());

            ////Radio.Desligar();
            stbLine.AppendLine(Radio.TurnOffRadio());

            ////Portas.Destrancar();
            stbLine.AppendLine(Doors.UnlockDoors());

            return stbLine.ToString();
        }
    }
}
