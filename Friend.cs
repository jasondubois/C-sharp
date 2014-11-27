/* Program Name: WriteFriendRecords
 Class name Friend
 Created by: J. DuBois
 Created on: 13-Apr-2014
 Exercise 14 problem 4a */
/************************/

/* This class creates 5
 properties to hold info
 about friends . */
/************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WriteFriendRecords
{
    class Friend
    {
        // Declare variables
        private string strFirstName;
        private string strLastName;
        private string strPhoneNumber;
        private byte bytMonthOfBirth;
        private byte bytDayOfBirth;
        // Declare and set properties
        public string FirstName
        {
            get
            {
                return strFirstName;
            }
            set
            {
                strFirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return strLastName;
            }
            set
            {
                strLastName = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return strPhoneNumber;
            }
            set
            {
                strPhoneNumber = value;
            }
        }
        public byte BirthMonth
        {
            get
            {
                return bytMonthOfBirth;
            }
            set
            {
                bytMonthOfBirth = value;
            }
        }
        public byte BirthDay
        { // Just the day, not the full month/day/year
            get
            {
                return bytDayOfBirth;
            }
            set
            {
                bytDayOfBirth = value;
            }
        }
    }
}
