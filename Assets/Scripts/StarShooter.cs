using System.Collections.Generic;
using UnityEngine;

public class StarShooter : MonoBehaviour
{

    [SerializeField]
    GameObject shootingStarPrefab;

    [SerializeField]
    float xDirection = 1;

    [SerializeField]
    float yDirection = 0;


    public static float count = 0;

    static List<GameObject> stars = new List<GameObject>();

    float radius;
    
    void Start() 
    {
        radius = transform.localScale.x;
        Shoot(xDirection, yDirection);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        RandomShoot();
    }

    private void Update()
    {
        if (count == 0)
            Debug.Log("no more star");
    }

    private void RandomShoot()
    {
        System.Random rnd = new System.Random();
        Shoot(rnd.Next(-10, 10), rnd.Next(-10, 10));
    }
    private void Shoot(float x, float y)
    {
        Vector2 aim = new Vector2(x,y);
        aim.Normalize();
        Vector3 position;
        position.x = transform.position.x + aim.x*radius;
        position.y = transform.position.y + aim.y*radius;
        position.z = 0;
        GameObject newStar = Instantiate(shootingStarPrefab);
        newStar.transform.position = position;
        newStar.GetComponent<shootingStar>().Shoot(aim.x, aim.y);
        stars.Add(newStar);
        count++;
    }

    public static void removeStar(GameObject go)
    {
        stars.Remove(go);
        count--;
    }

    public static void DestroyAll()
    {
        foreach (GameObject star in stars)
        {
            Destroy(star);
            removeStar(star);
            count--;
        }
    }

}
