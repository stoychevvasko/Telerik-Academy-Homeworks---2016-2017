////-------------------------------------------------------------------------------------------------
//// <copyright file="FurType.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace BunniesFormattingTask.Core.Enumerations
{
    /// <summary>
    /// Enumerates all allowed types of fur.
    /// </summary>
    public enum FurType
    {
        /// <summary>
        /// This value is suitable for creatures without fluffy fur.
        /// </summary>
        NotFluffy = 0,

        /// <summary>
        /// This value is suitable for creatures with fur that is just a little bit fluffy.
        /// </summary>
        ALittleFluffy,

        /// <summary>
        /// This value is suitable for creatures with a standardly fluffy fur.
        /// </summary>
        Fluffy,

        /// <summary>
        /// Use this value for maximum fur fluffiness.
        /// </summary>
        FluffyToTheLimit
    }
}
