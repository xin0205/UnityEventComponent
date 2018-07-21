using GameFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework;

public class ShowClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
       UGFEvent.Component.Subscribe(ClickEventArgs.EventId, OnClickCallback);
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnClickCallback(object sender, BaseEventArgs baseEventArgs)
    {
        ClickEventArgs clickEventArgs = baseEventArgs as ClickEventArgs;

        Debug.Log("Click Event:" + clickEventArgs.ClickArgs);

    }
}
