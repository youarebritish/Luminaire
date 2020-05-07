using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Minigame.Bumper
{
    public partial class SequenceActionBumperStart : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin m_in;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin m_finished;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin m_completed;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin m_coins;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin m_score;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin m_treasures;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin m_menuOpen;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin m_menuClosed;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin m_tableActor;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin m_close;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin m_lucky;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin m_quit;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin m_quitAccept;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin m_quitCancel;
		public float m_fadeInTime;
		public float m_fadeOutTime;
		public float m_chanceModifier;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionBumperStart();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Minigame.Bumper.SequenceActionBumperStart", 0, Black.Sequence.Action.Minigame.Bumper.SequenceActionBumperStart.ObjectType, null, properties, 0, 1912);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Minigame.Bumper.SequenceActionBumperStart", base.GetFieldProperties(), -1492506076, 98225638);
            
			fieldProperties.AddProperty(new Property("m_in", 3199662398, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_finished", 277576515, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_completed", 2040543282, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_coins", 3461243149, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 464, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_score", 305969077, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 552, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_treasures", 2198072597, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 640, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_menuOpen", 3712878914, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 728, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_menuClosed", 980561478, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 824, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_tableActor", 3448035276, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 920, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_close", 1742234179, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1008, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_lucky", 925520203, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1104, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_quit", 90355670, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1192, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_quitAccept", 3475398630, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1288, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_quitCancel", 715860972, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1384, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_fadeInTime", 3348092473, "float", 1480, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_fadeOutTime", 2799443428, "float", 1484, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_chanceModifier", 482142500, "float", 1488, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}