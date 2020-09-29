using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraCollider : MonoBehaviour
{
    public Button fakeCreat;
    public GameObject Creat;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CUBE"))
        {
            Debug.Log("트리커체크");
            fakeCreat.gameObject.SetActive(true);
            Creat.gameObject.SetActive(false);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("CUBE"))
        {
            Debug.Log("트리커액시트");
            fakeCreat.gameObject.SetActive(false);
            Creat.gameObject.SetActive(true);
        }
    }
}
