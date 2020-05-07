using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Sound
{
    public partial class SequenceActionPlaySoundEntity : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin play_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin playing_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pause_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin entity_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin volumePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pitchPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin filter_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin interactivePlayFrom_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin interactiveTrans_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin interactiveSetmode_;
		public SQEX.Ebony.Framework.Entity.TransformEntity entityPointer_;
		public float seekSec_;
		public bool bSumset_;
		public bool bClosest_;
		public uint filterAttr_;
		public int interactiveSection_;
		public int interactiveMode_;
		public int interactiveBar_;
		public int interactiveBeat_;
		public int interactiveUnit_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionPlaySoundEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Sound.SequenceActionPlaySoundEntity", 0, Black.Sequence.Action.Sound.SequenceActionPlaySoundEntity.ObjectType, null, properties, 0, 1336);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Sound.SequenceActionPlaySoundEntity", base.GetFieldProperties(), 886335154, -758652650);
            
			fieldProperties.AddProperty(new Property("play_", 3806684788, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("playing_", 3318230750, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("stop_", 3454812878, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pause_", 4078531478, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("entity_", 313491551, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 656, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("volumePin_", 799648379, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 744, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pitchPin_", 1069682637, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 832, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("filter_", 3486971640, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 920, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactivePlayFrom_", 4153742898, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1008, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactiveTrans_", 2557583128, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1104, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactiveSetmode_", 1723295147, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1200, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("entityPointer_", 3527687820, "SQEX.Ebony.Framework.Entity.TransformEntity", 1296, 8, 1, Property.PrimitiveType.Pointer, 0, (char)1));
			fieldProperties.AddProperty(new Property("seekSec_", 51457027, "float", 1304, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("bSumset_", 289354869, "bool", 1308, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bClosest_", 3307790953, "bool", 1309, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("filterAttr_", 4179606045, "SQEX.Ebony.Std.Fixid", 1312, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactiveSection_", 1155485811, "int", 1316, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactiveMode_", 4212740273, "int", 1320, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactiveBar_", 3796689281, "int", 1324, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactiveBeat_", 2511948640, "int", 1328, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactiveUnit_", 2650303802, "int", 1332, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}