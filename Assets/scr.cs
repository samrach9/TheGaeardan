using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scr : MonoBehaviour
{
    // Start is called before the first frame update
    float step = -22;//find a proper value for this
    void Start()
    {
        Button b = gameObject.GetComponent<Button>();
        b.onClick.AddListener(
            ()=>
            {
                Camera.main.gameObject.transform.Translate(0, step, 0);
            }
        );
    }
    
}
