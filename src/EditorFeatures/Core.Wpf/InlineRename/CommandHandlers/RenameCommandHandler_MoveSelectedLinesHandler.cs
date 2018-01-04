﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using Microsoft.VisualStudio.Commanding;
using Microsoft.VisualStudio.Text.Editor.Commanding.Commands;
using VSCommanding = Microsoft.VisualStudio.Commanding;

namespace Microsoft.CodeAnalysis.Editor.Implementation.InlineRename
{
    internal partial class RenameCommandHandler :
        IChainedCommandHandler<MoveSelectedLinesUpCommandArgs>, IChainedCommandHandler<MoveSelectedLinesDownCommandArgs>
    {
        public VSCommanding.CommandState GetCommandState(MoveSelectedLinesUpCommandArgs args, Func<VSCommanding.CommandState> nextHandler)
        {
            return nextHandler();
        }

        public void ExecuteCommand(MoveSelectedLinesUpCommandArgs args, Action nextHandler, CommandExecutionContext context)
        {
            CommitIfActiveAndCallNextHandler(args, nextHandler);
        }

        public VSCommanding.CommandState GetCommandState(MoveSelectedLinesDownCommandArgs args, Func<VSCommanding.CommandState> nextHandler)
        {
            return nextHandler();
        }

        public void ExecuteCommand(MoveSelectedLinesDownCommandArgs args, Action nextHandler, CommandExecutionContext context)
        {
            CommitIfActiveAndCallNextHandler(args, nextHandler);
        }
    }
}
