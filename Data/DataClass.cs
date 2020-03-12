using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace JsonData
{
    public class DataObject
    {
        public string author, header, content;
    }

    public class DataClass
    {
        public List<DataObject> Data { get; set; } = new List<DataObject>();
        private static readonly string PATH = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "data.json"));

        public DataClass()
        {
            try
            {
                Data = JArray.Parse(File.ReadAllText(PATH)).ToObject<List<DataObject>>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<string> Printable()
        {
            List<string> ret = new List<string>();
            foreach (DataObject obj in Data)
            {
                ret.Add($"({obj.author}) {obj.header}: {obj.content}");
            }
            return ret;
        }

        private int RandomIndex()
        {
            Random rng = new Random();

            return rng.Next(0, Data.Count);
        }

        /// <summary>
        /// Load a random quote
        /// </summary>
        /// <returns></returns>
        public (string author, string header, string content) Load()
        {
            int index = RandomIndex();
            string author = Data[index].author;
            string header = Data[index].header;
            string content = Data[index].content;
            return (author, header, content);
        }

        /// <summary>
        /// Load a quote at a specific zero-based index
        /// </summary>
        /// <param name="index">Quote position</param>
        /// <returns></returns>
        public (string author, string header, string content) Load(int index)
        {
            string author = Data[index].author;
            string header = Data[index].header;
            string content = Data[index].content;
            return (author, header, content);
        }

        public void AddObject(string author, string header, string content)
        {
            Data.Add(new DataObject { author = author, header = header, content = content });
        }

        public void EditObject(int index, string author, string header, string content)
        {
            Data[index] = new DataObject { author = author, header = header, content = content };
        }

        public void DeleteObject(int index)
        {
            Data.RemoveAt(index);
        }

        public void SaveData()
        {
            File.WriteAllText(PATH, JArray.FromObject(Data).ToString());
        }

        public bool HasChanges()
        {
            DataClass temp = new DataClass();
            return !temp.Data.Equals(Data);
        }
    }
}
