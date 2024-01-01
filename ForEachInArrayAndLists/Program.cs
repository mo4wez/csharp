using System;

namespace ForEachInArrayAndLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            students.Add("moawezz");
            students.Add("yasin");
            students.Add("naseer");

            List<string> fields = new List<string>()
            {
                "English", "math", "Physics"
            };

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }

            foreach (string field in fields)
            {
                Console.WriteLine("=====");
                Console.WriteLine(field);
            }
        }
    }
}
