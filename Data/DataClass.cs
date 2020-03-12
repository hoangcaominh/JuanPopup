using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace JsonData
{
    public class DataObject
    {
        public string author, header, content;
    }

    public class DataClass
    {
        private List<DataObject> Data { get; set; } = new List<DataObject>();

        public DataClass()
        {
            try
            {
                Data = JArray.Parse(File.ReadAllText("data.json")).ToObject<List<DataObject>>();
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

        public int Size()
        {
            return Data.Count;
        }

        public void Shuffle()
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            int n = Data.Count;

            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                DataObject value = Data[k];
                Data[k] = Data[n];
                Data[n] = value;
            }
        }

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
            File.WriteAllText("data.json", JArray.FromObject(Data).ToString());
        }

        public bool HasChanges()
        {
            DataClass temp = new DataClass();
            return !temp.Data.Equals(Data);
        }
    }
}
