using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerActorCreateSyncEvent : Black.Sequence.MultiPlayer.SequenceMultiPlayerSyncEventBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueUniqueId_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueAreaId_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueGroupId_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueUniqueId_;
		public uint uniqueFilterId_;
		public bool ignoreSamePeerId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerActorCreateSyncEvent();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerActorCreateSyncEvent", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerActorCreateSyncEvent.ObjectType, null, properties, 0, 776);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerActorCreateSyncEvent", base.GetFieldProperties(), -63061391, 1307896552);
            
			fieldProperties.AddProperty(new Property("inValueUniqueId_", 220492394, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 296, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueActor_", 2821532918, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 384, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueAreaId_", 3697629069, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 472, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueGroupId_", 1792074959, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 560, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueUniqueId_", 1254290315, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 648, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("uniqueFilterId_", 1611340006, "SQEX.Ebony.Std.Fixid", 736, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("ignoreSamePeerId_", 262364817, "bool", 740, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}