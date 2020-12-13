using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreEvents : MonoBehaviour {

    private readonly List<Action<ScoresManager>> _callbacks = new List<Action<ScoresManager>>();

    public void Subscribe(Action<ScoresManager> callback)
    {
        _callbacks.Add(callback);
    }

    public void Publish(ScoresManager unit)
    {
        foreach (Action<ScoresManager> callback in _callbacks)
            callback(unit);
    }
}
