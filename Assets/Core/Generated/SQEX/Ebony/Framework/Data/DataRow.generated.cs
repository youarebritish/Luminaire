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

namespace SQEX.Ebony.Framework.Data
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class DataRow : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		[UnityEngine.SerializeReference] public List<SQEX.Ebony.Framework.Data.DataCell> dataCellList_= new List<SQEX.Ebony.Framework.Data.DataCell>();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new DataRow();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Data.DataRow", 0, SQEX.Ebony.Framework.Data.DataRow.ObjectType, Construct, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Data.DataRow", base.GetFieldProperties(), 479585781, 678677804);
            
			
			
			fieldProperties.AddProperty(new Property("dataCellList_", 1597745162, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Data.DataCell* >", 8, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new DataRow();
        }
		
    }
}