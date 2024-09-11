using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private KeyCode keyCode;
    [SerializeField] private HingeJoint hingeJoint;
    [SerializeField] private float springValue;
    [SerializeField] private float targetPosEnter;
    [SerializeField] private float TargetPosExit;
    //[SerializeField] private JointSpring jointSpring;

    private void Start()
    {
        hingeJoint = this.GetComponent<HingeJoint>();
        //jointSpring = hingeJoint.spring;
      
    }
    private void Update()
    {
        JointSpring jointSpring = hingeJoint.spring;
        if (hingeJoint != null) {

            if (Input.GetKey(keyCode))
            {
                SoundManager.instance.playPaddleAudio();
                //Debug.Log(jointSpring);
                jointSpring.targetPosition = targetPosEnter;
            }
            else
            {
                //SoundManager.instance.playPaddleAudio();
                jointSpring.targetPosition = TargetPosExit;
            }
            hingeJoint.spring = jointSpring;
        }
    }
}
