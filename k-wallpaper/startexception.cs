using System;
using System.Runtime.Serialization;

namespace k_wallpaper
{
    /// <summary>
    /// 初始化异常
    /// </summary>
    [Serializable]
    public class startexception : Exception
    {
        /// <summary>
        /// 导致异常的函数名
        /// </summary>
        public string Function { get; set; }

        public startexception()
        {
        }

        public startexception(string message, string function) : base(message)
        {
            Function = function;
        }

    }
}
