using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldDisplay : MonoBehaviour
{
    [SerializeField]private TMP_Text _text;

    private void Start()
    {
        UpdateUI();
    }
    private void OnEnable() //event dinlemesi yaptýk.
    {
        GameInstance.Instance.GoldChanged += OnGoldChanged;
        
    }


    private void OnDisable() //event dinlemeyi býraktýk.
    {
        GameInstance.Instance.GoldChanged -= OnGoldChanged;
        
    }

   

    private void OnGoldChanged(int newGold)
    {
        UpdateUI(newGold);
    }


    private void UpdateUI(int value)
    {
        _text.text = value.ToString();
    }

    private void UpdateUI()
    {
       UpdateUI(GameInstance.Instance.Gold);
    }


    
}
