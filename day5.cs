using System;
using System.IO;
using System.Collections.Generic;

namespace Day5
{
    class day5
    {
        static void Main(){
            try
            {
                using(StreamReader sr = new StreamReader("day5test.txt")){
                    string line;
                    char[,] table = new char[,]{{'Z', 'N', '0', '0', '0'},{'M' , 'C' , 'D', '0', '0'}, {'P', '0', '0', '0', '0'}};
                    int honnan;
                    int hova;
                    int mennyit;
                    int[] lastElemet = {1,2,0};
                    while((line = sr.ReadLine()) != null){
                        var lines = line.Split(" ");
                        if(lines[0] == "move"){
                            mennyit = int.Parse(lines[1]);
                            honnan = int.Parse(lines[3]);
                            hova = int.Parse(lines[5]);

                            for(int i = 0; i < mennyit; i--){
                                table[hova,lastElemet[hova]+1] = table[honnan,lastElemet[honnan]];
                                table[honnan,lastElemet[honnan]] = '0';
                                lastElemet[honnan]--;
                                lastElemet[hova]++;
                                
                            }
                            for(int i = 0; i < 3; i++){
                                for(int j = 0; j < 3; j++){
                                    Console.Write(table[i,j]);
                                }
                                Console.WriteLine();
                            }
                        }
                        Console.WriteLine();
                    }
                    
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("The file is not readable");
                Console.WriteLine(ex.Message);
            }
        }
    }
}