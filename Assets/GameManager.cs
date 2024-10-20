using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }
    public void ButtonIsClicked()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Button has been clicked");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
