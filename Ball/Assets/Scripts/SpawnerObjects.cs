using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObjects : MonoBehaviour
{
    [SerializeField]
    private GameObject _coinObject;

    [SerializeField]
    private GameObject _stoneObject;

    private Vector3 _spawnPoint;


    private void Start()
    {
        StartCoroutine(CreateObjects());
    }

    private IEnumerator CreateObjects()
    {
        while (true)
        {
            int indexCreator = Random.Range(0,2);

            yield return new WaitForSeconds(Random.Range(1f, 3f));

            _spawnPoint = new Vector3(Random.Range(-10f, 10f), transform.position.y, transform.position.z);

            switch (indexCreator)
            {
                case 0:
                    Instantiate(_coinObject, _spawnPoint, Quaternion.identity);
                    break;
                case 1:
                    Instantiate(_stoneObject, _spawnPoint, Quaternion.identity);
                    break;
            }
        }
    }
}
