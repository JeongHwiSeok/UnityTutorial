using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    #region �ʱ�ȭ ����
    private void Awake()
    {
        Debug.Log("Awake");
        // Awake() : ���� ������Ʈ�� ������ �� �� 1���� ȣ��Ǹ�, ��ũ��Ʈ�� ��Ȱ��ȭ ������ ���� ȣ��Ǵ� �̺�Ʈ �Լ�
        // ex) ������ ��Ȱ
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
        // OnEnable() : ���� ������Ʈ�� Ȱ��ȭ�� ������ ȣ��Ǵ� �̺�Ʈ �Լ�
        // ex) �ʱ� ��ġ��, Object Fooling
    }

    private void Start()
    {
        Debug.Log("Start");
        // Start() : ���� ������Ʈ�� ������ �� �� 1���� ȣ��Ǹ�, ��ũ��Ʈ�� ��Ȱ��ȭ ������ ���� ȣ����� �ʴ� �̺�Ʈ �Լ�
        // ex) 
    }
    #endregion

    #region Physics
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
        // FixedUpdate() : timeStep�� ������ ���� ���� ������ �������� ȣ��Ǵ� �̺�Ʈ �Լ�
        // ex) ĳ������ �������� ó���� ��
    }
    #endregion

    #region Game logic
    private void Update()
    {
        Debug.Log("Update");
        // Update() : framerate�� �ұ�Ģ�� �������� �� �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ�
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
        // LateUpdate() : Update() �Լ��� ȣ��� �� 1�� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        // ex) ī�޶� ĳ���͸� ���󰥶�
    }
    #endregion

    #region Decommissioning
    private void OnDisable()
    {
        Debug.Log("OnDisable");
        // OnDisable() : ���� ������Ư�� ��Ȱ��ȭ �Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ�
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
        // OnDestroy() : ���� ������Ʈ�� ���� �Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ�
    }
    #endregion
}
