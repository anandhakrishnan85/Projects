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
    public partial class Blog : ActiveRecordBase<Blog> {
        
        private System.Nullable<int> _id;
        
        private string _name;
        
        private string _author;
        
        private IList<Post> _posts;
        
        [PrimaryKey(PrimaryKeyType.Native, ColumnType="Int32")]
        public System.Nullable<int> Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        [Property(ColumnType="String")]
        public string Name {
            get {
                return this._name;
            }
            set {
                this._name = value;
            }
        }
        
        [Property(ColumnType="String")]
        public string Author {
            get {
                return this._author;
            }
            set {
                this._author = value;
            }
        }
        
        [HasMany(typeof(Post), ColumnKey="BlogId", Table="Blog")]
        public IList<Post> Posts {
            get {
                return this._posts;
            }
            set {
                this._posts = value;
            }
        }
    }
    
    [ActiveRecord()]
    public partial class Post : ActiveRecordBase<Post> {
        
        private string _category;
        
        private string _title;
        
        private string _content;
        
        private System.Nullable<int> _id;
        
        private Blog _blog;
        
        [Property(ColumnType="String")]
        public string Category {
            get {
                return this._category;
            }
            set {
                this._category = value;
            }
        }
        
        [Property(ColumnType="String")]
        public string Title {
            get {
                return this._title;
            }
            set {
                this._title = value;
            }
        }
        
        [Property(ColumnType="String")]
        public string Content {
            get {
                return this._content;
            }
            set {
                this._content = value;
            }
        }
        
        [PrimaryKey(PrimaryKeyType.Native, ColumnType="Int32")]
        public System.Nullable<int> Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        [BelongsTo("BlogId")]
        public Blog Blog {
            get {
                return this._blog;
            }
            set {
                this._blog = value;
            }
        }
    }
}
