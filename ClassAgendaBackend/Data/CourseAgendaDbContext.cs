using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassAgendaBackend.Models;

    public class CourseAgendaDbContext : DbContext
    {
        public CourseAgendaDbContext (DbContextOptions<CourseAgendaDbContext> options)
            : base(options)
        {
        }

        public DbSet<ClassAgendaBackend.Models.CourseModel> CourseModel { get; set; } = default!;

public DbSet<ClassAgendaBackend.Models.ClassModel> ClassModel { get; set; } = default!;

public DbSet<ClassAgendaBackend.Models.MaterialModel> MaterialModel { get; set; } = default!;

public DbSet<ClassAgendaBackend.Models.PhotoModel> PhotoModel { get; set; } = default!;

public DbSet<ClassAgendaBackend.Models.StudentModel> StudentModel { get; set; } = default!;
    }
