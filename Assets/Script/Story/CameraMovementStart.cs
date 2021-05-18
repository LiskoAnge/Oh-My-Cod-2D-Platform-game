using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementStart : MonoBehaviour
{
    private Transform playerTransform;


    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("tPlayer").transform;




    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 followX = transform.position;
        followX.x = playerTransform.position.x + 1.5f;     //Follow horizontal player's movement
        transform.position = followX;


        Vector3 followY = transform.position;
        followY.y = playerTransform.position.y + 1.7f;     //Follow vertical player's movement (e.g. jumps)
        transform.position = followY;



    }
}
