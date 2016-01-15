using UnityEngine;
using System.Collections;

public class BarScript : MonoBehaviour {
    RectTransform rect;
	// Use this for initialization
	void Start () {
        rect = gameObject.GetComponent<RectTransform>();
        int num = 100;//getMaxSize from health/power script
        rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num);
        //setBackBar to +2 of max
        GameObject.Find("Max"+gameObject.name).GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num + 2);
    }

    /// <summary>
    /// Sets bar to length of num
    /// </summary>
    /// <param name="num">value to set bar width to</param>
    public void setBar(int num) {
        if (num < 0) num = 0;//uneeded later
        rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num);
    }

	// Update is called once per frame
	void Update () {
	    
	}
}
