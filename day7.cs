
using System;
using System.IO;
using System.Collections.Generic;

namespace Day7
{
    class day7
    {
        public struct FileSystems
        {
            public string filePath;
            public int size;
        };
        static void Main(){
            try
            {
                using(StreamReader sr = new StreamReader("day7.txt")){
                    
                    //int maxSize = 100000;
                    List<string> fileSystem = new List<string>();//file elérési útja addig ( cd név hozzáad, cd.. elveszi az utolsót)
                    List<string> files = new List<string>();//elérési út(spacekkel elválasztva) + fileneve + méret 
                    List<string> allFiles = new List<string>(); //
                    //int sumOfDir = 0;
                    string line1;
                    while((line1 = sr.ReadLine()) != null){
                        var line = line1.Split(" ");
                        //Console.WriteLine("Line:\t\t" + String.Join(" ", line));
                        if(line[1] == "cd"){

                            if(line[2] == ".."){
                                fileSystem.RemoveAt(fileSystem.Count-1);
                                //Console.WriteLine("FileSys:\t" + String.Join(" ", fileSystem));
                            }else{
                                fileSystem.Add(line[2]);
                                //Console.WriteLine("FileSys:\t" + String.Join(" ", fileSystem));
                            }
                        }else if(line[0] != "$"){
                            for(int i = 0; i < fileSystem.Count; i++){
                                files.Add(fileSystem[i]);
                            }
                            
                            files.Add(line[1]);
                            files.Add(line[0]);

                            //Console.WriteLine("1Files:\t" + String.Join(" ", files));
                            //Console.WriteLine("1FileSys:\t" + String.Join(" ", fileSystem));
                            allFiles.Add(String.Join(" ", files));
                            //Console.WriteLine("AllFiles:\t" + String.Join("\n\t\t", allFiles));
                            files.Clear();
                            
                            //Console.WriteLine("2Files:\t" + String.Join(" ", files));
                            //Console.WriteLine("2FileSys:\t" + String.Join(" ", fileSystem));
                        }
                    }
                    allFiles.Sort();
                    
                    int Tab = 0;

                    Console.WriteLine("----------------");
                    List<FileSystems> FileSystem = new List<FileSystems>();
                    FileSystems FS = new FileSystems();
                    for(int i=0; i < allFiles.Count;i++){

                        var line = allFiles[i].Split(" ");
                        string name = "";
                        Tab = line.Length - 2;
                        for(int j = 0; j < Tab; j++){
                            Console.Write("    ");
                            
                        }
                        
                        int value;
                        if(int.TryParse(line[line.Length-1], out value)){
                            for(int j = 0; j < Tab; j++){
                                name += line[j];
                            }
                            int size = value;
                            FS.filePath = name;
                            FS.size = size;
                            FileSystem.Add(FS);

                        }
                        for(int j = Tab; j < line.Length; j++){
                            Console.Write(line[j] + " ");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("\n\nAll Files:\t" + String.Join("\n\t\t", files));

                    
                
                
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(e.Message);
            }
        }
    }
}