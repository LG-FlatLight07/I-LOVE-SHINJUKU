using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public enum Key
{
    Left,
    Right,
    Up,
    Down,
    Space,
    Z,
    X,
    C,
}

public class InputManager : MonoBehaviour
{
    public static InputManager instance { get; private set; }


    private static bool left;
    private static bool right;
    private static bool up;
    private static bool down;
    private static bool space;
    private static bool z;
    private static bool x;
    private static bool c;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        left = Keyboard.current.leftArrowKey.wasPressedThisFrame;
        right = Keyboard.current.rightArrowKey.wasPressedThisFrame;
        up = Keyboard.current.upArrowKey.wasPressedThisFrame;
        down = Keyboard.current.downArrowKey.wasPressedThisFrame;
        space = Keyboard.current.spaceKey.wasPressedThisFrame;
        z = Keyboard.current.zKey.wasPressedThisFrame;
        x = Keyboard.current.xKey.wasPressedThisFrame;
        c = Keyboard.current.cKey.wasPressedThisFrame;
    }

    public static bool GetKey(Key key)
    {
        switch(key)
        {
            case Key.Left:
                return left;
            case Key.Right:
                return right;
            case Key.Up:
                return up;
            case Key.Down:
                return down;
            case Key.Space:
                return space;
            case Key.Z:
                return z;
            case Key.X:
                return x;
            case Key.C:
                return c;
        }
        return false;
    }
}
