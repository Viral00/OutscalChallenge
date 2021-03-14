using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonStart : MonoBehaviour
{
    
    public void OnButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Click");
    }
    public void OnButtonClick1()
    {
        SceneManager.LoadScene(2);
        
    }
    public void OnButtonClick2()
    {
        SceneManager.LoadScene(3);
        
    }
    public void OnButtonClick3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        
    }
}
