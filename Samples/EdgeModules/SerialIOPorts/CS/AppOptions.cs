﻿//
// Copyright (c) Microsoft. All rights reserved.
//
using Mono.Options;
using System;
using System.Collections.Generic;

namespace SampleModule
{
    public class AppOptions: EdgeModuleSamples.Common.Options.SpbAppOptions
    {
        public bool ShowConfig { get; private set; }
        public bool Receive { get; private set; }
        public bool Transmit { get; private set; }
        public bool UseEdge => ! base.Test;
        public bool Exit { get; private set; } = false;

        public AppOptions()
        {
            Add( "r|receive", "receive and display packets", v => Receive = v != null);
            Add( "s|send", "send packets (combine with -r for loopback)", v => Transmit = v != null);
            Add( "c|config", "display device configuration", v => ShowConfig = v != null);
        }
    }
}
