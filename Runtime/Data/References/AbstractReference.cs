using System;
using UnityEngine;

namespace Fenneig_Scriptable_Architecture.Runtime.Data
{
    [Serializable]
    public class AbstractReference<T>
    {
        [SerializeField] private bool _useConstant;
        [SerializeField] private T _constantValue;
        [SerializeField] private AbstractVariable<T> _variable;

        public T Value => _useConstant ? _constantValue : _variable.Value;
    }
}