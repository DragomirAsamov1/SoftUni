using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking {
    internal class Program {
        static void Main(string[] args) {
            string input = string.Empty;

            Dictionary<string, string> contests = new Dictionary<string, string>();     //Речник съдържащ състезания с парола

            Dictionary<string, Student> candidates = new Dictionary<string,Student>();  //Речник от кандидати съдържащ име и студент(име и списък с точки

            while ((input = Console.ReadLine()) != "end of contests") {
                string[] command = input.Split(':');

                contests.Add(command[0], command[1]);   //Тук се пълни речника състезания
            }

            while ((input = Console.ReadLine()) != "end of submissions") {  
                string[] command = input.Split("=>");

                string contest = command[0];
                string password = command[1];
                string username = command[2];
                int points = int.Parse(command[3]);

                if (!contests.ContainsKey(contest) || contests[contest] != password) {  //Проверка ако името на състезанието или паролата не съвпадат
                    continue;
                }

                if (!candidates.ContainsKey(username)) {    //Проверка дали в списъка Кандидати името на студента липсва
                    candidates.Add(username, new Student(username));
                }
                Student student = candidates[username];     //Създава се студент

                if (!student.ContestsWithPoints.ContainsKey(contest)) {     //Проверка дали студента не е бил на подаденото състезание
                    student.ContestsWithPoints.Add(contest, points);
                    continue;
                }

                if (student.ContestsWithPoints[contest] < points) {     //Проверка дали точките на студента от дадено състезание са по-малко от текущите
                    student.ContestsWithPoints[contest] = points;
                }
            }

            PrintTheRanking(candidates.Values.ToList());
        }

        private static void PrintTheRanking(List<Student> listWithStudents) {
            Student bestCandidate = listWithStudents.OrderByDescending(x => x.ContestsWithPoints.Values.Sum()).First();

            Console.WriteLine($"Best candidate is {bestCandidate.Name} with total {bestCandidate.ContestsWithPoints.Values.Sum()} points.");

            Console.WriteLine("Ranking: ");

            foreach (var student in listWithStudents.OrderBy(x => x.Name)) {
                Console.WriteLine(student.Name);

                foreach (var (contest, points) in student.ContestsWithPoints.OrderByDescending(x => x.Value)) {
                    Console.WriteLine($"#  {contest} -> {points}");
                }
            }
        }
    }
}
