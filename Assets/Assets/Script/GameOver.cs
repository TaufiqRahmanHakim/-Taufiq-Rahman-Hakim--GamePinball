using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject point;
    private void OnCollisionEnter(Collision collision)
    {
        PointManager.Instance.UpdatePoint();
        GameManager.instance.GameOver();
        point.gameObject.SetActive(false);
    }
}
