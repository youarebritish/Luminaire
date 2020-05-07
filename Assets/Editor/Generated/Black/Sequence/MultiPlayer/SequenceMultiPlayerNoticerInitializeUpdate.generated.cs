using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerNoticerInitializeUpdate : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inActivate_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inInitializeSync_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inInitializedFinished_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inInitializedSyncFailed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inIsSyncNumber_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inSyncId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inIsOwner_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outWaitInitializedStart_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outSendRequestAndQuestProgress_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outSetQuestProgress_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outCurrentInitId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerNoticerInitializeUpdate();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerNoticerInitializeUpdate", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerNoticerInitializeUpdate.ObjectType, null, properties, 0, 1208);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerNoticerInitializeUpdate", base.GetFieldProperties(), 370306430, -570536771);
            
			fieldProperties.AddProperty(new Property("inActivate_", 2735135568, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inInitializeSync_", 2475457176, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inInitializedFinished_", 2460390451, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inInitializedSyncFailed_", 2073013787, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inIsSyncNumber_", 577738801, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 560, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inSyncId_", 3552777269, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 648, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inIsOwner_", 1850215126, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 736, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outWaitInitializedStart_", 368178145, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 824, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outSendRequestAndQuestProgress_", 1699062677, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 920, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outSetQuestProgress_", 3148610211, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1016, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outCurrentInitId_", 4061471712, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1112, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}