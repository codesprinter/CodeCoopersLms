﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VirtualtraineesEntities : DbContext
    {
        public VirtualtraineesEntities()
            : base("name=VirtualtraineesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<ContentFile> ContentFiles { get; set; }
        public virtual DbSet<ContentHelpSite> ContentHelpSites { get; set; }
        public virtual DbSet<ContentProblem> ContentProblems { get; set; }
        public virtual DbSet<EmailBank> EmailBanks { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<HelpSite> HelpSites { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<Option> Options { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Problem> Problems { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Quiz> Quizs { get; set; }
        public virtual DbSet<QuizQuestion> QuizQuestions { get; set; }
        public virtual DbSet<Trainee> Trainees { get; set; }
        public virtual DbSet<TraineeHistory> TraineeHistories { get; set; }
        public virtual DbSet<TraineeQuizAnswerHistory> TraineeQuizAnswerHistories { get; set; }
        public virtual DbSet<TraineeQuizHistory> TraineeQuizHistories { get; set; }
    }
}
