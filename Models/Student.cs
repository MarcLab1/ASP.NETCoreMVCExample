using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace WebApplicationRandomHTMLColor.Models
{
    public class Student
    {
        [Required]
        public int id { get; set; }

        private string _key;

        public string Key
        {
            get
            {
                if(_key == null)
                {
                    _key = Regex.Replace(fName.ToLower(), "[^a-z0-9]", "-");
                }
                return _key;
            }
            set { _key = value; }
        }

        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Last Name has to be 2 characters min and 100 max")]
        public string lName { get; set; }
        [Required]
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
