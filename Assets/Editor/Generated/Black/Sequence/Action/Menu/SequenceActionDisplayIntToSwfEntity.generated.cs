using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionDisplayIntToSwfEntity : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputValuePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inEntity_1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inEntity_2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inEntity_3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inEntity_4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inEntity_5_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inEntity_6_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inEntity_7_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inEntity_8_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inEntity_9_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin commaEntity_1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin commaEntity_2_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDisplayIntToSwfEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionDisplayIntToSwfEntity", 0, Black.Sequence.Action.Menu.SequenceActionDisplayIntToSwfEntity.ObjectType, null, properties, 0, 1496);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionDisplayIntToSwfEntity", base.GetFieldProperties(), -951917984, 1308230651);
            
			
			
			return fieldProperties;
        }

		
    }
}