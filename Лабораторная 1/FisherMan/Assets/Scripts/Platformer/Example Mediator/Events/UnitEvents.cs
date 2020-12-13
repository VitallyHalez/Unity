﻿using System;
using System.Collections.Generic;
using UnityEngine;

public class UnitEvents : MonoBehaviour
{
    private readonly List<Action<Unit>> _callbacks = new List<Action<Unit>>();

    public void Subscribe(Action<Unit> callback)
    {
        _callbacks.Add(callback);
    }

    public void Publish(Unit unit)
    {
        foreach (Action<Unit> callback in _callbacks)
            callback(unit);
    }
}
