using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.System
{
    public partial class SequenceActionWaitForInstallation : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin leftValueOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin testPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionWaitForInstallation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.System.SequenceActionWaitForInstallation", 0, Black.Sequence.Action.System.SequenceActionWaitForInstallation.ObjectType, null, properties, 0, 592);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.System.SequenceActionWaitForInstallation", base.GetFieldProperties(), 423118145, 915525461);
            return fieldProperties;
        }

		
    }
}