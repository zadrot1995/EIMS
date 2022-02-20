﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Subject
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public Teacher Lecturer { get; set; }
        public Teacher Practitioner { get; set; }
        public List<Group> Groups { get; set; }
    }
}