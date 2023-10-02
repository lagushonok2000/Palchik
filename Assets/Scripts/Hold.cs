using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hold : MonoBehaviour, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler
{
    [SerializeField] Attack _attack;
    [SerializeField] private TMP_Text _textPointsCounter;
    [SerializeField] private TMP_Text _textTotalPointsCounter;
    [SerializeField] private float _startUpdatePerSeconds;
    [SerializeField] private float _subUpdatePerSeconds;
    [SerializeField] private float _minUpdatePerSeconds;
    private float _updatePerSeconds;
    public float _points = 0;
    public float TotalPoints = 0;
    public bool Active;
    
    IEnumerator PointsCounter()
    {
        _updatePerSeconds = _startUpdatePerSeconds;
        while (Active)
        {
            _points++;
            _textPointsCounter.text = _points.ToString("#");
            yield return new WaitForSeconds(_updatePerSeconds);
            if (_updatePerSeconds > _minUpdatePerSeconds)
            {
                _updatePerSeconds -= _subUpdatePerSeconds;
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Active = true;
        StartCoroutine(PointsCounter());
        StartCoroutine(_attack.SecondsToAttack());
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
        Active = false;
        TotalPoints += _points;
        _textTotalPointsCounter.text = TotalPoints.ToString("#");
        _textPointsCounter.text = "0";
        _points = 0;
        StopAllCoroutines();
    }

    public void ResetAll()
    {
        _points = 0;
        _textPointsCounter.text = "0";
        _textTotalPointsCounter.text = "0";
    }
}
