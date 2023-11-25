using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrientationMatcing : MonoBehaviour
{
    public GameObject TargetObject;
    public Text textUI;
    public float kakudo;
    private Vector3 localNormal = new Vector3(0, 0, 1);

    private double lastvibratetime = 0f;
    Gyroscope m_Gyro;
    // Start is called before the first frame update
    void Start()
    {
        m_Gyro = Input.gyro;
        m_Gyro.enabled = true;


    }

    // Update is called once per frame
    void Update()
    {
        Transform transform = this.gameObject.GetComponent<Transform>();
        // 加速度センサの値を取得
        Vector3 spval = Input.acceleration;

        //x,y,zそれぞれの値を出力する
        // Debug.Log("スマホx:" + spval.x + "y:" + spval.y + "z:" + spval.z);
        // Debug.Log("Unity側x:" + inputval.x + "y:" + inputval.y + "z:" + inputval.z);
        Quaternion q = m_Gyro.attitude;
        var newQ = new Quaternion(-q.x, -q.z, -q.y, q.w);
        newQ = newQ * Quaternion.Euler(-90f, 0f, 0f);
        // var newQ = new Quaternion(-q.x, -q.z, -q.y, q.w);
        transform.eulerAngles = new Vector3(
        newQ.eulerAngles.x,
        newQ.eulerAngles.y,
        newQ.eulerAngles.z);
        // Debug.Log("オイラー:" + newQ.eulerAngles.x + "y:" + deviceRotation.eulerAngles.y + "z:" + deviceRotation.eulerAngles.z);
        var targetTransform = TargetObject.GetComponent<Transform>();

        Vector3 worldNormal1 = transform.TransformDirection(localNormal);
        Vector3 worldNormal2 = targetTransform.TransformDirection(localNormal);
        float cosineSimilarity = Vector3.Dot(worldNormal1.normalized, worldNormal2.normalized);

        Debug.Log(cosineSimilarity);




        kakudo = cosineSimilarity;
        Debug.Log("内積" + kakudo);

        if (0.95f < kakudo)
        {
            Debug.Log("1111");

        }
        else if (0.9f < kakudo)
        {
            if (Time.realtimeSinceStartupAsDouble - lastvibratetime > 0.3f)
            {
                VibrationMng.ShortVibration();
                lastvibratetime = Time.realtimeSinceStartupAsDouble;
            }

            Debug.Log("2222");
        }
        else if (0.8f < kakudo)
        {
            if (Time.realtimeSinceStartupAsDouble - lastvibratetime > 0.2f)
            {
                VibrationMng.ShortVibration();
                lastvibratetime = Time.realtimeSinceStartupAsDouble;
            }
            Debug.Log("3333");

        }
        else if (0.7f < kakudo)
        {
            if (Time.realtimeSinceStartupAsDouble - lastvibratetime > 0.1f)
            {
                VibrationMng.ShortVibration();
                lastvibratetime = Time.realtimeSinceStartupAsDouble;
            }
            Debug.Log("4444");

        }
        else if (kakudo <= 0.7f)
        {
            if (Time.realtimeSinceStartupAsDouble - lastvibratetime > 0.05f)
            {
                VibrationMng.ShortVibration();
                lastvibratetime = Time.realtimeSinceStartupAsDouble;
            }
            Debug.Log("5555");

        }


    }
}
