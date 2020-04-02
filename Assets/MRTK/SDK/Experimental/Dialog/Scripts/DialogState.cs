﻿//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Experimental.Dialog
{
    /// <summary>
    /// Enum that describes the current state of a Dialog.
    /// </summary>
    public enum DialogState
    {
        Uninitialized = 0,
        Opening,
        WaitingForInput,
        InputReceived,
        Closing,
        Closed,
    }
}