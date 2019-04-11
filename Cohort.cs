using System;
using System.Collections.Generic;

namespace StudentExercises {

    public class cohort {

        public string name {get; set;}

        public List<student> students = new List<student>();

        public List<instructor> instructors =new List<instructor>();
        
    }
}