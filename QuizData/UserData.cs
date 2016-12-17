using System;
using System.ComponentModel.DataAnnotations;

namespace QuizData
{
    public class UserData
    {
        [Key]
        public int Id { get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string Email{ get; set; }
        public string DateOfBirth{ get; set; }
        public int Salary{ get; set; }
    }
}
