using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotCnt : MonoBehaviour
{
    Animator animator;
    public static bool jumping;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            this.transform.position += this.transform.forward*3f;
            animator.SetBool("walk",true); 
        }else if(Input.GetKey(KeyCode.RightArrow)){
            animator.SetBool("walk",true);
            this.transform.Rotate(0,2f,0);
        }else if(Input.GetKey(KeyCode.LeftArrow)){
            animator.SetBool("walk",true);
            this.transform.Rotate(0,-2f,0);
        }else{
            animator.SetBool("walk",false);
        }
        if(animator.GetBool("walk")){
            if(Input.GetKey(KeyCode.J)){
                animator.SetBool("walkjump",true);
            }else{
                animator.SetBool("walkjump",false);
            }
        }else{
             if(Input.GetKey(KeyCode.J)){
                animator.SetBool("jump",true);
            }else{
                animator.SetBool("jump",false);
            }
        }
    }
}
