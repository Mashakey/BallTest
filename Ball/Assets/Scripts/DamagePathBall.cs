using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePathBall : MonoBehaviour
{
    [SerializeField]
    private float _damage;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<BallHealth>().Values.death = true;
            other.gameObject.GetComponent<BallHealth>().Values.healthBall -= _damage;
            other.gameObject.GetComponent<BallHealth>().HealthBallScore();
        }
    }
}
