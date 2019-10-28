//******************************************************
// File: Assignment.cs
//
// Purpose: Contains Assignment class and all set/get properties and tostring
//
// Written By: Ian Matlak
//
// Compiler: Visual Studio 2019
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
    [DataContract(Name = "assignments")] 
    public class Assignment
    {
        #region Private Member variables
        private string name;
        private string description;
        private string categoryName;
        #endregion

        //Constructor and ToString
        #region Assignment Methods

        //****************************************************
        // Method: Assignment
        //
        // Purpose: Constructor that sets default values
        //****************************************************
        public Assignment()
        {
            name = "defaut";
            description = "defaut";
            categoryName = "defaut";
        }

        //****************************************************
        // Method: ToString
        //
        // Purpose: Returns a string that outputs data in a formatted manner
        //****************************************************
        public override string ToString()
        {
            string str = "Assignment Name: " + name +
                "\n" + "Assignment Description: " + description +
                "\n" + "Assignment Category Name: " + categoryName +
                "\n";

            return str.ToString();
        }
        #endregion

        //Get and Sets for private member variables
        #region Assignment properties

        //****************************************************
        // Method: Get/Set Properties, DataContract
        //
        // Purpose: Gets and sets memeber variables with DataContract
        //****************************************************

        //DataContract
        [DataMember(Name = "name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //DataContract
        [DataMember(Name = "description")]
        public string Description {
            get { return description; }
            set { description = value; }
            }

        //DataContract
        [DataMember(Name = "categoryname")]
        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }
        #endregion

    }
}
