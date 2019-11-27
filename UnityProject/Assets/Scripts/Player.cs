using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("動畫參數名稱")]
    public string parRun = "跑步開關";
    public string parJump = "跳躍開關";
    public string parAtk = "攻擊觸發";
    public string parDamage = "受傷觸發";
    public string parDead = "死亡開關";
    [Header("道具")]
    public int countNeed = 10;
    public int countCurrent;
    [Header("數值")]
    public bool isDead;
    [Range(0, 500)]
    public float hp = 100;
}
