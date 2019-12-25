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

        Drive(100, "前");                  // 呼叫自訂方法，必須給予引數
        Drive(200, "後", "碰碰碰~");
        Drive(300, "左", effect:"火花");   // 具名方式
        Drive(10, "前方");

        int t = Tax();  // 使用傳回方法，他會傳回一個資料
        print("稅金：" + t);

        print("減稅：" + (Tax() - 10000));
    }

    // 定義方法 (宣告方法)
    // 語法：
    // 修飾詞 傳回類型 名稱 (參數1, 參數2, ....) { 陳述式、演算法 }
    // 參數語法：類型 名稱
    // void 無傳回
    // 自訂方法不會執行必須呼叫
    // 參數可以加預設值：選填式參數 (只能放在最右邊)

    /// <summary>
    /// 開車方法
    /// </summary>
    /// <param name="speed">速度</param>
    /// <param name="direction">方向</param>
    /// <param name="sound">引擎音效</param>
    /// <param name="effect">特效</param>
    public void Drive(int speed, string direction, string sound = "噗噗噗", string effect = "煙霧")
    {
        print("開車囉，時數：" + speed);
        print("開車方向：" + direction);
        print("引擎聲：" + sound);
        print("特效：" + effect);
    }

    // 傳回類型：int float string bool
    /// <summary>
    /// 運算稅金方法
    /// </summary>
    /// <returns>傳回稅金運算結果</returns>
    public int Tax()
    {
        return cc * 1000;
    }
}
