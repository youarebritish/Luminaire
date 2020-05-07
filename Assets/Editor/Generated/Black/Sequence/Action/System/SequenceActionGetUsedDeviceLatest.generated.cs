using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.System
{
    public partial class SequenceActionGetUsedDeviceLatest : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin mouse_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin keyboard_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin pad_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin unknown_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetUsedDeviceLatest();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.System.SequenceActionGetUsedDeviceLatest", 0, Black.Sequence.Action.System.SequenceActionGetUsedDeviceLatest.ObjectType, null, properties, 0, 656);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.System.SequenceActionGetUsedDeviceLatest", base.GetFieldProperties(), -1382083262, -522527776);
            return fieldProperties;
        }

		
    }
}