using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.Ambient
{
    public partial class AmbientSpawnPointEntity : Black.AI.Ambient.AmbientActPoint
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint archeType_;
		public IList<Black.AI.Ambient.AmbientArchetypeArrayItem> additionalArchetypes_;
		public uint initScript_;
		public bool spawnInCamera_;
		public int priority_;
		public int actorMode_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AmbientSpawnPointEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.Ambient.AmbientSpawnPointEntity", 0, Black.AI.Ambient.AmbientSpawnPointEntity.ObjectType, null, properties, 0, 384);
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

            fieldProperties = new PropertyContainer("Black.AI.Ambient.AmbientSpawnPointEntity", base.GetFieldProperties(), 2066299506, -1684836506);
            
			fieldProperties.AddProperty(new Property("archeType_", 2117969097, "SQEX.Ebony.Std.Fixid", 304, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("additionalArchetypes_", 716462357, "SQEX.Ebony.Std.DynamicArray< Black.AI.Ambient.AmbientArchetypeArrayItem* >", 312, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("initScript_", 2532876081, "SQEX.Ebony.Std.Fixid", 328, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("spawnInCamera_", 683679205, "bool", 332, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("priority_", 3125928034, "Black.AI.Ambient.SpawnPriority", 336, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorMode_", 1880764250, "Black.AI.Ambient.AmbientSpawnPointActorMode", 340, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}