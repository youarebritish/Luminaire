using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.CharacterEntry
{
    public partial class CharacterEntryMaterialParamArrayItem : Black.Entity.Data.CharacterEntry.CharacterEntryArrayItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int Type;
		public string MaterialName;
		public string ParamName;
		public float Value;
		public UnityEngine.Vector4 VectorValue;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CharacterEntryMaterialParamArrayItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.CharacterEntry.CharacterEntryMaterialParamArrayItem", 0, Black.Entity.Data.CharacterEntry.CharacterEntryMaterialParamArrayItem.ObjectType, null, properties, 0, 80);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.CharacterEntry.CharacterEntryMaterialParamArrayItem", base.GetFieldProperties(), -1833237775, 762505244);
            
			
			
			return fieldProperties;
        }

		
    }
}