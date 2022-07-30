using System;
using System.Collections.Generic;
using System.Text;

namespace KeyGenerator
{
    class AccessKey
    {
        // 8 
        // 4
        // 4
        // 4
        // 12
        public int CreationPhase { get; set; }
        public int PasswordSize { get; set; }
        public string PassWordSplit1 { get; set; }
        public string PassWordSplit2 { get; set; }
        public string PassWordSplit3 { get; set; }
        public string PassWordSplit4 { get; set; }
        public string PassWordSplit5 { get; set; }
        public string RandomPass { get; set; }
        public void CreateKey()
        {
            // Create a string of characters, numbers, special characters that allowed in the password
            //PasswordSize = 15;
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();

            // Select one random character at a time from the string  
            // and create an array of chars  
            char[] chars = new char[PasswordSize];
            for (int i = 0; i < PasswordSize; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            RandomPass = new string(chars);
        }
    }
}
