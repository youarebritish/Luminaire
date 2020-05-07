using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Mission
{
    public partial class SequenceActionSetNavMarker : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin positionTargetPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enable_;
		public bool changePosition_;
		public Black.Entity.Map.NavigationMarkerEntity entityPointer_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetNavMarker();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Mission.SequenceActionSetNavMarker", 0, Black.Sequence.Action.Level.Mission.SequenceActionSetNavMarker.ObjectType, null, properties, 0, 472);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Mission.SequenceActionSetNavMarker", base.GetFieldProperties(), 627601432, -145003846);
            return fieldProperties;
        }

		
    }
}