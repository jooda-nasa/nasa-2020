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

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace YodaClock.DataContext
{
    // UserPrecondition
    public class UserPrecondition
    {
        public int Id { get; set; } // Id (Primary key)
        public int UserId { get; set; } // UserId
        public int SleepDuration { get; set; } // SleepDuration
        public int SleepInterruptions { get; set; } // SleepInterruptions

        // Foreign keys

        /// <summary>
        /// Parent User pointed by [UserPrecondition].([UserId]) (FK_UserPrecondition_User)
        /// </summary>
        public virtual User User { get; set; } // FK_UserPrecondition_User
    }

}
// </auto-generated>
