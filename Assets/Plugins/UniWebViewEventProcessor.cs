using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class UniWebViewEventProcessor : MonoBehaviour {
    
    private System.Object _queueLock = new System.Object();
    private List<Action> _queuedEvents = new List<Action>();
    private List<Action> _executingEvents = new List<Action>();

    private static UniWebViewEventProcessor _instance = null;

    public static UniWebViewEventProcessor instance
    {
        get
        {
            if (!_instance)
            {
                _instance = FindObjectOfType(typeof(UniWebViewEventProcessor)) as UniWebViewEventProcessor;

                if (!_instance)
                {
                    var obj = new GameObject("UniWebViewEventProcessor");
                    DontDestroyOnLoad(obj);
                    _instance = obj.AddComponent<UniWebViewEventProcessor>();
                }
            }
            return _instance;
        }
    }

    public void QueueEvent(Action action)
    {
        lock (_queueLock)
        {
            _queuedEvents.Add(action);
        }
    }

    void Update()
    {
        MoveQueuedEventsToExecuting();

        while (_executingEvents.Count > 0)
        {
            Action e = _executingEvents[0];
            _executingEvents.RemoveAt(0);
            e();
        }
    }

    private void MoveQueuedEventsToExecuting()
    {
        lock (_queueLock)
        {
            while (_queuedEvents.Count > 0)
            {
                Action e = _queuedEvents[0];
                _executingEvents.Add(e);
                _queuedEvents.RemoveAt(0);
            }
        }
    }
}
