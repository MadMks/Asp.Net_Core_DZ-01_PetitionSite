using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Core_DZ_01_PetitionSite.Models
{
    public class PetitionContext : DbContext
    {
        public DbSet<Petition> Petitions { get; set; }
        // TODO DbSet: list_of_votes, state_of_petitions, users
    }
}
