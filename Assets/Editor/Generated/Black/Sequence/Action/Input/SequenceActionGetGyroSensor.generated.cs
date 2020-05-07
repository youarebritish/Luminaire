using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Input
{
    public partial class SequenceActionGetGyroSensor : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin connected_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin ax_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin ay_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin az_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin rx_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin ry_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin rz_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetGyroSensor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Input.SequenceActionGetGyroSensor", 0, Black.Sequence.Action.Input.SequenceActionGetGyroSensor.ObjectType, null, properties, 0, 1024);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Input.SequenceActionGetGyroSensor", base.GetFieldProperties(), -1236665600, -467283148);
            return fieldProperties;
        }

		
    }
}