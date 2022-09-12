using System;
using Microsoft.EntityFrameworkCore;
using ProniaWebsite.Models;

namespace ProniaWebsite.DAL
{
    public class ProniaContext: DbContext
    {
        public ProniaContext(DbContextOptions<ProniaContext> options): base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }

    }
}
