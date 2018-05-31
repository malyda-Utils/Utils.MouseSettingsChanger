using MouseSettingsChangerLib;
using System;

namespace Utils.MouseSettingsChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            // new mouse speed value
            UInt32 mouseSpeed = 5;

            // change sensitivity
            Changer.ChangeMouseSpeed(mouseSpeed); 

            Console.WriteLine("MouseSpeedChanged to: {0}", mouseSpeed);
            Console.Read();
        }
    }
}
