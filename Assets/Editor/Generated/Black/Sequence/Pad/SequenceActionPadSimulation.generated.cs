using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Pad
{
    public partial class SequenceActionPadSimulation : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin up_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin right_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin down_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin left_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin a_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin b_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin x_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin y_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin triangle_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin circle_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin cross_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin square_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin select_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin start_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin l1_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin r1_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin l2_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin r2_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin l3_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin r3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin lt_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rt_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin lx_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ly_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rx_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ry_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionPadSimulation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Pad.SequenceActionPadSimulation", 0, Black.Sequence.Pad.SequenceActionPadSimulation.ObjectType, null, properties, 0, 2824);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Pad.SequenceActionPadSimulation", base.GetFieldProperties(), -190710575, 747725956);
            
			fieldProperties.AddProperty(new Property("enable_", 3925052483, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("disable_", 1760805492, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("up_", 1636505837, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("right_", 127990734, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("down_", 1969139582, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("left_", 4210150909, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("a_", 1915043849, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 752, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("b_", 1915485134, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 848, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("x_", 845366280, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 944, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("y_", 1918883633, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1040, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("triangle_", 3164948270, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1136, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("circle_", 44343522, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1232, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cross_", 3503684748, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1328, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("square_", 2476637531, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1424, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("select_", 1728529782, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1520, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("start_", 3266844032, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1616, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("l1_", 652833987, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1712, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("r1_", 1530447241, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1808, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("l2_", 1726454508, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1904, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("r2_", 1530888526, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2000, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("l3_", 1726307413, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2096, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("r3_", 456973815, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 2192, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lt_", 1737782838, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2288, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rt_", 1540348548, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2376, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lx_", 662146914, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2464, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ly_", 1735664267, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2552, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rx_", 468552408, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2640, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ry_", 468405313, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2728, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}