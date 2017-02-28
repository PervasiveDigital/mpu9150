using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using System.Threading;

using PervasiveDigital.Hardware;

namespace RadiusTest
{
    public class Program
    {
        private static Mpu9150 _mpu;

        public static void Main()
        {
            _mpu = new Mpu9150(0x68, 400, 10, Cpu.Pin.GPIO_NONE);
            _mpu.Wake();
            _mpu.setFullScaleGyroRange(2);
            _mpu.setFullScaleAccelRange(2);

            while (true)
            {
                Debug.Print("Ax Ay Az : " + _mpu.aX + ", " + _mpu.aY + ", " + _mpu.aZ);
                Debug.Print("Gx Gy Gz : " + _mpu.gX + ", " + _mpu.gY + ", " + _mpu.gZ);
                Thread.Sleep(500);
            }
        }
    }
}
