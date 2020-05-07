using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.CharacterEntry
{
    public partial class CharaEntryPackage : Black.Entity.EntityPackage
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int loadPriority_;
		public string specialID_;
		public bool unloadWithLoadUnit_;
		public bool noAutoLoad_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> noAutoLoadCharaEntryFixIDList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CharaEntryPackage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.CharacterEntry.CharaEntryPackage", 0, Black.Entity.Data.CharacterEntry.CharaEntryPackage.ObjectType, null, properties, 0, 672);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.CharacterEntry.CharaEntryPackage", base.GetFieldProperties(), 746367485, -1612267195);
            
			fieldProperties.AddProperty(new Property("loadPriority_", 3386041302, "Black.Entity.Data.CharacterEntry.CharaEntryPackage.LOAD_PRIORITY", 608, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("specialID_", 1885593974, "SQEX.Ebony.Base.String", 616, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("unloadWithLoadUnit_", 4200952821, "bool", 632, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("noAutoLoad_", 1577118962, "bool", 633, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("noAutoLoadCharaEntryFixIDList_", 1027490259, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem* >", 640, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}