using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261025_w06
{
    class Person
    {
        private string personName;
        private string personLastname;
        private double personSalary;
        private string personPosition;
        public string PersonName
        {
            get { return personName; }
            set { personName = value; }
        }
        public string PersonLastname
        {
            get { return personLastname; }
            set { personLastname = value; }
        }
        public double PersonSalary
        {
            get { return personSalary; }
            set { personSalary = value; }
        }
        public string PersonPosition
        {
            get { return personPosition; }
            set { personPosition = value; }
        }

        public Person() { }
        public Person(string pn, string pl, double ps, string pp)
        {
            this.PersonName = pn;
            this.PersonLastname = pl;
            this.PersonSalary = ps;
            this.PersonPosition = pp;
        }

        public override string ToString()
        {
            return this.PersonName + " " +
                this.PersonLastname + " " + "salary : " +
                this.PersonSalary + " " + "Tax : " +
                Tax.getTax(this.personSalary * 12);
        }
    }
}
