using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ParallaxEffect : MonoBehaviour
{
    [SerializeField]
    private float parallaxSpeed;
    
    private Transform cameraTransform;
    private float startPositionX;
    private float spriteSizeX;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        startPositionX = transform.position.x;
        //gives length of sprite//
        spriteSizeX = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void Update()
    {
    float relativeDist = cameraTransform.position.x * parallaxSpeed;
        transform.position = new Vector3(startPositionX + relativeDist, transform.position.y, transform.position.z);

        //Loop parallax effect - make sure the parent object in scene is centered at zero with the children on either size to ensure good looping//
        float relativeCameraDist = cameraTransform.position.x * (1 - parallaxSpeed);
        if (relativeCameraDist > startPositionX + spriteSizeX)
        {
            startPositionX += spriteSizeX;
        }
        else if (relativeCameraDist < startPositionX - spriteSizeX) 
        {
            startPositionX -= spriteSizeX;   
        }
    }
}
