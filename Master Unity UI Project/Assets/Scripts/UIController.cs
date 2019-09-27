using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    Image[] images;
    int count;
    Image healthBar;
    Vector3 lScale; // local scale of healthbar
    float currentAlpha = 1;

    // Start is called before the first frame update
    void Start()
    {
        images = GetComponentsInChildren<Image>();
        count = images.Length;

        healthBar = images[count - 1];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            if (healthBar.fillAmount < 1f)
            healthBar.fillAmount += .1f;
        }

        else if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            if (healthBar.fillAmount > 0f)
                healthBar.fillAmount -= .1f;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            currentAlpha -= .5f;
            if (currentAlpha < 0) currentAlpha = 1f;

            for (int i = 0; i < count; i ++)
            {
                Color color = images[i].color;
                color.a = currentAlpha;
                images[i].color = color;
            }
        }
    }
}
