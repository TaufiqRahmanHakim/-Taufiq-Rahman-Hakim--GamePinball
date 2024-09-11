using UnityEngine;
using UnityEngine.Events;

public class TriggerHandler : MonoBehaviour
{
    [Tooltip("One time use")]
    [SerializeField] bool oneTimeUse;

    [Tooltip("Search only Tags")]
    [SerializeField] string tagFilter;

    [SerializeField] UnityEvent onTriggerEnter;
    /*[SerializeField] UnityEvent onTriggerStay;*/
    [SerializeField] UnityEvent onTriggerExit;

    private void OnTriggerEnter(Collider other)
    {
        if (!string.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;
        onTriggerEnter.Invoke();
        if (oneTimeUse)
        {
            Destroy(this);
        }
    }

   /* private void OnTriggerStay(Collider other)
    {
        if (!string.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;
        onTriggerStay.Invoke();
        if (oneTimeUse)
        {
            Destroy(this);
        }
    }*/

    private void OnTriggerExit(Collider other)
    {
        if (!string.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;
        onTriggerExit.Invoke();
        if (oneTimeUse)
        {
            Destroy(this);
        }
    }
}
