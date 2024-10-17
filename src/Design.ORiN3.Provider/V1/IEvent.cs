using Design.ORiN3.Provider.V1.Base;
using System;
using System.Collections.Generic;

namespace Design.ORiN3.Provider.V1;

/// <summary>
/// Interface to the Event object, an ORiN3 object.
/// </summary>
public interface IEvent : IORiN3Object, IChild
{
    /// <summary>
    /// Call a registered method.
    /// </summary>
    /// <param name="argument">Arguments to be passed to the registered method</param>
    void Publish(IDictionary<string, object?> argument);

    /// <summary>
    /// Register a method that has no return value. 
    /// The methods registered here will be called when the Publish method is called.
    /// Multiple methods can be registered.
    /// </summary>
    /// <param name="handler">Methods to register</param>
    /// <returns>Subscription key</returns>
    int Subscribe(Action<IDictionary<string, object?>> handler);

    /// <summary>
    /// Unregistering a registered method
    /// </summary>
    /// <param name="subscriptionKey">Subscription key</param>
    void Unsubscribe(int subscriptionKey);
}