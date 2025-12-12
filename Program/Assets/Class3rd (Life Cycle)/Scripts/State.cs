using UnityEngine;

public class State : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        //Awake()
        //클래스가 생성되는 시점에 단 한 번만 호출되며,
        //클래스가 비활성화 되어 있어도
        //호출되는 이벤트 함수입니다.
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        //OnEnable()
        //게임 오브젝트가 활성화될 때마다 호출되는
        //이벤트 함수입니다.
        Debug.Log("OnEnable");
    }

    private void Start()
    {
        //Start()
        //게임 오브젝트가 생성되었을 때, 단 한 번만 호출되며,
        //클래스가 비활성화되었을 때는 호출되지 않는 이벤트 함수입니다.
        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        //FixedUpdate()
        //Time Step에 설정된 값에 따라 일정한 간격으로
        //호출되는 이벤트 함수입니다.
        Debug.Log("Fixed Update");
    }

    private void Update()
    {
        //Update()
        //매 프레임마다 호출되는 이벤트 함수입니다.
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        //LateUpdate()
        //Update 함수가 호출된 후에 호출되는 이벤트 함수입니다.
        Debug.Log("Late Update");
    }

    private void OnDisable()
    {
        //OnDisable()
        //게임 오브젝트가 비활성화될 때마다 호출되는 이벤트 함수입니다.
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        //OnDestroy()
        //게임 오브젝트가 삭제되면 호출되는 이벤트 함수입니다.
        Debug.Log("OnDestroy");
    }
}
