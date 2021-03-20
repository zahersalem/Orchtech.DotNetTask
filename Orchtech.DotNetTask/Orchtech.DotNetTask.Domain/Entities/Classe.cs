using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Orchtech.DotNetTask.Domain.Entities
{
    public class Classe
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int AcceptedGenderId { get; set; }

        [ForeignKey("AcceptedGenderId")]
        public virtual Gender Gender { get; set; }

        public virtual List<Enrolment> Enrolments { get; set; }

    }
}
