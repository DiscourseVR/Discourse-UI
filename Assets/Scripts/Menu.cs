using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Menu : MonoBehaviour
{
    // Define the Objects
    public GameObject start,view;

    public GameObject debate,menu;
    private Button btnStart, btnView;
    // Start is called before the first frame update
    void Start()
    {
      btnStart = start.GetComponent<Button>();
      btnView = view.GetComponent<Button>();
      btnStart.onClick.AddListener(onStart);
      btnView.onClick.AddListener(onView);
    }

    void onStart()
    {
      Debug.Log("Clicked start");
      debate.SetActive(true);
      menu.SetActive(false);
    }
    void onView()
    {
      Debug.Log("Clicked view");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
