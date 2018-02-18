﻿using System;

namespace TwitchLib.Exceptions.API.UploadVideo.UploadVideoPart
{
    /// <inheritdoc />
    /// <summary>Exception thrown when this library detects the part is invalid.</summary>
    public class BadPartException : Exception
    {
        /// <inheritdoc />
        /// <summary>Exception constructor</summary>
        public BadPartException(string apiData)
            : base(apiData)
        {
        }
    }
}
