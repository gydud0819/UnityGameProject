using System;
using System.Collections;
using UnityEngine;

public class Cat : MonoBehaviour
{
    [SerializeField] private Ability ablilty;
    //[SerializeField] private int HP;

    private void Awake()
    {
        // Awake : ��ü�� ������ �� ȣ��Ǵ� �Լ���, ��ü�� ��Ȱ��ȭ�Ǿ� ���� ���� ȣ��ǰ�, �� �ѹ��� ȣ��Ǵ� �̺�Ʈ �Լ�

        Debug.Log("Awake");
        Debug.Log(ablilty.Strength);
    }

    private void OnEnable()
    {
        // OnEnable : ��ü�� Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("OnEnable");
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Start : ��ü�� �����Ǿ��� �� ȣ��ǰ�, �� �ѹ��� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        // FixedUpdate :  Time Step�� ������ ���� ���� ������ �������� ȣ��Ǵ� �̺�Ʈ �Լ�

        Debug.Log("Fixed Update");
    }

    // Update is called once per frame
    void Update()
    {
        // Update : ��ü�� Ȱ��ȭ�Ǵ� ���� �� �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("Update");
      
    }

    private void LateUpdate()
    {
        // LateUpdate : �� �������� ������ �ܰ迡�� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("Late Update");
    }

    private void OnDisable()
    {
        // OnDisable : ��ü�� ��Ȱ��ȭ �Ǿ����� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("OnDisable");
        //gameObject.SetActive(false);
    }

    private void OnDestroy()
    {
        // OnDestroy : ��ü�� �����Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("OnDestroy");
    }

}
