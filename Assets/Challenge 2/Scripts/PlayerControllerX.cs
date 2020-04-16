using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float DogCooldown = 1.5f;
    private float TimerDog=1.5f;

    // Update is called once per frame
    void Awake()
    {
        TimerDog = DogCooldown;
    }
    void Update()
    {
        TimerDog -= Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && TimerDog < 0.0f)
        {
            TimerDog = DogCooldown;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
