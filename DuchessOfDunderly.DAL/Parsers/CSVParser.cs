using System;
using System.Collections.Generic;
using System.IO;
using DuchessOfDunderly.DAL.Models;

namespace DuchessOfDunderly.DAL.Parsers
{
    public class CSVParser
    {
        public List<T> BuildRepository<T>(string filePath, bool header = true, string delimiter = ",") where T : IArraySourced, new()
        {
            List<T> result = new List<T>();
            using (var reader = new StreamReader(File.OpenRead(filePath)))
            {
                bool skipheader = true;
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(delimiter, StringSplitOptions.None);
                    if (header && skipheader)
                    {
                        skipheader = false;
                    }
                    else
                    {
                        T item = new T();
                        item.BuildFromArray(line);
                        result.Add(item);
                    }
                }
            }
            return result;
        }
    }
}