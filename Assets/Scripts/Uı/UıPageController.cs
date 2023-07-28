using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UıPageController : MonoBehaviour
{
    [SerializeField] private GameObject _menuPage;
    [SerializeField] private GameObject _gamePage;
    [SerializeField] private GameObject _losePage;
    [SerializeField] private GameObject _winPage;


    private void Start()
    {
        _gamePage.SetActive(false);
    }

    private void OnEnable() //event dinlemesi yaptık.
    {
        
        GameInstance.Instance.Won += OnGameWon;
        GameInstance.Instance.Lost += OnGameLost;
    }


    private void OnDisable() //event dinlemeyi bıraktık.
    {
        
        GameInstance.Instance.Won += OnGameWon;
        GameInstance.Instance.Lost += OnGameLost;
    }

    private void OnGameLost()
    {
        _gamePage.SetActive(false);
    }

    private void OnGameWon()
    {

    }

    private void OnGameStarted()
    {

    }
}

