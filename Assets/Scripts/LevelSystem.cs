using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    [SerializeField] private Hold _hold;
    [SerializeField] private TMP_Text _textTotalPointsCounter;
    [SerializeField] private GameObject _hat;
    [SerializeField] private GameObject _bowTie;
    [SerializeField] private GameObject _glasses;
    [SerializeField] private GameObject _stick;
    [SerializeField] private GameObject _endFace;
    [SerializeField] private GameObject _monsterFace;
    [SerializeField] int[] Levels = { };

    private void Update()
    {
        Hat();
        BowTie();
        Glasses();
        Stick();
        EndGame();
    }
    public void Hat()
    {
        if (_hold.TotalPoints >= Levels[0])
        {
          _hat.SetActive(true);
        }
    }

    public void BowTie()
    {
        if (_hold.TotalPoints >= Levels[1])
        {
            _bowTie.SetActive(true);
        }
    }

    public void Glasses()
    {
        if (_hold.TotalPoints >= Levels[2])
        {
           _glasses.SetActive(true);
        }
    }

    public void Stick()
    {
        if (_hold.TotalPoints >= Levels[3])
        {
            _stick.SetActive(true);
        }
    }

    public void EndGame()
    {
        if (_hold.TotalPoints >= Levels[4])
        {
            _endFace.SetActive(true);
            _monsterFace.SetActive(false);
        }
    }
}
