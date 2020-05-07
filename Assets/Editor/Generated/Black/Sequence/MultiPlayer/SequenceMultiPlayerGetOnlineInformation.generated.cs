using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerGetOnlineInformation : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isBeforeServicePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin beforeServiceTimePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isEndedServicePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin endedServiceTimePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isMaintenancePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin maintenanceStartTimePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin maintenanceEndTimePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin maintenanceNumPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin informationPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin revisionVersionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin minorVersionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin majorVersionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin checkAcceptIpInOutOfServicePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin stringAcceptIpInOutOfServicePin_;
		public bool isRetail_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerGetOnlineInformation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerGetOnlineInformation", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerGetOnlineInformation.ObjectType, null, properties, 0, 1416);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerGetOnlineInformation", base.GetFieldProperties(), -514674360, -357480077);
            return fieldProperties;
        }

		
    }
}