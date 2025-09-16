using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] int count;
    [SerializeField] GameObject prefab;
    GameObject game;
    [SerializeField] List<GameObject> prefabs;
    [SerializeField] float time;     // 5.0 붙여야하나 
    private void Start()
    {
        //game.transform.position = new Vector3(1, 0, 0);

        //for (int i = 0; i < 5; i++)
        //{

        //    prefabs[i].SetActive(false);
        //    prefabs.Add(Instantiate(prefab));
        //}

        Initialized();

    }

    private void Update()
    {
        time += Time.deltaTime;

        if(time >= 5.0)
        {
            Debug.Log("호출");
        }
    }

     void Initialized()
    {
        prefabs.Capacity = 10;
        for (int i = 0; i < count; i++)
        {
            game = Instantiate(prefab, gameObject.transform);
            game.SetActive(false);
            prefabs.Add(game);
        }
    }

}
