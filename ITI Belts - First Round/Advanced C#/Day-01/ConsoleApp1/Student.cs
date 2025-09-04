using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public string Name { get; set; }
        public int? Age { get; set; }
        public List<int> Scores { get; set; }

        public Student(string name, int? age = null)
        {
            Name = name;
            Age = age;
            Scores = new List<int>();
        }

        public void AddScores(params int[] scores)
        {
            foreach (var score in scores)
            {
                Scores.Add(score);
            }
        }

        public double? GetAverageScore()
        {
            if (Scores.Count == 0) return null;
            return Scores.Average();
        }
    }
}
