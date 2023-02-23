using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Enemy enemy))
        {
            //enemy.Die();
            //enemy.MakePhysical();
            enemy.MakePhysical();
            Destroy(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
            //StartCoroutine(Destroy());
        }
    }

    //IEnumerator Destroy()
    //{
    //    yield return new WaitForSeconds(3.0f);
    //    Destroy(gameObject);
    //}
}