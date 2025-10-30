using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    [SerializeField] private GameObject footstep;
    private PlayerControls playerControls;
    // Start is called before the first frame update

    private void Awake()
    {
        playerControls = new PlayerControls();
        footstep.SetActive(false);
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }
    // Update is called once per frame
    private void Update()
    {
        float movementInput = playerControls.Travel.Move.ReadValue<float>();
        if (movementInput != 0)
        {
            footsteps();
            Debug.Log("Move is triggered");
        }
        else 
        {
            stopfootsteps();
        }
    }

    private void footsteps()
    {
        footstep.SetActive(true);
    }
    private void stopfootsteps()
    {
        footstep.SetActive(false);
    }


    private void OnDisable()
    {
        playerControls.Disable();

    }
}
