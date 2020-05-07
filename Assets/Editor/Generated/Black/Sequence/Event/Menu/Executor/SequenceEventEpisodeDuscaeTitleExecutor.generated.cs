using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu.Executor
{
    public partial class SequenceEventEpisodeDuscaeTitleExecutor : Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin open_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin closed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin new_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin newplus_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin continue_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin option_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin debug_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventEpisodeDuscaeTitleExecutor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.Executor.SequenceEventEpisodeDuscaeTitleExecutor", 0, Black.Sequence.Event.Menu.Executor.SequenceEventEpisodeDuscaeTitleExecutor.ObjectType, null, properties, 0, 1864);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.Executor.SequenceEventEpisodeDuscaeTitleExecutor", base.GetFieldProperties(), -596657853, 1137664461);
            
			fieldProperties.AddProperty(new Property("open_", 1412397090, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1088, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("closed_", 36233838, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1184, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("new_", 935828682, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1280, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("newplus_", 625146618, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1376, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("continue_", 1916568705, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1472, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("option_", 3542630545, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1568, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("debug_", 3991031877, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1664, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}