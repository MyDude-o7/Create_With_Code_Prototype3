﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtonXYZ : MonoBehaviour
{
    private Button button;
    private GameManagerXYZ gameManagerXYZ;
    public int difficulty;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerXYZ = GameObject.Find("Game Manager").GetComponent<GameManagerXYZ>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }

    /* When a button is clicked, call the StartGame() method
     * and pass it the difficulty value (1, 2, 3) from the button 
    */
    void SetDifficulty()
    {
        Debug.Log(button.gameObject.name + " was clicked");
        gameManagerXYZ.StartGame(difficulty);
    }



}
