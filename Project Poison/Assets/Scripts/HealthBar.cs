using UnityEngine;
using System.Collections;

public class PowerBar : MonoBehaviour {
    public GameObject bar;
    RectTransform rect;
	// Use this for initialization
	void Start () {
        rect = bar.GetComponent<RectTransform>();
        int num = 200;//getMaxSize from health/power script
        rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num);
        GameObject.Find("MaxHealth").GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num + 2);
    }

    //
    public void setBar(int num) {
        if (num < 0) num = 0;//uneeded later
        rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num);
    }
	// Update is called once per frame
	void Update () {
	    
	}
}
