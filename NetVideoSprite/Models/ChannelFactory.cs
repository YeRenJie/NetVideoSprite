using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace NetVideoSprite
{
    public  class ChannelFactory
    {
        /// <summary>
        /// 简单工厂实例化对象
        /// </summary>
        /// <param name="type">频道类型</param>
        /// <returns>channel实例</returns>
        public static ChannelBase CreateChannel(string type)
        {
            ChannelBase channel = null;
            switch (type)
            {
                case "TypeA":
                     channel = new TypeAChannel();
                     break;
                case "TypeB" :
                    channel = new TypeBChannel();
                     break;
                default:
                    break;
            }
            return channel;
        }
     
    }
}
