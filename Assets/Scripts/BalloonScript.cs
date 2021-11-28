using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonScript : MonoBehaviour
{
    private float speed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyBallon());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }

    IEnumerator DestroyBallon()
    {
        yield return new WaitForSeconds(10);
        Destroy(transform.gameObject);
    }
}
