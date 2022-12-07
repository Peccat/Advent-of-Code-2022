using System.Text;
using System;
using System.Collections.Generic;
using System.IO;

namespace Day3{
    class Day3{
        static void Main(){
            int length = 24;
            int length2 = length/2;
            for(int i = 0; i != length2; i++){       //0-11
                for(int j = length2; j != length; j++){  //12-23
                    Console.WriteLine(i + "-" + j);
                }
            }
        }
    }
}