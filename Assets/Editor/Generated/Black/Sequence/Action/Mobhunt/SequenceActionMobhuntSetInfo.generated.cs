using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Mobhunt
{
    public partial class SequenceActionMobhuntSetInfo : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin recieveIn_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin cancelIn_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin reportIn_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin cancelAllOtherDinerIn_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin startDirectonCameraOut_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin endDirectonCameraOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valueCameraTypeOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valueTargetOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin questMarkerPosValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin questMarkerRadiusValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueMobhuntFixId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueQuestTargetId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueDinnerIdToCancelOtherAll_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin successed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin completed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin notCompleted_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionMobhuntSetInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Mobhunt.SequenceActionMobhuntSetInfo", 0, Black.Sequence.Action.Mobhunt.SequenceActionMobhuntSetInfo.ObjectType, null, properties, 0, 2040);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Mobhunt.SequenceActionMobhuntSetInfo", base.GetFieldProperties(), 657917288, 2116719094);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("recieveIn_", 3646307454, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cancelIn_", 3813912853, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("reportIn_", 2971981733, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cancelAllOtherDinerIn_", 1538406852, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("startDirectonCameraOut_", 2116726625, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("endDirectonCameraOut_", 2284025200, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 752, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueCameraTypeOut_", 645691836, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 848, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueTargetOut_", 1964228006, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 936, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("questMarkerPosValue_", 2334808033, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1024, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("questMarkerRadiusValue_", 3169260599, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1112, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueMobhuntFixId_", 2804625178, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1200, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueQuestTargetId_", 4240598341, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1288, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueDinnerIdToCancelOtherAll_", 1705832626, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1376, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("successed_", 3410995658, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("completed_", 543657015, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("notCompleted_", 2120035840, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1752, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}