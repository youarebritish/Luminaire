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

namespace Black.Entity.Data.Menu
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class SwfStringArrayItem : Black.Entity.Data.Menu.SwfArrayItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string Value= string.Empty;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SwfStringArrayItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Menu.SwfStringArrayItem", 0, Black.Entity.Data.Menu.SwfStringArrayItem.ObjectType, Construct, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Menu.SwfStringArrayItem", base.GetFieldProperties(), 98320589, -398879377);
            
			
			
			fieldProperties.AddProperty(new Property("Value", 3511155050, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new SwfStringArrayItem();
        }
		
    }
}