using UnityEngine;

public class Car : MonoBehaviour
{
    // 定義欄位 (宣告變數)
    // 語法：
    // 修飾詞 類型 名稱 (指定 值) 結束
    // 私人 - 隱藏 private (預設)
    // 公開 - 顯示 public

    [Header("CC 數")][Range(500, 10000)]
    public int cc = 2000;           // 整數 int
    [Header("重量"), Range(50f, 500f)]
    public float weight = 150.5f;   // 浮點數 float
    [Header("品牌"), Tooltip("這是汽車的品牌名稱~")]
    public string brand = "BMW";    // 字串 string
    [Header("剎車"), Tooltip("判斷汽車是否剎車，true 剎車中，false 沒有剎車")]
    public bool _break = false;     // 布林值 bool - true/false
}
