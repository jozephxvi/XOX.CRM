﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOX.CRM.Lib
{
    public class BatchWorkSchedule
    {
        public long BatchWorkId { get; set; }
        public DateTime NextSchedule { get; set; }
    }
}
