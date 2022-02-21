using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BallHealth : MonoBehaviour
{
    [SerializeField]
    private GameValues _gameValues;

    public GameValues Values => _gameValues;

    [SerializeField]
    private TextMeshProUGUI _scoreText;

    [SerializeField]
    private TextMeshProUGUI _healthBallText;

    [SerializeField]
    private Slider _progressHealth;

    [SerializeField]
    private UtilsController _UtilsController;

    [SerializeField]
    private BallMovement _BallMovement;

    private float _deathCounter = 0.1f;
    private float _invincibilityCounter = 1f;

    private void Awake()
    {
        _UtilsController = FindObjectOfType<UtilsController>();
        _BallMovement = FindObjectOfType<BallMovement>();

    }

    public void ScoreBall()
    {
       
        _scoreText.text = _gameValues.scoreBall.ToString();

        if(_gameValues.scoreBall == 10)
        {
           _BallMovement._moveSpeed *= 1.5f;
        }

        if (_gameValues.scoreBall == 25)
        {
            _BallMovement._moveSpeed *= 2f;
        }

        if (_gameValues.scoreBall == 50)
        {
            _BallMovement._moveSpeed *= 3f;
        }

        if (_gameValues.scoreBall == 100)
        {
            _BallMovement._moveSpeed *= 4f;
        }
    }

    public void HealthBallScore()
    {
        _healthBallText.text = _gameValues.healthBall.ToString();
        _progressHealth.value -= (1f/3f);

        if (_gameValues.healthBall == 0)
        {
            _UtilsController.PauseGame();
        }
    }

    public void Update()
    {
        if (_gameValues.death == true)
        {
            if (_invincibilityCounter > 0)
            {
                _invincibilityCounter -= Time.deltaTime;

                _deathCounter -= Time.deltaTime;

                if (_deathCounter <= 0)
                {
                    gameObject.GetComponent<MeshRenderer>().enabled = !gameObject.GetComponent<MeshRenderer>().enabled;
                    _deathCounter = 0.1f;
                }

                if (_invincibilityCounter <= 0)
                {
                    _gameValues.death = false;
                    gameObject.GetComponent<MeshRenderer>().enabled = true;
                    _invincibilityCounter = 1f;
                }
            }
            
        }
        
    }

}
