# Bachelor's Degree Thesis: Control of Electromechanical Devices using BCI - Unity Part (Version with Unity Robotics Hub)

## About
This repository is an earlier version of the Unity component of my Bachelor's Degree Thesis project, which is about controlling electromechanical devices using a Brain-Computer Interface (BCI). It initially made use of the Unity-Robotics-Hub, a Unity package that managed ROS connections. However, due to unidentified issues causing the application to crash when used in conjunction with the NextMind device, I've decided to transition to the ROS2-For-Unity library for the final version of the project.

## Design
This application uses the [Unity-Robotics-Hub][1] for managing ROS connections. The following diagram illustrates the scheme of these connections.

[1]: https://github.com/Unity-Technologies/Unity-Robotics-Hub/ "Unity-Robotics-Hub"

![Unity-ROS Comunication.png](./img/unity_ros.png)

## Setup
### Server Endpoint
The server endpoint is initiated in a colcon workspace in a Linux OS, in this case WSL with Ubuntu 22.04v. To start the server endpoint, run the following command, replacing "<your IP address>" with the IP address or hostname of your ROS machine:
```bash
ros2 run ros_tcp_endpoint default_server_endpoint --ros-args -p ROS_IP:=<your IP address>
```

On Linux, you can find out your IP address with the command "hostname -I".

### Start the Echo monitor
To verify that messages are actually being received by ROS, run the "rostopic echo" command:
  
```bash
source install/setup.bash
ros2 topic echo dir_goal
```

## Transition to ROS2-For-Unity
Due to the unidentified issues causing the application to crash when Unity-Robotics-Hub is used in conjunction with NextMind, we've decided to switch to the ROS2-For-Unity library in the final version of the project. This decision was made to ensure the seamless integration of Unity, ROS, and the NextMind device, which is the primary aim of this project.
  
## License
This project is licensed under the GNU General Public License Version 3, dated 29 June 2007. For more information, please see the LICENSE file in this repository or visit https://www.gnu.org/licenses/gpl-3.0.html.

