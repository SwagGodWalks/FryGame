using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAi : MonoBehaviour
{
     GameObject Player;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.gameObject.transform);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
