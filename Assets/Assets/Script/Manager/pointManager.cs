using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    public static PointManager Instance {  get; private set; }
    private void Awake()
    {
        Instance = this;
    }

    [SerializeField] private TextMeshProUGUI pointText;
    [SerializeField] private TextMeshProUGUI pointTextEnd;
    [SerializeField] private int totalPoint;
    private void FixedUpdate()
    {
        pointText.text = "Total Point : "+totalPoint.ToString();
    }

    public void addPointByBumper()
    {
        totalPoint += 5;
    }
    public void UpdatePoint()
    {
        pointTextEnd.text = "Total Point : " + totalPoint.ToString();
    }
}
