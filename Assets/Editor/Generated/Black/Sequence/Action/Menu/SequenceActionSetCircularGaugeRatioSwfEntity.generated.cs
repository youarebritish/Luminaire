using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionSetCircularGaugeRatioSwfEntity : Black.Sequence.Action.Menu.SequenceActionSwfEntityHierarchyBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin swfEntityInput1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin swfEntityInput2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin swfEntityInput3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin swfEntityInput4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ratioPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetCircularGaugeRatioSwfEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionSetCircularGaugeRatioSwfEntity", 0, Black.Sequence.Action.Menu.SequenceActionSetCircularGaugeRatioSwfEntity.ObjectType, null, properties, 0, 944);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionSetCircularGaugeRatioSwfEntity", base.GetFieldProperties(), -1439165217, 988479151);
            return fieldProperties;
        }

		
    }
}