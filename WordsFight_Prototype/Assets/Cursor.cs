using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public Vector3 defaultPos;
    public KeyCode left, right, up, down;
    public float offsetX, offsetY;
    private float xPos, yPos;

    
    // Start is called before the first frame update
    void Start()
    {
        defaultPos = new Vector3(-2.65f, -2.25f, 0);
        this.transform.position = defaultPos;
        Debug.Log(this.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(left))
        {
            xPos = xPos-offsetX;
            this.transform.position = new Vector3(xPos, this.transform.position.y,0f);
            Debug.Log(this.transform.position);
        }
        if (Input.GetKeyDown(right))
        {
            xPos = xPos+offsetX;
            this.transform.position = new Vector3(xPos, this.transform.position.y,0f);
            Debug.Log(this.transform.position);
        }
        if (Input.GetKeyDown(up))
        {
            yPos += offsetY;
            this.transform.position = new Vector3(this.transform.position.x, yPos,0f);
            Debug.Log(this.transform.position);
        }
        if (Input.GetKeyDown(down))
        {
            yPos -= offsetY;
            this.transform.position = new Vector3(this.transform.position.x, yPos,0f);
            Debug.Log(this.transform.position);
        }
    }
}
