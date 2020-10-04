// <auto-generated>
// ReSharper disable CheckNamespace
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable NotAccessedVariable
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantCast
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// ReSharper disable UsePatternMatching
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace YodaClock.DataContext
{
    // UserMealExercise
    public class UserMealExerciseConfiguration : IEntityTypeConfiguration<UserMealExercise>
    {
        public void Configure(EntityTypeBuilder<UserMealExercise> builder)
        {
            builder.ToTable("UserMealExercise", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_UserEatingExerise").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.UserId).HasColumnName(@"UserId").HasColumnType("int").IsRequired();
            builder.Property(x => x.MealId).HasColumnName(@"MealId").HasColumnType("int").IsRequired();
            builder.Property(x => x.ExerciseId).HasColumnName(@"ExerciseId").HasColumnType("int").IsRequired();
            builder.Property(x => x.Ate).HasColumnName(@"Ate").HasColumnType("bit").IsRequired();
            builder.Property(x => x.Time).HasColumnName(@"Time").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Timestamp).HasColumnName(@"Timestamp").HasColumnType("datetime").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.Exercise).WithMany(b => b.UserMealExercises).HasForeignKey(c => c.ExerciseId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_UserMealExerise_Exercise");
            builder.HasOne(a => a.Meal).WithMany(b => b.UserMealExercises).HasForeignKey(c => c.MealId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_UserMeaExerise_Meal");
            builder.HasOne(a => a.User).WithMany(b => b.UserMealExercises).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_UserMealExerise_User");
        }
    }

}
// </auto-generated>
