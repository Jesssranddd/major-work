using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialoguestarter : MonoBehaviour
{
    public GameObject textMeshPro;


    void start()
    {
        textMeshPro.SetActive(false);

    }
    void OnTriggerEnter(Collider Car)
    {
        if (Car.gameObject.tag == "Car")
        {
            textMeshPro.SetActive(true);
            StartCoroutine("WaitforSec");
        }
    }
    IEnumerator WaitforSec()
    {
        yield return new WaitForSeconds(2);

        Destroy(textMeshPro);
    }
}