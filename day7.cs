using System;
using System.IO;
using System.Collections.Generic;

namespace Day7
{
    class day7
    {
        static void Main(){
            try
            {
                using(StreamReader sr = new StreamReader("day7test.txt")){
                    string line;
                    List<string> fileSystem = new List<string>();//file elérési útja addig ( cd név hozzáad, cd.. elveszi az utolsót)
                    List<string> files = new List<string>();//elérési út(spacekkel elválasztva) + fileneve + méret 

                    while((line = sr.ReadLine()) != null){

                    }
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(e.Message());
            }
        }
    }
}