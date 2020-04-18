using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class warningfade : MonoBehaviour
{
    public Image warning, parent;
    private float alpha = 1;

    void Update()
    {
        if (warning.color.a <= 0)
        {
            Destroy(this.gameObject);
        }

        else
        {
            Color newColor = new Color(1, 1, 1, alpha);
            warning.color = newColor;
            parent.color = newColor;
        }

        alpha -= 0.004f;
    }
}
