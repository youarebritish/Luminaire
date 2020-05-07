using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerMatchingConnect : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disconnectPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fail_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin destinationIPAddressPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin destinationPortPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerMatchingConnect();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.MultiPlayer.SequenceMultiPlayerMatchingConnect", 0, SQEX.Ebony.Framework.Sequence.MultiPlayer.SequenceMultiPlayerMatchingConnect.ObjectType, null, properties, 0, 736);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.MultiPlayer.SequenceMultiPlayerMatchingConnect", base.GetFieldProperties(), 1915313511, 1962601577);
            
			
			
			return fieldProperties;
        }

		
    }
}