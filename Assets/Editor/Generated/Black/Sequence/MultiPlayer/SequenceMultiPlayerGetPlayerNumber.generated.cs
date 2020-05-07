using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerGetPlayerNumber : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin num1_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin num2_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin num3_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin num4_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin host_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerGetPlayerNumber();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerGetPlayerNumber", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerGetPlayerNumber.ObjectType, null, properties, 0, 752);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerGetPlayerNumber", base.GetFieldProperties(), 1908839507, -2089043963);
            
			
			
			return fieldProperties;
        }

		
    }
}