using System;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    [SerializeField] private List<GameObject> _panels;
    [SerializeField] private TMP_Text _resolutionText;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            foreach (GameObject panel in _panels)
            {
                panel.SetActive(false);
            }
        }
    }

    public void GraphicsApply()
    {

        string[] size;
        size =_resolutionText.ToString().Split('x');
        Screen.SetResolution(Convert.ToInt32(size[0]), Convert.ToInt32(size[1]), FullScreenMode.ExclusiveFullScreen, 60);
    }
}
