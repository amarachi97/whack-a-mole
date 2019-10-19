using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
    private GameObject[] objects;
    private float[] objectsPos;     //array of gameobject initial position
    private Random random;
    private float waitTime;
    int objsize;
    bool up = true;
    private Transform[] startPos;
    public Transform endPos;
    public Text countText;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        setCountText();
        objects = GameObject.FindGameObjectsWithTag("head");
        objsize = objects.Length;
        print(objsize);
        objectsPos = new float[objsize];
        for (int i = 0; i < objsize; i++) {
            objectsPos[i] = objects[i].transform.position.y;
        }
        random = new Random();
        waitTime = 3.0f;
        InvokeRepeating("SetTime", 10, 10);
        StartCoroutine(Bop());
    }

    IEnumerator Bop()
    {
        
        
        while (Time.unscaledTime < 60)
        {

            int randomHead = Random.Range(0, objsize);
            //if up, put down 
            //if down, put up
            GameObject curr = objects[randomHead];
            if (up) //if up, put down
            {
                curr.transform.position = new Vector3(curr.transform.position.x, 0, curr.transform.position.z);
                up = false;
            }

            else //if down, put up
            {
                curr.transform.position = new Vector3(curr.transform.position.x, objectsPos[randomHead] , curr.transform.position.z);
                up = true;
            }
            yield return new WaitForSeconds(waitTime);
        }


    }

    void SetTime()
    {
        waitTime -= 0.5f;
        print("waitTime: " + waitTime);
        print("currTime: " + Time.time);
    }

    void OnMouseDown()
    {
        count += 1;
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        setCountText();
        up = false;
    }

    void setCountText() {
        countText.text = "Score: " + count.ToString();
    }
}
