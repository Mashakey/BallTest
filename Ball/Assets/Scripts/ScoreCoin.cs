using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCoin : MonoBehaviour
{
    [SerializeField] 
    private int _score;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<BallHealth>().Values.scoreBall += _score;
            other.gameObject.GetComponent<BallHealth>().ScoreBall();
            Destroy(gameObject);
        }
    }
}
