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
            return fieldProperties;
        }

		
    }
}