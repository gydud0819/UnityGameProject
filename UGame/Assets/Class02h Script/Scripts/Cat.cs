using System;
using System.Collections;
using UnityEngine;

public class Cat : MonoBehaviour
{
    [SerializeField] private Ability ablilty;
    //[SerializeField] private int HP;

    private void Awake()
    {
        // Awake : 객체가 생성될 때 호출되는 함수로, 객체가 비활성화되어 있을 때도 호출되고, 단 한번만 호출되는 이벤트 함수

        Debug.Log("Awake");
        Debug.Log(ablilty.Strength);
    }

    private void OnEnable()
    {
        // OnEnable : 객체가 활성화되었을 때 호출되는 이벤트 함수
        Debug.Log("OnEnable");
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Start : 객체가 생성되었을 때 호출되고, 단 한번만 호출되는 이벤트 함수
        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        // FixedUpdate :  Time Step에 설정된 값에 따라 일정한 간격으로 호출되는 이벤트 함수

        Debug.Log("Fixed Update");
    }

    // Update is called once per frame
    void Update()
    {
        // Update : 객체가 활성화되는 동안 매 프레임마다 호출되는 이벤트 함수
        Debug.Log("Update");
      
    }

    private void LateUpdate()
    {
        // LateUpdate : 한 프레임의 마지막 단계에서 호출되는 이벤트 함수
        Debug.Log("Late Update");
    }

    private void OnDisable()
    {
        // OnDisable : 객체가 비활성화 되었을때 호출되는 이벤트 함수
        Debug.Log("OnDisable");
        //gameObject.SetActive(false);
    }

    private void OnDestroy()
    {
        // OnDestroy : 객체가 삭제되었을 때 호출되는 이벤트 함수
        Debug.Log("OnDestroy");
    }

}
