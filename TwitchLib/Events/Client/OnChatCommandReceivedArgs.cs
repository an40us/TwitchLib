﻿using System;
using TwitchLib.Models.Client;

namespace TwitchLib.Events.Client
{
    /// <inheritdoc />
    /// <summary>Args representing chat command received event.</summary>
    public class OnChatCommandReceivedArgs : EventArgs
    {
        /// Property representing received command.
        public ChatCommand Command;
    }
}
