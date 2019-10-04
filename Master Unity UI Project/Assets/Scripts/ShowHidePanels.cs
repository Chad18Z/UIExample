using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHidePanels : MonoBehaviour
{
    public CanvasGroup inventoryPanel;
    public bool inventoryUp = false;

    public CanvasGroup pausePanel;
    public bool pauseUp = false;

    // Start is called before the first frame update
    void Start()
    {
        inventoryPanel.alpha = 0;
        inventoryPanel.interactable = false;
        inventoryPanel.blocksRaycasts = false;

        pausePanel.alpha = 0;
        pausePanel.interactable = false;
        pausePanel.blocksRaycasts = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I) && pauseUp == false)
        {
            if(inventoryUp == false)
            {
                inventoryUp = true;
                inventoryPanel.alpha = 1;
                inventoryPanel.interactable = true;
                inventoryPanel.blocksRaycasts = true;
            }
            else
            {
                inventoryUp = false;
                inventoryPanel.alpha = 0;
                inventoryPanel.interactable = false;
                inventoryPanel.blocksRaycasts = false;
            }
        }

        if (Input.GetButtonDown("Pause"))
        {
            if (pauseUp == false)
            {
                pauseUp = true;
                pausePanel.alpha = 1;
                pausePanel.interactable = true;
                pausePanel.blocksRaycasts = true;
                Time.timeScale = 0;
            }
            else
            {
                pauseUp = false;
                pausePanel.alpha = 0;
                pausePanel.interactable = false;
                pausePanel.blocksRaycasts = false;
                Time.timeScale = 1;
            }
        }
    }
}
