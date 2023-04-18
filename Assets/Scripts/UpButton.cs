using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpButton : MonoBehaviour
{

    private static bool upButton = false;

    public static bool getUpButton() {
        return upButton;
    }

    public static void setUpButton(bool value) {
        upButton = value;
    }

    public void upButtonPressed() {
        setUpButton(true);
    }

}
