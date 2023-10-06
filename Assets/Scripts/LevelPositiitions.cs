using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPositiitions : MonoBehaviour
{
    [SerializeField] private float[] _levelsPositionsX;
    [SerializeField] private RectTransform _rectTransformContent;


    public void ChangeLevelsPositions(int indexLevel)
    {
        _rectTransformContent.anchoredPosition = new Vector3(_levelsPositionsX[indexLevel], 0, 0);
    }
}
