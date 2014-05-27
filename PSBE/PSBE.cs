using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * PSBElib: A C#.NET implementation of the PSBE encryption algorithm.
 *
 * Originally written in QBasic, PSBE is a simple and fast encryption
 * algorithm.
 *
 * Original Author: Mario LaRosa
 *           eMail: ESmemberNEMESIS@aol.com
 *         Website: http://members.aol.com/esmembernemesis/index.htm
 *         
 * C# Rewrite Author: Steven Gann
 *             eMail: sgann2012@fau.edu
 *             
 * LICENSE from original QBasic source:
 *   (C)opyright 2004, Pure QB Innovations
 *   THIS PROGRAM MAY BE DISTRIBUTED FREELY AS PUBLIC DOMAIN SOFTWARE
 *   AS LONG AS ANY PART OF THIS FILE IS NOT ALTERED IN ANY WAY.
 *   IF YOU DO WISH TO USE THESE ROUTINES IN YOUR OWN PROGRAMS
 *   THEN PLEASE GIVE CREDIT TO THE AUTHOR... Mario LaRosa.
 *           
 */

namespace PSBElib
{
    public class PSBE
    {
        //=================================================
        //Public Methods
        //-------------------------------------------------

        //The primary method of this library. Takes in a string and a password
        //and outputs an encrypted string.
        public static string Encrypt(string payload, string password)
        {
            string result = "";
            return result;
        }

        //The other primary method of this library. Takes in a string and a
        //password and outputs a decrypted string.
        public static string Decrypt(string payload, string password)
        {
            string result = "";
            return result;
        }

        //A simple checksum of random integers generated from a known seed.
        //Verifies that the RNG is actually working correctly.
        public static bool Diagnostic()
        {
            bool result = false;

            Random RNG = new Random(82052);
            float testResult = 0;

            for (int i = 1; i <= 100000; i++)
            {
                testResult -= RNG.Next(100000);
                testResult += RNG.Next(100000);
            }

            if (testResult == -4089972)
            {
                result = true;
            }

            return result;
        }
        //=================================================
        //Private Methods
        //-------------------------------------------------

        //Processes the password string and returns a seed for the the RNG.
        private int plant(string password)
        {
            int lenPassword = password.Length;
            int seed = 0x8000;
            int r = 0;
            Random RNG = new Random(seed);

            for (int x = 1; x <= lenPassword; x++)
            {
                r = (int)(((float)RNG.Next(1000000)/(1000000.0f)) * lenPassword + 1);

                //seed = seed + 
            }

            return seed;
        }

        //C# implementation of the nested QBasic functions ASC(MID$())
        private int ASCMID(string password, int r, int n)
        {
            int result = 0;

            return result;
        }


        
    }
}
