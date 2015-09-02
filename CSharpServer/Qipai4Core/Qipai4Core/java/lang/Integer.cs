﻿/*
* SilverFoxServer: massive multiplayer game server for Flash, ...
* VERSION:3.0
* PUBLISH DATE:2015-9-2 
* GITHUB:github.com/wdmir/521266750_qq_com
* UPDATES AND DOCUMENTATION AT: http://www.silverfoxserver.net
* COPYRIGHT 2009-2015 SilverFoxServer.NET. All rights reserved.
* MAIL:521266750@qq.com
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace java.lang
{
    public class Integer
    {

        public static int parseInt(String s)
        {
            return valueOf(s, 10);
        }

        public static int valueOf(String s)
        {
            return valueOf(s, 10);
        }

        public static int valueOf(String s, int radix)
        {
            return Convert.ToInt32(s,radix);
        }



    }
}