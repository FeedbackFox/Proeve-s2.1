using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    void Start()
    {
        if (this.gameObject.transform.position.y < 0.385f || this.gameObject.transform.position.y > 0.385f);
        {
            this.gameObject.transform.position = new Vector3(transform.position.x, 0.385f, transform.position.z);
        }
        StartCoroutine(DestroyTimer());
    }

    IEnumerator DestroyTimer()
    {
        int _waitTime = Random.Range(0, 5);
        yield return new WaitForSeconds(_waitTime);
        DestroyObject();
    }

    void DestroyObject()
    {
        Destroy(this.gameObject);
    }
}
