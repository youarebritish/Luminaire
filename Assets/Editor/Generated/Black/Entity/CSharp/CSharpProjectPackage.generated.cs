using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.CSharp
{
    public partial class CSharpProjectPackage : Black.Entity.EntityPackage
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> CSharpReferencePathList;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CSharpProjectPackage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.CSharp.CSharpProjectPackage", 0, Black.Entity.CSharp.CSharpProjectPackage.ObjectType, null, properties, 0, 624);
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

            fieldProperties = new PropertyContainer("Black.Entity.CSharp.CSharpProjectPackage", base.GetFieldProperties(), -549068082, 206443784);
            
			fieldProperties.AddProperty(new Property("CSharpReferencePathList", 3635259704, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 608, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			
			
			return fieldProperties;
        }

		
    }
}