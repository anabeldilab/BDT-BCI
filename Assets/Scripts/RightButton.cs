using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightButton : MonoBehaviour
{
    private static bool rightButton = false;

    public static bool getRightButton() {
        return rightButton;
    }

    public static void setRightButton(bool value) {
        rightButton = value;
    }

    public void rightButtonPressed() {
        setRightButton(true);
    } 
}
