using System;
using System.Collections.Generic;

namespace StudentExercises {
    public class instructor {
        public string firstName {get; set;}

        public string lastName {get; set;}

        public string slackHandle {get; set;}

        public string cohort {get; set;}

        public void instructer (student student, exercise exercise) {
            student.exercises.Add(exercise);
        }
    }
}