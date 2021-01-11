using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using ProjectBug.Helpers;

namespace ProjectBug.Model
{
    public class BugContext : DbContext
    {
        public DbSet<Bug> Bugs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source=bugs.db");
    }

    public class Bug
    {
        [Key] public int ID { get; set; } //The unique id for it
        public Severity Severity { get; set; } //How sever are we?
        public string Description { get; set; } //The content of the bug
        public string Label { get; set; } //i.e, Question?
        public string Assignees { get; set; } //People that are assigned to solve it
        public User Assigner { get; set; } //The person that created it
        public string Participants { get; set; } //The people that have commented on it
        public DateTime CreationDate { get; set; } //When was this created?
        public string Comments { get; set; } //The comments that the thread of the bug has
        public string Type { get; set; } //This is the type of bug, i.e., which section this bug belongs to
    }
}