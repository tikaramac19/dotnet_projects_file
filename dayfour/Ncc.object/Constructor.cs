using System;

namespace Object
{
    class FullName
    {
        public string fname = "Tikaram";
        public string lname = "Acharya";
        public string mname;
        public int dob = 1999;
    }

    public FullName(string mmname)
    {
         mname = mmname;
    }
}