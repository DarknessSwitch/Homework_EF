using System.Collections.Generic;
using Homework_EF.Models;

namespace Homework_EF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Homework_EF.DataAccess.TestingDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Homework_EF.DataAccess.TestingDbContext context)
        {
            IList<Category> categories = new List<Category>();
            categories.Add(new Category { Name = ".Net" });
            categories.Add(new Category { Name = "JS" });
            categories.Add(new Category { Name = "PHP" });
            categories.Add(new Category { Name = "DB" });
            categories.Add(new Category { Name = "OOP" });
            categories.Add(new Category { Name = "English" });
            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }

            IList<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher { Name = "Dmitrii" });
            teachers.Add(new Teacher { Name = "Stepan" });
            teachers.Add(new Teacher { Name = "Fedor" });
            foreach (var item in teachers)
            {
                context.Teachers.Add(item);
            }

            IList<Lecture> lectures = new List<Lecture>();
            lectures.Add(new Lecture
            {
                Category = categories[0],
                Name = "lecture 1",
                Teacher = new[] { teachers[0], teachers[1] },
                Description = "lecture 1 description"
            });
            lectures.Add(new Lecture
            {
                Category = categories[1],
                Name = "lecture 2",
                Teacher = new[] { teachers[0], teachers[2] },
                Description = "lecture 2 description"
            });
            lectures.Add(new Lecture
            {
                Category = categories[2],
                Name = "lecture 3",
                Teacher = new[] { teachers[1], teachers[2] },
                Description = "lecture 3 description"
            });
            lectures.Add(new Lecture
            {
                Category = categories[3],
                Name = "lecture 4",
                Teacher = new[] { teachers[1] },
                Description = "lecture 4 description"
            });
            lectures.Add(new Lecture
            {
                Category = categories[4],
                Name = "lecture 5",
                Teacher = new[] { teachers[0] },
                Description = "lecture 5 description"
            });
            lectures.Add(new Lecture
            {
                Category = categories[5],
                Name = "lecture 6",
                Teacher = new[] { teachers[1] },
                Description = "lecture 6 description"
            });
            lectures.Add(new Lecture
            {
                Category = categories[0],
                Name = "lecture 7",
                Teacher = new[] { teachers[0] },
                Description = "lecture 7 description"
            });
            foreach (var item in lectures)
            {
                context.Lectures.Add(item);
            }

            IList<User> users = new List<User>();
            users.Add(new User
            {
                Name = "Andrey",
                Email = "andrew1337@gmail.com",
                Age = 19,
                Category = categories[0],
                City = "Zaporizhya",
                University = "ZNTU"
            });
            users.Add(new User
            {
                Name = "Sergey",
                Email = "sergey1336@gmail.com",
                Age = 20,
                Category = categories[1],
                City = "Kiev",
                University = "KPI"
            });
            users.Add(new User
            {
                Name = "Alexandr",
                Email = "sanyok@gmail.com",
                Age = 21,
                Category = categories[2],
                City = "Kiev",
                University = "KPI"
            });
            users.Add(new User
            {
                Name = "Varvara",
                Email = "varya@gmail.com",
                Age = 19,
                Category = categories[0],
                City = "Lviv",
                University = "LNU"
            });
            users.Add(new User
            {
                Name = "Nikita",
                Email = "nekit@gmail.com",
                Age = 21,
                Category = categories[2],
                City = "Lviv",
                University = "LNU"
            });
            users.Add(new User
            {
                Name = "Irakliy",
                Email = "irakliy@gmail.com",
                Age = 19,
                Category = categories[1],
                City = "Kharkiv",
                University = "KNU"
            });
            users.Add(new User
            {
                Name = "Anton",
                Email = "antoha@gmail.com",
                Age = 20,
                Category = categories[1],
                City = "Kiev",
                University = "KPI"
            });
            users.Add(new User
            {
                Name = "Konstantin",
                Email = "bones@gmail.com",
                Age = 22,
                Category = categories[0],
                City = "Kiev",
                University = "KPI"
            });
            users.Add(new User
            {
                Name = "Georgiy",
                Email = "jora1337@gmail.com",
                Age = 21,
                Category = categories[2],
                City = "Lviv",
                University = "LNU"
            });
            users.Add(new User
            {
                Name = "Tomara",
                Email = "tomato@gmail.com",
                Age = 22,
                Category = categories[1],
                City = "Kharkiv",
                University = "KNU"
            });
            foreach (var item in users)
            {
                context.Users.Add(item);
            }

            IList<Test> tests = new List<Test>();

            tests.Add(new Test
            {
                Name = ".Net test 1",
                Category = categories[0],
                PassingScore = 60,
                GivenTime = 20,
            });
            tests.Add(new Test
            {
                Name = ".Net test 2",
                Category = categories[0],
                PassingScore = 70,
                GivenTime = 35,
            });
            tests.Add(new Test
            {
                Name = "JS test 1",
                Category = categories[1],
                PassingScore = 60,
                GivenTime = 30,
            });
            tests.Add(new Test
            {
                Name = "JS test 2",
                Category = categories[1],
                PassingScore = 50,
                GivenTime = 15,
            });
            tests.Add(new Test
            {
                Name = "JS test 3",
                Category = categories[1],
                PassingScore = 60,
                GivenTime = 20,
            });
            tests.Add(new Test
            {
                Name = "PHP test 1",
                Category = categories[2],
                PassingScore = 60,
                GivenTime = 30,
            });
            tests.Add(new Test
            {
                Name = "PHP test 2",
                Category = categories[2],
                PassingScore = 70,
                GivenTime = 30,
            });
            tests.Add(new Test
            {
                Name = "Datebase test",
                Category = categories[3],
                PassingScore = 60,
                GivenTime = 30,
            });
            tests.Add(new Test
            {
                Name = "OOP test",
                Category = categories[4],
                PassingScore = 70,
                GivenTime = 30,
            });
            tests.Add(new Test
            {
                Name = "English test",
                Category = categories[5],
                PassingScore = 60,
                GivenTime = 30,

            });
            tests.Add(new Test
            {
                Name = "PHP test 3",
                Category = categories[2],
                PassingScore = 80,
                GivenTime = 50,

            });
            tests.Add(new Test
            {
                Name = "PHP test 4",
                Category = categories[2],
                PassingScore = 50,
                GivenTime = 30,

            });
            tests.Add(new Test
            {
                Name = ".Net test 4",
                Category = categories[0],
                PassingScore = 60,
                GivenTime = 30,

            });
            tests.Add(new Test
            {
                Name = ".Net test 5",
                Category = categories[0],
                PassingScore = 60,
                GivenTime = 30,

            });
            tests.Add(new Test
            {
                Name = "JS test 5",
                Category = categories[1],
                PassingScore = 60,
                GivenTime = 30,

            });
            tests.Add(new Test
            {
                Name = "JS test 6",
                Category = categories[1],
                PassingScore = 60,
                GivenTime = 30,

            });
            tests.Add(new Test
            {
                Name = "PHP test 5",
                Category = categories[2],
                PassingScore = 60,
                GivenTime = 30,

            });
            tests.Add(new Test
            {
                Name = "PHP test 6",
                Category = categories[2],
                PassingScore = 60,
                GivenTime = 30,

            });
            tests.Add(new Test
            {
                Name = ".Net test 6",
                Category = categories[0],
                PassingScore = 60,
                GivenTime = 30,

            });
            tests.Add(new Test
            {
                Name = "JS test 7",
                Category = categories[1],
                PassingScore = 60,
                GivenTime = 30,

            });

            foreach (var item in tests)
            {
                context.Tests.Add(item);
            }

            IList<TestResult> testResults = new List<TestResult>();

            testResults.Add(new TestResult
                {
                    Test = tests[0],
                    Result = 85,
                    TimeTaken = 18,
                    User = users[0]
                });
            testResults.Add(new TestResult
            {
                Test = tests[9],
                Result = 90,
                TimeTaken = 15,
                User = users[0]
            });
            
                testResults.Add(new TestResult
                {
                    Test = tests[1],
                    Result = 65,
                    TimeTaken = 15,
                    User = users[1]
                });
                testResults.Add(new TestResult
                {
                    Test = tests[7],
                    Result = 80,
                    TimeTaken = 15,
                    User = users[1]
                });
                testResults.Add(new TestResult
                {
                    Test = tests[2],
                    Result = 50,
                    TimeTaken = 17,
                    User = users[2]
                });
                testResults.Add(new TestResult
                {
                    Test = tests[8],
                    Result = 50,
                    TimeTaken = 17,
                    User = users[2]
                });
                testResults.Add(new TestResult
                {
                    Test = tests[3],
                    Result = 90,
                    TimeTaken = 19,
                    User = users[3]
                });
                testResults.Add(new TestResult
                {
                    Test = tests[14],
                    Result = 90,
                    TimeTaken = 19,
                    User = users[3]
                });
                testResults.Add(new TestResult
                {
                    Test = tests[4],
                    Result = 90,
                    TimeTaken = 30,
                    User = users[4]
                });
                testResults.Add(new TestResult
                {
                    Test = tests[15],
                    Result = 90,
                    TimeTaken = 30,
                    User = users[4]
                });
                testResults.Add(new TestResult
                {
                    Test = tests[5],
                    Result = 85,
                    TimeTaken = 30,
                    User = users[5]
                });
                testResults.Add(new TestResult
                {
                    Test = tests[16],
                    Result = 85,
                    TimeTaken = 30,
                    User = users[5]
                });
                testResults.Add(new TestResult
                {
                    Test = tests[6],
                    Result = 65,
                    TimeTaken = 15,
                    User = users[6]
                });
                testResults.Add(new TestResult
                {
                    Test = tests[10],
                    Result = 65,
                    TimeTaken = 15,
                    User = users[6]
                });
                testResults.Add(new TestResult
                {
                    Test = tests[19],
                    Result = 95,
                    TimeTaken = 22,
                    User = users[7]
                });
                testResults.Add(new TestResult
                {
                    Test = tests[11],
                    Result = 95,
                    TimeTaken = 22,
                    User = users[7]
                });
                testResults.Add(new TestResult
                {
                    Test = tests[18],
                    Result = 85,
                    TimeTaken = 40,
                    User = users[8]
                });
                testResults.Add(new TestResult
                {
                    Test = tests[12],
                    Result = 85,
                    TimeTaken = 40,
                    User = users[8]
                });
                testResults.Add(new TestResult
                {
                    Test = tests[17],
                    Result = 90,
                    TimeTaken = 40,
                    User = users[9]
                });
                testResults.Add(new TestResult
                {
                    Test = tests[13],
                    Result = 90,
                    TimeTaken = 40,
                    User = users[9]
                });
            foreach (var item in testResults)
            {
                context.TestResults.Add(item);
            }

            IList<Question> questions = new List<Question>();

            questions.Add(new Question
            {
                Category = categories[0],
                Text = ".Net question 1",
                Tests = new[] { tests[0], tests[1], tests[12], tests[13], tests[18]}
            });
            questions.Add(new Question
            {
                Category = categories[0],
                Text = ".Net question 2",
                Tests = new[] { tests[0], tests[1], tests[12], tests[13], tests[18] }
            });
            questions.Add(new Question
            {
                Category = categories[0],
                Text = ".Net question 3",
                Tests = new[] { tests[12], tests[13], tests[18] }
            });
            questions.Add(new Question
            {
                Category = categories[0],
                Text = ".Net question 4",
                Tests = new[] { tests[0], tests[1], tests[12] }
            });
            questions.Add(new Question
            {
                Category = categories[1],
                Text = "JS question 1",
                Tests = new[] { tests[19], tests[15], tests[14], tests[4], tests[3], tests[2] }
            });
            questions.Add(new Question
            {
                Category = categories[1],
                Text = "JS question 2",
                Tests = new[] { tests[19], tests[15], tests[14], tests[4],  tests[2] }
            });
            questions.Add(new Question
            {
                Category = categories[1],
                Text = "JS question 3",
                Tests = new[] { tests[19], tests[4], tests[3], tests[2] }
            });
            questions.Add(new Question
            {
                Category = categories[1],
                Text = "JS question 4",
                Tests = new[] { tests[14], tests[4], tests[3], tests[2] }
            });
            questions.Add(new Question
            {
                Category = categories[2],
                Text = "PHP question 1",
                Tests = new[] { tests[5], tests[6], tests[10], tests[11], tests[16],tests[17]}
            });
            questions.Add(new Question
            {
                Category = categories[2],
                Text = "PHP question 2",
                Tests = new[] { tests[5], tests[6], tests[10], tests[11], tests[16] }
            });
            questions.Add(new Question
            {
                Category = categories[2],
                Text = "PHP question 3",
                Tests = new[] {  tests[6], tests[10], tests[11], tests[16] }
            });
            questions.Add(new Question
            {
                Category = categories[2],
                Text = "PHP question 4",
                Tests = new[] { tests[5], tests[6], tests[11], tests[16], tests[17] }
            });
            questions.Add(new Question
            {
                Category = categories[3],
                Text = "DB question 1",
                Tests = new[]
                {
                    tests[5], tests[6], tests[10], tests[11], tests[16], tests[17],
                    tests[19], tests[15], tests[14], tests[4],  tests[2],
                    tests[0], tests[1], tests[12], tests[13], tests[18]
                }
            });
            questions.Add(new Question
            {
                Category = categories[3],
                Text = "DB question 2",
                Tests = tests
            });
            questions.Add(new Question
            {
                Category = categories[3],
                Text = "DB question 3",
                Tests = new []
                {
                     tests[10], tests[11], tests[16], tests[17],
                    tests[19], tests[15], tests[14], tests[4],  tests[2],
                    tests[0], tests[1], tests[12], tests[13], tests[18]
                }
            });
            questions.Add(new Question
            {
                Category = categories[3],
                Text = "DB question 4",
                Tests = new[]
                {
                    tests[5], tests[6], tests[10], tests[11], tests[16], tests[17],
                    tests[19], tests[4],  tests[2],
                    tests[0], tests[1], tests[12], tests[13], tests[18]
                }
            });
            questions.Add(new Question
            {
                Category = categories[4],
                Text = "OOP question 1",
                Tests = tests
            });
            questions.Add(new Question
            {
                Category = categories[4],
                Text = "OOP question 2",
                Tests = new[]
                {
                     tests[6], tests[10], tests[11], tests[16], tests[17],
                    tests[19], tests[15], tests[14], tests[4],  tests[2],
                    tests[0], tests[1], tests[12], tests[13], tests[18]
                }
            });
            questions.Add(new Question
            {
                Category = categories[4],
                Text = "OOP question 3",
                Tests = tests
            });
            questions.Add(new Question
            {
                Category = categories[4],
                Text = "OOP question 4",
                Tests = tests
            });
            questions.Add(new Question
            {
                Category = categories[5],
                Text = "English question 1",
                Tests = new[]
                {
                    tests[5], tests[6], tests[10], tests[11], tests[16], tests[17],
                    tests[19], tests[15], tests[14], tests[4],  tests[2],
                    tests[0], tests[12], tests[13], tests[18]
                }
            });
            questions.Add(new Question
            {
                Category = categories[5],
                Text = "English question 2",
                Tests = new[]
                {
                    tests[5], tests[6], tests[10], tests[11], tests[16], tests[17],
                    tests[19],tests[0], tests[1], tests[12], tests[13], tests[18]
                }
            });
            questions.Add(new Question
            {
                Category = categories[5],
                Text = "English question 3",
                Tests = new[]
                {
                    tests[5], tests[6], tests[10], tests[11], tests[16], tests[17],
                    tests[19], tests[15], tests[14], tests[4],  tests[2],
                    tests[1], tests[12], tests[13], tests[18]
                }
            });
            questions.Add(new Question
            {
                Category = categories[5],
                Text = "English question 4",
                Tests = new[]
                {
                    tests[5], tests[6], tests[10], tests[0], tests[1], tests[12], tests[13], tests[18]
                }
            });
            foreach (var item in questions)
            {
                context.Questions.Add(item);
            }

            IList<Answer> answers = new List<Answer>();
            
            answers.Add(new Answer
            {
                Text = "Answer 1",
                Question = questions[0],
                TestResult = testResults[0]
            });
            answers.Add(new Answer
            {
                Text = "Answer 2",
                Question = questions[0],
                TestResult = testResults[0]
            });
            answers.Add(new Answer
            {
                Text = "Answer 3",
                Question = questions[0],
                TestResult = testResults[1]
            });
            answers.Add(new Answer
            {
                Text = "Answer 4",
                Question = questions[1],
                TestResult = testResults[4]
            });
            answers.Add(new Answer
            {
                Text = "Answer 5",
                Question = questions[2],
                TestResult = testResults[2]
            });
            answers.Add(new Answer
            {
                Text = "Answer 6",
                Question = questions[3],
                TestResult = testResults[5]
            });
            answers.Add(new Answer
            {
                Text = "Answer 7",
                Question = questions[3],
                TestResult = testResults[3]
            });
            answers.Add(new Answer
            {
                Text = "Answer 8",
                Question = questions[4],
                TestResult = testResults[6]
            });
            answers.Add(new Answer
            {
                Text = "Answer 9",
                Question = questions[5],
                TestResult = testResults[4]
            });
            answers.Add(new Answer
            {
                Text = "Answer 10",
                Question = questions[6],
                TestResult = testResults[7]
            });
            answers.Add(new Answer
            {
                Text = "Answer 11",
                Question = questions[7],
                TestResult = testResults[5]
            });
            answers.Add(new Answer
            {
                Text = "Answer 12",
                Question = questions[8],
                TestResult = testResults[8]
            });
            answers.Add(new Answer
            {
                Text = "Answer 13",
                Question = questions[8],
                TestResult = testResults[6]
            });
            answers.Add(new Answer
            {
                Text = "Answer 14",
                Question = questions[8],
                TestResult = testResults[9]
            });
            answers.Add(new Answer
            {
                Text = "Answer 15",
                Question = questions[9],
                TestResult = testResults[7]
            });
            answers.Add(new Answer
            {
                Text = "Answer 16",
                Question = questions[9],
                TestResult = testResults[10]
            });
            answers.Add(new Answer
            {
                Text = "Answer 17",
                Question = questions[9],
                TestResult = testResults[8]
            });
            answers.Add(new Answer
            {
                Text = "Answer 18",
                Question = questions[10],
                TestResult = testResults[11]
            });
            answers.Add(new Answer
            {
                Text = "Answer 19",
                Question = questions[11],
                TestResult = testResults[9]
            });
            answers.Add(new Answer
            {
                Text = "Answer 20",
                Question = questions[12],
                TestResult = testResults[12]
            });
            answers.Add(new Answer
            {
                Text = "Answer 21",
                Question = questions[13],
                TestResult = testResults[10]
            });
            answers.Add(new Answer
            {
                Text = "Answer 21",
                Question = questions[13],
                TestResult = testResults[13]
            });
            answers.Add(new Answer
            {
                Text = "Answer 22",
                Question = questions[13],
                TestResult = testResults[11]
            });
            answers.Add(new Answer
            {
                Text = "Answer 23",
                Question = questions[13],
                TestResult = testResults[14]
            });
            answers.Add(new Answer
            {
                Text = "Answer 24",
                Question = questions[14],
                TestResult = testResults[12]
            });
            answers.Add(new Answer
            {
                Text = "Answer 25",
                Question = questions[14],
                TestResult = testResults[15]
            });
            answers.Add(new Answer
            {
                Text = "Answer 26",
                Question = questions[14],
                TestResult = testResults[13]
            });
            answers.Add(new Answer
            {
                Text = "Answer 27",
                Question = questions[14],
                TestResult = testResults[16]
            });
            answers.Add(new Answer
            {
                Text = "Answer 28",
                Question = questions[15],
                TestResult = testResults[14]
            });
            answers.Add(new Answer
            {
                Text = "Answer 29",
                Question = questions[15],
                TestResult = testResults[17]
            });
            answers.Add(new Answer
            {
                Text = "Answer 30",
                Question = questions[16],
                TestResult = testResults[18]
            });
            answers.Add(new Answer
            {
                Text = "Answer 31",
                Question = questions[17],
                TestResult = testResults[15]
            });
            answers.Add(new Answer
            {
                Text = "Answer 32",
                Question = questions[18],
                TestResult = testResults[18]
            });
            answers.Add(new Answer
            {
                Text = "Answer 33",
                Question = questions[18],
                TestResult = testResults[16]
            });
            answers.Add(new Answer
            {
                Text = "Answer 34",
                Question = questions[18],
                TestResult = testResults[19]
            });
            answers.Add(new Answer
            {
                Text = "Answer 35",
                Question = questions[18],
                TestResult = testResults[17]
            });
            answers.Add(new Answer
            {
                Text = "Answer 36",
                Question = questions[19],
                TestResult = testResults[0]
            });
            answers.Add(new Answer
            {
                Text = "Answer 37",
                Question = questions[20],
                TestResult = testResults[1]
            });
            answers.Add(new Answer
            {
                Text = "Answer 38",
                Question = questions[21],
                TestResult = testResults[2]
            });
            answers.Add(new Answer
            {
                Text = "Answer 39",
                Question = questions[22],
                TestResult = testResults[2]
            });
            answers.Add(new Answer
            {
                Text = "Answer 40",
                Question = questions[22],
                TestResult = testResults[3]
            });
            answers.Add(new Answer
            {
                Text = "Answer 41",
                Question = questions[22],
                TestResult = testResults[4]
            });
            answers.Add(new Answer
            {
                Text = "Answer 42",
                Question = questions[22],
                TestResult = testResults[5]
            });
            answers.Add(new Answer
            {
                Text = "Answer 43",
                Question = questions[23],
                TestResult = testResults[6]
            });
            answers.Add(new Answer
            {
                Text = "Answer 44",
                Question = questions[23],
                TestResult = testResults[7]
            });
            answers.Add(new Answer
            {
                Text = "Answer 45",
                Question = questions[23],
                TestResult = testResults[8]
            });
            answers.Add(new Answer
            {
                Text = "Answer 46",
                Question = questions[23],
                TestResult = testResults[9]
            });
            answers.Add(new Answer
            {
                Text = "Answer 47",
                Question = questions[23],
                TestResult = testResults[10]
            });
            answers.Add(new Answer
            {
                Text = "Answer 48",
                Question = questions[23],
                TestResult = testResults[11]
            });

            foreach (var item in answers)
            {
                context.Answers.Add(item);
            }

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
