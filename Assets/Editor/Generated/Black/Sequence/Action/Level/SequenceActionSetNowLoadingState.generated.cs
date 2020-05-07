using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSetNowLoadingState : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin on_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin off_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool waitLoadFinish_;
		public bool displayNowLoading_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetNowLoadingState();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSetNowLoadingState", 0, Black.Sequence.Action.Level.SequenceActionSetNowLoadingState.ObjectType, null, properties, 0, 480);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSetNowLoadingState", base.GetFieldProperties(), -1070101062, -1910658688);
            return fieldProperties;
        }

		
    }
}