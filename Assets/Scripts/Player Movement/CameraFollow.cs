using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    public float interpVelocity;
    public float minDistance;
    public float followDistance;
    public GameObject target;
    public Vector3 offset;
    Vector3 targetPos;
    private bool cameraSwitch = false;
    private bool cameraSwitch2 = false;
    GameObject player;
    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player");
        targetPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x > 340.5f)
        {
            cameraSwitch = true;
            if (gameObject.transform.position.y > 625.0f)
            {
                cameraSwitch = false;
                cameraSwitch2 = true;

            }

        }
        //If using original camera
        if (!cameraSwitch)
        {
            if (target)
            {
                Vector3 posNoZ = transform.position;
                posNoZ.z = target.transform.position.z;

                Vector3 targetDirection = (target.transform.position - posNoZ);

                interpVelocity = targetDirection.magnitude * 5f;

                targetPos = transform.position + (targetDirection.normalized * interpVelocity * Time.deltaTime);

                transform.position = Vector3.Lerp(transform.position, targetPos + offset, 0.25f);
                if (!cameraSwitch2)
                {
                    transform.position = new Vector3(transform.position.x, 0.0f, transform.position.z);
                }
                else
                {
                    transform.position = new Vector3(transform.position.x, 629.61f, transform.position.z);

                }
            }
        }
        else
        {
            if (target)
            {
                gameObject.transform.position = new Vector3(340.6f, target.transform.position.y, -10);
            }
        }
    }
}