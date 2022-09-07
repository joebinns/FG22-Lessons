using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform target;

    [SerializeField] private Vector3 offset;

    private void Start()
    {
        offset = this.transform.position - target.transform.position;
    }

    private void Update()
    {
        this.transform.position = target.transform.position + offset;
    }
}
