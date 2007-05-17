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

using System.Collections.Generic;
using Castle.FlexBridge.ActionScript;
using Castle.FlexBridge.Serialization;

namespace Castle.FlexBridge.Messaging.Messages
{
    /// <summary>
    /// This interface defines the contract for Adobe Flex (tm) message objects.
    /// </summary>
    /// <remarks>
    /// This is a built-in message type ported from Adobe Flex 2 (tm) libraries.
    /// Refer to Adobe Flex (tm) documentation for more details.
    /// </remarks>
    public interface IMessage
    {
        /// <summary>
        /// The body of a message contains the specific data that needs to be delivered to the remote destination.
        /// </summary>
        [ActionScriptProperty("body")]
        object Body { get; set; }

        /// <summary>
        /// The clientId indicates which MessageAgent sent the message.
        /// </summary>
        [ActionScriptProperty("clientId")]
        string ClientId { get; set; }

        /// <summary>
        /// The message destination.
        /// </summary>
        [ActionScriptProperty("destination")]
        string Destination { get; set; }

        /// <summary>
        /// Provides access to the headers of the message.
        /// The headers of a message are an associative array where the key is the
        /// header name and the value is the header value.
        /// </summary>
        [ActionScriptProperty("headers")]
        IDictionary<string, object> Headers { get; set; }

        /// <summary>
        /// The unique id for the message.
        /// The message id can be used to correlate a response to the original request
        /// message in request-response messaging scenarios. 
        /// </summary>
        [ActionScriptProperty("messageId")]
        string MessageId { get; set; }


        /// <summary>
        /// Provides access to the time stamp for the message.
        /// A time stamp is the date and time that the message was sent.
        /// The time stamp is used for tracking the message through the system,
        /// ensuring quality of service levels and providing a mechanism for expiration. 
        /// </summary>
        [ActionScriptProperty("timestamp")]
        double Timestamp { get; set; }

        /// <summary>
        /// The time to live value of a message indicates how long the message should be
        /// considered valid and deliverable. This value works in conjunction with the
        /// timestamp value. Time to live is the number of milliseconds that this message
        /// remains valid starting from the specified timestamp value. For example, if
        /// the timestamp value is 04/05/05 1:30:45 PST and the timeToLive value is 5000,
        /// then this message will expire at 04/05/05 1:30:50 PST. Once a message expires
        /// it will not be delivered to any other clients. 
        /// </summary>
        double TimeToLive { get; set; }
    }
}