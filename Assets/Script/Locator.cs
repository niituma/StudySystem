using System.Collections;
using System.Collections.Generic;
using System;

public class Locator
{
    private static readonly Dictionary<Type, object> _instanceDict = new Dictionary<Type, object>();

   /// <summary>
    /// �T�[�r�X�擾
    /// </summary>
    public static T Resolve<T>()
    {
        return (T)_instanceDict[typeof(T)];
    }

    /// <summary>
    /// �T�[�r�X�o�^
    /// </summary>
    public static void Register<T>(T instance)
    {
        _instanceDict[typeof(T)] = instance;
    }

    /// <summary>
    /// �T�[�r�X�o�^����
    /// </summary>
    public static void UnRegister<T>()
    {
        _instanceDict.Remove(typeof(T));
    }
}
