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
            
			fieldProperties.AddProperty(new Property("isBeforeServicePin_", 3385321969, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 88, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("beforeServiceTimePin_", 4175457684, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 176, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEndedServicePin_", 3571745902, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 264, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("endedServiceTimePin_", 1658262067, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 352, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isMaintenancePin_", 2032808192, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 440, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("maintenanceStartTimePin_", 2336641401, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 528, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("maintenanceEndTimePin_", 3768763908, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 616, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("maintenanceNumPin_", 3004704208, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 704, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("informationPin_", 2605244833, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 792, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("revisionVersionPin_", 642465764, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 880, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("minorVersionPin_", 1862383618, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 968, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("majorVersionPin_", 1746221742, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1056, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkAcceptIpInOutOfServicePin_", 1912086429, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1144, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("stringAcceptIpInOutOfServicePin_", 922021978, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1232, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isRetail_", 3369017207, "bool", 1320, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}