using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchManager : MonoBehaviour
{
    [SerializeField] private bool oneTimeUse;

    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private Material material;

    private void OnTriggerEnter(Collider other)
    {
        meshRenderer.material = material;
        if (oneTimeUse)
        {
            Destroy(this);
        }
    }


    
}
