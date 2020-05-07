using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Actor.Material
{
    public partial class SequenceActionTimeLineActorMaterialIntTrack : Black.Sequence.Action.TimeLine.Actor.Material.SequenceActionTimeLineActorMaterialTrackCommon
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int value_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineActorMaterialIntTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Actor.Material.SequenceActionTimeLineActorMaterialIntTrack", 0, Black.Sequence.Action.TimeLine.Actor.Material.SequenceActionTimeLineActorMaterialIntTrack.ObjectType, null, properties, 0, 432);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Actor.Material.SequenceActionTimeLineActorMaterialIntTrack", base.GetFieldProperties(), -1289302363, 364926116);
            
			fieldProperties.AddProperty(new Property("value_", 273093519, "int", 416, 4, 1, Property.PrimitiveType.Int32, 0, (char)1));
			
			
			return fieldProperties;
        }

		
    }
}