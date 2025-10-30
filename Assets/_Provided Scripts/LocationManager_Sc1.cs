using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class LocationManager_Sc1 : MonoBehaviour
{
    [Header("X Location ID")]
    [SerializeField] private int mapNum;



    private PlayerControls playerControls;
    private bool playerInRange;



    private void Awake()
    {
        playerInRange = false;
        playerControls = new PlayerControls();

    }


    private void OnEnable()
    {
        playerControls.Enable();

    }

    public void Update()
    {
        if (playerInRange)
        {
            MapLocVariable.mapLocNum = mapNum;
            //Debug.Log("New Number Set "+mapNum);
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