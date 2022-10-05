using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerTitle : MonoBehaviour
{
    public GameObject MainMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            MainMenu.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
