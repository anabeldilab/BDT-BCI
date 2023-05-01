using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownButton : MonoBehaviour
{

    private static bool downButton = false;

    public static bool getDownButton() {
        return downButton;
    }

    public static void setDownButton(bool value) {
        downButton = value;
    }

    public void downButtonPressed() {
        setDownButton(true);
    }

}
