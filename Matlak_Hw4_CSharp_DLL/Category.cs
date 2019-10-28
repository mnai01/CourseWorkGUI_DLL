//******************************************************
// File: Category.cs
//
// Purpose: Contains Category class and all set/get properties and tostring
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
    [DataContract(Name = "categories")]
    public class Category
    {
        #region Private Member variables
        private string name;
        private double percentage;
        #endregion

        //Constructor and ToString
        #region Category Methods

        //****************************************************
        // Method: Category
        //
        // Purpose: Constructor that sets default values
        //****************************************************
        public Category()
        {
            name = "defaut";
            percentage = 0;

        }

        //****************************************************
        // Method: ToString
        //
        // Purpose: Returns a string that outputs data in a formatted manner
        //****************************************************
        public override string ToString()
        {
            string str = "Category Name: " + name +
                "\n" + " Category Percentage: " + percentage +
                "\n";

            return str.ToString();
        }
        #endregion

        //Get and Sets for private member variables
        #region Category properties

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
        [DataMember(Name = "percentage")]
        public double Percentage
        {
            get { return percentage; }
            set { percentage = value; }
        }
        #endregion

    }
}
