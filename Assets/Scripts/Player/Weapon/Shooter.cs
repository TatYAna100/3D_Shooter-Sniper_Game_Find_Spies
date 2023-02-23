using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private Bullet _bulletTemplate;

    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Instantiate(_bulletTemplate, _shootPoint.position, _shootPoint.rotation);
            //StartCoroutine(DestroyBullet(_bulletTemplate));
        }
    }

    //IEnumerator DestroyBullet(Bullet bullet)
    //{
    //    yield return new WaitForSeconds(10.0f);
    //    Destroy(bullet);
    //}
}