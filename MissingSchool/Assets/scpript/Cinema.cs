using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class Cinema : MonoBehaviour
{
    public GameObject tPlayer; public Transform tFollowTarget;
    private CinemachineVirtualCamera vcam;
    void Start() { vcam = GetComponent<CinemachineVirtualCamera>(); tPlayer = null; }
    // �� ������Ʈ�� �ƴ� start���� �ѹ��� �����ص� �Ǵ°� �ƴұ�?
    void Update()
    {
        if (tPlayer == null)
        {
            tPlayer = GameObject.FindWithTag("Player");
            if (tPlayer != null)
            {
                tFollowTarget = tPlayer.transform; vcam.Follow = tFollowTarget;
            }
        }
    }
}
