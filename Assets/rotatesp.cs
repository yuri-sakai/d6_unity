using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class rotatesp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        // // Transformも自身のコンポーネントの一つなので、GetComponentで取得できる
        // // 自身のTransformを取得して、myTransform1と定義した変数へ入れる例
        Transform myTransform = this.gameObject.GetComponent<Transform>();

        if (Input.GetKey(KeyCode.RightArrow))
        {
            myTransform.Rotate(0, -1.0f, 0, Space.World);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myTransform.Rotate(0, 1.0f, 0, Space.World);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            myTransform.Rotate(-1.0f, 0, 0, Space.World);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            myTransform.Rotate(1.0f, 0, 0, Space.World);
        }




    }
}
