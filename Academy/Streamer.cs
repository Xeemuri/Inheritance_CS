using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Academy
{
    internal class Streamer
    {
        public void Print(Human[] group)
        {
            for (int i = 0; i < group.Length; i++)
            {
                Console.WriteLine(group[i]);
            }
        }
        public void Save(Human[] group, string filename)
        {
            Directory.SetCurrentDirectory($"{Application.ExecutablePath}\\..\\..\\..");
            Console.WriteLine(Directory.GetCurrentDirectory());
            StreamWriter writer = new StreamWriter(filename);
            foreach (Human h in group)
            {
                writer.WriteLine(h.ToFileString() + ";");
            }
            writer.Close();
            Process.Start("notepad", filename);//CSV - Comma-Separated Values (Значения, разделенные запятыми);
                                               //https://ru.wikipedia.org/wiki/CSV  
        }
        public Human[] Load(string filename)
        {
            List<Human> group = new List<Human>();
            Directory.SetCurrentDirectory($"{Application.ExecutablePath}\\..\\..\\..");
            Console.WriteLine(Directory.GetCurrentDirectory());
            StreamReader reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            {
                string record = reader.ReadLine();
                Console.WriteLine(record);
                group.Add(Factory.Create(record.Split(':').First()).Init(record.Split(":,;".ToCharArray())));
            }
            reader.Close();
            return group.ToArray();
        }
    }
}
