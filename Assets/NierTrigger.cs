using UnityEngine;
using System.Collections;

/*
 *  Author:     yanagiragi 
 *  Purpose:    用來測試事件的Script，綁在測試模型(Yorha 2B)上
 *  Reminds:    需要掛上Collider
 */


public class NierTrigger : BaseTrigger {

    // 因為要讓外面呼叫所以要用public
    public void publicTrigger()
    {
        base.getTrigger()();
    }

    // Contructor
    public NierTrigger() : base()
    {
        // 如果直接用 base 的 contructor 呼叫，會因為現在這個物件還沒建立無法存取到 this.trigger() 的Instance.
        // 因此初始化 p_Instance 在 child Class 內進行。
        base.p_Instance = new BaseTrigger.exceutable(trigger);
    }


    // ============================ 以下自定義 ============================ //

    // 自定義 function callback
    protected void trigger() 
    {
        Debug.Log("Gaze At 2B");
    }

    void Start() { }

    void Update() { }
}
