// Copyright 2007 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Runtime.Serialization;

namespace Castle.FlexBridge.Serialization
{
    /// <summary>
    /// Exception type thrown when errors occur during ActionScript operations.
    /// </summary>
    [Serializable]
    public class ActionScriptException : Exception
    {
        public ActionScriptException(string message)
            : base(message)
        {
        }

        public ActionScriptException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected ActionScriptException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}