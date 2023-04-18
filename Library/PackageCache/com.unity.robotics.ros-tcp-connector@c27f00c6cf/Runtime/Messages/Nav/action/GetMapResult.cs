//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Nav
{
    [Serializable]
    public class GetMapResult : Message
    {
        public const string k_RosMessageName = "nav_msgs/GetMap";
        public override string RosMessageName => k_RosMessageName;

        public OccupancyGridMsg map;

        public GetMapResult()
        {
            this.map = new OccupancyGridMsg();
        }

        public GetMapResult(OccupancyGridMsg map)
        {
            this.map = map;
        }

        public static GetMapResult Deserialize(MessageDeserializer deserializer) => new GetMapResult(deserializer);

        private GetMapResult(MessageDeserializer deserializer)
        {
            this.map = OccupancyGridMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.map);
        }

        public override string ToString()
        {
            return "GetMapResult: " +
            "\nmap: " + map.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize, MessageSubtopic.Result);
        }
    }
}
