using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectMainMenu : MonoBehaviour
{
    public string menu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Menu()
    {
        SceneManager.LoadScene(menu);
    }


}
