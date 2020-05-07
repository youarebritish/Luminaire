using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerNoticerClearUpdate : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inActivate_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outTrue_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outFalse_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outClearId_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outClearTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerNoticerClearUpdate();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerNoticerClearUpdate", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerNoticerClearUpdate.ObjectType, null, properties, 0, 648);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerNoticerClearUpdate", base.GetFieldProperties(), -18334999, -263732496);
            return fieldProperties;
        }

		
    }
}