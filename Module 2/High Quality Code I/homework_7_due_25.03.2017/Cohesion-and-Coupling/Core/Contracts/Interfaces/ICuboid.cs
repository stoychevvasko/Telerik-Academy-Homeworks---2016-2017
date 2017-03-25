//// <copyright file="ICuboid.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace CohesionAndCoupling.Core.Contracts.Interfaces
{
    /// <summary>Provides cuboid-specific functionality.</summary>
    internal interface ICuboid
    {
        /// <summary>Gets or sets the depth dimension of a cuboid shape.</summary>
        double Depth { get; set; }

        /// <summary>Gets or sets the height dimension of a cuboid shape.</summary>
        double Height { get; set; }

        /// <summary>Gets or sets the width dimension of a cuboid shape.</summary>
        double Width { get; set; }

        /// <summary>Calculates the XY diagonal of a cuboid shape.</summary><returns>A <see cref="double"/> value as result.</returns>
        double CalcDiagonalXY();

        /// <summary>Calculates the XYZ diagonal of a cuboid shape.</summary><returns>A <see cref="double"/> value as result.</returns>
        double CalcDiagonalXYZ();

        /// <summary>Calculates the XZ diagonal of a cuboid shape.</summary><returns>A <see cref="double"/> value as result.</returns>
        double CalcDiagonalXZ();

        /// <summary>Calculates the YZ diagonal of a cuboid shape.</summary><returns>A <see cref="double"/> value as result.</returns>
        double CalcDiagonalYZ();

        /// <summary>Calculates the volume of the cuboid shape.</summary><returns>A <see cref="double"/> value as result.</returns>
        double CalcVolume();
    }
}
