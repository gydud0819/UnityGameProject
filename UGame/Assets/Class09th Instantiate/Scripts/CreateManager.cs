using NUnit.Framework;
using System.Collections;
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
        StartCoroutine(Coroutine());

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

    bool ExmineActive()
    {
        for (int i = 0; i < prefabs.Count; i++)
        {
            if (prefabs[i].activeSelf == false)
            {
                return false;
            }
        }

        return true;
    }

    IEnumerator Coroutine()
    {
        int idx = 0;

        while (true)
        {
            // 5초마다 하나씩 생성시키되 같은 수가 나오면 그 다음걸 실행시키기..?
            yield return new WaitForSeconds(5.0f);      // yield : 양보하다(?)

            idx = Random.Range(0, count);

            if (prefabs[idx].activeSelf)
            {
                //idx = (idx + 1) % prefabs.Count;
                continue;   // 얘도 될거같은디 
            }

            prefabs[idx].SetActive(true);

            if(ExmineActive())
            {
                yield break;
            }

            //while (prefabs[idx].activeSelf)
            //{
            //    idx = Random.Range(0, count);
            //}

            //for (int i = 0; i < count; i++)
            //{
            //    if (prefabs[i].activeSelf)
            //    {
            //        index++;
            //    }

            //}
            //if (index == count)
            //{
            //    yield break;

            //}

            //이게 탈출 조건 ?
        }

    }

}
