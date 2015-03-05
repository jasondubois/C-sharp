/*
Name:       Jason DuBois
Class:      UCSD Viusal C#.NET Programming I
Due:        05-Mar-2015
Assignment: 3, Working with Classes, Strings and List<>
Created:    02-Mar-2015
Purpose:	The class below defines a fish as sampled for scientific research.
 *          (I work for the CA Dept Fish and Wildlife). Data collected on Fish are
 *          Common name, length (in centimeters), weight (in kilograms), date of capture
 *          (when the fish was caught), tag number (of the tag affixed to the fish),
 *          and gear type (method used to catch fish; e.g., nets, hook and line).
 *          
 *          I need to also include 3 constructors and override the ToString method
 *          such that the output is presented neatly in tabular format
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Fish
    {
        #region Fields
        private string m_CommonName;
        private int m_TotalLength;
        private double m_Weight;
        private DateTime m_CaptureDate;
        private string m_TagNumber;
        private string m_GearType;
        #endregion Fields

        #region Properties
        /// <summary>
        /// Common name of fish
        /// </summary>
        public string CommonName
        {
            get
            {
                return m_CommonName;
            }
            set
            {
                if (value == "Unk" || value == "Sturgeon" || value == "Salmon")
                {
                    m_CommonName = value;
                }
                else
                {
                    throw new ArgumentException("Common name must be either Sturgeon " +
                        "or Salmon. Enter Unk if unknown.", "CommonName");
                }
                
            }
        }

        /// <summary>
        /// Total length in centimeters (cm TL)
        /// </summary>
        public int TotalLength
        {
            get
            {
                return m_TotalLength;
            }
            set
            {
                if(value == 0 || (value >= 100 & value <= 200))
                {
                    m_TotalLength = value;
                }
                else
                {
                    throw new ArgumentException("Length must be either 0 (no length) or " +
                        "between 100 and 200", "TotalLength");
                } 
            }
        }

        /// <summary>
        /// Weight in grams (g)
        /// </summary>
        public double Weight
        {
            get
            {
                return m_Weight;
            }
            set
            {
                if (value == 0 || (value >= 5 & value <= 100))
                {
                    m_Weight = value;
                }
                else
                {
                    throw new ArgumentException("Weight must be either 0 (no weight) or " +
                        "between 5 and 100", "Weight");
                }
            }
        }

        /// <summary>
        /// Date of capture
        /// </summary>
        public DateTime CaptureDate
        {
            get
            {
                return m_CaptureDate;
            }
            set
            {
                if(value <= DateTime.Now)
                {
                    m_CaptureDate = value;
                }
                else
                {
                    throw new ArgumentException("Capture date cannot be greater than " +
                        "today.", "CaptureDate");
                }
                
            }
        }

        /// <summary>
        /// Tag number of tag affixed to fish
        /// </summary>
        public string TagNumber
        {
            get
            {
                return m_TagNumber;
            }
            set
            {
                if (value == "Unk" || value.StartsWith("HH") || value.StartsWith("FF"))
                {
                    m_TagNumber = value;
                }
                else
                {
                    throw new ArgumentException("Tag number must begin with " +
                        "FF or HH. Enter Unk if unknown.", "TagNumber");
                }
            }
        }

        /// <summary>
        /// Type of gear used to catch fish
        /// </summary>
        public string GearType
        {
            get
            {
                return m_GearType;
            }
            set
            {
                if (value == "Unk" || value == "trammel" || value == "gill")
                {
                    m_GearType = value;
                }
                else
                {
                    throw new ArgumentException("Gear type must be either trammel " +
                        "or gill. Enter Unk if unknown.", "GearType");
                }
            }
        }
        #endregion Properties

        #region Constructors
        /// <summary>
        /// Default contructor with default values
        /// </summary>
        public Fish()
        {
            // assign properties to a default; Unk = unknown
            CommonName = "Unk";
            TotalLength = 0;
            Weight = 0;
            CaptureDate = DateTime.Now;
            TagNumber = "Unk";
            GearType = "Unk";
        }

        /// <summary>
        /// Constructor accepts six arguments
        /// </summary>
        /// <param name="commonName"></param>
        /// <param name="totalLength"></param>
        /// <param name="weight"></param>
        /// <param name="captureDate"></param>
        /// <param name="tagNumber"></param>
        /// <param name="gearType"></param>
        public Fish(string commonName, int totalLength, double weight,
            DateTime captureDate, string tagNumber, string gearType)
        {
            // assign constructor parametrs to properties
            CommonName = commonName;
            TotalLength = totalLength;
            Weight = weight;
            CaptureDate = captureDate;
            TagNumber = tagNumber;
            GearType = gearType;
        }

        /// <summary>
        /// The copy constructor
        /// </summary>
        /// <param name="anotherFish"></param>
        public Fish(Fish anotherFish)
        {
            CommonName = anotherFish.CommonName;
            TotalLength = anotherFish.TotalLength;
            Weight = anotherFish.Weight;
            CaptureDate = anotherFish.CaptureDate;
            TagNumber = anotherFish.TagNumber;
            GearType = anotherFish.GearType;
        }
        #endregion Constructors

        #region Methods
        /// <summary>
        /// Displays output in tabular format
        /// </summary>
        /// <returns>capture data about a fish</returns>
        public override string ToString()
        {
            // declare variable
            string tabularFormat = String.Empty;

            // assign tabularFormat to custom output
            tabularFormat = String.Format("{0,-20}{1,5}{2,12}{3,15:MM-dd-yyyy}{4,12}{5,13}",
                CommonName, TotalLength, Weight, CaptureDate, TagNumber, GearType);

            // method output
            return tabularFormat;
        }
        #endregion Methods
    } // end Fish class
}
