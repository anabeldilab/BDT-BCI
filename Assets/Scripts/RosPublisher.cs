using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Std;
using static LeftButton;
using static RightButton;
using static UpButton;
using static DownButton;

/// <summary>
///
/// </summary>
public class RosPublisher : MonoBehaviour
{
    ROSConnection ros;
    public string topicName = "dir_goal";

    private const string messageLeft = "Left";
    private const string messageRight = "Right";
    private const string messageUp = "Up";
    private const string messageDown = "Down";

    // Check if button is pressed every 0.5 seconds
    public float publishMessageFrequency = 0.5f;

    // Used to determine how much time has elapsed since the last message was published
    private float timeElapsed;

    void Start() {
        // start the ROS connection
        ros = ROSConnection.GetOrCreateInstance();
        ros.RegisterPublisher<StringMsg>(topicName);
        LeftButton.setLeftButton(false);
        RightButton.setRightButton(false);
    }

    private void Update() {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > publishMessageFrequency)
        {   
            if(LeftButton.getLeftButton()) {
                Publish(messageLeft);
                LeftButton.setLeftButton(false);
            } else if (RightButton.getRightButton()) {
                Publish(messageRight);
                RightButton.setRightButton(false);
            } else if (UpButton.getUpButton()) {
                Publish(messageUp);
                UpButton.setUpButton(false);
            } else if (DownButton.getDownButton()) {
                Publish(messageDown);
                DownButton.setDownButton(false);
            } 
            timeElapsed = 0;
        }
    }

    private void Publish(string message) {
        Debug.Log(message);
        StringMsg msg = new StringMsg(message);
        ros.Publish(topicName, msg);
    }
}
