using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu
{
    public partial class SequenceEventUiEntityInputBase : Black.Sequence.Event.Menu.SequenceEventUiBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin0_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin5_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin6_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin7_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventUiEntityInputBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase", 0, Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase.ObjectType, null, properties, 0, 1088);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase", base.GetFieldProperties(), 2110746992, 1607532894);
            return fieldProperties;
        }

		
    }
}