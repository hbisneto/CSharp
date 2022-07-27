using System;
using System.IO;

namespace VolumeInfo
{
    class Program
    {
        public double DiskCapacity { get; set; }
        public double FreeSpace { get; set; }
        public double UsedSpace { get; set; }

        public string DiskCapacityUnityType { get; set; }
        public string FreeSpaceUnityType { get; set; }
        public string UsedSpaceUnityType { get; set; }

        public string DiskCapacityOutput { get; set; }
        public string FreeSpaceOutput { get; set; }
        public string UsedSpaceOutput { get; set; }

        static void Main(string[] args)
        {
            // We use these constants to convert bytes to megabytes and gigabytes
            //const double BytesInMB = 1048576;
            //const double BytesInGB = 1073741824;
            //const double BytesInTB = 1099511627776;
            const double BytesInMB = 1000000;
            const double BytesInGB = 1000000000;
            const double BytesInTB = 1000000000000;

            Console.WriteLine("Computer drive sizes:");

            // Go through each of the computer's drives
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                // Skip to next loop cycle when drive is not ready
                if (!drive.IsReady)
                    continue;

                if (drive.VolumeLabel == "/") // Macintosh HD. I don't need additional drives
                {
                    string DiskCapacityUnity = "";
                    string FreeSpaceUnity = "";
                    string UsedSpaceUnity = "";

                    double DiskCapacity = (drive.TotalSize);
                    double FreeSpace = (drive.AvailableFreeSpace);
                    double UsedSpace = (DiskCapacity - FreeSpace);

                    // CHECK USED SPACE
                    if (UsedSpace > 1000)
                    {
                        // Bytes to MB
                        UsedSpace = (DiskCapacity - FreeSpace) / BytesInMB;
                        UsedSpaceUnity = "MB";
                    }

                    if (UsedSpace > 1000)
                    {
                        UsedSpace = (DiskCapacity - FreeSpace) / BytesInGB;
                        UsedSpaceUnity = "GB";
                    }

                    if (UsedSpace > 1000)
                    {
                        UsedSpace = (DiskCapacity - FreeSpace) / BytesInTB;
                        UsedSpaceUnity = "TB";
                    }

                    // CHECK DISK CAPACITY
                    if (DiskCapacity > 1000)
                    {
                        // Bytes to MB
                        DiskCapacity = drive.TotalSize / BytesInMB;
                        DiskCapacityUnity = "MB";
                    }

                    if(DiskCapacity > 1000)
                    {
                        DiskCapacity = drive.TotalSize / BytesInGB;
                        DiskCapacityUnity = "GB";
                    }

                    if(DiskCapacity > 1000)
                    {
                        DiskCapacity = drive.TotalSize / BytesInTB;
                        DiskCapacityUnity = "TB";
                    }

                    // CHECK DISK FREE SPACE
                    if (FreeSpace > 1000)
                    {
                        // Bytes to MB
                        FreeSpace = drive.AvailableFreeSpace / BytesInMB;
                        FreeSpaceUnity = "MB";
                    }

                    if (FreeSpace > 1000)
                    {
                        FreeSpace = drive.AvailableFreeSpace / BytesInGB;
                        FreeSpaceUnity = "GB";
                    }

                    if (FreeSpace > 1000)
                    {
                        FreeSpace = drive.AvailableFreeSpace / BytesInTB;
                        FreeSpaceUnity = "TB";
                    }

                    Console.WriteLine("Capacity: {0:0.00} " + DiskCapacityUnity, DiskCapacity);
                    Console.WriteLine("Free Space: {0:0.00} " + FreeSpaceUnity, FreeSpace);
                    Console.WriteLine("Used Space: {0:0.00} " + UsedSpaceUnity, UsedSpace);
                }
            }

            Console.WriteLine("\nPress a key to close this window...");
            Console.ReadKey();
        }
    }
}

