using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCnt : MonoBehaviour
{
    public GameObject robot;
    public float rotateSpeed;
    private bool pressL;
    private bool pressR;
    private float angle;
    // Start is called before the first frame update
    void Start()
    {
        rotateSpeed = 5f;
        pressL = false;
        pressR = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKey(KeyCode.K)){
            float angle = Input.GetAxis("Horizontal")*rotateSpeed;
            Vector3 robotpos = robot.transform.position;
            transform.RotateAround(robotpos,Vector3.up, angle);
        }*/

        if(Input.GetMouseButtonDown(0)){
            pressL = true;
        }else if(Input.GetMouseButtonDown(1)){
            pressR = true;
        }else if(Input.GetMouseButtonUp(0)){
            pressL = false;
        }else if(Input.GetMouseButtonUp(1)){
            pressR = false;
        }

        if(pressL){
            angle = rotateSpeed;
        }else if(pressR){
            angle = -rotateSpeed;
        }else{
        Å@angle = 0;
        }

        Vector3 robotpos = robot.transform.position;
        transform.RotateAround(robotpos,Vector3.up, angle);
    }
}
