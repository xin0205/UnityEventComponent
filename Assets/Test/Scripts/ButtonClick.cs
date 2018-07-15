using GameFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework;

public class ButtonClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Click() {
        UGF.EventComponent.Fire(this, new ClickEventArgs() { ClickArgs = "click me" });

    }

}
