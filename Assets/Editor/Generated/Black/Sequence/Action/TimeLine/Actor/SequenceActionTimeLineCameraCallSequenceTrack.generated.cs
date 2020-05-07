using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Actor
{
    public partial class SequenceActionTimeLineCameraCallSequenceTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineDurationTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor2Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin vector1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin float1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin int1Pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraCallSequenceTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineCameraCallSequenceTrack", 0, Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineCameraCallSequenceTrack.ObjectType, null, properties, 0, 912);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineCameraCallSequenceTrack", base.GetFieldProperties(), -249097596, 38270769);
            
			
			
			return fieldProperties;
        }

		
    }
}