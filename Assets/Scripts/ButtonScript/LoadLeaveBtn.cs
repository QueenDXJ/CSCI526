﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLeaveBtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Button btn = this.GetComponent<Button>();
        //btn.onClick.AddListener(OnClick);
    }

    // Update is called once per frame

    public void loadLeave()
    {
        SceneManager.LoadScene("begin");
    }
}