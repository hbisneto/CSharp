using System;
using System.IO;

namespace VolumeInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //const double BytesInMB = 1048576;
            //const double BytesInGB = 1073741824;
            //const double BytesInTB = 1099511627776;

            const double BytesInMB = 1000000;
            const double BytesInGB = 1000000000;
            const double BytesInTB = 1000000000000;

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (!drive.IsReady)
                {
                    continue;
                }

                Console.WriteLine("Drive Letter: " + drive.Name);
                Console.WriteLine("Drive Format: " + drive.DriveFormat);

                double DiskCapacity = (drive.TotalSize) / (BytesInGB);
                double FreeSpace = (drive.AvailableFreeSpace) / (BytesInGB);
                double UsedSpace = DiskCapacity - FreeSpace;

                Console.WriteLine("Capacity: {0:0.00} GB", DiskCapacity);
                Console.WriteLine("Free Space: {0:0.00} GB", FreeSpace);
                Console.WriteLine("Used Space: {0:0.00} GB", UsedSpace);
                Console.WriteLine("\n");
            }
        }
    }
}
