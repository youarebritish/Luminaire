using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerMatchingLobbyInformation : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inIPAddress_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPort_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outIPAddress_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outPort_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerMatchingLobbyInformation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerMatchingLobbyInformation", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerMatchingLobbyInformation.ObjectType, null, properties, 0, 440);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerMatchingLobbyInformation", base.GetFieldProperties(), 1924046107, 1248545907);
            return fieldProperties;
        }

		
    }
}