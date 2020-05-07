using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Actor.Material
{
    public partial class SequenceActionTimeLineActorMaterialVectorTrack : Black.Sequence.Action.TimeLine.Actor.Material.SequenceActionTimeLineActorMaterialTrackCommon
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 value_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineActorMaterialVectorTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Actor.Material.SequenceActionTimeLineActorMaterialVectorTrack", 0, Black.Sequence.Action.TimeLine.Actor.Material.SequenceActionTimeLineActorMaterialVectorTrack.ObjectType, null, properties, 0, 432);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Actor.Material.SequenceActionTimeLineActorMaterialVectorTrack", base.GetFieldProperties(), -1726964693, -1208146226);
            
			fieldProperties.AddProperty(new Property("value_", 273093519, "Luminous.Math.VectorA", 416, 16, 1, Property.PrimitiveType.Vector4, 0, (char)1));
			
			
			return fieldProperties;
        }

		
    }
}