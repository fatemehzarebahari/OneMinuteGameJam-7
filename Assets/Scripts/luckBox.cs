
using System.Collections.Generic;
using UnityEngine;

public class luckBox : MonoBehaviour
{
    [SerializeField]
    DrawLine lineContainer;

    [SerializeField]
    LineRenderer linePrefab;

    [SerializeField]
    Transform starParent;
    List<Transform> children;

    [SerializeField]
    AudioSource openBox;
    private void Awake()
    {
        children = new List<Transform>();
        gatherChildren();
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        openBox.Play(); 
        Destroy(gameObject);
        createRandomLines();
    }
    void createRandomLines()
    {
        System.Random rnd = new System.Random();

        for (int j = 0; j < 4; j++)
        {
            int a = rnd.Next(0, children.Count-1);
            int b = rnd.Next(0, children.Count - 1);
            LineRenderer newLine = Instantiate(linePrefab);
            newLine.SetPosition(0, children[a].GetComponent<Transform>().position);
            newLine.SetPosition(1, children[b].GetComponent<Transform>().position);
            newLine.GetComponent<lineCollider>().SetCollider();
            lineContainer.AddLine(newLine);
            if (lineContainer.CountLine() > 0)
            {
                float time = newLine.GetComponent<destroyTime>().getTime();
                StartCoroutine(lineContainer.DestroyLine(time));
            }

        }
    }

    void gatherChildren()
    {
        foreach (Transform child in starParent)
            children.Add(child);
    }

}
