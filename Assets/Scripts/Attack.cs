using System.Collections;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private Hold _hold;
    [SerializeField] private float _maxSecondsToAttack;
    [SerializeField] private Animator _animation;

    public IEnumerator SecondsToAttack()
    {
        yield return new WaitForSeconds(Random.Range(1, _maxSecondsToAttack));
        _animation.SetTrigger("start");
    }

    public void Close()
    {
        if (_hold.Active)
        {
            _hold.ResetAll();
            Handheld.Vibrate();
        }
    }
}
    
      
    
    
    
  