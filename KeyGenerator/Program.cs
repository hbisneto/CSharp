using System;

namespace KeyGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var Keys = new AccessKey();

            for(int i = 0; i < 5; i++)
            {
                Keys.CreationPhase++;
                
                if(Keys.CreationPhase == 1)
                {
                    Keys.PasswordSize = 8;
                    Keys.CreateKey();
                    Keys.PassWordSplit1 = Keys.RandomPass;
                }

                if (Keys.CreationPhase == 2)
                {
                    Keys.PasswordSize = 4;
                    Keys.CreateKey();
                    Keys.PassWordSplit2 = Keys.RandomPass;
                }

                if (Keys.CreationPhase == 3)
                {
                    Keys.PasswordSize = 4;
                    Keys.CreateKey();
                    Keys.PassWordSplit3 = Keys.RandomPass;
                }

                if (Keys.CreationPhase == 4)
                {
                    Keys.PasswordSize = 4;
                    Keys.CreateKey();
                    Keys.PassWordSplit4 = Keys.RandomPass;
                }

                if (Keys.CreationPhase == 5)
                {
                    Keys.PasswordSize = 12;
                    Keys.CreateKey();
                    Keys.PassWordSplit5 = Keys.RandomPass;
                }
            }
            Console.WriteLine($"{Keys.PassWordSplit1}-{Keys.PassWordSplit2}-{Keys.PassWordSplit3}-{Keys.PassWordSplit4}-{Keys.PassWordSplit5}");

            // 8
            // 4
            // 4
            // 4
            // 12
            //WOML2WAS-G0Q7-58FH-JTBO-YF03ZWEO7B00
            //S4QBRXOD-WYVG-8DK1-92VP-NNL70VYNQ3KA
            //R71Y0JXD-0X1G-KLGJ-W2CA-XFPH3FQAWW2C

            //R71Y0JXD-0X1G-KLGJ-XFPH3FQA
        }
    }
}