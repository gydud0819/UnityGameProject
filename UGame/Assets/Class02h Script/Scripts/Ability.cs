using UnityEngine;
[System.Serializable]       // 데이터 직렬화 

public class Ability
{
    public Ability()
    {
        Debug.Log("Ability");
    }

    [Header("스크립트 테스트")]

    [SerializeField] private int strength = 10;

    public int Strength { get { return strength; } }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("strength : " + strength);
    }

  
}
