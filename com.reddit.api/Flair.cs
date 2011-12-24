﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.reddit.api
{
    public sealed class Flair
    {
        #region // Properties //
        public string User
        {
            get;
            set;
        }

        public string CssClass
        {
            get;
            set;
        }

        public string Text
        {
            get;
            set;
        }
        #endregion

        #region // Data Access //

        public static FlairListing GetFlair(Session session, string sub)
        {
            return GetFlair(session, sub, string.Empty);
        }

        public static FlairListing GetFlair(Session session, string sub, string after)
        {
            return GetFlair(session, sub, string.Empty, string.Empty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        /// <param name="sub"></param>
        /// <see cref="https://github.com/reddit/reddit/wiki/API%3A-flairlist"/>
        /// <returns></returns>
        public static FlairListing GetFlair(Session session, string sub, string after, string before)
        {
            // http://www.reddit.com/api/flairlist
            throw new NotImplementedException();
        }

        #endregion

    }
}
