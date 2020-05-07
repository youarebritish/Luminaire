using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Vehicle
{
    public partial class SequenceActionGetPositionOnCurve : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inBaseActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inDistance_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inIsFrontOfBase_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failure_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin curvePos_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin curveDir_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin curveRight_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin distanceToPos_;
		public float distance_;
		public bool isFrontOfBase_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetPositionOnCurve();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Vehicle.SequenceActionGetPositionOnCurve", 0, Black.Sequence.Action.Vehicle.SequenceActionGetPositionOnCurve.ObjectType, null, properties, 0, 1096);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Vehicle.SequenceActionGetPositionOnCurve", base.GetFieldProperties(), 1613419617, 602484320);
            return fieldProperties;
        }

		
    }
}