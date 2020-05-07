using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Mobhunt
{
    public partial class SequenceActionMobhuntRecivedGetInfo : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failedOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin typeOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin diffiCultOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin morningRateOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin dayRateOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin nightRateOut_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionMobhuntRecivedGetInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Mobhunt.SequenceActionMobhuntRecivedGetInfo", 0, Black.Sequence.Action.Mobhunt.SequenceActionMobhuntRecivedGetInfo.ObjectType, null, properties, 0, 1144);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Mobhunt.SequenceActionMobhuntRecivedGetInfo", base.GetFieldProperties(), 94466055, 492803663);
            return fieldProperties;
        }

		
    }
}