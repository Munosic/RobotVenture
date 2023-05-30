using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    public GameObject robot;
    private GameObject mainCam;
    private GameObject subCam;
    float detecdist;
    bool spotflag;
    void Start()
    {
        animator = robot.GetComponent<Animator>();
        detecdist = 50f;
        mainCam = GameObject.Find("Cam");
        subCam = GameObject.Find("JumpCam");
        subCam.SetActive(false);
        spotflag = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 robotpos = robot.transform.position;
        Vector3 spotpos = this.transform.position;
        float distance = Vector3.Distance(robotpos,spotpos);
       
        if(detecdist > distance){
            if(Input.GetKey(KeyCode.J)){
                GetComponent<AudioSource>().Play();  // Œø‰Ê‰¹‚ð–Â‚ç‚·;
                subCam.SetActive(true);
                mainCam.SetActive(false);
                spotflag = true;
            }
        }
        
        if(animator.GetBool("walk") || animator.GetBool("stand")){
            spotflag = false;
            mainCam.SetActive(true);
            subCam.SetActive(false);
        }else if(animator.GetBool("jump")){
            subCam.SetActive(true);
        }
    }
}