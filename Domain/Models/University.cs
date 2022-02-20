using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class University
    {
        public string Name { get; set; }
        public List<Institute> Institutes { get; set; }
        public string About { get; set; }
    }
}
