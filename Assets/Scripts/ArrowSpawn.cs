using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawn : MonoBehaviour
{
    [SerializeField] GameObject _arrow;
    [SerializeField] Transform _arrowTransfrom;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_arrow, _arrowTransfrom.position, _arrowTransfrom.rotation);
        }
    }
}
