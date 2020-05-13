using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Instructor : NSSPerson
    {
        public string Specialty { get; set; }
        
        public List<Exercise> Exercises = new List<Exercise>();

        public Instructor(string firstName, string lastName, string slackHandle, string cohort, string Specialty)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
            this.Specialty = Specialty;
        }

        public void AddExercise(Exercise exercise, Student student)
        {
            student.Exercises.Add(exercise);
        }
    }
}