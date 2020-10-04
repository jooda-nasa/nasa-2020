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
    // Exercise
    public class Exercise
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name (length: 100)
        public int PlanId { get; set; } // PlanId

        // Reverse navigation

        /// <summary>
        /// Child UserMealExercises where [UserMealExercise].[ExerciseId] point to this entity (FK_UserMealExerise_Exercise)
        /// </summary>
        public virtual ICollection<UserMealExercise> UserMealExercises { get; set; } // UserMealExercise.FK_UserMealExerise_Exercise

        // Foreign keys

        /// <summary>
        /// Parent Plan pointed by [Exercise].([PlanId]) (FK_Exercise_Plan)
        /// </summary>
        public virtual Plan Plan { get; set; } // FK_Exercise_Plan

        public Exercise()
        {
            UserMealExercises = new List<UserMealExercise>();
        }
    }

}
// </auto-generated>

