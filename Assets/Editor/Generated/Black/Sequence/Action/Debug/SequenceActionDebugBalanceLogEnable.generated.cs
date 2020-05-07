using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Debug
{
    public partial class SequenceActionDebugBalanceLogEnable : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin set_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin toggle_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int logType_;
		public bool isLogEnable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDebugBalanceLogEnable();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.SequenceActionDebugBalanceLogEnable", 0, Black.Sequence.Action.Debug.SequenceActionDebugBalanceLogEnable.ObjectType, null, properties, 0, 472);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.SequenceActionDebugBalanceLogEnable", base.GetFieldProperties(), -1067731627, -1775265664);
            return fieldProperties;
        }

		
    }
}