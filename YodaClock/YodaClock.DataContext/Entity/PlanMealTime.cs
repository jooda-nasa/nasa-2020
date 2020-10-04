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
    // PlanMealTime
    public class PlanMealTime
    {
        public int Id { get; set; } // Id (Primary key)
        public int PlanId { get; set; } // PlanId
        public int MealId { get; set; } // MealId
        public decimal Percentage { get; set; } // Percentage
        public DateTime Start { get; set; } // Start
        public DateTime End { get; set; } // End

        // Foreign keys

        /// <summary>
        /// Parent Meal pointed by [PlanMealTime].([MealId]) (FK_PlanMealTime_Meal)
        /// </summary>
        public virtual Meal Meal { get; set; } // FK_PlanMealTime_Meal

        /// <summary>
        /// Parent Plan pointed by [PlanMealTime].([PlanId]) (FK_PlanMealTime_Plan)
        /// </summary>
        public virtual Plan Plan { get; set; } // FK_PlanMealTime_Plan
    }

}
// </auto-generated>

