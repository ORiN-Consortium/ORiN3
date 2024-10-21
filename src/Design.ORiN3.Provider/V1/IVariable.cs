﻿using Design.ORiN3.Provider.V1.Base;
using Design.ORiN3.Provider.V1.Type;
using System.Threading;
using System.Threading.Tasks;

namespace Design.ORiN3.Provider.V1;

/// <summary>
/// Interface of the Variable object, which is an ORiN3 object.
/// </summary>
public interface IVariable : IORiN3Object, IChild
{
    /// <summary>
    /// Enumerated values of the ORiN3 data type that it handles
    /// </summary>
    ORiN3ValueType ORiN3ValueType { get; }
}

/// <summary>
/// Generic class for IVariable class
/// </summary>
/// <typeparam name="T">ORiN3Variable object value type</typeparam>
public interface IVariable<T> : IVariable
{
    /// <summary>
    /// Set data
    /// </summary>
    /// <param name="value">Value to be set</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>The task object representing the asynchronous operation</returns>
    Task SetValueAsync(T value, CancellationToken token = default);

    /// <summary>
    /// Get data
    /// </summary>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>Value to be get</returns>
    Task<T> GetValueAsync(CancellationToken token = default);
}