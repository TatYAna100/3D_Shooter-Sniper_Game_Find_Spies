using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Animator))]
public class Spawner : MonoBehaviour
{
    [SerializeField] private Bullet _bulletTemplate;
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private int _speed;
    [SerializeField] private Rigidbody _rigidbody;

    //private float _shootInterval = 3.0f;
    //private float _nextShoot;
    //private bool _scopeIsOn;
    private Animator _animator;

    private const string _recharge = "Recharge";

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        ShootBullet();
    }

    private void ShootBullet()
    {
        Instantiate(_bulletTemplate, _shootPoint);
        //Instantiate(_bulletTemplate, _shootPoint.position, _shootPoint.rotation);

        if (Input.GetKeyDown(KeyCode.Space)/*GetMouseButtonDown(1)*/)
        {
            if (_bulletTemplate != null)
            {
                transform.Translate(Vector3.forward * _speed * Time.deltaTime);
                //_rigidbody.AddForce(Vector3.zero * _speed);
                //transform.Translate(Vector3.forward * _speed, Space.Self);
                //bullet.transform.GetComponent<Rigidbody>().AddForce(transform.forward * _speed);

                //StartCoroutine(StartReloadAnimation());
                StartCoroutine(DestroyBullet(_bulletTemplate));

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Enemy enemy))
        {
            //enemy.Die();
            Destroy(gameObject);
        }
    }

    IEnumerator DestroyBullet (Bullet bullet)
    {
        yield return new WaitForSeconds(3.0f);
        Destroy(bullet);
    }

    //IEnumerator StartReloadAnimation()
    //{
    //    yield return new WaitForSeconds(1.0f);
    //    //_animator.SetTrigger(_recharge);
    //    //transform.GetComponentInChildren<Scope>().MainCamera.fieldOfView = transform.GetComponentInChildren<Scope>().CurrentFieldOfView;
    //    //transform.GetComponentInChildren<Scope>().AimingWindow.SetActive(false);
    //    //transform.GetComponentInChildren<Scope>().WeaponCamera.SetActive(true);
    //}



    //[SerializeField] private int _damage;
    //[SerializeField] private float _speed;

    //private void Update()
    //{
    //    transform.Translate(Vector3.forward * _speed * Time.deltaTime, Space.World);
    //}

    //private void OnTriggerEnter(Collider collision)
    //{
    //    if(collision.gameObject.TryGetComponent(out Enemy enemy))
    //    {
    //        enemy.MakePhysical();
    //        enemy.TakeDamage(_damage);

    //        Destroy(gameObject);
    //    }
    //}
}