using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour
{

    public GameObject uiObject;
    void Start()
    {
        uiObject.SetActive(false);
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);

        }
    }

    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(false);
        }
    }

}