﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice.Domain.Entities
{
    public class Top10FlowsWithStatus
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
        public string UniqueId { get; set; }
        public string FlowTypeTitle { get; set; }
        public string FlowActivityTypeTitle { get; set; }
        public string StatusTypeTitle { get; set; }
        public int StatusId { get; set; }
    }
}
