//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Geometry
{
    [Serializable]
    public class TransformMsg : Message
    {
        public const string k_RosMessageName = "geometry_msgs/Transform";
        public override string RosMessageName => k_RosMessageName;

        //  This represents the transform between two coordinate frames in free space.
        public Vector3Msg translation;
        public QuaternionMsg rotation;

        public TransformMsg()
        {
            this.translation = new Vector3Msg();
            this.rotation = new QuaternionMsg();
        }

        public TransformMsg(Vector3Msg translation, QuaternionMsg rotation)
        {
            this.translation = translation;
            this.rotation = rotation;
        }

        public static TransformMsg Deserialize(MessageDeserializer deserializer) => new TransformMsg(deserializer);

        private TransformMsg(MessageDeserializer deserializer)
        {
            this.translation = Vector3Msg.Deserialize(deserializer);
            this.rotation = QuaternionMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.translation);
            serializer.Write(this.rotation);
        }

        public override string ToString()
        {
            return "TransformMsg: " +
            "\ntranslation: " + translation.ToString() +
            "\nrotation: " + rotation.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
