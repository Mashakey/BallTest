using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Values", menuName = "ScriptableObjects/GameValues", order = 1)]
public class GameValues : ScriptableObject
{
    public float healthBall;

    public float scoreBall;

    public bool death;

    public void Reset()
    {
       healthBall = 3;
       scoreBall = 0;
      death = false;
    }
}
