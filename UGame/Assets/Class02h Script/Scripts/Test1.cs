using UnityEngine;

public class Test1 : MonoBehaviour
{
    [Header("��ũ��Ʈ �׽�Ʈ")]
    //[SerializeField] Rigidbody rigidbody;
    //[SerializeField] Transform transform;

    [SerializeField] private int strength;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       

        Debug.Log("Strength : " + strength);
    }

  
}
