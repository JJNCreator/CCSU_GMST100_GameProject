using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    [SerializeField] private GameObject soundeffect;

    private bool playerInRange;
    private PlayerControls playerControls;
    private void Awake()
    {
        playerInRange = false;
        soundeffect.SetActive(false);
        playerControls = new PlayerControls();

    }
    private void OnEnable()
    {
        playerControls.Enable();

    }

    // Update is called once per frame
    private void Update()
    {
        if (playerInRange)
        {
            if (!soundeffect.activeSelf)
            {
                soundeffect.SetActive(true);
            }
            else if (soundeffect.activeSelf)
            {
                //
            }
        }
        else if (!playerInRange)
        {
            soundeffect.SetActive(false);
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
