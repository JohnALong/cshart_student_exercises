using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {            
            // instantiate cohorts
            Cohort dayCohort40 = new Cohort("Day Cohort 40");
            Cohort dayCohort37 = new Cohort("Day Cohort 37");
            Cohort dayCohort36 = new Cohort("Day Cohort 36");

            // instantiate exercises
            Exercise nutshell = new Exercise("Nutshell", "React");
            Exercise tribute = new Exercise("Celebrity Tribute", "HTML");
            Exercise journal = new Exercise("Daily Journal", "JavaScript");
            Exercise bangazon = new Exercise("Bangazon", "Python/Django");

            // instantiate students
            Student john = new Student("John", "Long", "JohnALong", "c36");
            Student holden = new Student("Holden", "Parker", "HoldenDev", "c37");
            Student guy = new Student("Guy", "Cherkesky", "@Guy", "c40");
            Student trey = new Student("Trey", "Suitor", "@TreySuitor", "c36");
            Student nicole = new Student("Nicole", "Noname", "@nicole", "c40");

            Instructor joe = new Instructor("Joe", "Shepherd", "@JoeShep", "c36", "Dad jokes");
            Instructor jisie = new Instructor("Jisie", "David", "JisieTheSith", "c40", "Sith Lord");
            Instructor brenda = new Instructor("Brenda", "Long", "@BellsMom", "c37", "Front End");

            dayCohort36.AddStudent(john);
            dayCohort36.AddStudent(trey);
            dayCohort37.AddStudent(holden);
            dayCohort40.AddStudent(guy);
            dayCohort40.AddStudent(nicole);

            dayCohort36.AddInstructor(joe);
            dayCohort37.AddInstructor(brenda);
            dayCohort40.AddInstructor(jisie);

            joe.AddExercise(tribute, john);
            joe.AddExercise(bangazon, john);
            joe.AddExercise(nutshell, john);
            joe.AddExercise(journal, trey);
            joe.AddExercise(tribute, trey);
            brenda.AddExercise(journal, holden);
            brenda.AddExercise(nutshell, holden);
            jisie.AddExercise(tribute, guy);
            jisie.AddExercise(bangazon, guy);

            List<Student> students = new List<Student>()
            {
                john,
                holden,
                guy,
                trey,
                nicole
            };

            List<Exercise> exercises = new List<Exercise>()
            {
                bangazon,
                nutshell,
                journal,
                tribute
            };

            List<Cohort> cohorts = new List<Cohort>()
            {
                dayCohort36,
                dayCohort37,
                dayCohort40
            };

            List<Instructor> instructors = new List<Instructor>()
            {
                joe,
                brenda,
                jisie
            };
            
            // foreach (Exercise exercise in john.Exercises)
            // {
            //     Console.WriteLine($"{john.FirstName} {john.LastName} has been assigned {exercise.Name}");
            // }

            var jsExercises = exercises.Where(exercise => exercise.Language == "JavaScript");
            foreach (var exercise in jsExercises)
            {
                Console.WriteLine($"{exercise.Name} is built using {exercise.Language}");
            }

            var c36Students = students.Where(student => student.Cohort == "c36");

            foreach (var student in c36Students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is in {student.Cohort}");
            }

            var c37Instructors = instructors.Where(instructor => instructor.Cohort == "c37");

            foreach (var instructor in c37Instructors)
            {
                Console.WriteLine($"{instructor.FirstName} {instructor.LastName} is teaching {instructor.Cohort}");
            }

            var studentsLastName = students.OrderBy(student => student.LastName);

            Console.WriteLine("Students by last name");
            foreach (var student in studentsLastName)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            var studentsNotWorking = students.Where(student => student.Exercises.Count() == 0);

            foreach (var student in studentsNotWorking)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} has zero exercises assigned.");
            }

            var numExercises = 0;
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is working on {student.Exercises.Count()} exercises.");
                if (student.Exercises.Count() >= numExercises)
                {
                    numExercises = student.Exercises.Count();
                    Console.WriteLine($"{student.FirstName} {student.LastName} is working on {numExercises} exercises, and that is the most");
                }
            }

            foreach (var cohort in cohorts)
            {
                Console.WriteLine($"There are {cohort.Students.Count()} students in {cohort.Name}");
            }

        }
    }
}
