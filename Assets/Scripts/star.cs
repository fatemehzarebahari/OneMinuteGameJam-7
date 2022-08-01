using UnityEngine;

public class star : MonoBehaviour
{
    [SerializeField]
    LineRenderer linePrefab;

    [SerializeField]
    DrawLine lineConntainer;

    LineRenderer line;


    public static bool lineIsBeingDrawn = false;


    public void OnMouseUpAsButton()
    {
        if (!lineIsBeingDrawn && line == null)
        {
            line = Instantiate(linePrefab);
            lineConntainer.AddLine(line);
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Camera.main.nearClipPlane;
            line.SetPosition(0, Camera.main.ScreenToWorldPoint(mousePos));
            line.SetPosition(1, Camera.main.ScreenToWorldPoint(mousePos));
            lineIsBeingDrawn = true;
        }
        else if(lineIsBeingDrawn && line == null)
        {
            lineIsBeingDrawn = false;
            LineRenderer currentLine = lineConntainer.GetLine();
            currentLine.GetComponent<lineDetected>().setDetected(true);
            currentLine.GetComponent<lineCollider>().SetCollider();
            StartCoroutine(lineConntainer.DestroyLine());

        }
        
    }


    
    private void Update()
    {
        if (line != null && lineIsBeingDrawn) {
            bool val = line.GetComponent<lineDetected>().getDetected();

            if (!val)
            { 
                Vector3 mousePos = Input.mousePosition;
                mousePos.z = Camera.main.nearClipPlane;
                line?.SetPosition(1, Camera.main.ScreenToWorldPoint(mousePos));
            }
        }
       
    }

}
