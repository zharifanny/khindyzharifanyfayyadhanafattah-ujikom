using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField]public float countdownTime = 60f;
    public TextMeshProUGUI countdownText; 

    private float currentTime;
    public CameraChange cameraChange;

    void Start()
    {
        currentTime = countdownTime;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        countdownText.text = "Timer : " + currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            Debug.Log("timer end");
            cameraChange.ChangeCamera();
        }
    }
}