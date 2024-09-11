using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelontar : MonoBehaviour
{
    [SerializeField] private float multiplier;
    public float force;

    [SerializeField] private Animator animator;
    [SerializeField] private Material materialDefault;
    [SerializeField] private Material materialHited;

    [SerializeField] private MeshRenderer meshRenderer;

    public Collider bola;

    [SerializeField] private bool plontarFlag;

    private void Start()
    {
        animator = this.GetComponent<Animator>();
        //GetComponent<MeshRenderer>().material = materialDefault;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space)){
            StartTahan();
        }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            StartPelontar();
        }
    }
    private void StartTahan()
    {
        //CameraController.instance.StartMovePosition();
        animator.SetBool("Tembak", false);
        animator.SetBool("Tahan", true);
    }

    private void StartPelontar()
    {
        //CameraController.instance.GoBackToDefault();
        // ambil rigidbody nya lalu kali kecepatannya sebanyak multiplier agar bisa memantul lebih cepat
        plontarFlag = true;
        animator.SetBool("Tembak", true);
        animator.SetBool("Tahan", false);
        Invoke("setBoolDelay", 0.4f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (plontarFlag && collision.collider == bola)
        {
            Debug.Log("testss");
            /*Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;*/

            collision.collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
            setBoolDelay();
        }
    }
    private void setBoolDelay()
    {
        plontarFlag = false;
        /*animator.SetBool("Play", false);
        GetComponent<MeshRenderer>().material = materialDefault;*/
    }
}
