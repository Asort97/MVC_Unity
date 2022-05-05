using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerView _playerView;
    private PlayerModel _playerModel;

    private PlayerController _playerController;

    private void Start()
    {
        _playerModel = new PlayerModel();
        _playerController = new PlayerController(_playerView, _playerModel);
    }
    

    public void LefillLives()
    {
        _playerModel.FillLives();
    }

    public void TakeDamage()
    {
        _playerModel.LoseLives();
    }

    public void LoadScene(int idScene)
    {
        SceneManager.LoadScene(idScene);
    }
    
    public void OnExit()
    {
        Application.Quit();
    }
}
