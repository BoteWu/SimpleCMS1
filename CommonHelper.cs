using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SimpleCMS
{
    public class CommonHelper
    {
        public static T GetConfigValue<T>(string hashKey, T defaultValue)
        {
            try
            {
                var value = ConfigurationManager.AppSettings[hashKey];
                if (value == null)
                    return defaultValue;
                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}