using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Cirelli_Unit3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //************************************************************
            //******Assignment 3 Section 1
            //************************************************************

            string[,] salesRegions;
            salesRegions = new string[4, 4];
            salesRegions[0,0] = "North";
            salesRegions[1, 0] = "South";
            salesRegions[2, 0] = "East";
            salesRegions[3, 0] = "West";

            salesRegions[0, 1] = "Bob";
            salesRegions[0, 2] = "Stef";
            salesRegions[0, 3] = "Ron";

            salesRegions[1, 1] = "Sue";
            salesRegions[1, 2] = "Janice";
            salesRegions[1, 3] = "Will";

            salesRegions[2, 1] = "Nathan";
            salesRegions[2, 2] = "Henry";
            salesRegions[2, 3] = "Kimmy";

            salesRegions[3, 1] = "Wanda";
            salesRegions[3, 2] = "Charles";
            salesRegions[3, 3] = "Pete";

            
        }
    }
}
