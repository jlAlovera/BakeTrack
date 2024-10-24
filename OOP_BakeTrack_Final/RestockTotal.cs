using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_BakeTrack_Final
{
    internal class RestockTotal
    {
        public static double increase(double add)
        {
            String filename = "Restock_Total.txt";
            double value = get() + add;
            string vstr = String.Format("{0:0.00}", value);
            File.WriteAllText(filename, vstr);
            return value;
        }
        public static double get()
        {
            double value = 0.0f;
            String filename = "Restock_Total.txt";
            if (File.Exists(filename))
            {
                string original_str = File.ReadAllText(filename);
                value = Convert.ToDouble(original_str);
                value = Math.Round(value, 2);
            }
            return value;
        }
        public static void clear()
        {
            String filename = "Restock_Total.txt";
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
        }
    }
}
