//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Beetle.Redis
{
    
    
    /// <summary>
    /// The RedisClientSection Configuration Section.
    /// </summary>
    public partial class RedisClientSection : global::System.Configuration.ConfigurationSection
    {
        
        #region Singleton Instance
        /// <summary>
        /// The XML name of the RedisClientSection Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string RedisClientSectionSectionName = "redisClientSection";
        
        /// <summary>
        /// Gets the RedisClientSection instance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public static global::Beetle.Redis.RedisClientSection Instance
        {
            get
            {
                return ((global::Beetle.Redis.RedisClientSection)(global::System.Configuration.ConfigurationManager.GetSection(global::Beetle.Redis.RedisClientSection.RedisClientSectionSectionName)));
            }
        }
        #endregion
        
        #region Xmlns Property
        /// <summary>
        /// The XML name of the <see cref="Xmlns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string XmlnsPropertyName = "xmlns";
        
        /// <summary>
        /// Gets the XML namespace of this Configuration Section.
        /// </summary>
        /// <remarks>
        /// This property makes sure that if the configuration file contains the XML namespace,
        /// the parser doesn't throw an exception because it encounters the unknown "xmlns" attribute.
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Redis.RedisClientSection.XmlnsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Xmlns
        {
            get
            {
                return ((string)(base[global::Beetle.Redis.RedisClientSection.XmlnsPropertyName]));
            }
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region DB Property
        /// <summary>
        /// The XML name of the <see cref="DB"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string DBPropertyName = "dB";
        
        /// <summary>
        /// Gets or sets the DB.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The DB.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Redis.RedisClientSection.DBPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false, DefaultValue=0)]
        public virtual int DB
        {
            get
            {
                return ((int)(base[global::Beetle.Redis.RedisClientSection.DBPropertyName]));
            }
            set
            {
                base[global::Beetle.Redis.RedisClientSection.DBPropertyName] = value;
            }
        }
        #endregion
        
        #region Cached Property
        /// <summary>
        /// The XML name of the <see cref="Cached"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string CachedPropertyName = "cached";
        
        /// <summary>
        /// Gets or sets the Cached.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Cached.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Redis.RedisClientSection.CachedPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string Cached
        {
            get
            {
                return ((string)(base[global::Beetle.Redis.RedisClientSection.CachedPropertyName]));
            }
            set
            {
                base[global::Beetle.Redis.RedisClientSection.CachedPropertyName] = value;
            }
        }
        #endregion
        
        #region Reads Property
        /// <summary>
        /// The XML name of the <see cref="Reads"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string ReadsPropertyName = "reads";
        
        /// <summary>
        /// Gets or sets the Reads.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Reads.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Redis.RedisClientSection.ReadsPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual global::Beetle.Redis.HostItemCollection Reads
        {
            get
            {
                return ((global::Beetle.Redis.HostItemCollection)(base[global::Beetle.Redis.RedisClientSection.ReadsPropertyName]));
            }
            set
            {
                base[global::Beetle.Redis.RedisClientSection.ReadsPropertyName] = value;
            }
        }
        #endregion
        
        #region Writes Property
        /// <summary>
        /// The XML name of the <see cref="Writes"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string WritesPropertyName = "writes";
        
        /// <summary>
        /// Gets or sets the Writes.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Writes.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Redis.RedisClientSection.WritesPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual global::Beetle.Redis.HostItemCollection Writes
        {
            get
            {
                return ((global::Beetle.Redis.HostItemCollection)(base[global::Beetle.Redis.RedisClientSection.WritesPropertyName]));
            }
            set
            {
                base[global::Beetle.Redis.RedisClientSection.WritesPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace Beetle.Redis
{
    
    
    /// <summary>
    /// The HostItem Configuration Element.
    /// </summary>
    public partial class HostItem : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Host Property
        /// <summary>
        /// The XML name of the <see cref="Host"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string HostPropertyName = "host";
        
        /// <summary>
        /// Gets or sets the Host.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Host.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Redis.HostItem.HostPropertyName, IsRequired=true, IsKey=true, IsDefaultCollection=false)]
        public virtual string Host
        {
            get
            {
                return ((string)(base[global::Beetle.Redis.HostItem.HostPropertyName]));
            }
            set
            {
                base[global::Beetle.Redis.HostItem.HostPropertyName] = value;
            }
        }
        #endregion
        
        #region Connections Property
        /// <summary>
        /// The XML name of the <see cref="Connections"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string ConnectionsPropertyName = "connections";
        
        /// <summary>
        /// Gets or sets the Connections.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Connections.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Beetle.Redis.HostItem.ConnectionsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false, DefaultValue=10)]
        public virtual int Connections
        {
            get
            {
                return ((int)(base[global::Beetle.Redis.HostItem.ConnectionsPropertyName]));
            }
            set
            {
                base[global::Beetle.Redis.HostItem.ConnectionsPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace Beetle.Redis
{
    
    
    /// <summary>
    /// A collection of HostItem instances.
    /// </summary>
    [global::System.Configuration.ConfigurationCollectionAttribute(typeof(global::Beetle.Redis.HostItem), CollectionType=global::System.Configuration.ConfigurationElementCollectionType.AddRemoveClearMapAlternate, AddItemName="add", RemoveItemName="remove", ClearItemsName="clear")]
    public partial class HostItemCollection : global::System.Configuration.ConfigurationElementCollection
    {
        
        #region Constants
        /// <summary>
        /// The XML name of the individual <see cref="global::Beetle.Redis.HostItem"/> instances in this collection.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string HostItemPropertyName = "hostItem";
        #endregion
        
        #region Overrides
        /// <summary>
        /// Gets the type of the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <returns>The <see cref="global::System.Configuration.ConfigurationElementCollectionType"/> of this collection.</returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return global::System.Configuration.ConfigurationElementCollectionType.AddRemoveClearMapAlternate;
            }
        }
        
        /// <summary>
        /// Gets the name used to identify this collection of elements
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        protected override string ElementName
        {
            get
            {
                return global::Beetle.Redis.HostItemCollection.HostItemPropertyName;
            }
        }
        
        /// <summary>
        /// Indicates whether the specified <see cref="global::System.Configuration.ConfigurationElement"/> exists in the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="elementName">The name of the element to verify.</param>
        /// <returns>
        /// <see langword="true"/> if the element exists in the collection; otherwise, <see langword="false"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        protected override bool IsElementName(string elementName)
        {
            return (elementName == global::Beetle.Redis.HostItemCollection.HostItemPropertyName);
        }
        
        /// <summary>
        /// Gets the element key for the specified configuration element.
        /// </summary>
        /// <param name="element">The <see cref="global::System.Configuration.ConfigurationElement"/> to return the key for.</param>
        /// <returns>
        /// An <see cref="object"/> that acts as the key for the specified <see cref="global::System.Configuration.ConfigurationElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
        {
            return ((global::Beetle.Redis.HostItem)(element)).Host;
        }
        
        /// <summary>
        /// Creates a new <see cref="global::Beetle.Redis.HostItem"/>.
        /// </summary>
        /// <returns>
        /// A new <see cref="global::Beetle.Redis.HostItem"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        protected override global::System.Configuration.ConfigurationElement CreateNewElement()
        {
            return new global::Beetle.Redis.HostItem();
        }
        #endregion
        
        #region Indexer
        /// <summary>
        /// Gets the <see cref="global::Beetle.Redis.HostItem"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::Beetle.Redis.HostItem"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public global::Beetle.Redis.HostItem this[int index]
        {
            get
            {
                return ((global::Beetle.Redis.HostItem)(base.BaseGet(index)));
            }
        }
        
        /// <summary>
        /// Gets the <see cref="global::Beetle.Redis.HostItem"/> with the specified key.
        /// </summary>
        /// <param name="host">The key of the <see cref="global::Beetle.Redis.HostItem"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public global::Beetle.Redis.HostItem this[object host]
        {
            get
            {
                return ((global::Beetle.Redis.HostItem)(base.BaseGet(host)));
            }
        }
        #endregion
        
        #region Add
        /// <summary>
        /// Adds the specified <see cref="global::Beetle.Redis.HostItem"/> to the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="hostItem">The <see cref="global::Beetle.Redis.HostItem"/> to add.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public void Add(global::Beetle.Redis.HostItem hostItem)
        {
            base.BaseAdd(hostItem);
        }
        #endregion
        
        #region Remove
        /// <summary>
        /// Removes the specified <see cref="global::Beetle.Redis.HostItem"/> from the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="hostItem">The <see cref="global::Beetle.Redis.HostItem"/> to remove.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public void Remove(global::Beetle.Redis.HostItem hostItem)
        {
            base.BaseRemove(this.GetElementKey(hostItem));
        }
        #endregion
        
        #region GetItem
        /// <summary>
        /// Gets the <see cref="global::Beetle.Redis.HostItem"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::Beetle.Redis.HostItem"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public global::Beetle.Redis.HostItem GetItemAt(int index)
        {
            return ((global::Beetle.Redis.HostItem)(base.BaseGet(index)));
        }
        
        /// <summary>
        /// Gets the <see cref="global::Beetle.Redis.HostItem"/> with the specified key.
        /// </summary>
        /// <param name="host">The key of the <see cref="global::Beetle.Redis.HostItem"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public global::Beetle.Redis.HostItem GetItemByKey(string host)
        {
            return ((global::Beetle.Redis.HostItem)(base.BaseGet(((object)(host)))));
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
    }
}