//******************************************************
// File: CourseWorkUnitTesting.cs
//
// Purpose: Contains all functions to unit test Assignment.cs and Catergory.cs
//
// Written By: Ian Matlak
//
// Compiler: Visual Studio 2019
//
//******************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matlak_Hw4_Csharp_DLL
{
    public class CourseWorkUnitTesting
    {
        #region Category Unit Testing
        //****************************************************
        // Method: UnitTestCategory
        //
        // Purpose: Unit testing for Category class
        //****************************************************
        public void UnitTestCategory() {
            Category catTest = new Category();

            //Sets testing varibales
            string testName = "catTest";
            double testPercentage = 100.10;

            //Member variables from Category or being set to equal the test variables
            catTest.Name = testName;
            catTest.Percentage = testPercentage;

            //Displays Title of which test is being ran
            Console.WriteLine("\n" + "**********************");
            Console.WriteLine("Unit Testing: Category");
            Console.WriteLine("**********************");

            //Testing m_name from Category
            if (catTest.Name == testName)
            {
                Console.WriteLine("Category Name Property: Pass");
            }
            else
            {
                Console.WriteLine("Category Name Property: Failed");

            }

            //Testing m_percentage from Category
            if (catTest.Percentage == testPercentage)
            {
                Console.WriteLine("Category Percentage Property: Pass" + "\n");
            }
            else
            {
                Console.WriteLine("Category Percentage Property: Failed" + "\n");

            }
        }

        //****************************************************
        // Method: UnitTestAssignment
        //
        // Purpose: Unit testing for Assignment class
        //****************************************************
        public void UnitTestAssignment() {
            Assignment asgTest = new Assignment();

            //Sets testing varibales
            string testName = "asgTest";
            string testDescription = "none";
            string testCategoryname = "no asg";

            //Member variables from Assignment or being set to equal the test variables
            asgTest.Name = testName;
            asgTest.Description = testDescription;
            asgTest.CategoryName = testCategoryname;

            Console.WriteLine("\n" + "************************");
            Console.WriteLine("Unit Testing: Assignment");
            Console.WriteLine("***********************");

            //Testing m_name from Assignment
            if (asgTest.Name == testName)
            {
                Console.WriteLine("Assignment Name Property: Pass");
            }
            else
            {
                Console.WriteLine("Assignment Name Property: Failed");

            }

            //Testing m_description from Assignment
            if (asgTest.Description == testDescription)
            {
                Console.WriteLine("Assignment Description Property: Pass");
            }
            else
            {
                Console.WriteLine("Assignment Description Property: Failed");

            }

            //Testing m_categoryName from Assignment
            if (asgTest.CategoryName == testCategoryname)
            {
                Console.WriteLine("Assignment Category Name Property: Pass" + "\n");
            }
            else
            {
                Console.WriteLine("Assignment Category Name Property: Failed" + "\n");

            }
        }
        #endregion
    }
}
