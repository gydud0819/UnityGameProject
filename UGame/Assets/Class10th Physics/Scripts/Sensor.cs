using UnityEngine;

public class Sensor : MonoBehaviour
{
    Vector3 dir;
   
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stay");

        // 왜 높게 안튀냐?
        other.GetComponent<Rigidbody>().AddForce(dir, ForceMode.Impulse);


    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit");

    }
}
