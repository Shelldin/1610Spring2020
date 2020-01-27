using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
[RequireComponent(typeof(CinemachineVirtualCamera))]
public class VirtualCameraController : MonoBehaviour
{
  public PlayerData playerData;

  private CinemachineVirtualCamera virtualCamera;

  private void Awake()
  {
    virtualCamera = GetComponent<CinemachineVirtualCamera>();
    playerData.instanceAction = InstanceHandler;
    playerData.InstancePlayer();
  }

  private void InstanceHandler(GameObject obj)
  {
    virtualCamera.Follow = obj.transform;
  }

}
