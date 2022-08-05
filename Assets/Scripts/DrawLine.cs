using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DrawLine : MonoBehaviour
{

    public static List<LineRenderer> lines;

    private void Awake()
    {
        lines = new List<LineRenderer>();
    }

    
    public void AddLine(LineRenderer line)
    {
        lines.Add(line);
    }

    public LineRenderer GetLine()
    {
        return lines[lines.Count - 1];
    }
    public int CountLine()
    {
        return lines.Count;
    }
    /*public IEnumerator  DestroyLine(float time)
    {
        if (lines.Count > 0)
        {
            yield return new WaitForSeconds(time);
            Destroy(lines[0].gameObject);
            lines.RemoveAt(0);
        }
    }*/

}
