using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSetPackageTriggerOnOff : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int prefixType_;
		public uint searchLabelId_;
		public uint searchPackageId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin searchLabelIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin isEnableInputPin_;
		public bool isEnable_;
		public bool toTriggerUntouch_;
		public bool toForceEnable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetPackageTriggerOnOff();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSetPackageTriggerOnOff", 0, Black.Sequence.Action.Level.SequenceActionSetPackageTriggerOnOff.ObjectType, null, properties, 0, 568);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSetPackageTriggerOnOff", base.GetFieldProperties(), -1071618047, 1081783335);
            
			
			
			return fieldProperties;
        }

		
    }
}