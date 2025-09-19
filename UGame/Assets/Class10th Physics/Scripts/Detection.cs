using UnityEngine;
using UnityEngine.Events;

public class Detection : MonoBehaviour
{
    [SerializeField] UnityEvent callback;
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {

        Debug.Log("Detection Enter");
        
    }

    private void OnCollisionStay(UnityEngine.Collision collision)
    {
        if (callback != null)
        {
            callback.Invoke();
        }
    }

    private void OnCollisionExit(UnityEngine.Collision collision)
    {
        Debug.Log("Detection Exit");

    }
}
