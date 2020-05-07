using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class DungeonLevelItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int level_;
		public UnityEngine.Vector4 offset_;
		public string filePath_;
		public bool isCamp_;
		public UnityEngine.Vector4 campOffset_;
		public uint stayPlaceID_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new DungeonLevelItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.DungeonLevelItem", 0, Black.Sequence.Action.Level.DungeonLevelItem.ObjectType, null, properties, 0, 96);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.DungeonLevelItem", base.GetFieldProperties(), 1497696508, -1699292372);
            
			
			
			fieldProperties.AddProperty(new Property("level_", 1967616422, "int", 8, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("offset_", 1294275471, "Luminous.Math.VectorA", 16, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("filePath_", 956091201, "Ebony.Base.String", 32, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCamp_", 3808541089, "bool", 48, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("campOffset_", 799198608, "Luminous.Math.VectorA", 64, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("stayPlaceID_", 3291481715, "SQEX.Ebony.Std.Fixid", 80, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}