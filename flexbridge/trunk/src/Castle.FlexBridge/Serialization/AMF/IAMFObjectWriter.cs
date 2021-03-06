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
using System.Collections.Generic;
using System.Text;
using Castle.FlexBridge.ActionScript;

namespace Castle.FlexBridge.Serialization.AMF
{
    /// <summary>
    /// An interface for writing AMF objects with type codes.
    /// </summary>
    internal interface IAMFObjectWriter
    {
        /// <summary>
        /// Gets the encoding used by the object writer.
        /// </summary>
        AMFObjectEncoding ObjectEncoding { get; }

        /// <summary>
        /// Resets the object writer in preparation for a new message body.
        /// </summary>
        void Reset();

        /// <summary>
        /// Writes the preamble for initializing the object stream.
        /// </summary>
        void WriteObjectStreamPreamble();

        /// <summary>
        /// Writes an object to the stream.
        /// </summary>
        /// <param name="value">The value to write</param>
        void WriteObject(IASValue value);
    }
}
