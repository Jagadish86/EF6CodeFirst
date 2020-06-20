using System;

namespace EF6CodeFirst.Models.Business
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public string RollNo { get; set; }

        public Grade Grade { get; set; }
    }
}
