using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController  
{
    private PlayerView _playerView;
    private PlayerModel _playerModel;

    public PlayerController(PlayerView view, PlayerModel model)
    {
        _playerView = view;
        _playerModel = model;

        _playerModel.TakeDamage += Death;
        _playerModel.LefillLives += FillLives;
    }

    public void OnDisable()
    {
        _playerModel.TakeDamage -= Death;
        _playerModel.LefillLives -= FillLives;
    }

    private void Death(int currentHp)
    {
        _playerView.TakeDamage(currentHp);
    }

    private void FillLives(int currentHp)
    {
        _playerView.LefillHp(currentHp);
    }
}
