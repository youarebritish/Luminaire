using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.AIMode
{
    public partial class SequenceActionExecAIModePlayMotion : Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin aniPathLoopPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin aniPathStartPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin facialAniPathLoopPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin facialAniPathStartPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin target_;
		public string aniPathStart_;
		public string aniPathLoop_;
		public string facialAniPathStart_;
		public string facialAniPathLoop_;
		public float loopTime_;
		public float startBlendDuration_;
		public float loopBlendDuration_;
		public bool disableLookAtIK;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionExecAIModePlayMotion();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModePlayMotion", 0, Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModePlayMotion.ObjectType, null, properties, 0, 2024);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModePlayMotion", base.GetFieldProperties(), 347331577, 435579830);
            
			fieldProperties.AddProperty(new Property("aniPathLoopPin_", 363111108, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1224, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("aniPathStartPin_", 3507767054, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1312, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("facialAniPathLoopPin_", 2333602596, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1400, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("facialAniPathStartPin_", 1916585326, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1488, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target_", 1693858869, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1576, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("aniPathStart_", 1294612387, "Ebony.Base.String", 1664, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("aniPathLoop_", 3709417409, "Ebony.Base.String", 1680, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("facialAniPathStart_", 1508534851, "Ebony.Base.String", 1696, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("facialAniPathLoop_", 3656304481, "Ebony.Base.String", 1712, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("loopTime_", 3914347911, "float", 1728, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("startBlendDuration_", 49625535, "float", 1732, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("loopBlendDuration_", 2220178539, "float", 1736, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("disableLookAtIK", 2586624813, "bool", 1740, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}