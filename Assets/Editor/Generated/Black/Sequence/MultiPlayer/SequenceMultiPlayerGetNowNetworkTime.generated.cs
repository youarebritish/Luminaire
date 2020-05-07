using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerGetNowNetworkTime : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueOffset_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueWithoutSecond_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueSecond_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueYear_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueDifferenceSecond_;
		public bool isLocalTime_;
		public bool isMachineTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerGetNowNetworkTime();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerGetNowNetworkTime", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerGetNowNetworkTime.ObjectType, null, properties, 0, 624);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerGetNowNetworkTime", base.GetFieldProperties(), -1929633700, 622981554);
            
			
			
			return fieldProperties;
        }

		
    }
}