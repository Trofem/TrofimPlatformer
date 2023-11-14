using UnityEngine;
using UnityEngine.UI;

public class ScrollBarPhysics : MonoBehaviour
{
    public static float Jump_factor = 1f;
    [SerializeField] private Text JumpNumberText;

    public static float Move_factor = 1f;
    [SerializeField] private Text MoveNumberText;

    public void ScrollBarJumpData(float jump)
    {
        Jump_factor = Mathf.Round(jump * 100.0f) * 0.01f;
        Debug.Log("Your jump factor is " + Jump_factor + ".");
        JumpNumberText.text = "Jump factor = " + Jump_factor + ".";
    }
    public void ScrollBarMoveData(float move)
    {
        Move_factor = Mathf.Round(move * 100.0f) * 0.01f;
        Debug.Log("Your move factor is " + Move_factor + ".");
        MoveNumberText.text = "Move factor = " + Move_factor + ".";
    }
}