using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CinemaProjectB.Classes;

namespace CinemaProjectB.DAL
{
    public class DataStorageHandler
    {
        public static string StorageFileLocation { get; set; }
        public static DataStorage Storage { get; set; }

        public static void Init(string filename)
        {
            // use case hint
            if (!(File.Exists(filename)))
            {
                using StreamWriter sw = File.CreateText(filename);
            }

            StorageFileLocation = filename;
            string fileContent = File.ReadAllText(StorageFileLocation);

            // nog een hint
            try
            {
                Storage = JsonConvert.DeserializeObject<DataStorage>(fileContent);
                if (Storage == null)
                { Storage = new DataStorage(); }
            }
            catch (Exception e )
            {
                Storage = new DataStorage();
                Console.WriteLine(e);
            }   
        } 

        public static void SaveChanges()
        {
            string JsonString = JsonConvert.SerializeObject(Storage, Formatting.Indented);    
            File.WriteAllText(StorageFileLocation, JsonString);
        }
    }
}
