using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.SceneControl
{
    public partial class SequenceEventSCActorStatus : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin allEnemyDied_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin gameStarted_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin teamNameDestroyed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin teamTypeDestroyed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin sceneNoDestroyed_;
		public int specificSceneNo_;
		public string specificTeamName_;
		public string specificTeamType_;
		public uint specificTeamNameId_;
		public uint specificTeamTypeId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventSCActorStatus();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.SceneControl.SequenceEventSCActorStatus", 0, Black.Sequence.Event.SceneControl.SequenceEventSCActorStatus.ObjectType, null, properties, 0, 704);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.SceneControl.SequenceEventSCActorStatus", base.GetFieldProperties(), 329517466, -1624087371);
            
			fieldProperties.AddProperty(new Property("allEnemyDied_", 1822208411, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("gameStarted_", 2040522001, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("teamNameDestroyed_", 2009653083, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("teamTypeDestroyed_", 4192508152, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sceneNoDestroyed_", 2027868804, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("specificSceneNo_", 2556286697, "int", 656, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("specificTeamName_", 77141852, "Ebony.Base.String", 664, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("specificTeamType_", 3884683245, "Ebony.Base.String", 680, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("specificTeamNameId_", 3192883291, "SQEX.Ebony.Std.Fixid", 696, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("specificTeamTypeId_", 3717570310, "SQEX.Ebony.Std.Fixid", 700, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}