using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Actor.Material
{
    public partial class SequenceActionTimeLineActorMaterialBoolTrack : Black.Sequence.Action.TimeLine.Actor.Material.SequenceActionTimeLineActorMaterialTrackCommon
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool value_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineActorMaterialBoolTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Actor.Material.SequenceActionTimeLineActorMaterialBoolTrack", 0, Black.Sequence.Action.TimeLine.Actor.Material.SequenceActionTimeLineActorMaterialBoolTrack.ObjectType, null, properties, 0, 432);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Actor.Material.SequenceActionTimeLineActorMaterialBoolTrack", base.GetFieldProperties(), -268829013, -1581687174);
            
			fieldProperties.AddProperty(new Property("value_", 273093519, "bool", 416, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			
			
			return fieldProperties;
        }

		
    }
}