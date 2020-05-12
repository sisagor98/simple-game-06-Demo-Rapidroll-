using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public float speed = 10f;
    private void Start()
    {
        Invoke("DeActivePlatform", 6f);
    }

    void Update()
    {
        transform.Translate(Vector3.up* speed * Time.deltaTime);
    }

    void DeActivePlatform()
    {
        Destroy(this.gameObject);
    }
}
