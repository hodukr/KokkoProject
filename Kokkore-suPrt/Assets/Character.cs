using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    private GameObject _target = null;
    //public GameObject _Target
    //{
    //    get { return _target; }
    //    set { _target = value; }
    //}
    [SerializeField]
    private float _speed;
    //public float _Speed
    //{
    //    get { return _speed; }
    //    set { _speed = value; }
    //}



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_target)
        {
            Vector3 vel = _target.transform.position - transform.position;
            vel.Normalize();
            vel *= _speed;
            transform.position += vel * Time.deltaTime;
        }
    }
}
