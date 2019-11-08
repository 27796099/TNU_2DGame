
using UnityEngine;

public class player : MonoBehaviour
{
    [Header("速度"),Range(0f,100f)]
    public float speed = 3.5f;
    [Header("跳躍高度"),Range(100,2000)]
    public int jumpHigh = 300;
    [Header("是否在地上"),Tooltip("用來判斷角色是否在地上")]
    bool isGround = false;
    [Header("玩家名稱")]
    public string name = "RR";


}
