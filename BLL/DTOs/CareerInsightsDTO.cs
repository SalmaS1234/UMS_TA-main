﻿using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CareerInsightsDTO
    {
        
        public int ID { get; set; }
        
        public int S_ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime SubmissionDate { get; set; }
        
    }
}
