
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
    private void Awake()
    {
        children = new List<Transform>();
        gatherChildren();
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
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
            print(children[a].GetComponent<Transform>().position);
            print(children[b].GetComponent<Transform>().position);
            newLine.SetPosition(0, children[a].GetComponent<Transform>().position);
            newLine.SetPosition(1, children[b].GetComponent<Transform>().position);
            newLine.GetComponent<lineCollider>().SetCollider();
            lineContainer.AddLine(newLine);

        }
    }

    void gatherChildren()
    {
        foreach (Transform child in starParent)
            children.Add(child);
    }

}
