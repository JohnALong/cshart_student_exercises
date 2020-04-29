using System;

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
            Student john = new Student("John", "Long", "JohnALong");
            Student holden = new Student("Holden", "Parker", "HoldenDev");
            Student guy = new Student("Guy", "Cherkesky", "@Guy");
            Student trey = new Student("Trey", "Suitor", "@TreySuitor");

            Instructor joe = new Instructor("Joe", "Shepherd", "@JoeShep", "Dad jokes");
            Instructor jisie = new Instructor("Jisie", "David", "JisieTheSith", "Sith Lord");
            Instructor brenda = new Instructor("Brenda", "Long", "@BellsMom", "Front End");

            dayCohort36.AddStudent(john);
            dayCohort36.AddStudent(trey);
            dayCohort37.AddStudent(holden);
            dayCohort40.AddStudent(guy);

            dayCohort36.AddInstructor(joe);
            dayCohort37.AddInstructor(brenda);
            dayCohort40.AddInstructor(jisie);

            joe.AddExercise(bangazon, john);
            joe.AddExercise(nutshell, john);
            joe.AddExercise(journal, trey);
            joe.AddExercise(tribute, trey);
            brenda.AddExercise(journal, holden);
            brenda.AddExercise(nutshell, holden);
            jisie.AddExercise(tribute, guy);
            jisie.AddExercise(bangazon, guy);

            
            foreach (Exercise exercise in john.Exercises)
            {
                Console.WriteLine($"{john.FirstName} {john.LastName} has been assigned {exercise.Name}");
            }


        }
    }
}
