using UnityEngine;
[System.Serializable]       // ������ ����ȭ 

public class Ability
{
    public Ability()
    {
        Debug.Log("Ability");
    }

    [Header("��ũ��Ʈ �׽�Ʈ")]

    [SerializeField] private int strength = 10;

    public int Strength { get { return strength; } }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("strength : " + strength);
    }

  
}
