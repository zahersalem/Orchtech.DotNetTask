using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orchtech.DotNetTask.Domain.Entities
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Mobile { get; set; }
        public int GenderId { get; set; }

        [ForeignKey("AcceptedGenderId")]
        public virtual Gender Gender { get; set; }

        public virtual List<Enrolment> Enrolments { get; set; }
    }
}
