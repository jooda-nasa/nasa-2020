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
    // UserProductMeal
    public class UserProductMeal
    {
        public int Id { get; set; } // Id (Primary key)
        public int UserId { get; set; } // UserId
        public int ProductId { get; set; } // ProductId
        public int MealId { get; set; } // MealId
        public int Amount { get; set; } // Amount
        public DateTime Timestamp { get; set; } // Timestamp

        // Foreign keys

        /// <summary>
        /// Parent Meal pointed by [UserProductMeal].([MealId]) (FK_UserProductMeal_Meal)
        /// </summary>
        public virtual Meal Meal { get; set; } // FK_UserProductMeal_Meal

        /// <summary>
        /// Parent Product pointed by [UserProductMeal].([ProductId]) (FK_UserProductMeal_Product)
        /// </summary>
        public virtual Product Product { get; set; } // FK_UserProductMeal_Product

        /// <summary>
        /// Parent User pointed by [UserProductMeal].([UserId]) (FK_UserProductMeal_User)
        /// </summary>
        public virtual User User { get; set; } // FK_UserProductMeal_User
    }

}
// </auto-generated>

