using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceVariablePlayerVehicleDrive : SQEX.Ebony.Framework.Sequence.SequenceActivatableNode
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int target_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin true_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin false_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isPlayerVehicle_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariablePlayerVehicleDrive();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceVariablePlayerVehicleDrive", 0, Black.Sequence.Variable.SequenceVariablePlayerVehicleDrive.ObjectType, null, properties, 0, 552);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceVariablePlayerVehicleDrive", base.GetFieldProperties(), 1073923321, -755756087);
            return fieldProperties;
        }

		
    }
}