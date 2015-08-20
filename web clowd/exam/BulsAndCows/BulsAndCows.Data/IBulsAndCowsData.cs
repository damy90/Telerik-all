using System;
using BulsAndCows.Data.Repositories;
using BulsAndCows.Models;

namespace BulsAndCows.Data
{
    public interface IBulsAndCowsData
    {
        IRepository<Game> Games { get; }
        IRepository<ApplicationUser> Users { get; }
        int SaveChanges();
    }
}
