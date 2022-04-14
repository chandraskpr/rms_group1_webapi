using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RmsWebApi.RMS_DB
{
    public partial class RMSContext : DbContext
    {
        public RMSContext()
        {
        }

        public RMSContext(DbContextOptions<RMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AboutMe> AboutMes { get; set; } = null!;
        public virtual DbSet<Achievement> Achievements { get; set; } = null!;
        public virtual DbSet<Certification> Certifications { get; set; } = null!;
        public virtual DbSet<DesignationMaster> DesignationMasters { get; set; } = null!;
        public virtual DbSet<EducationDetail> EducationDetails { get; set; } = null!;
        public virtual DbSet<Membership> Memberships { get; set; } = null!;
        public virtual DbSet<MyDetail> MyDetails { get; set; } = null!;
        public virtual DbSet<ProjectMaster> ProjectMasters { get; set; } = null!;
        public virtual DbSet<Resume> Resumes { get; set; } = null!;
        public virtual DbSet<RoleMaster> RoleMasters { get; set; } = null!;
        public virtual DbSet<Skill> Skills { get; set; } = null!;
        public virtual DbSet<UserInfo> UserInfos { get; set; } = null!;
        public virtual DbSet<UserNotification> UserNotifications { get; set; } = null!;
        public virtual DbSet<UserResume> UserResumes { get; set; } = null!;
        public virtual DbSet<WorkExperience> WorkExperiences { get; set; } = null!;
        public virtual DbSet<training> training { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=PS-WIN-LP-509;Database=RMS;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AboutMe>(entity =>
            {
                entity.ToTable("AboutMe");

                entity.Property(e => e.AboutMeId).HasColumnName("aboutMeId");

                entity.Property(e => e.KeyPoints)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("keyPoints");

                entity.Property(e => e.MainDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("mainDescription");

                entity.Property(e => e.ResumeId).HasColumnName("resumeId");

                entity.HasOne(d => d.Resume)
                    .WithMany(p => p.AboutMes)
                    .HasForeignKey(d => d.ResumeId)
                    .HasConstraintName("FK_AboutMe_Resume")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Achievement>(entity =>
            {
                entity.Property(e => e.AchievementId).HasColumnName("achievementId");

                entity.Property(e => e.AchievementName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("achievementName");

                entity.Property(e => e.ResumeId).HasColumnName("resumeId");

                entity.HasOne(d => d.Resume)
                    .WithMany(p => p.Achievements)
                    .HasForeignKey(d => d.ResumeId)
                    .HasConstraintName("FK_Achievements_Resume")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Certification>(entity =>
            {
                entity.ToTable("Certification");

                entity.Property(e => e.CertificationId).HasColumnName("certificationId");

                entity.Property(e => e.CertificationName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("certificationName");

                entity.Property(e => e.ResumeId).HasColumnName("resumeId");

                entity.HasOne(d => d.Resume)
                    .WithMany(p => p.Certifications)
                    .HasForeignKey(d => d.ResumeId)
                    .HasConstraintName("resumeId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<DesignationMaster>(entity =>
            {
                entity.HasKey(e => e.DesignationId)
                    .HasName("PK__Designat__197CE32AFB186297");

                entity.ToTable("DesignationMaster");

                entity.Property(e => e.DesignationId).HasColumnName("designationId");

                entity.Property(e => e.DesignationDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("designationDescription");

                entity.Property(e => e.DesignationName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("designationName");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            });

            modelBuilder.Entity<EducationDetail>(entity =>
            {
                entity.HasKey(e => e.EducationId)
                    .HasName("PK__Educatio__DA3BE2B8AD4F4C05");

                entity.Property(e => e.EducationId).HasColumnName("educationId");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("courseName");

                entity.Property(e => e.InstituteName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("instituteName");

                entity.Property(e => e.Marks).HasColumnName("marks");

                entity.Property(e => e.PassingYear).HasColumnName("passingYear");

                entity.Property(e => e.ResumeId).HasColumnName("resumeId");

                entity.Property(e => e.Specialization)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("specialization");

                entity.Property(e => e.University)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("university");

                entity.HasOne(d => d.Resume)
                    .WithMany(p => p.EducationDetails)
                    .HasForeignKey(d => d.ResumeId)
                    .HasConstraintName("FK_EducationDetails_Resume")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Membership>(entity =>
            {
                entity.ToTable("Membership");

                entity.Property(e => e.MembershipId).HasColumnName("membershipId");

                entity.Property(e => e.MembershipName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("membershipName");

                entity.Property(e => e.ResumeId).HasColumnName("resumeId");

                entity.HasOne(d => d.Resume)
                    .WithMany(p => p.Memberships)
                    .HasForeignKey(d => d.ResumeId)
                    .HasConstraintName("FK_Membership_Resume")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<MyDetail>(entity =>
            {
                entity.HasKey(e => e.UserdetailsId)
                    .HasName("PK__MyDetail__317C6392ACFF1B40");

                entity.Property(e => e.UserdetailsId).HasColumnName("userdetailsId");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.ProfilePicture)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("profilePicture");

                entity.Property(e => e.ResumeId).HasColumnName("resumeId");

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("role");

                entity.Property(e => e.TotalExp).HasColumnName("totalExp");

                entity.HasOne(d => d.Resume)
                    .WithMany(p => p.MyDetails)
                    .HasForeignKey(d => d.ResumeId)
                    .HasConstraintName("FK_MyDetails_Resume")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<ProjectMaster>(entity =>
            {
                entity.HasKey(e => e.ProjectId)
                    .HasName("PK__ProjectM__11F14DA50A53363C");

                entity.ToTable("ProjectMaster");

                entity.Property(e => e.ProjectId).HasColumnName("projectId");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ProjectDescription)
                    .HasColumnType("text")
                    .HasColumnName("projectDescription");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("projectName");
            });

            modelBuilder.Entity<Resume>(entity =>
            {
                entity.ToTable("Resume");

                entity.Property(e => e.ResumeId).HasColumnName("resumeId");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("creationDate");

                entity.Property(e => e.ResumeStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("resumeStatus");

                entity.Property(e => e.ResumeTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("resumeTitle");

                entity.Property(e => e.UpdationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updationDate");
            });

            modelBuilder.Entity<RoleMaster>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__RoleMast__CD98462AD5F64F93");

                entity.ToTable("RoleMaster");

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.RoleDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("roleDescription");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("roleName");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.Property(e => e.SkillId).HasColumnName("skillId");

                entity.Property(e => e.Category)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.ResumeId).HasColumnName("resumeID");

                entity.HasOne(d => d.Resume)
                    .WithMany(p => p.Skills)
                    .HasForeignKey(d => d.ResumeId)
                    .HasConstraintName("FK_Skills_Resume")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserInfo__CB9A1CFF75194059");

                entity.ToTable("UserInfo");

                entity.HasIndex(e => e.UserEmail, "UQ__UserInfo__D54ADF552A81C599")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userEmail");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userName");

                entity.Property(e => e.UserRole)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userRole");
            });

            modelBuilder.Entity<UserNotification>(entity =>
            {
                entity.HasKey(e => e.NotificationId)
                    .HasName("PK__UserNoti__4BA5CEA9E0F226C5");

                entity.ToTable("UserNotification");

                entity.Property(e => e.NotificationId).HasColumnName("notificationId");

                entity.Property(e => e.CreationDate)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("creationDate");

                entity.Property(e => e.NotificationDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("notificationDescription");

                entity.Property(e => e.NotificationState)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("notificationState");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserNotifications)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserNotif__userI__3E52440B")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<UserResume>(entity =>
            {
                entity.ToTable("UserResume");

                entity.Property(e => e.UserResumeId).HasColumnName("userResumeId");

                entity.Property(e => e.ResumeId).HasColumnName("resumeId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Resume)
                    .WithMany(p => p.UserResumes)
                    .HasForeignKey(d => d.ResumeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserResume_Resume");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserResumes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserResume_UserInfo");
            });

            modelBuilder.Entity<WorkExperience>(entity =>
            {
                entity.ToTable("WorkExperience");

                entity.Property(e => e.WorkExperienceId).HasColumnName("workExperienceId");

                entity.Property(e => e.BusinessSolution)
                    .IsUnicode(false)
                    .HasColumnName("businessSolution");

                entity.Property(e => e.ClientDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("clientDescription");

                entity.Property(e => e.Country)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("endDate");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("projectName");

                entity.Property(e => e.ProjectResponsibilities)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("projectResponsibilities");

                entity.Property(e => e.ProjectRole)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("projectRole");

                entity.Property(e => e.ResumeId).HasColumnName("resumeId");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("startDate");

                entity.Property(e => e.TechnologyStack)
                    .IsUnicode(false)
                    .HasColumnName("technologyStack");

                entity.HasOne(d => d.Resume)
                    .WithMany(p => p.WorkExperiences)
                    .HasForeignKey(d => d.ResumeId)
                    .HasConstraintName("FK_WorkExperience_Resume")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<training>(entity =>
            {
                entity.ToTable("Training");

                entity.Property(e => e.TrainingId).HasColumnName("trainingId");

                entity.Property(e => e.ResumeId).HasColumnName("resumeId");

                entity.Property(e => e.Trainingname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trainingname")
                    .IsFixedLength();

                entity.HasOne(d => d.Resume)
                    .WithMany(p => p.training)
                    .HasForeignKey(d => d.ResumeId)
                    .HasConstraintName("FK__Training__resume__6EF57B66")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
