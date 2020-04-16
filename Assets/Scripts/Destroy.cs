using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private float topbound = -30;
    private float loverbound = 24;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < topbound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > loverbound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
