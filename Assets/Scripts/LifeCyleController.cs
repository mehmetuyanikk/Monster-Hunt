using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCyleController : MonoBehaviour
{
    [SerializeField] float _enemyLifeTime;
    float _currentTime;

    private void FixedUpdate()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime > _enemyLifeTime)
        {
            Destroy(this.gameObject);
        }
    }

}
