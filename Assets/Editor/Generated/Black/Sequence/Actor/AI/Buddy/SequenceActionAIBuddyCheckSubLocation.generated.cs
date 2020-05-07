using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Buddy
{
    public partial class SequenceActionAIBuddyCheckSubLocation : Black.Sequence.Actor.AI.SequenceActionAIBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin manualCheckPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enableAutoCheckPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disableAutoCheckPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin manualTruePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin manualFalsePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin autoTagInPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin autoTagOutPin_;
		public bool isEnableAutoCheck_;
		public int targetBuddy_;
		public int checkMode_;
		public uint tag1ID_;
		public uint tag2ID_;
		public uint tag3ID_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIBuddyCheckSubLocation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyCheckSubLocation", 0, Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyCheckSubLocation.ObjectType, null, properties, 0, 1072);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyCheckSubLocation", base.GetFieldProperties(), 2040144236, -572741183);
            
			fieldProperties.AddProperty(new Property("manualCheckPin_", 2132234865, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 184, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableAutoCheckPin_", 919856159, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 280, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("disableAutoCheckPin_", 206094640, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 376, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorPin_", 3381458010, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 472, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPin_", 2732252299, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("manualTruePin_", 1362199931, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("manualFalsePin_", 2532198114, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 752, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoTagInPin_", 3350570037, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 848, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoTagOutPin_", 2929243434, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 944, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEnableAutoCheck_", 3568513108, "bool", 1040, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetBuddy_", 156417829, "Black.AI.Buddy.BUDDY_TYPE", 1044, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkMode_", 2065600077, "Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyCheckSubLocation.CHECK_MODE", 1048, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("tag1ID_", 278967628, "SQEX.Ebony.Std.Fixid", 1052, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("tag2ID_", 1229859379, "SQEX.Ebony.Std.Fixid", 1056, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("tag3ID_", 708809510, "SQEX.Ebony.Std.Fixid", 1060, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}