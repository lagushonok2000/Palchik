using System.Collections;
using UnityEngine;

public class Attack : Hold
{
    public float RandomNumber = Random.Range(1, 7);
    public bool Hold = true;
    public Animator CheekAnimation;
    public Animator TeethAnimation;

    public void Update()
    {
        StartCoroutine(SecondsToAttack());
    }
    
    public IEnumerator SecondsToAttack()
    {
        while (Hold)  // onPointerDown
        {
            yield return new WaitForSeconds (RandomNumber);
            Debug.Log("схлопывается"); //срабатывает метод OnPointerUp()
            CheekAnimation = GetComponent<Animator>();
            TeethAnimation = GetComponent<Animator>();
            CheekAnimation.enabled = true;
            TeethAnimation.enabled = true;

        }
    }
}
    
      
    
    
    
  