using System;
using System.Linq;
using Homework_EF.DataAccess;

namespace Homework_EF.Servises
{
    internal class Reporter
    {
        public void MakeReport(TestingDbContext context)
        {
            using (context)
            {
                var resultsByUser = context.TestResults.GroupBy(u => u.User, r => r,
                    (k, d) => new {User = k, Result = d});

                var report1 =
                    resultsByUser.Where(
                        ru =>
                            ru.Result.Count(
                                r =>
                                    r.Result >= r.Test.PassingScore) ==
                            ru.Result.Count()).Select(ru => ru.User);

                var report2 =
                    resultsByUser.Where(
                        ru =>
                            ru.Result.Count(
                                r =>
                                    r.TimeTaken <= r.Test.GivenTime &&
                                    r.Result >= r.Test.PassingScore) ==
                            ru.Result.Count()).Select(ru => ru.User);

                var report3 =
                    resultsByUser.Where(
                        ru =>
                            ru.Result.Count(
                                r =>
                                    r.TimeTaken > r.Test.GivenTime &&
                                    r.Result >= r.Test.PassingScore) > 0).
                        Select(ru => ru.User);

                var report4 = context.Users.GroupBy(c => c.City, u => u, (k, d) => new {City = k, Students = d});

                var report5 = report2.GroupBy(c => c.City, u => u, (k, d) => new {City = k, Students = d});

                var report6 =
                    context.TestResults.GroupBy(u => u.User, r => r, (key, data) => new {User = key, Result = data})
                        .Select(
                            ru =>
                                new
                                {
                                    Student = ru.User,
                                    TestResults =
                                        ru.Result.Select(
                                            r => new {Result = r.Result, TimeTaken = r.TimeTaken, Test = r.Test}),
                                    Rate = (double) ru.Result.Sum(item => item.Result)/ru.Result.Count(),
                                });

                var report7 =
                    context.Questions.Select(q => new {q.Tests.Count, q.Text, q.Category})
                        .OrderByDescending(s => s.Count);

                var report8 = context.Teachers.Select(t => new {t.Lecture.Count, t.Name})
                    .OrderByDescending(s => s.Count);

                var report9 = context.Tests.GroupBy(t => t.Category, d => d,
                    (key, data) => new {Category = key, Test = data})
                    .Select(g => new {Average = g.Test.Average(t => t.TestResult.Result), g.Category})
                    .OrderByDescending(t => t.Average);

                var report10 =
                    context.Answers.GroupBy(a => a.Question, a => a)
                        .Select(aq => new {Question = aq.Key, Count = aq.Count()})
                        .OrderByDescending(a => a.Count);

                Console.WriteLine("\nReport 1. Users that successfully passed their tests, regardless of time taken\n");
                foreach (var item in report1)
                {
                    Console.WriteLine("{0} -- {1} -- Age : {2} -- {3} -- {4} -- {5}", item.Name, item.Email, item.Age, item.Category, item.City, item.University);
                }

                Console.WriteLine("\nReport 2. Users that successfully passed their tests in time\n");
                foreach (var item in report2)
                {
                    Console.WriteLine("{0} -- {1} -- Age : {2} -- {3} -- {4} -- {5}", item.Name, item.Email, item.Age, item.Category, item.City, item.University);
                }

                Console.WriteLine("\nReport 3. Users that successfully passed their tests but didn't make it in time\n");
                foreach (var item in report3)
                {
                    Console.WriteLine("{0} -- {1} -- Age : {2} -- {3} -- {4} -- {5}", item.Name, item.Email, item.Age, item.Category, item.City, item.University);
                }

                Console.WriteLine("\nReport 4. Number of students grouped by city\n");
                foreach (var item in report4)
                {
                    Console.WriteLine("\n{0} -- {1}", item.City, item.Students.Count());
                    foreach (var st in item.Students)
                    {
                        Console.WriteLine("{0} -- {1} -- Age : {2} -- {3} -- {4} -- {5}", st.Name, st.Email, st.Age, st.Category, st.City, st.University);
                    }
                }

                Console.WriteLine("\nReport 5. Successful students grouped by city\n");
                foreach (var item in report5)
                {
                    Console.WriteLine("\n{0} -- {1}", item.City, item.Students.Count());
                    foreach (var st in item.Students)
                    {
                        Console.WriteLine("{0} -- {1} -- Age : {2} -- {3} -- {4} -- {5}", st.Name, st.Email, st.Age, st.Category, st.City, st.University);
                    }
                }

                Console.WriteLine("\nReport 6. Results for every student + success rate (%)\n");
                foreach (var item in report6)
                {
                    Console.WriteLine("\n{0} -- success rate : {1}", item.Student.Name, item.Rate);
                    foreach (var res in item.TestResults)
                    {
                        Console.WriteLine("{0} -- {1} -- {2} minutes", res.Test.Name, res.Result, res.TimeTaken);
                    }
                }

                Console.WriteLine("\nReport 7. Rating of popularity of questions. Number of times used in tests\n");
                foreach (var item in report7)
                {
                    Console.WriteLine("{0} -- {1} -- {2}", item.Text, item.Category.Name, item.Count);
                }

                Console.WriteLine("\nReport 8. Rating of teachers by number of lectures\n");
                foreach (var item in report8)
                {
                    Console.WriteLine("{0} -- {1}", item.Name, item.Count);
                }

                Console.WriteLine("\nReport 9. Average score of tests by category\n");
                foreach (var item in report9)
                {
                    Console.WriteLine("{0} -- average : {1}", item.Category.Name, item.Average);
                }

                Console.WriteLine("\nReport 10. Rating of correctly answered questions\n");
                foreach (var item in report10)
                {
                    Console.WriteLine("{0} -- answered {1} times", item.Question.Text, item.Count);
                }
            }
        }
    }
}

