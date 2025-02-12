﻿//******************************************************
// File: Assignment.cs
//
// Purpose: Contains Assignment class and all set/get properties and tostring
//
// Written By: Ian Matlak
//
// Compiler: Visual Studio 2019
//
// Update: 
// Added 10/20 to hold lists of assignments/submissions/categories
//
//******************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Matlak_Hw4_Csharp_DLL
{
    //Needed for file serializaton
    [DataContract(Name = "coursename")] 
    public class CourseWork
    {
        #region Private Member variables
        private string courseName;
        private List<Category> categories;
        private List<Assignment> assignments;
        private List<Submission> submissions;
        #endregion

        #region CourseWork Properties
        //****************************************************
        // Method: Get/Set Properties, CourseWork
        //
        // Purpose: Gets and sets memeber variables with CourseWork
        //****************************************************

        //Needed for file serializaton
        [DataMember(Name = "coursename")]
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        //Needed for file serializaton
        [DataMember(Name = "categories")]
        public List<Category> Categories
        {
            get { return categories; }
            set { categories = value; }
        }

        //Needed for file serializaton
        [DataMember(Name = "assignments")]
        public List<Assignment> Assignment
        {
            get { return assignments; }
            set { assignments = value; }
        }

        //Needed for file serializaton
        [DataMember(Name = "submissions")]
        public List<Submission> Submission
        {
            get { return submissions; }
            set { submissions = value; }
        }
        #endregion

        #region CourseWork Methods
        //****************************************************
        // Method: CourseWork constructor
        //
        // Purpose: Sets all values to default
        //****************************************************
        public CourseWork()
        {
            courseName = "None";
            categories = new List<Category>();
            assignments = new List<Assignment>();
            submissions = new List<Submission>();
        }
        //****************************************************
        // Method: FindSubmission
        //
        // Purpose: Searchs submission for that assignment name if found return that assignment else return null
        //****************************************************
        public Submission FindSubmission(String an)
        {
            // Scans submission 
            foreach (var i in submissions)
            {
                // If submission.Assignment name matches the parameter provided return it
                if(i.AssignmentName == an)
                {
                    return i;
                }
            }
            return null;
        }

        //****************************************************
        // Method: CalculateGrade
        //
        // Purpose: takes the weights of each type of assignment, adds all the assignments up divides it but the # of assignments and find the average. 
        //          Then the weight is used to find a to find the actually total avg
        //****************************************************
        public double CalculateGrade()
        {
            double examWeights = 0;
            double homeworkWeights = 0;
            double quizWeights = 0;
            double labWeights = 0;

            // Iterates throught categories
            foreach (var i in categories)
            {
                // Finds categories with name Exams
                if (i.Name == "Exams")
                {
                    // Sets weight to Percentage found in the list
                    examWeights = i.Percentage;
                    Console.WriteLine(i.Percentage);

                }
                // Finds categories with name Homework
                else if (i.Name == "Homework")
                {
                    // Sets weight to Percentage found in the list
                    homeworkWeights = i.Percentage;
                    Console.WriteLine(i.Percentage);
                }
                // Finds categories with name Quizzes
                else if (i.Name == "Quizzes")
                {
                    // Sets weight to Percentage found in the list
                    quizWeights = i.Percentage;
                    Console.WriteLine(i.Percentage);
                }
                // Finds categories with name Labs
                else if (i.Name == "Labs")
                {
                    // Sets weight to Percentage found in the list
                    labWeights = i.Percentage;
                    Console.WriteLine(i.Percentage);
                }
            }

            //TODO: could make it way more modular, maybe something with generics?

            //Adds up the grades
            double ExamGradesTotal = submissions.Where(i=>i.CategoryName == "Exams").Select(i => i.Grade).Sum();
            //Find out the number of exams there were
            int numberOfExams = submissions.Where(i => i.CategoryName == "Exams").Count();
            //Divides total grades added by number of exams
            double examGradeAvg = Math.Round(ExamGradesTotal / numberOfExams);
            //displays avg
            Console.WriteLine("Exam Average: " + examGradeAvg);

            // Add homework grades for a total
            double homeWorkGradesTotal = submissions.Where(i => i.CategoryName == "Homework").Select(i => i.Grade).Sum();
            // counts number of homeworks
            int numberOfHomeWorks = submissions.Where(i => i.CategoryName == "Homework").Count();
            // divides Number of homeworks from total homeworks grades to get avgerage
            double homeworkGradeAvg = Math.Round(homeWorkGradesTotal / numberOfHomeWorks);
            Console.WriteLine("Homework Average: " + homeworkGradeAvg);

            // Add quiz grades for a total
            double quizGradesTotal = submissions.Where(i => i.CategoryName == "Quizzes").Select(i => i.Grade).Sum();
            // Add number of quizzes
            int numberOfQuiz = submissions.Where(i => i.CategoryName == "Quizzes").Count();
            // divides Number of quizzes from total quizzes grades to get avgerage
            double quizGradeAvg = Math.Round(quizGradesTotal / numberOfQuiz, 2);
            Console.WriteLine("Quizzes Average: " + quizGradeAvg);
           
            // Add labs grades for a total
            double labGradesTotal = submissions.Where(i => i.CategoryName == "Labs").Select(i => i.Grade).Sum();
            // Add number of labs
            int numberOfLabs = submissions.Where(i => i.CategoryName == "Labs").Count();
            // divides Number of labs from total labs grades to get avgerage
            double labGradesAvg = Math.Round(labGradesTotal / numberOfLabs, 2);
            Console.WriteLine("Labs Average: " + labGradesAvg);

            //Multiples weights by the grade avgs, adds all of them up and divides it by 100 to get the avg.
            double TotalGrade = Math.Round((examGradeAvg*examWeights + homeworkGradeAvg*homeworkWeights + quizGradeAvg*quizWeights + labGradesAvg * labWeights) / 100, 2) ;
            Console.WriteLine("Your total Average is: " + TotalGrade);
            return TotalGrade;
        }

        //****************************************************
        // Method: ToString()
        //
        // Purpose: Displays all data collected in ToString Format
        //****************************************************
        public override string ToString()
        {
            string str = null;

            foreach (var i in Categories)
            {
                str += "Category Name: " + i.Name + ", " + "\n" + "Category Percentage: " + i.Percentage + ", " + "\n";
            }
            foreach (var i in Assignment)
            {
                str += "Assignments Name: " + i.Name + ", "  + "\n" + "Assignments Description: " + i.Description + ", "  + "\n" + "Assignments CategoryName: " +  i.CategoryName + ", " + "\n";
            }
            foreach (var i in Submission)
            {
                str += "Submission AssignmentName: " + i.AssignmentName + ", " + "\n" + "Submission Grade: " + i.Grade + ", " + "\n" + "Submission CategoryName: " + i.CategoryName + ", " + "\n";

            }
            return str.ToString();
        }
        #endregion

    }
}
