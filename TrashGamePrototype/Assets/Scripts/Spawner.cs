using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject trashPrefab;
    [SerializeField]
    private float _radius = 1f;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        int _waitTime = Random.Range(0, 5);
        yield return new WaitForSeconds(_waitTime);
        SpawnObjectAtRandom();
    }

    void SpawnObjectAtRandom()
    {
        Vector3 _randomPos = Random.insideUnitCircle * _radius;
        Instantiate(trashPrefab, _randomPos, Quaternion.identity);
        StartCoroutine(SpawnRoutine());
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(this.transform.position, _radius);
    }
}
