using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] Button[] buttonList;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void Execute()
    {
        
        Debug.Log("Execute");
    }
    
    public void Option()
    {
        Debug.Log("Option");

    }

    public void Quit()
    {
        Debug.Log("Quit");
        
    }
}
