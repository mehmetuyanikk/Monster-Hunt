using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowLife : MonoBehaviour
{
    [SerializeField] float _arrowTime;
    float _currentTime;

    private void FixedUpdate()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime > _arrowTime)
        {
            Destroy(this.gameObject);
        }
    }

}
