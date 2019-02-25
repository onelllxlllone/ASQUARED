using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {
    //make a public float for speed
    public float scrollSpeed = 0.1f;
    //make a private MeshRenderer for scroll of background
    private MeshRenderer mr;
    //Make a private float here for Sroll
    private float xScroll;

    //change Start() to Awake()
    void Awake () {
        //make the name of MeshRenderer equal to GetCompenet<MeshRenderer>()
        mr = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        //add Scroll() to this
        Scrollq();
	}
    void Scrollq()
    {
        //make speed of scroll equal to Time.time * speed of scroll
        xScroll = Time.time * scrollSpeed;
        //make a Vector2 and call it offset, make it equal to new Vector2(speed of scroll, 0f)
        Vector2 offset = new Vector2(xScroll, 0f);
        //here put name of meshrenderer.sharedMaterial.SetTextureOffset("_MainTex",offset)
        mr.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
     