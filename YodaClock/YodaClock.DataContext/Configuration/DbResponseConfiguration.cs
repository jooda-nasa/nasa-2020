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
    // DbResponse
    public class DbResponseConfiguration : IEntityTypeConfiguration<DbResponse>
    {
        public void Configure(EntityTypeBuilder<DbResponse> builder)
        {
            builder.ToTable("DbResponse", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_DbResponse_1").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Db).HasColumnName(@"DB").HasColumnType("int").IsRequired();
            builder.Property(x => x.Percentage).HasColumnName(@"Percentage").HasColumnType("decimal(18,2)").IsRequired();
        }
    }

}
// </auto-generated>
