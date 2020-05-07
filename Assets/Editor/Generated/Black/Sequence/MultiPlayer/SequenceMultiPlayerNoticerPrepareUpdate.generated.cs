using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerNoticerPrepareUpdate : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inActivate_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inContinue_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outFound_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outNotFound_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outIndex_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerNoticerPrepareUpdate();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerNoticerPrepareUpdate", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerNoticerPrepareUpdate.ObjectType, null, properties, 0, 656);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerNoticerPrepareUpdate", base.GetFieldProperties(), 2025565975, -908356916);
            return fieldProperties;
        }

		
    }
}