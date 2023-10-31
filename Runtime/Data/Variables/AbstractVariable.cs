using UnityEngine;

namespace Fenneig_Scriptable_Architecture.Runtime.Data
{
    public class AbstractVariable<T> : ScriptableObject
    {
        [SerializeField] private T _value;
#if UNITY_EDITOR
#pragma warning disable CS0414
        [Multiline]
        [SerializeField] private string _developerDescription = "";
#pragma warning restore CS0414
#endif


        public T Value
        {
            get => _value;
            set => _value = value;
        }
    }
}