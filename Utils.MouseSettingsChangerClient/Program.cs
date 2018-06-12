using MouseSettingsChangerLib;
using System;

namespace Utils.MouseSettingsChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            // default mouse speed value
            UInt32 defaultMouseSpeed = 5;

            UInt32 newMouseSpeed;

            while(true)
            {
                Console.WriteLine("Type number between 1-10 to set new mouse speed.");
                if(UInt32.TryParse(Console.ReadLine(),out newMouseSpeed))
                {
                    // If new mouse speed is between 1 and 10 change it
                    if(newMouseSpeed < 0 || newMouseSpeed > 10)
                    {
                        newMouseSpeed = defaultMouseSpeed;
                    }
                    // change sensitivity
                    Changer.ChangeMouseSpeed(newMouseSpeed);

                    Console.WriteLine("MouseSpeedChanged to: {0}", newMouseSpeed);
                    Console.WriteLine("Actual mouse speed from WinApi: {0}", Changer.GetMouseSpeed());
                    break;
                }
            }

            Console.Read();
        }
    }
}
