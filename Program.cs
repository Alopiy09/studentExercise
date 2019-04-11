using System;
using System.Collections.Generic;


namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            exercise makeAWorld = new exercise()
            {
                exerciseName = "Make a world",
                exerciseLanguage = "Javascript",
            };
            exercise legos = new exercise()
            {
                exerciseName = "Legos",
                exerciseLanguage = "Html/css",
            };
            exercise sinCity = new exercise()
            {
                exerciseName = "sinCity",
                exerciseLanguage = "React.js",
            };
            exercise skydivingWithSpoons = new exercise()
            {
                exerciseName = "Skydiving with spoons",
                exerciseLanguage = ".Net",
            };

            cohort eveningCohort3 = new cohort()
            {
                name = "Evening cohort 3",
            };
            cohort Cohort35 = new cohort()
            {
                name = "Cohort 35",
            };
            cohort Cohort54 = new cohort()
            {
                name = "Cohort 54",
            };
            cohort eveningCohort65 = new cohort()
            {
                name = "Evening cohort 65",
            };

            student samFisher = new student()
            {
                firstName = "Sam",
                lastName = "Fisher",
                slackHandle = "ThirdEchelon",
            };
            student tomThumb = new student()
            {
                firstName = "Tom",
                lastName = "Thumb",
                slackHandle = "TheBeeKeeper",
            };
            student markWhalberg = new student()
            {
                firstName = "Mark",
                lastName = "Whalberg",
                slackHandle = "NJPD",
            };
            student bruceWayne = new student()
            {
                firstName = "Bruce",
                lastName = "Wayne",
                slackHandle = "Batman",
            };

            eveningCohort3.students.Add(samFisher);
            eveningCohort65.students.Add(tomThumb);
            Cohort35.students.Add(markWhalberg);
            Cohort54.students.Add(bruceWayne);

            instructor mickyMouse = new instructor()
            {
                firstName = "Micky",
                lastName = "Mouse",
                slackHandle = "TheKing",
            };
            instructor MewTwo = new instructor()
            {
                firstName = "Mew",
                lastName = "Two",
                slackHandle = "TheGreatest",
            };
            instructor steveBrownlee = new instructor()
            {
                firstName = "Steve",
                lastName = "Brownlee",
                slackHandle = "TheFontOfKnowledge",
            };

            steveBrownlee.instructer(bruceWayne, skydivingWithSpoons);
            steveBrownlee.instructer(markWhalberg, sinCity);
            steveBrownlee.instructer(samFisher, legos);
            steveBrownlee.instructer(tomThumb, makeAWorld);

            MewTwo.instructer(tomThumb, legos);
            MewTwo.instructer(samFisher, makeAWorld);
            MewTwo.instructer(bruceWayne, skydivingWithSpoons);
            MewTwo.instructer(markWhalberg, sinCity);

            mickyMouse.instructer(samFisher, legos);
            mickyMouse.instructer(markWhalberg, skydivingWithSpoons);
            mickyMouse.instructer(tomThumb, makeAWorld);
            mickyMouse.instructer(bruceWayne, sinCity);

            List<student> students = new List<student>();

            students.Add(markWhalberg);
            students.Add(bruceWayne);
            students.Add(tomThumb);
            students.Add(samFisher);

            // List<exercise> exercises = new List<exercise>();

            addExercise(legos);
            addExercise(skydivingWithSpoons);
            addExercise(makeAWorld);
            addExercise(sinCity);

            foreach(student student in students) {
                Console.WriteLine($"{student.firstName} {student.lastName} is working on {student.exercises}");
            }

        }
    }
}
