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
    
    
    public partial class NHQGWithNHOne {
        
        private System.Nullable<int> _id;
        
        private string _name;
        
        private IList<NHQGWithNHMany> _nHQGWithNHManies;
        
        public System.Nullable<int> Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        public string Name {
            get {
                return this._name;
            }
            set {
                this._name = value;
            }
        }
        
        public IList<NHQGWithNHMany> NHQGWithNHManies {
            get {
                return this._nHQGWithNHManies;
            }
            set {
                this._nHQGWithNHManies = value;
            }
        }
    }
    
    public partial class NHQGWithNHMany {
        
        private System.Nullable<int> _id;
        
        private string _name;
        
        private NHQGWithNHOne _nHQGWithNHOne;
        
        public System.Nullable<int> Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        public string Name {
            get {
                return this._name;
            }
            set {
                this._name = value;
            }
        }
        
        public NHQGWithNHOne NHQGWithNHOne {
            get {
                return this._nHQGWithNHOne;
            }
            set {
                this._nHQGWithNHOne = value;
            }
        }
    }
}
