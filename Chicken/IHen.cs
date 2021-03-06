﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IHen.cs" company="RHEA System S.A.">
//    Copyright (c) 2019 RHEA System S.A.
//
//    Author: Sam Gerené
//
//    This file is part of the Chicken
//
//    The Chicken is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 3 of the License, or (at your option) any later version.
//
//    The Chicken is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public License
//    along with this program; if not, write to the Free Software Foundation,
//    Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Chicken
{
    /// <summary>
    /// The definition of the <see cref="IHen"/> interface. An <see cref="IHen"/> is a female <see cref="IChicken"/>
    /// </summary>
    interface IHen : IChicken
    {
        /// <summary>
        /// Gets a value expressing the sexual state, which is age dependent, of the <see cref="IHen"/>
        /// </summary>
        FemaleSexualState SexualState { get; }

        /// <summary>
        /// The action of laying an <see cref="IEgg"/>.
        /// </summary>
        /// <returns>
        /// An instance of <see cref="IEgg"/>
        /// </returns>
        IEgg LayAnEgg();
    }
}