﻿namespace Bing.Caching.Abstractions
{
    /// <summary>
    /// 缓存终端
    /// </summary>
    public interface ICacheEndpoint
    {
        /// <summary>
        /// 主机
        /// </summary>
        string Host { get; set; }

        /// <summary>
        /// 端口号
        /// </summary>
        int Port { get; set; }

        /// <summary>
        /// 获取连接字符串
        /// </summary>
        /// <returns></returns>
        string GetConnectionString();
    }
}
