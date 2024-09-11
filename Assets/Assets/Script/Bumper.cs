using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    [SerializeField] private float multiplier;
    public Collider bola;

    [SerializeField] private Animator animator;
    [SerializeField] private Material materialDefault;
    [SerializeField] private Material materialHited;

    [SerializeField] private MeshRenderer meshRenderer;

    private void Start()
    {
        animator = this.GetComponent<Animator>();
        GetComponent<MeshRenderer>().material = materialDefault;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            GetComponent<MeshRenderer>().material = materialHited;
            animator.SetBool("Play", true);

            SoundManager.instance.PlaySFX(collision.transform.position);
            VFXManager.instance.PlayVFX(collision.transform.position);

            Debug.Log("test");
            // ambil rigidbody nya lalu kali kecepatannya sebanyak multiplier agar bisa memantul lebih cepat
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;
            Invoke("setBoolDelay", 0.4f);
        }
    }

    private void setBoolDelay()
    {
        animator.SetBool("Play", false);
        GetComponent<MeshRenderer>().material = materialDefault;
    }
}
