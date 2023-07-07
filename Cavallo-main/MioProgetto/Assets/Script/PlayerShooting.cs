using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject boccafuoco;
    public Transform player;
    public float offset;
    public float delayBetweenShots = 1f;
    private float timePassedSinceLast = 0f;
    public float effectsDuration = 0.2f;
    private Vector3 velocity = Vector3.zero;

     void Start()
    {
        timePassedSinceLast = delayBetweenShots;
    }

    void Update()
{
    timePassedSinceLast += Time.deltaTime;

    if (Input.GetMouseButton(0) && timePassedSinceLast >= delayBetweenShots)
    {
        Shooting();
        timePassedSinceLast = 0f;
    }

    if (timePassedSinceLast <= effectsDuration)
    {
        EnableEffects();
    }
    else
    {
        DisableEffects();
    }
}

void Shooting()
{
    EnableEffects();
    GameObject bullet = (GameObject)Instantiate(Resources.Load("Lazer3"), boccafuoco.transform.position, transform.rotation);
}

void EnableEffects()
{
    boccafuoco.SetActive(true);
}

void DisableEffects()
{
    boccafuoco.SetActive(false);
}
}
