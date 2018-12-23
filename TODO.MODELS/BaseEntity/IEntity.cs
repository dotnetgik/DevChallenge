﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TODO.BaseEntity
{
    public class Entity
    {
        public int ID { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

    }
}
