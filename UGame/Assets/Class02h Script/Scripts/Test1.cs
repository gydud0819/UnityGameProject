using UnityEngine;

public class Test1 : MonoBehaviour
{
    [Header("스크립트 테스트")]
    //[SerializeField] Rigidbody rigidbody;
    //[SerializeField] Transform transform;

    [SerializeField] private int strength;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       

        Debug.Log("Strength : " + strength);
    }

  
}
