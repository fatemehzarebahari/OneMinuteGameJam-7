using System.Collections.Generic;
using UnityEngine;

public class lineCollider : MonoBehaviour
{
    LineRenderer myLine;

    [SerializeField]
    GameObject boxCollidPrefab;

    GameObject boxCollid;

    void Awake()
    {
        myLine = this.GetComponent<LineRenderer>();
    }


    public void SetCollider()
    {

        boxCollid = Instantiate(boxCollidPrefab);
        boxCollid.transform.parent = transform;
        Vector2 startPos = myLine.GetPosition(0);
        Vector2 endPos = myLine.GetPosition(1);

        if (startPos.x > endPos.x)
        {
            Vector2 temp = startPos;
            startPos = endPos;
            endPos = temp;
        }

        float length = (endPos - startPos).magnitude;
        float deltaX = Mathf.Abs(endPos.x - startPos.x);
        float rotDeg = Mathf.Acos(deltaX / length);

        boxCollid.transform.position = (endPos + startPos) / 2;
        if(startPos.y<endPos.y )
            boxCollid.transform.Rotate(0, 0, -(90-((rotDeg) * Mathf.Rad2Deg)));
        else
            boxCollid.transform.Rotate(0, 0, 90-((rotDeg)*Mathf.Rad2Deg));
        boxCollid.gameObject.transform.localScale = new Vector3(0.1f,length,0);

    }
}
