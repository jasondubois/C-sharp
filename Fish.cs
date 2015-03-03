/*
Name:       Jason DuBois
Class:      UCSD Viusal C#.NET Programming I
Due:        05-Mar-2015
Assignment: 3, Working with Classes, Strings and List<>
Created:    02-Mar-2015
Purpose:	The class below defines a fish as sampled for scientific research.
 *          (I work for the CA Dept Fish and Wildlife). Data collected on Fish are
 *          Common name, length (in centimeters), weight (in grams), date of capture
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
                m_CommonName = value;
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
                m_TotalLength = value;
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
                m_Weight = value;
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
                m_CaptureDate = value;
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
                m_TagNumber = value;
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
                m_GearType = value;
            }
        }
        #endregion Properties

        #region Constructors
        public Fish()
        {
            // assign properties as empty
            CommonName = String.Empty;
            TotalLength = 0;
            Weight = 0;
            CaptureDate = DateTime.Now;
            TagNumber = String.Empty;
            GearType = String.Empty;
        }

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

        // add copy constructor here

        #endregion Constructors


        // add methods here (override tostring)

        public override string ToString()
        {
            // declare variable
            string tabularFormat = String.Empty;

            // assign tabularFormat to custom output
            tabularFormat = String.Format("{0,-20}", CommonName);

            return tabularFormat;
        }



    } // end Fish class
}
