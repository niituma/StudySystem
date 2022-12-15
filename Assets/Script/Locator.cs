using System.Collections;
using System.Collections.Generic;
using System;

public class Locator
{
    private static readonly Dictionary<Type, object> _instanceDict = new Dictionary<Type, object>();

   /// <summary>
    /// サービス取得
    /// </summary>
    public static T Resolve<T>()
    {
        return (T)_instanceDict[typeof(T)];
    }

    /// <summary>
    /// サービス登録
    /// </summary>
    public static void Register<T>(T instance)
    {
        _instanceDict[typeof(T)] = instance;
    }

    /// <summary>
    /// サービス登録解除
    /// </summary>
    public static void UnRegister<T>()
    {
        _instanceDict.Remove(typeof(T));
    }
}
