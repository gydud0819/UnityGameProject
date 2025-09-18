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

        // �� ���� ��Ƣ��?
        other.GetComponent<Rigidbody>().AddForce(dir, ForceMode.Impulse);


    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit");

    }
}
