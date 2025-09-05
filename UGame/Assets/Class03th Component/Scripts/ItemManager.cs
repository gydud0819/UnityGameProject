using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] Item[] gameObjects;
    [SerializeField] int count;

   
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        //foreach (var item in gameObjects)
        //{
        //    //Debug.Log($"name : {item.name}");
        //    item.gameObject.SetActive(false);

        //}

        for (int i = 0; i < gameObjects.Length; i++)
        {
            //Debug.Log(gameObjects[i].name);
            gameObjects[i].transform.gameObject.SetActive(false);
        }
        count = gameObjects.Length - 1;
    }

    private void Update()
    {

        // 누를 때 마다?

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Swap();
        }

        if(Input.GetMouseButtonDown(0))
        {
            gameObjects[count].Activate();
        }

    }

    public void Swap()
    {
        gameObjects[count].transform.gameObject.SetActive(false);
        count = (count + 1) % gameObjects.Length;

        gameObjects[count].transform.gameObject.SetActive(true);
    }

}