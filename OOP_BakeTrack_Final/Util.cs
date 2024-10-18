using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BakeTrack_Final
{
    internal class Util
    {
        public static String checkValidName(String input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsLetter(input[i]) && input[i] != ' ')
                {
                    throw new Exception("Invalid name.");
                }
            }

            return input;
        }
    }
}
