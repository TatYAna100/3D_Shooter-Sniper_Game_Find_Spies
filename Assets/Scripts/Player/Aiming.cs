using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Camera _camera;

    //private const string _aiming = "Aiming";
    //private const string _aimingReloadNoAmmo = "AimingReloadNoAmmo";
    private const string _aiming = "Aiming";

    Coroutine zoomCoroutine;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _animator.SetTrigger(_aiming);
            //_animator.SetBool("anim", true);

            if (zoomCoroutine != null)
            {
                StopCoroutine(zoomCoroutine);
            }

            zoomCoroutine = StartCoroutine(aimFieldOfView(_camera, 15, 0.3f));
        }
        else if(Input.GetMouseButtonUp(0))
        {
            //_animator.ResetTrigger(_aiming);
            //_animator.SetBool("anim", false);

            if (zoomCoroutine != null)
            {
                StopCoroutine(zoomCoroutine);
            }

            zoomCoroutine = StartCoroutine(aimFieldOfView(_camera, 60, 0.3f));
        }
    }

    IEnumerator aimFieldOfView(Camera targetCamera, float toView, float duration)
    {
        float counter = 0;
        float fromView = targetCamera.fieldOfView;

        while(counter < duration)
        {
            counter += Time.deltaTime;

            float viewTime = counter / duration;

            targetCamera.fieldOfView = Mathf.Lerp(fromView, toView, viewTime);

            yield return null;
        }
    }
}