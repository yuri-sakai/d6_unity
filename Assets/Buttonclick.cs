using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttonclick : MonoBehaviour

{
    public GameObject TargetObject;
    Transform TargetTransform;
    public Button up;
    // 計算ボタン
    public Button down;
    // クリアボタン
    public Button right;

    public Button left;
    // Start is called before the first frame update
    void Start()
    {
        TargetObject = GameObject.Find("UnitySP");
        TargetTransform = TargetObject.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {



    }
    public void Inputup()
    {
        Debug.Log("UP");
        TargetTransform.Rotate(10.0f, 0, 0, Space.World);

    }

    public void Inputdown()
    {
        TargetTransform.Rotate(-10.0f, 0, 0, Space.World);
        Debug.Log("down");

    }

    public void Inputright()
    {
        Debug.Log("right");
        TargetTransform.Rotate(0, -10.0f, 0, Space.World);

    }
    public void Inputleft()
    {
        Debug.Log("left");
        TargetTransform.Rotate(0, 10.0f, 0, Space.World);
    }


}

