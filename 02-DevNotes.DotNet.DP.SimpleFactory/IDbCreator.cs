﻿namespace DevNotes.DotNet.DP.SimpleFactory
{
    /// <summary>
    /// 定义创建对象接口
    /// </summary>
    public interface IDbCreator
    {
        /// <summary>
        /// 创建方法
        /// </summary>
        void Create();
    }
}
