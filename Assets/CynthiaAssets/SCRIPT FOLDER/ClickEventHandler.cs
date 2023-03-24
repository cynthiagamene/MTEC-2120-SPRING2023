using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEventHandler : MonoBehaviour
{
    public Action<GameObject> OnClick { get; private set; }

    // Start is called before the first frame update
    private void Start()
    {
        ClickEventHandler clickEventHandler = FindObjectOfType<ClickEventHandler>();
        if (clickEventHandler != null)
        {
            clickEventHandler.OnClick += HandleClickEvent;
        }
    }

    private void HandleClickEvent(GameObject g)
    {
        // Handle the click event here
    }

}