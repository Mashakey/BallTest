using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UtilsController : MonoBehaviour
{
    private GameTimeController _gameTimeController;

    [SerializeField]
    private GameObject _restartPanel;

    [SerializeField]
    private Slider _progressHealth;

    [SerializeField]
    private GameValues _gameValues;

    [SerializeField]
    private BallMovement _ballMovement;

    private void Awake()
    {
        _gameTimeController = new GameTimeController();
        _ballMovement = FindObjectOfType<BallMovement>();
    }

    private void Start()
    {
        _gameTimeController.PauseGame();
    }

    public void StartGame()
    {
        _gameTimeController.UnpauseGame();
        _gameValues.Reset();
        _progressHealth.value = 1;
        _ballMovement.ResetSpeed();
    }

    public void PauseGame()
    {
        _gameTimeController.PauseGame();
        _restartPanel.SetActive(true);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
