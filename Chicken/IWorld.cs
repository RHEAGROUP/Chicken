﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IWorld.cs" company="RHEA System S.A.">
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
    /// The place all chickens live
    /// </summary>
    public interface IWorld
    {
        /// <summary>
        /// Starts the world
        /// </summary>
        void Start();

        /// <summary>
        /// Ends the world
        /// </summary>
        void End();

        /// <summary>
        /// Gets or sets the speed at which the time in the <see cref="IWorld"/> passes. The default is one, which indicates
        /// that the clock goes at nominal speed, 2 indicates the clock goes twice as fast, etc.
        /// </summary>
        int ClockSpeed { get; set; }
    }
}