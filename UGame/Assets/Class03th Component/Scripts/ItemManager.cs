using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] GameObject[] gameObjects;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        // ¿©±â¿¡?
    }
    void Start()
    {
        foreach (var item in gameObjects)
        {
            Debug.Log($"name : {item.name}");
            item.gameObject.SetActive(false);

        }

        //for (int i = 0; i < gameObjects.Length; i++)
        //{
        //    Debug.Log(gameObjects[i].name);
        //}
    }

    private void Update()
    {

        for (int i = 0; i < gameObjects.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameObject.SetActive(true);
            }

        }



    }

}