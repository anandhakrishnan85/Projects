// Copyright 2004-2008 Castle Project - http://www.castleproject.org/
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

namespace Castle.MonoRail.Rest
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Castle.MonoRail.Framework;
	using Castle.Core;
	using Castle.MonoRail.Framework.Services;

	public class DefaultUrlProvider : IServiceEnabledComponent
	{
		private IControllerTree controllerTree;
		private IUrlTokenizer urlTokenizer;


		#region IServiceEnabledComponent Members

		public IUrlTokenizer Tokenizer
		{
			get { return urlTokenizer; }
			set { urlTokenizer = value; }
		}

		public void Service(IServiceProvider provider)
		{
			controllerTree = (IControllerTree)provider.GetService(typeof(IControllerTree));
			urlTokenizer = (IUrlTokenizer)provider.GetService(typeof(IUrlTokenizer));


			
			if (controllerTree != null && urlTokenizer != null)
			{
				controllerTree.ControllerAdded += this.ControllerAddedToTree;
			}
		}

		#endregion

		public void ControllerAddedToTree(object sender, ControllerAddedEventArgs args)
		{

			//If in a virtual directory I need to prepend a slash

			string url = args.Area + "/" + args.ControllerName + ".rails";
			urlTokenizer.AddDefaultRule(url, args.Area, args.ControllerName, "collection");
			urlTokenizer.AddDefaultRule("/" + url, args.Area, args.ControllerName, "collection");
		}
	}
}
