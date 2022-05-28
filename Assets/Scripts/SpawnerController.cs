using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] GameObject _monster;
    [SerializeField] Transform _monsterTransform;
    [SerializeField] float _randomSpawnTimeEnemy, _currentTimeEnemy;

    [Range(1, 5)][SerializeField] float _minSpawnTime;
    [Range(2, 6)][SerializeField] float _maxSpawnTime;

    private void FixedUpdate()
    {
        _currentTimeEnemy += Time.deltaTime;

        if (_currentTimeEnemy > _randomSpawnTimeEnemy)
        {
            EnemySpawnStart();
            ResetTimeMonster();
        }
    }

    void EnemySpawnStart()
    {
        Instantiate(_monster, _monsterTransform.position, _monsterTransform.rotation, _monsterTransform.transform);

        ResetTimeMonster();
    }

    void ResetTimeMonster()
    {
        _currentTimeEnemy = 0;
        _randomSpawnTimeEnemy = Random.Range(_minSpawnTime, _maxSpawnTime);
    }

}
