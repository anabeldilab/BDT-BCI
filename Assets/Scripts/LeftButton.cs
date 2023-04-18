using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : MonoBehaviour
{

    private static bool leftButton = false;

    public static bool getLeftButton() {
        return leftButton;
    }

    public static void setLeftButton(bool value) {
        leftButton = value;
    }

    public void leftButtonPressed() {
        setLeftButton(true);
    }

}
