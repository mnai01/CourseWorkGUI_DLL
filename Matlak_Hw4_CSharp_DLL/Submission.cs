//******************************************************
// File: Category.cs
//
// Purpose: Contains Category class and all set/get properties and tostring
//
// Written By: Ian Matlak
//
// Compiler: Visual Studio 2019
//
// Update:
// 9/29/19: Added submission class 
//******************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Matlak_Hw4_Csharp_DLL
{
    [DataContract(Name = "submissions")] //added because i saw it in the slides
    public class Submission
    {
        #region Private Member variables
        private string categoryName;
        private string assignmentName;
        private double grade;
        #endregion

        #region Submission Methods

        //****************************************************
        // Method: Submission
        //
        // Purpose: Constructor that sets default values
        //****************************************************
        public Submission()
        {
            categoryName = "defaut";
            assignmentName = "defaut";
            grade = 0;
        }

        //****************************************************
        // Method: ToString
        //
        // Purpose: Returns a string that outputs data in a formatted manner
        //****************************************************
        public override string ToString()
        {
            string str = "Category Name: " + categoryName +
                "\n" + " Assignment Name: " + assignmentName +
                "\n" + " Grade: " + grade +
                "\n";
            return str.ToString();
        }

        #endregion

        #region Submission properties

        //****************************************************
        // Method: Get/Set Properties, DataContract
        //
        // Purpose: Gets and sets memeber variables with DataContract
        //****************************************************

        //DataContract
        [DataMember(Name = "categoryname")]
        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        //DataContract
        [DataMember(Name = "assignmentname")]
        public string AssignmentName
        {
            get { return assignmentName; }
            set { assignmentName = value; }
        }

        //DataContract
        [DataMember(Name = "grade")]
        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        #endregion
    }
}
