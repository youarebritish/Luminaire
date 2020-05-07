using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.PostEffect
{
    public partial class SequenceActionSetGraphics : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool forceOffBG_;
		public bool forceOffChr1Bone_;
		public bool forceOffEFF_;
		public bool forceOffShadow_;
		public bool forceOffLocalShadow_;
		public bool forceOffTerrain_;
		public bool forceOffFoliage_;
		public bool forceOffSLP_;
		public bool forceOffDLP_;
		public bool forceOffSSR_;
		public bool forceOffAA_;
		public bool forceOffBokeh_;
		public bool forceOffMB_;
		public bool forceOffSharpen_;
		public bool forceOffSAO_;
		public bool forceOffFogAC4_;
		public bool forceOffOcean_;
		public bool forceHairZPrepass_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetGraphics();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.PostEffect.SequenceActionSetGraphics", 0, Black.Sequence.Action.PostEffect.SequenceActionSetGraphics.ObjectType, null, properties, 0, 392);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.PostEffect.SequenceActionSetGraphics", base.GetFieldProperties(), -1504717266, -910550406);
            
			
			
			return fieldProperties;
        }

		
    }
}