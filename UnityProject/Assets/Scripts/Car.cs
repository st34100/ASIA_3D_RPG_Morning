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

    // 事件：在特定時間會已指定次數執行
    // 開始事件：播放時候執行一次
    private void Start()
    {
        // API 功能 - 輸出
        print("哈囉，沃德~");
        // 取得欄位
        print(cc);
        print(brand);
        // 存放欄位
        weight = 999.9f;
        cc = 3000;
        brand = "福特";
        _break = true;
    }

    // 更新事件：約一秒執行 60 次 (60FPS)
    // 監聽玩家輸入事件
    private void Update()
    {
        print("啦啦啦~");
    }
}
