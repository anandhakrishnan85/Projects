﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
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
    public partial class VirtualPropertyTestClass : ActiveRecordBase<VirtualPropertyTestClass> {
        
        private string _virtualProperty;
        
        [Property(ColumnType="String")]
        public virtual string VirtualProperty {
            get {
                return this._virtualProperty;
            }
            set {
                this._virtualProperty = value;
            }
        }
    }
}
