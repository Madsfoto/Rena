using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ren
{

class Program
    {
        public string newname(string currentStartNumber)
        {
            // This function is moddelled from setConsoleString, same functionality. 
            // the output filename is "average(currentStartNumber).jpg, where (currentStartNumber) is a 6 digit number.
            string outputString = String.Concat(currentStartNumber, ".jpg");

            return outputString;
            // tested 8 may 2017: Works
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            string padding = "000000";
            string SearchPattern = "*.jpg";

        // for all the jpg files, do rename in increasing number, with padding
        // step 1: Find all jpg's in the current folder

        // method for getting current directory 
        string Dir = Directory.GetCurrentDirectory();

            
            // method for getting all the files in the current directory with the extention
            string[] files = Directory.GetFiles(Dir, SearchPattern);

            int currentInt=1;

                foreach (string file in files)
                {
                // increment counter
                // 
                File.Move(file, p.newname(currentInt.ToString(padding)));
                currentInt = currentInt + 1;

            }

            // step 2: use the number as the max in the renaming loop





        }
    }
}

