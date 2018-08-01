using log4net;
using System;
using System.IO;

namespace HK.PEIS.Utility.Helper
{
    /// <summary>
    /// 日志帮助类
    /// </summary>
    public class LogHelper
    {
        private static readonly ILog LogInfo = LogManager.GetLogger("LogInfo");
        private static readonly ILog LogError = LogManager.GetLogger("LogError");
        private static readonly ILog LogMonitor = LogManager.GetLogger("LogMonitor");

        static LogHelper()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + @"\Log4net.config";
            log4net.Config.XmlConfigurator.Configure(new FileInfo(path));
        }
        /// <summary>
        /// 设置log4net配置文件
        /// </summary>
        public static void SetConfig()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        /// <summary>
        /// 设置log4net配置文件
        /// </summary>
        /// <param name="confFile">文件信息</param>
        public static void SetConfig(FileInfo confFile)
        {
            log4net.Config.XmlConfigurator.Configure(confFile);
        }

        /// <summary>
        /// 错误日志
        /// </summary>
        /// <param name="errorMsg"></param>
        /// <param name="ex"></param>
        public static void Error(string errorMsg, System.Exception ex = null)
        {
            if (ex != null)
            {
                LogError.Error(errorMsg, ex);
            }
            else
            {
                LogError.Error(errorMsg);
            }
        }

        /// <summary>
        /// 日志信息
        /// </summary>
        /// <param name="msg"></param>
        public static void Info(string msg)
        {
            LogInfo.Info(msg);
        }

        /// <summary>
        /// 监控日志
        /// </summary>
        /// <param name="msg"></param>
        public static void Monitor(string msg)
        {
            LogMonitor.Info(msg);
        }
    }
}
