﻿using System;
using UnityEditor;

namespace Fjord.Common.UnityEditor
{
    /// <summary>
    /// Extension methods for use in custom Editor scripts.
    /// </summary>
    public static class EditorExtensionMethods
    {
        public static T enumValue<T>(this SerializedProperty serializedProperty)
        {
            return (T) Enum.ToObject(typeof (T), serializedProperty.enumValueIndex);
        }
    }
}