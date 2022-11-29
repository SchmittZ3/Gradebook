using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;

namespace Gradebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, IDictionary<string, List<decimal>>> students = new Dictionary<string, IDictionary<string, List<decimal>>>
            {
                {
                    "Morty",
                    new Dictionary<string, List<decimal>>
                    {
                        { "homework", new List<decimal> { 90, 67, 97 } },
                        { "quizzes", new List<decimal> { 85, 72, 60 } },
                        { "tests", new List<decimal> { 90, 95, 92 } }
                    }
                },
                {
                    "Opie",
                    new Dictionary<string, List<decimal>>
                    {
                        { "homework", new List<decimal> { 72, 61, 79 } },
                        { "quizzes", new List<decimal> { 75, 0, 100 } },
                        { "tests", new List<decimal> { 79, 86, 97 } }
                    }
                },
                {
                    "Charlie",
                    new Dictionary<string, List<decimal>>
                    {
                        { "homework", new List<decimal> { 91, 92, 93 } },
                        { "quizzes", new List<decimal> { 78, 67, 80 } },
                        { "tests", new List<decimal> { 91, 89, 87 } }
                    }
                }
            };
            CalculateAssignmentAverage(students);

        }

        static void PrintStudentInfo(IDictionary<string, IDictionary<string, List<decimal>>> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.Key);
                foreach (var kvp in student.Value)
                {
                    Console.Write("{0}:", kvp.Key);
                    foreach (var score in kvp.Value)
                    {
                        Console.Write(" {0}", score);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        static void CalculateClassAverage(string name, string assignment)
        {

        }

        static void CalculateAssignmentAverage(IDictionary<string, IDictionary<string, List<decimal>>> students)
        {
            foreach (var student in students)
            {
                foreach (var kvp in student.Value)
                {
                    decimal avgScore = Decimal.Round(kvp.Value.Average(), 1);
                    char letterGrade = GetLetterGrade(avgScore);
                    Console.Write("{0}'s average score for {1} was {2} ({3})\n", student.Key, kvp.Key, avgScore, letterGrade);
                }
            }
        }

        static char GetLetterGrade(decimal score)
        {
            if (score >= 90)
            {
                return 'A';
            }
            else if (score >= 80)
            {
                return 'B';
            }
            else if (score >= 70)
            {
                return 'C';
            }
            else if (score >= 60)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }
    }
}


