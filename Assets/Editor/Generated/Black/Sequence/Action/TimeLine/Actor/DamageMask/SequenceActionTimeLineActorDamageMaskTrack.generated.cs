using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Actor.DamageMask
{
    public partial class SequenceActionTimeLineActorDamageMaskTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineDurationTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int type_;
		public float contiuousTime_;
		public float fadeoutTime_;
		public float radius_;
		public float power_;
		public float concentration_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin damageSpherePosPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineActorDamageMaskTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Actor.DamageMask.SequenceActionTimeLineActorDamageMaskTrack", 0, Black.Sequence.Action.TimeLine.Actor.DamageMask.SequenceActionTimeLineActorDamageMaskTrack.ObjectType, null, properties, 0, 528);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Actor.DamageMask.SequenceActionTimeLineActorDamageMaskTrack", base.GetFieldProperties(), -1246048972, -136049654);
            
			fieldProperties.AddProperty(new Property("type_", 3554705238, "Black.Sequence.Action.TimeLine.Actor.DamageMask.SequenceActionTimeLineActorDamageMaskTrack.DamageMaskType", 400, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("contiuousTime_", 93596058, "float", 404, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeoutTime_", 3863122145, "float", 408, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("radius_", 2286360452, "float", 412, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("power_", 1150566491, "float", 416, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("concentration_", 529123403, "float", 420, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("damageSpherePosPin_", 25802229, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 424, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}