/* Program Name: CarInsurance
 Class for CarInsurance
 Created by: J. DuBois
 Created on: 24-Mar-2014
 Exercise 11 problem 3 */
/************************/

/* This class creates 2
 objects and a method
 to be used in problem 3. */
/************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarInsurance
{
    class CarInsurance
    {
        // Declare variables and properties
        private byte bytDriverAge;
        private string strState;
        public byte DriverAge
        {
            get
            {
                return bytDriverAge;
            }
            set
            {
                bytDriverAge = value;
            }
        }
        public string State
        {
            get
            {
                return strState;
            }
            set
            {
                strState = value;
            }
        }

        /* Create method GetPremium - will throw error if state not IL or WI
        and age < 16 or age > 80 */
        public void GetPremium(string state, byte age)
        {
            // Declare in instantiate dblPremium variable
            double dblPremium = 0;
            
            // Establish try block
            try
            {
                // Set criteria
                if ((state == "IL" | state == "WI") & (age >= 16 & age <= 80))
                {
                    // Premium base price
                    switch (state)
                    {
                        case "IL":
                            dblPremium += 100;
                            break;
                        case "WI":
                            dblPremium += 50;
                            break;
                    }

                    // Premium base + age adjustment
                    dblPremium += 3 * (100 - age);

                    // Output premium in dollars
                    Console.WriteLine("\nDriver's premium is {0}.", dblPremium.ToString("C"));
                }
                else
                {
                    // Move to catch block if criteria not met
                    throw new ArgumentException();
                }
            }
            
            // Catch block
            catch (ArgumentException error)
            {
                Console.Write("\nCheck state or age: ");
                Console.WriteLine(error.Message.ToString());
            }
        }
    }
}
