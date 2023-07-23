using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Std;
using RosMessageTypes.BuiltinInterfaces;


public class RosPublisher : MonoBehaviour {
  ROSConnection ros;
  public string topicName = "action";

  private const string messageLeft = "ACT_/Left";
  private const string messageRight = "ACT_/Right";
  private const string messageUp = "ACT_/Up";
  private const string messageDown = "ACT_/Down";
  private const string messageReset = "ACT_/Reset";

  void Start() {
    ros = ROSConnection.GetOrCreateInstance();
    if (ros == null) {
      Debug.LogError("ROS Connection is null!");
      return;
    }
    if (ros.GetTopic(topicName) == null) {
      ros.RegisterPublisher<HeaderMsg>(topicName);
    }

    PublishHeaderMsg("CON_/CAM");
  }

  public void PublishReset() {
    PublishHeaderMsg(messageReset);
  }


  public void PublishLeft() {
    PublishHeaderMsg(messageLeft);
  }

  public void PublishRight() {
    PublishHeaderMsg(messageRight);
  }

  public void PublishUp() {
    PublishHeaderMsg(messageUp);
  }

  public void PublishDown() {
    PublishHeaderMsg(messageDown);
  }

  public void PublishDisconnectSAP() {
    PublishHeaderMsg("CON_/DIS");
  }

  private void PublishHeaderMsg(string frame_id) {
    Debug.Log(frame_id);
    TimeMsg time = new TimeMsg();
    HeaderMsg msg = new HeaderMsg(time, frame_id);

    ros.Publish(topicName, msg);
  }
}
