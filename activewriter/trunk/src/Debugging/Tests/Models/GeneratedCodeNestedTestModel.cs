﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Debugging.Tests {
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using Castle.ActiveRecord;
    
    
    [ActiveRecord()]
    public partial class NestingClass1 : ActiveRecordBase<NestingClass1> {
        
        private NestedClass1 _nestedClass1;
        
        private NestedClass2 _customizedName;
        
        [Nested("columnPrefix", MapType=typeof(NestedClass1), Insert=true, Update=true)]
        public virtual NestedClass1 NestedClass1 {
            get {
                return this._nestedClass1;
            }
            set {
                this._nestedClass1 = value;
            }
        }
        
        [Nested(Insert=true, Update=true)]
        public virtual NestedClass2 CustomizedName {
            get {
                return this._customizedName;
            }
            set {
                this._customizedName = value;
            }
        }
    }
    
    public partial class NestedClass1 {
        
        private string _nestedClass1Property;
        
        [Property(ColumnType="String")]
        public virtual string NestedClass1Property {
            get {
                return this._nestedClass1Property;
            }
            set {
                this._nestedClass1Property = value;
            }
        }
    }
    
    public partial class NestedClass2 {
    }
}
