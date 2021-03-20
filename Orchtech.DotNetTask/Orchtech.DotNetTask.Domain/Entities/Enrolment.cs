using System;
using System.Collections.Generic;
using System.Text;

namespace Orchtech.DotNetTask.Domain.Entities
{
   public class Enrolment
    {
        public Guid Id { get; set; }
        public Guid ClassId { get; set; }
        public Guid StudentId { get; set; }
    }
}
