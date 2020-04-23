﻿/*
 * Magic, Copyright(c) Thomas Hansen 2019 - 2020, thomas@servergardens.com, all rights reserved.
 * See the enclosed LICENSE file for details.
 */

using System.IO;
using magic.node;
using magic.signals.contracts;

namespace magic.backend.slots
{
    /// <summary>
    /// [load-app-settings] slot returning the entire contents of appsettings.json file raw to caller.
    /// </summary>
    [Slot(Name = "load-app-settings")]
    public class LoadAppSettings : ISlot
    {
        /// <summary>
        /// Implementation of signal
        /// </summary>
        /// <param name="signaler">Signaler used to signal</param>
        /// <param name="input">Parameters passed from signaler</param>
        public void Signal(ISignaler signaler, Node input)
        {
            input.Value = File.ReadAllText(
                Directory.GetCurrentDirectory().Replace("\\", "/").TrimEnd('/') +
                "/appsettings.json");
        }
    }
}
