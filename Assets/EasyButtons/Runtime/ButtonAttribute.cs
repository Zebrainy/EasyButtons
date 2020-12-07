﻿namespace EasyButtons
{
    using System;

    public enum ButtonMode
    {
        AlwaysEnabled,
        EnabledInPlayMode,
        DisabledInPlayMode
    }

    [Flags]
    public enum ButtonSpacing
    {
        None = 0,
        Before = 1,
        After = 2
    }

    /// <summary>
    /// Attribute to create a button in the inspector for calling the method it is attached to.
    /// The method must have no arguments.
    /// </summary>
    /// <example><code>
    /// [Button]
    /// public void MyMethod()
    /// {
    ///     Debug.Log("Clicked!");
    /// }
    /// </code></example>
    [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public sealed class ButtonAttribute : Attribute
    {
        private readonly string name = null;
        private readonly ButtonMode mode = ButtonMode.AlwaysEnabled;
        private readonly ButtonSpacing spacing = ButtonSpacing.None;

        public string Name => name;
        public ButtonMode Mode => mode;
        public ButtonSpacing Spacing => spacing;

        public ButtonAttribute()
        {
        }

        public ButtonAttribute(string name)
        {
            this.name = name;
        }

        public ButtonAttribute(ButtonMode mode)
        {
            this.mode = mode;
        }

        public ButtonAttribute(ButtonSpacing spacing)
        {
            this.spacing = spacing;
        }

        public ButtonAttribute(string name, ButtonMode mode)
        {
            this.name = name;
            this.mode = mode;
        }

        public ButtonAttribute(string name, ButtonSpacing spacing)
        {
            this.name = name;
            this.spacing = spacing;
        }

        public ButtonAttribute(string name, ButtonMode mode, ButtonSpacing spacing)
        {
            this.name = name;
            this.mode = mode;
            this.spacing = spacing;
        }
    }
}
