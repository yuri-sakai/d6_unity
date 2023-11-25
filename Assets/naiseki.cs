using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class naiseki : MonoBehaviour
{
    public Text naiseki_obj = null; // Textオブジェクト
    public GameObject SP;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        OrientationMatcing orientationMatcing = SP.GetComponent<OrientationMatcing>();

        Text naiseki_text = naiseki_obj.GetComponent<Text>();
        naiseki_obj.text = "内積:" + orientationMatcing.kakudo;

    }
}
