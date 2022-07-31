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
        boxCollid = Instantiate(boxCollidPrefab);
        myLine = this.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        SetCollider();
    }

    void SetCollider()
    {
        
        Vector2 startPos = myLine.GetPosition(0);
        Vector2 endPos = myLine.GetPosition(1);

        boxCollid.transform.position = (endPos + startPos) / 2;
        float length = (endPos - startPos).magnitude;
        float deltaX = Mathf.Abs(endPos.x - startPos.x);

        float rotDeg = Mathf.Acos(deltaX / length);
        boxCollid.transform.Rotate(0, 0, rotDeg);
        boxCollid.gameObject.transform.localScale = new Vector3(0.1f,length,0);

    }
}
