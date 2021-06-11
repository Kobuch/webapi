using Jppapi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jppapi.Data
{
    public class RozliczenieContext:DbContext
    {
        public RozliczenieContext(DbContextOptions<RozliczenieContext> opt):base(opt)
        {

        }

        public DbSet<Stawka> Stawki { get; set; }
    }
}
