using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionSelectMenuListControl : Black.Sequence.Action.Menu.SequenceActionSelectMenuListControlBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int pinListingNum_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin10_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin9_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin8_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin7_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin6_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin5_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin1_;
		public string prefix1_;
		public string prefix2_;
		public string prefix3_;
		public string prefix4_;
		public string prefix5_;
		public string prefix6_;
		public string prefix7_;
		public string prefix8_;
		public string prefix9_;
		public string prefix10_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cursorSwfPlayerEntityInput_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSelectMenuListControl();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionSelectMenuListControl", 0, Black.Sequence.Action.Menu.SequenceActionSelectMenuListControl.ObjectType, null, properties, 0, 2736);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionSelectMenuListControl", base.GetFieldProperties(), 102071002, -1106252193);
            return fieldProperties;
        }

		
    }
}