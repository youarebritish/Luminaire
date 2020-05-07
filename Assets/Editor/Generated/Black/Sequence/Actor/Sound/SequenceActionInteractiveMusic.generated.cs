using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.Sound
{
    public partial class SequenceActionInteractiveMusic : Black.Sequence.Actor.SequenceActionBgmBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int bgmtype_mode_;
		public int interactiveSection_;
		public int interactiveMode_;
		public int interactiveBar_;
		public int interactiveBeat_;
		public int interactiveUnit_;
		public float fadeTime_;
		public bool isReserve_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin interactiveSetmode_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin syncTo_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionInteractiveMusic();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.Sound.SequenceActionInteractiveMusic", 0, Black.Sequence.Actor.Sound.SequenceActionInteractiveMusic.ObjectType, null, properties, 0, 600);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.Sound.SequenceActionInteractiveMusic", base.GetFieldProperties(), 1040868347, -374188401);
            
			fieldProperties.AddProperty(new Property("bgmtype_mode_", 1084392658, "Black.Sound.BGMManager.BGM_TYPE", 376, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactiveSection_", 1155485811, "int", 380, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactiveMode_", 4212740273, "int", 384, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactiveBar_", 3796689281, "int", 388, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactiveBeat_", 2511948640, "int", 392, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactiveUnit_", 2650303802, "int", 396, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeTime_", 2176527919, "float", 400, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isReserve_", 1497474316, "bool", 404, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactiveSetmode_", 1723295147, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 408, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("syncTo_", 3758124576, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 504, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}