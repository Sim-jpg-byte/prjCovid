using System;
using System.Collections.Generic;
using System.Text;

namespace prjCovid
{
    class Info
    {
        private static int iSizeArray = 0;
        private static int iCounter = 0;

        private static string HosipitalName;
        private static string Address;
        private static bool bType; //private or public hospital
        private static char cProvince;
       
        /// gets and sets for th main class
     
        public  string HosipitalName1 { get => HosipitalName; set => HosipitalName = value; }
        public string Address1 { get => Address; set => Address = value; }
        public bool BType { get => bType; set => bType = value; }
        public char CProvince { get => cProvince; set => cProvince = value; }

        private static String[] ID_Number;
        private static String[] Medical_Aid;
        private static String[] Name;
        private static String[] Surname;
        private static String[] RefDr;
        private static Char[] Blood;
        private static String[] Allergies;
        private static Boolean[] CovidPositive;
        private static String[] Vaccine;

        public void setArray(int num)
        {
            ID_Number = new string[num];
            Medical_Aid = new string[num];
            Name = new string[num];
            Surname = new string[num];
            RefDr = new string[num];
            Blood = new Char[num];
            Allergies = new string[num];
            CovidPositive = new Boolean[num];
            Vaccine = new string[num];

            iSizeArray = num;
    }

        public void addPerson(String strID, String strMedic, String strName, String strSurname,String strRefDr, Char cBloodType, String strAllegies, Boolean bCovid, String strVac )
        {
            ID_Number[iCounter] = strID;
            Medical_Aid[iCounter] = strMedic;
            Name[iCounter] = strName;
            Surname[iCounter] = strSurname;
            RefDr[iCounter] = strRefDr;
            Blood[iCounter] = cBloodType;
            Allergies[iCounter] = strAllegies;
            CovidPositive[iCounter] = bCovid;
            Vaccine[iCounter] = strVac;

            iCounter++;
        }
        
    }
}
