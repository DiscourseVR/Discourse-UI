using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gameLogic : MonoBehaviour
{
    // Define the Objects
    public GameObject start_timer, button, message;

    private TextMeshPro Timer, Message;

    private int time = 0;


    // Start is called before the first frame update
    void Start()
    {
      Timer = start_timer.GetComponent<TextMeshPro>();
      Message = message.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        getStatus();
        getTimer();
    }

    void getTimer()
    {
      time+=1;
      Timer.SetText("{0}:{1}",time%60,time);
    }
    void getStatus()
    {
      Message.SetText("message set");
    }

    void OnTriggerEnter(Collider collision)
    {
      Debug.Log(collision.gameObject.name);
      if (collision.gameObject.name == "hand") {
        Debug.Log("hand touched");
      }
    }
}
