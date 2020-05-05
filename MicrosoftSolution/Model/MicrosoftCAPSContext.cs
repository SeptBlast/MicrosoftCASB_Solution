// 	File Name : MicrosoftCAPSContext.cs
// 	Auther Name : Devesh Kumar
// 	Auther EmailId : deveshkumarsep12@outlook.com
// 	Date : 05-05-2020
//
using System;
using Microsoft.EntityFrameworkCore;

namespace MicrosoftCAPS.Model
{
    public class MicrosoftCAPSContext : DbContext
    {
        public MicrosoftCAPSContext(DbContextOptions<MicrosoftCAPSContext> options)
            : base(options)
        {
        }

        public DbSet<MicrosftCAPSItems> MicrosftCAPSItems { get; set; }
    }
}
