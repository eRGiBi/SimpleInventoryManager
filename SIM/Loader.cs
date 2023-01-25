using SIM.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SIM
{
    class Loader
    {
        public static List<T> Load<T>(string fileName, IItemParser parser)
        {
            FileInfo fileInfo = new FileInfo(fileName);
          
            if (!fileInfo.Exists)
            {
                fileName = "..\\..\\..\\Data\\" + fileName;
            }

            StreamReader stream = new StreamReader(fileName);
            
            List<T> objects = new List<T>();

            while (!stream.EndOfStream)               
            {                       
                string line = stream.ReadLine();    
                
                if (!(line == null))                   
                {
                    //objects.Add((T)Convert.ChangeType(parser.Parse(line), typeof(T))); 
                    //bad practice?

                    object objectToAdd = parser.Parse(line);

                    if (!(objectToAdd is T))
                    {
                        throw new Exception("Error with the file");                       
                    }
                    else { objects.Add((T)objectToAdd); }

                }               
            }           
            stream.Close();               
            return objects;           
        }
    }
}
