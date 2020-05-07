using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Mobhunt
{
    public partial class SequenceActionDinnerMobhuntInfoDialog : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin recieveIn_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin cancelIn_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin reportIn_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin closeMenuIn_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin menuCloseOut_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin getRewardOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valueRewardGillOut_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin rankUpOut_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin rankUpFinishOut_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin recieveOut_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDinnerMobhuntInfoDialog();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Mobhunt.SequenceActionDinnerMobhuntInfoDialog", 0, Black.Sequence.Action.Mobhunt.SequenceActionDinnerMobhuntInfoDialog.ObjectType, null, properties, 0, 1400);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Mobhunt.SequenceActionDinnerMobhuntInfoDialog", base.GetFieldProperties(), 829500598, 111606990);
            return fieldProperties;
        }

		
    }
}