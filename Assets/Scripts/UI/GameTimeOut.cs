using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameTimeOut : MonoBehaviour
{
    public event UnityAction GameOver;

    public void RanOutTime()
    {
        GameOver?.Invoke();
    }
}