using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Render
{
    public partial class SequenceActionSetProceduralSkyMulMap : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enableWeather_;
		public bool enableMulMap_;
		public UnityEngine.Color bgColor_;
		public float bgPower_;
		public float blendPower_;
		public UnityEngine.Color discColor_;
		public float discPower_;
		public float angleSoft_;
		public float angleHard_;
		public float phi_;
		public float thetaX_;
		public float thetaY_;
		public UnityEngine.Color discColor2_;
		public float discPower2_;
		public float angleSoft2_;
		public float angleHard2_;
		public float phi2_;
		public float thetaX2_;
		public float thetaY2_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetProceduralSkyMulMap();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Render.SequenceActionSetProceduralSkyMulMap", 0, Black.Sequence.Action.Render.SequenceActionSetProceduralSkyMulMap.ObjectType, null, properties, 0, 512);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Render.SequenceActionSetProceduralSkyMulMap", base.GetFieldProperties(), 1141004260, 1875361245);
            return fieldProperties;
        }

		
    }
}