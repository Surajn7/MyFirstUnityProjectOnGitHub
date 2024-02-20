using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UI_Script : MonoBehaviour
{
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button back;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadScene1()
    {
        //btn1 = GetComponent<Button>();
        SceneManager.LoadScene(1);
        Debug.Log("Button1 is clicked");
    }

    public void loadScene2()
    {
       // btn1 = GetComponent<Button>();
        SceneManager.LoadScene(2);
        Debug.Log("Button2 is clicked");
    }

    public void loadScene3()
    {
        //btn1 = GetComponent<Button>();
        SceneManager.LoadScene(3);
        Debug.Log("Button3 is clicked");
    }

    public void loadMain()
    {
        //back = GetComponent<Button>();
        SceneManager.LoadScene(0);
        Debug.Log("You clicked on Back Button");
    }

    public void Back()
    {
        //back = GetComponent<Button>();
        Debug.Log("You click on back button ");
        SceneManager.LoadScene(0);
    }
}
