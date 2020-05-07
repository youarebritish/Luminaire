using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Party
{
    public partial class SequenceActionCheckParty : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin member0ExistPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin member1ExistPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin member2ExistPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin member3ExistPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin member4ExistPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin member5ExistPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin member6ExistPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin member7ExistPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin member8ExistPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin conditionTruePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin conditionFalsePin_;
		public int member0CheckType_;
		public int member1CheckType_;
		public int member2CheckType_;
		public int member3CheckType_;
		public int member4CheckType_;
		public int member5CheckType_;
		public int member6CheckType_;
		public int member7CheckType_;
		public int member8CheckType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCheckParty();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Party.SequenceActionCheckParty", 0, Black.Sequence.Action.Level.Party.SequenceActionCheckParty.ObjectType, null, properties, 0, 1368);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Party.SequenceActionCheckParty", base.GetFieldProperties(), 280313634, 1842573798);
            
			fieldProperties.AddProperty(new Property("inPin_", 3408135614, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("member0ExistPin_", 916942424, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("member1ExistPin_", 3065548581, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("member2ExistPin_", 1511785506, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("member3ExistPin_", 3232270799, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("member4ExistPin_", 2568233020, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("member5ExistPin_", 2660159225, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 752, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("member6ExistPin_", 2339868406, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 848, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("member7ExistPin_", 512461843, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 944, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("member8ExistPin_", 4249674192, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1040, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("conditionTruePin_", 1536500994, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1136, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("conditionFalsePin_", 52253521, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1232, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("member0CheckType_", 3942325332, "Black.Sequence.Action.Level.Party.SequenceActionCheckParty.CHECK_TYPE", 1328, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("member1CheckType_", 2866314779, "Black.Sequence.Action.Level.Party.SequenceActionCheckParty.CHECK_TYPE", 1332, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("member2CheckType_", 1195279158, "Black.Sequence.Action.Level.Party.SequenceActionCheckParty.CHECK_TYPE", 1336, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("member3CheckType_", 1466830285, "Black.Sequence.Action.Level.Party.SequenceActionCheckParty.CHECK_TYPE", 1340, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("member4CheckType_", 641375696, "Black.Sequence.Action.Level.Party.SequenceActionCheckParty.CHECK_TYPE", 1344, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("member5CheckType_", 2560000055, "Black.Sequence.Action.Level.Party.SequenceActionCheckParty.CHECK_TYPE", 1348, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("member6CheckType_", 816204802, "Black.Sequence.Action.Level.Party.SequenceActionCheckParty.CHECK_TYPE", 1352, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("member7CheckType_", 2603044729, "Black.Sequence.Action.Level.Party.SequenceActionCheckParty.CHECK_TYPE", 1356, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("member8CheckType_", 3833789676, "Black.Sequence.Action.Level.Party.SequenceActionCheckParty.CHECK_TYPE", 1360, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}