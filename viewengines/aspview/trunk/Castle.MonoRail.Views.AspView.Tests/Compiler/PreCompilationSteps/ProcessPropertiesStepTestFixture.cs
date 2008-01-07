#region license
// Copyright 2006-2007 Ken Egozi http://www.kenegozi.com/
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
#endregion

namespace Castle.MonoRail.Views.AspView.Tests.Compiler.PreCompilationSteps
{
	using AspView.Compiler;
	using AspView.Compiler.PreCompilationSteps;
	using NUnit.Framework;

	[TestFixture]
	public class ProcessPropertiesStepTestFixture : AbstractPreCompilationStepTestFixture
	{
		private static void AssertPropertiesSectionHasBeenRemoved(string viewSource)
		{
			if (Internal.RegularExpressions.PropertiesSection.IsMatch(viewSource))
				Assert.Fail("Properties section has not been removed from view source");
		}

		protected override void CreateStep()
		{
			step = new ProcessPropertiesStep();
		}

		[Test]
		public void Process_WhenEmpty_DoesNotRegisterAnyProperties()
		{
			file.RenderBody = @"
<aspview:properties>
</aspview:properties>
view content";
			step.Process(file);

			Assert.AreEqual(0, file.Properties.Count);

			AssertPropertiesSectionHasBeenRemoved(file.RenderBody);
		}

		[Test]
		public void Process_WhenHasOnlyScriptMarkers_DoesNotRegisterAnyProperties()
		{
			file.RenderBody = @"
<aspview:properties>
<%
%>
</aspview:properties>
view content";
			step.Process(file);

			Assert.AreEqual(0, file.Properties.Count);

			AssertPropertiesSectionHasBeenRemoved(file.RenderBody);
		}

		[Test]
		public void Process_WhenHasRegularProperty_RegistersThatProperty()
		{
			file.RenderBody = @"
<aspview:properties>
<%
string myString;
%>
</aspview:properties>
view content";
			step.Process(file);

			AssertViewPropertyEqual(new ViewProperty("myString", "string", null), "myString");

			AssertPropertiesSectionHasBeenRemoved(file.RenderBody);
		}

		[Test]
		public void Process_WhenHasTwoProperties_RegistersBoth()
		{
			file.RenderBody = @"
<aspview:properties>
<%
string myString;
int myInt;
%>
</aspview:properties>
view content";
			step.Process(file);

			AssertViewPropertyEqual(new ViewProperty("myString", "string", null), "myString");
			AssertViewPropertyEqual(new ViewProperty("myInt", "int", null), "myInt");

			AssertPropertiesSectionHasBeenRemoved(file.RenderBody);
		}

		[Test]
		public void Process_WhenHasDefaultValue_RegistersPropertyWithTheValue()
		{
			file.RenderBody = @"
<aspview:properties>
<%
string myString = ""Sample"";
int myInt;
%>
</aspview:properties>
view content";
			step.Process(file);

			AssertViewPropertyEqual(new ViewProperty("myString", "string", "\"Sample\""), "myString");

			AssertPropertiesSectionHasBeenRemoved(file.RenderBody);
		}


		#region helpers
		private void AssertViewPropertyEqual(ViewProperty expectedProperty, string propertyName)
		{
			Assert.IsTrue(file.Properties.ContainsKey(propertyName), "Property [{0}] is missing.", propertyName);
			ViewProperty actual = file.Properties[propertyName];
			Assert.AreEqual(expectedProperty.Type, actual.Type, "Property [{0}] should be of type [{1}], but was of type [{2}] instead.", propertyName, expectedProperty.Type, actual.Type);
			if (expectedProperty.DefaultValue == null)
				Assert.IsNull(actual.DefaultValue, "Property [{0}] should have had no default value, however a default value of [{1}] was found.", propertyName, actual.DefaultValue);
			else
			{
				Assert.IsNotNull(actual.DefaultValue, "Property [{0}] should have had a default value, however none was found.", propertyName);
				Assert.AreEqual(expectedProperty.DefaultValue, actual.DefaultValue, "Property [{0}] should have had a default value of [{1}], however [{2}] was found.", propertyName, expectedProperty.DefaultValue, actual.DefaultValue);
			}
		}
		#endregion
	}
}