// Copyright 2006 Gokhan Altinoren - http://altinoren.com/
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

namespace Altinoren.ActiveWriter
{
    using System.CodeDom;
    using CodeGeneration;

    public partial class ManyToOneRelation
    {
        public CodeAttributeDeclaration GetHasManyAttribute()
        {
            CodeAttributeDeclaration attribute = new CodeAttributeDeclaration("HasMany");

            attribute.Arguments.Add(AttributeHelper.GetPrimitiveTypeAttributeArgument(CodeGenerationContext.GetTypeDeclaration(Source).Name));
            if (TargetAccess != PropertyAccess.Property)
                attribute.Arguments.Add(AttributeHelper.GetNamedEnumAttributeArgument("Access", "PropertyAccess", TargetAccess));
            if (TargetCache != CacheEnum.Undefined)
                attribute.Arguments.Add(AttributeHelper.GetNamedEnumAttributeArgument("Cache", "CacheEnum", TargetCache));
            if (TargetCascade != ManyRelationCascadeEnum.None)
                attribute.Arguments.Add(AttributeHelper.GetNamedEnumAttributeArgument("Cascade", "ManyRelationCascadeEnum", TargetCascade));
            if (!string.IsNullOrEmpty(TargetColumnKey))
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("ColumnKey", TargetColumnKey));
            if (!string.IsNullOrEmpty(TargetCustomAccess))
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("CustomAccess", TargetCustomAccess));
            if (TargetRelationType == RelationType.Map)
            {
                // TODO: Index & IndexType ?
            }
            if (TargetInverse)
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("Inverse", TargetInverse));
            if (TargetLazy)
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("Lazy", TargetLazy));
			if (TargetFetch != FetchEnum.Unspecified)
				attribute.Arguments.Add(AttributeHelper.GetNamedEnumAttributeArgument("Fetch", "FetchEnum", TargetFetch));
			if (!string.IsNullOrEmpty(TargetMapType))
                attribute.Arguments.Add(AttributeHelper.GetNamedTypeAttributeArgument("MapType", TargetMapType));
            if (!string.IsNullOrEmpty(TargetOrderBy))
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("OrderBy", TargetOrderBy));
            if (TargetRelationType != RelationType.Guess)
                attribute.Arguments.Add(
                    AttributeHelper.GetNamedEnumAttributeArgument("RelationType", "RelationType", TargetRelationType));
            if (!string.IsNullOrEmpty(TargetSchema))
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("Schema", TargetSchema));
            if (TargetRelationType == RelationType.Set && !string.IsNullOrEmpty(TargetSort))
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("Sort", TargetSort));
            if (!string.IsNullOrEmpty(TargetTable))
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("Table", TargetTable));
            if (!string.IsNullOrEmpty(TargetWhere))
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("Where", TargetWhere));
            if (TargetNotFoundBehaviour != NotFoundBehaviour.Default)
                attribute.Arguments.Add(
                    AttributeHelper.GetNamedEnumAttributeArgument("NotFoundBehaviour", "NotFoundBehaviour",
                                                  TargetNotFoundBehaviour));
            if (!string.IsNullOrEmpty(TargetIndexType))
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("IndexType", TargetIndexType));
            if (!string.IsNullOrEmpty(TargetIndex))
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("Index", TargetIndex));
            if (!string.IsNullOrEmpty(TargetElement))
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("Element", TargetElement));

            return attribute;
        }

        public CodeAttributeDeclaration GetBelongsToAttribute()
        {
            CodeAttributeDeclaration attribute = new CodeAttributeDeclaration("BelongsTo");
            if (!string.IsNullOrEmpty(SourceColumn))
                attribute.Arguments.Add(AttributeHelper.GetPrimitiveAttributeArgument(SourceColumn));
            if (SourceCascade != CascadeEnum.None)
                attribute.Arguments.Add(AttributeHelper.GetNamedEnumAttributeArgument("Cascade", "CascadeEnum", SourceCascade));
            if (!string.IsNullOrEmpty(SourceCustomAccess))
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("CustomAccess", SourceCustomAccess));
            if (!SourceInsert)
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("Insert", SourceInsert));
            if (SourceNotNull)
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("NotNull", SourceNotNull));
            if (SourceOuterJoin != OuterJoinEnum.Auto)
                attribute.Arguments.Add(
                    AttributeHelper.GetNamedEnumAttributeArgument("OuterJoin", "OuterJoinEnum", SourceOuterJoin));
            if (!string.IsNullOrEmpty(SourceType))
                attribute.Arguments.Add(AttributeHelper.GetNamedTypeAttributeArgument("Type", SourceType));
            if (SourceUnique)
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("Unique", SourceUnique));
            if (!SourceUpdate)
                attribute.Arguments.Add(AttributeHelper.GetNamedAttributeArgument("Update", SourceUpdate));
            if (SourceNotFoundBehaviour != NotFoundBehaviour.Default)
                attribute.Arguments.Add(AttributeHelper.GetNamedEnumAttributeArgument("NotFoundBehaviour", "NotFoundBehaviour", SourceNotFoundBehaviour));

            return attribute;
        }
    }
}
