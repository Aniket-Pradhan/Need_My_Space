using Assets.Scripts;
using UnityEngine;

public class ArrowKeysDetector : MonoBehaviour, IInputDetector
{
    public InputDirection? DetectInputDirection()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            return InputDirection.Top;
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            return InputDirection.Bottom;
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            return InputDirection.Right;
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            return InputDirection.Left;
        else
            return null;
    }
}