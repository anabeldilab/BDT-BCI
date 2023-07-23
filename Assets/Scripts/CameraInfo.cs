using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInfo : MonoBehaviour {
  public bool GetState() {
    return RosSubscriber.Instance.CameraEnabled;
  }

  public string GetIP() {
    return RosSubscriber.Instance.CameraIP;
  }

  public string GetUrl() {
    if (GetState() == false) {
      return "No camera URL";
    }
    return "http://" + GetIP() + ":81";
  }

  public string GetUrlApiRest() {
    if (GetState() == false) {
      return "No camera URL";
    }
    return "http://" + GetIP() + ":80";
  }

}
