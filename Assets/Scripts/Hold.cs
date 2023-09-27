using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hold : MonoBehaviour, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler
{
    [SerializeField] private TMP_Text _textPointsCounter;
    [SerializeField] private TMP_Text _textTotalPointsCounter;
    [SerializeField] private float _updatePerSeconds;
    [SerializeField] private int _maxAdd;
    [SerializeField] private int _countAdd;
    private float _points = 0;
    private bool _active;
    
    
    IEnumerator PointsCounter()
    {
        float add = _countAdd;
        while (_active)
        {
            _points = _points + 1;
            _textPointsCounter.text = _points.ToString("#");
            yield return new WaitForSeconds(_updatePerSeconds);
            _updatePerSeconds -= 0.001f;
            
            if (add < _maxAdd)
            {
                add += _countAdd;
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _active = true;
        StartCoroutine(PointsCounter());
    }
  
    public void OnPointerExit(PointerEventData eventData)
    {
        PointerUp();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        PointerUp();
    }

    private void PointerUp()
    {
        _active = false;
        _textTotalPointsCounter.text = (Convert.ToSingle(_textTotalPointsCounter.text) + _points).ToString();
        _textPointsCounter.text = "0";
        _points = 0;
        StopAllCoroutines();
    }
}
