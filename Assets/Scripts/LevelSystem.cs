using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    [SerializeField] private Hold _hold;
    [SerializeField] private LevelPositiitions _changeLevelsPositions;
    [SerializeField] public int[] Levels = { };
    [SerializeField] private GameObject[] _accessories;
    [SerializeField] private GameObject _endFace;
    [SerializeField] private GameObject _monsterFace;
    

    public void LevelChek(float TotalPoints)
    {
        for (int i = 0; i < Levels.Length; i++)
        {
            if (TotalPoints >= Levels[i])
            {
                _accessories[i].SetActive(true);
                _changeLevelsPositions.ChangeLevelsPositions(i);

                if (i == 4)
                {
                    _monsterFace.SetActive(false);
                    _endFace.SetActive(true);
                }
                
            }
        }
    }
    
    private void GameOver()
    {
        if (_hold.TotalPoints == 0)
        {
            _endFace.SetActive(false);
            _monsterFace.SetActive(true);
            for (int i = 0;i < _accessories.Length;i++)
            {
                _accessories[i].SetActive(false);
            }

            _changeLevelsPositions.ChangeLevelsPositions(0);
        }
    }
}
