//----------------------
// <auto-generated>
// This file was automatically generated. Any changes to it will be lost if and when the file is regenerated.
// </auto-generated>
//----------------------
#pragma warning disable

using System;
using SQEX.Luminous.Core.Object;
using System.Collections.Generic;
using CodeDom = System.CodeDom;

namespace Black.Entity.Data.Area
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class HyperLodItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		[UnityEngine.SerializeReference] public List<Black.Entity.Data.Area.MapLodItem> hyperLowItemList_= new List<Black.Entity.Data.Area.MapLodItem>();
		[UnityEngine.SerializeReference] public List<Black.Entity.Data.Area.MapLodItem> lodItemList_= new List<Black.Entity.Data.Area.MapLodItem>();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new HyperLodItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Area.HyperLodItem", 0, Black.Entity.Data.Area.HyperLodItem.ObjectType, Construct, properties, 0, 48);
        }
		
        public override ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected override PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Entity.Data.Area.HyperLodItem", base.GetFieldProperties(), 1121485182, 605620577);
            
			
			
			fieldProperties.AddProperty(new Property("hyperLowItemList_", 2017489063, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.Area.MapLodItem* >", 8, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("lodItemList_", 340035472, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.Area.MapLodItem* >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new HyperLodItem();
        }
		
    }
}