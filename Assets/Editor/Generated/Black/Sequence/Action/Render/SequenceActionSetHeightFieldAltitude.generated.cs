using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Render
{
    public partial class SequenceActionSetHeightFieldAltitude : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public float minAltitude_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin minAltitudePin_;
		public float maxAltitude_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin maxAltitudePin_;
		public float scale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin scalePin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetHeightFieldAltitude();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Render.SequenceActionSetHeightFieldAltitude", 0, Black.Sequence.Action.Render.SequenceActionSetHeightFieldAltitude.ObjectType, null, properties, 0, 656);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Render.SequenceActionSetHeightFieldAltitude", base.GetFieldProperties(), 427268417, -868529332);
            return fieldProperties;
        }

		
    }
}