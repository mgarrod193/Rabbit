using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    //variables to manage gamestate
    private int _lives = 3;
    private gameState _state;

    //reference to player prefab and spawnpoint
    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private GameObject _playerSpawnPoint;


    private void PlayerDied()
    {
        DecreaseLives();
        if (_lives >0 )
        { Instantiate(_playerSpawnPoint, _playerSpawnPoint.transform.position, _playerSpawnPoint.transform.rotation);  }
        else
        {
            UpdateGameState(gameState.Lose);
        }
    }

    private void DecreaseLives()
    {
        _lives--;
    }


    private void UpdateGameState(gameState GameState)
    {
        _state = GameState;
    }

    private enum gameState
    {
        MainMenu,
        Gameplay,
        Win,
        Lose,
    }
}
