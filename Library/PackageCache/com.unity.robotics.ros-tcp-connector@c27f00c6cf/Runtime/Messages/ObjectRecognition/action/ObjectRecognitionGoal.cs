//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.ObjectRecognition
{
    [Serializable]
    public class ObjectRecognitionGoal : Message
    {
        public const string k_RosMessageName = "object_recognition_msgs-master/ObjectRecognition";
        public override string RosMessageName => k_RosMessageName;

        //  Optional ROI to use for the object detection
        public bool use_roi;
        public float[] filter_limits;

        public ObjectRecognitionGoal()
        {
            this.use_roi = false;
            this.filter_limits = new float[0];
        }

        public ObjectRecognitionGoal(bool use_roi, float[] filter_limits)
        {
            this.use_roi = use_roi;
            this.filter_limits = filter_limits;
        }

        public static ObjectRecognitionGoal Deserialize(MessageDeserializer deserializer) => new ObjectRecognitionGoal(deserializer);

        private ObjectRecognitionGoal(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.use_roi);
            deserializer.Read(out this.filter_limits, sizeof(float), deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.use_roi);
            serializer.WriteLength(this.filter_limits);
            serializer.Write(this.filter_limits);
        }

        public override string ToString()
        {
            return "ObjectRecognitionGoal: " +
            "\nuse_roi: " + use_roi.ToString() +
            "\nfilter_limits: " + System.String.Join(", ", filter_limits.ToList());
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize, MessageSubtopic.Goal);
        }
    }
}
