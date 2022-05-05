using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlayerModel 
{
    public event Action<int> TakeDamage;
    public event Action<int> LefillLives;
    private int _maxLives = 20;
    private int _currentLives;

    public PlayerModel()
    {
        _currentLives = 0;
    }

    public void FillLives()
    {
        _currentLives = _maxLives;

        LefillLives?.Invoke(_currentLives);
    }
    public void LoseLives()
    {
        if(_currentLives > 0)
        {
            _currentLives -= 1;
            TakeDamage?.Invoke(_currentLives);
        }
    }
}
