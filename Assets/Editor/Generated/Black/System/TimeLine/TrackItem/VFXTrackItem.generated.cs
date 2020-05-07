using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem
{
    public partial class VFXTrackItem : Black.System.TimeLine.TrackItem.VFXTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 position_;
		public UnityEngine.Vector4 rotation_;
		public UnityEngine.Vector4 scaling_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new VFXTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.VFXTrackItem", 0, Black.System.TimeLine.TrackItem.VFXTrackItem.ObjectType, null, properties, 0, 208);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.VFXTrackItem", base.GetFieldProperties(), 1431599124, -169508573);
            
			fieldProperties.AddIndirectlyProperty(new Property("name_", 182823483, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startTime_", 140908163, "float", 24, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("duration_", 1282328598, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sourcePath_", 341055184, "Ebony.Base.String", 136, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("leafId_", 2513060509, "SQEX.Ebony.Std.Fixid", 152, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 160, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 176, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("scaling_", 3325430311, "Luminous.Math.VectorA", 192, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}