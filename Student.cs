using System;
using System.Collections.Generic;

namespace StudentExercises {

    public class student {
        public string firstName {get; set;}

        public string lastName {get; set;}

        public string slackHandle {get; set;}

        public string cohort {get; set;}

        public List<exercise> exercises = new List<exercise>();

        public addExercise (exercise exercise){
             exercises.Add(exercise);

            }
        }
    }
}