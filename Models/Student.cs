namespace WebApplicationRandomHTMLColor.Models
{
    public class Student
    {
        public int id { get; set; }
        public string lName { get; set; }
        public string fName { get; set; }

        public Student()
        {

        }
        public Student (int id, string fName, string lName)
        {
            this.id = id;
            this.lName = lName;
            this.fName = fName;
        }

        override public string ToString()
        {
            return id + " " + fName + " " + lName;
        }
    }  
}
