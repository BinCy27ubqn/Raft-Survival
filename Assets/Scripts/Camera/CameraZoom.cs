using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    [SerializeField]
    private Camera _cam;

    private float _zoomSize;
    private float _maxZoom = 5f;
    private float _smoothTime = 0.4f;
    private float _velocity = 0f;

    [SerializeField]
    private float _zoomTime;

    private Animator _animator;

    void Start()
    {
        _zoomSize = _cam.orthographicSize;
    }

    void Update()
    {
        float scroll = Time.deltaTime * _zoomTime;
        if(_zoomSize > _maxZoom)
        {
            _zoomSize -= scroll;
        }
        _cam.orthographicSize = Mathf.SmoothDamp(_cam.orthographicSize, _zoomSize, ref _velocity, _smoothTime);
        
    }
}
