using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSystemManager : MonoBehaviour
{
    [SerializeField] private GameObject Sun1_On;
    [SerializeField] private GameObject Sun2_On;
    [SerializeField] private GameObject Sun3_Off;
    [SerializeField] private GameObject Sun4_Off;
    [SerializeField] private GameObject Sun5_Off;


    private bool playerInRange;
    private void Awake()
    {
        playerInRange = false;
        Sun1_On.SetActive(false);
        Sun2_On.SetActive(false);
        Sun3_Off.SetActive(false);
        Sun4_Off.SetActive(false);
        Sun5_Off.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange)
        {
            Sun1_On.SetActive(true);
            Sun2_On.SetActive(true);
            Sun3_Off.SetActive(false);
            Sun4_Off.SetActive(false);
            Sun5_Off.SetActive(false);
        }
        else
        {
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }
}
