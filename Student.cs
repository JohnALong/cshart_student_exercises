using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Student : NSSPerson
    {
        public List<Exercise> Exercises = new List<Exercise>();

        public Student(string firstName, string lastName, string slackHandle, string cohort)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
        }
    }
}