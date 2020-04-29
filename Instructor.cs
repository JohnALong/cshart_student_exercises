using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Instructor 
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string SlackHandle { get; set; }

        public string Specialty { get; set; }
        
        public List<Exercise> Exercises = new List<Exercise>();

        public Instructor(string firstName, string lastName, string slackHandle, string Specialty)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            this.Specialty = Specialty;
        }

        public void AddExercise(Exercise exercise, Student student)
        {
            student.Exercises.Add(exercise);
        }
    }
}