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
            return fieldProperties;
        }

		
    }
}