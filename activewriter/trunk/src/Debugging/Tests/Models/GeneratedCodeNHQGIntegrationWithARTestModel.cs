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
    public partial class NHQGWithAROne : ActiveRecordBase<NHQGWithAROne> {
        
        private int _id;
        
        private string _name;
        
        private IList<NHQGWithARMany> _nHQGWithARManies;
        
        [PrimaryKey(PrimaryKeyType.Native, ColumnType="Int32")]
        public virtual int Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        [Property(ColumnType="String")]
        public virtual string Name {
            get {
                return this._name;
            }
            set {
                this._name = value;
            }
        }
        
        [HasMany(typeof(NHQGWithARMany))]
        public virtual IList<NHQGWithARMany> NHQGWithARManies {
            get {
                return this._nHQGWithARManies;
            }
            set {
                this._nHQGWithARManies = value;
            }
        }
    }
    
    [ActiveRecord()]
    public partial class NHQGWithARMany : ActiveRecordBase<NHQGWithARMany> {
        
        private int _id;
        
        private string _name;
        
        private NHQGWithAROne _nHQGWithAROne;
        
        [PrimaryKey(PrimaryKeyType.Native, ColumnType="Int32")]
        public virtual int Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        [Property(ColumnType="String")]
        public virtual string Name {
            get {
                return this._name;
            }
            set {
                this._name = value;
            }
        }
        
        [BelongsTo()]
        public virtual NHQGWithAROne NHQGWithAROne {
            get {
                return this._nHQGWithAROne;
            }
            set {
                this._nHQGWithAROne = value;
            }
        }
    }
}
