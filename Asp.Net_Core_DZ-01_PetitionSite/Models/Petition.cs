﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Core_DZ_01_PetitionSite.Models
{
    public class Petition
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        // TODO user_id
        public int CountOfVotes { get; set; }
    }
}
