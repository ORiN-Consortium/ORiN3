﻿using Design.ORiN3.Provider.V1.Type;
using System;

namespace Design.ORiN3.Provider.V1.Base;

/// <summary>
/// ORiN3 object information
/// </summary>
public interface IORiN3ObjectInformation
{
    /// <summary>
    /// ID to identify the ORiN3 object
    /// </summary>
    /// <remarks>
    /// Unique for each ORiN3 object.
    /// </remarks>
    Guid Id { get; }

    /// <summary>
    /// Name
    /// </summary>
    /// <remarks>
    /// It can be used to identify ORiN3 objects in the application layer, but it does not check for duplicate names in the ORiN3 layer.
    /// </remarks>
    string Name { get; }

    /// <summary>
    /// ORiN3 object type
    /// </summary>
    ORiN3ObjectType ORiN3ObjectType { get; }
}