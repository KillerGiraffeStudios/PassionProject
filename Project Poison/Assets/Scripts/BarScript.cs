using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarScript : MonoBehaviour {
    RectTransform rect;
    Text barText;
    public int maxSize;
    public int curSize;//DELETE
	// Use this for initialization
	void Start () {
        rect = gameObject.GetComponent<RectTransform>();
        //maxSize = 100;//getMaxSize from health/power script
        rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, maxSize);
        //setBackBar to +2 of max
        curSize = maxSize;
        barText = GameObject.Find(gameObject.name + "Text").GetComponent<Text>();
        barText.text = maxSize + "/" + maxSize;
        GameObject.Find(gameObject.name+"Max").GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, maxSize + 2);
    }

    /// <summary>
    /// Sets bar to length of num
    /// </summary>
    /// <param name="num">value to set bar width to</param>
    public void setBar(int num) {
        if (num < 0) num = 0;//uneeded later
        rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num);
        barText.text = num + "/" + maxSize;
    }

    /// <summary>
    /// ****DELETE****
    /// </summary>
    /// <param name="num"></param>
    public void takeDam(int num) {
        curSize -= num;
        setBar(curSize);
    }

	// Update is called once per frame
	void Update () {
	    
	}
}
