using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    #region 초기화 영역
    private void Awake()
    {
        Debug.Log("Awake");
        // Awake() : 게임 오브젝트가 생성될 때 단 1번만 호출되며, 스크립트가 비활성화 상태일 때도 호출되는 이벤트 함수
        // ex) 생성자 역활
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
        // OnEnable() : 게임 오브젝트가 활성화될 때마다 호출되는 이벤트 함수
        // ex) 초기 위치값, Object Fooling
    }

    private void Start()
    {
        Debug.Log("Start");
        // Start() : 게임 오브젝트가 생성될 때 단 1번만 호출되며, 스크립트가 비활성화 상태일 때는 호출되지 않는 이벤트 함수
        // ex) 
    }
    #endregion

    #region Physics
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
        // FixedUpdate() : timeStep에 설정된 값에 따라 일정한 간격으로 호출되는 이벤트 함수
        // ex) 캐릭터의 움직임을 처리할 때
    }
    #endregion

    #region Game logic
    private void Update()
    {
        Debug.Log("Update");
        // Update() : framerate의 불규칙한 간격으로 매 프레임마다 호출되는 이벤트 함수
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
        // LateUpdate() : Update() 함수가 호출된 후 1번 씩 호출되는 이벤트 함수
        // ex) 카메라가 캐릭터를 따라갈때
    }
    #endregion

    #region Decommissioning
    private void OnDisable()
    {
        Debug.Log("OnDisable");
        // OnDisable() : 게임 오브젝특가 비활성화 되었을 때 호출되는 이벤트 함수
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
        // OnDestroy() : 게임 오브젝트가 삭제 되었을 때 호출되는 이벤트 함수
    }
    #endregion
}
