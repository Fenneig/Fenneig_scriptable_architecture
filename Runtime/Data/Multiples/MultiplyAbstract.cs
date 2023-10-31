using System.Collections.Generic;
using UnityEngine;

namespace Fenneig_Scriptable_Architecture.Runtime.Data.Multiples
{
    public class MultiplyAbstract<T> : ScriptableObject
    {
        private Dictionary<int, T> _properties = new();

        public void RegisterEntity(int id, T entityValue)
        {
            if (_properties.ContainsKey(id)) return;
            _properties.Add(id, entityValue);
        }

        public void UnregisterEntity(int id)
        {
            if (_properties.ContainsKey(id))
                _properties.Remove(id);
        }

        public bool TryGetEntity(int id, out T amount)
        {
            amount = default;

            if (_properties.ContainsKey(id))
            {
                amount = _properties[id];
                return true;
            }

            return false;
        }
    }
}